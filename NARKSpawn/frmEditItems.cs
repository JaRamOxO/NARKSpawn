using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace NARKSpawn
{
    public partial class frmEditItems : Form
    {
        private NarkspawnContext _dbContext = new NarkspawnContext();

        private List<Items> items;

        private Items editItem;

        private List<string> cat;
        private List<string> type;
        private List<string> type2;

        //From file
        private List<Items> FileItems = new List<Items>();
        private List<Items> SaveItems = new List<Items>();

        private int flIdx = 0;
        private int saved = 0;

        private bool IsEdit = false;
        private int EditId = 0;

        public frmEditItems()
        {
            InitializeComponent();
            LoadItemsList();
            MakeListsAndFillCmbs();
        }

        public frmEditItems(int dbid)
        {
            InitializeComponent();
            LoadItemsList();
            editItem = items.Find(x => x.Dbid == dbid);
            MakeListsAndFillCmbs();
            FillFieldsWithItem(editItem);
            IsEdit = true;
            EditId = dbid;
        }

        private void FillFieldsWithItem(Items item)
        {
            lblEdit_DBid_Value.Text = item.Dbid.ToString();
            cmbEdit_Category.SelectedIndex = !string.IsNullOrEmpty(item.Category) ? cmbEdit_Category.Items.IndexOf(item.Category) : 0;
            cmbEdit_Type.SelectedIndex = !string.IsNullOrEmpty(item.Type) ? cmbEdit_Type.Items.IndexOf(item.Type) : 0;
            cmbEdit_Type2.SelectedIndex = !string.IsNullOrEmpty(item.Type2) ? cmbEdit_Type2.Items.IndexOf(item.Type2) : 0;
            txtEdit_Name.Text = item.Name;
            if (!string.IsNullOrEmpty(item.Itemid)) txtEdit_ItemId.Text = item.Itemid;
            if (!string.IsNullOrEmpty(item.Path)) txtEdit_Path.Text = item.Path;
            txtEdit_Max.Text = item.Max;
        }

        private void MakeListsAndFillCmbs()
        {
            cat = new List<string>();
            type = new List<string>();
            type2 = new List<string>();
            foreach (var item in items)
            {
                if (!string.IsNullOrEmpty(item.Category))
                {
                    if (!cat.Contains(item.Category)) cat.Add(item.Category);
                }

                if (!string.IsNullOrEmpty(item.Type))
                {
                    if (!type.Contains(item.Type)) type.Add(item.Type);
                }

                if (!string.IsNullOrEmpty(item.Type2))
                {
                    if (!type2.Contains(item.Type2)) type2.Add(item.Type2);
                }
            }
            

            if (cat.Count > 0)
            {
                cat.Sort();
                cmbEdit_Category.Items.AddRange(cat.ToArray());
            }
            if (type.Count > 0)
            {
                type.Sort();
                cmbEdit_Type.Items.AddRange(type.ToArray());
            }
            if (type2.Count > 0)
            {
                type2.Sort();
                cmbEdit_Type2.Items.AddRange(type2.ToArray());
            }
        }

        private void ResetCmb(ComboBox cmb)
        {
            cmb.Items.Clear();
            cmb.Items.Add("<none>");
        }

        private void frmEditItems_Load(object sender, EventArgs e)
        {

        }

        private void LoadItemsList()
        {
            items = _dbContext.Items.ToList();
        }

        private void SetMaxAmountFrmBtn(object sender, EventArgs e)
        {
            txtEdit_Max.Text = (sender as Button).Text;
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            ofdLoadItems.InitialDirectory = Application.StartupPath;
            DialogResult res = ofdLoadItems.ShowDialog();
            if (res == DialogResult.OK)
            {
                FileItems = new List<Items>();
                SaveItems = new List<Items>();
                string[] lines = File.ReadAllLines(ofdLoadItems.FileName);
                
                Items ti = new Items();
                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line) && line.Length > 5 && !line.StartsWith("***"))
                    {
                        if (line.StartsWith("Name:"))
                        {
                            ti = new Items();
                            ti.Name = line.Replace("Name: ", "");
                        }
                        else if (line.StartsWith("PATH:"))
                        {
                            ti.Path = line.Replace("PATH: ", "");
                            FileItems.Add(ti);
                        }
                    }
                }
                flIdx = 0;
                saved = 0;
                ProcessFileItems(flIdx);
                btnFileList_SaveCurr.Enabled = true;
                btnFileList_SkipToNext.Enabled = true;
                btnFileList_SaveToDb.Enabled = false;
            }
        }

        private void ProcessFileItems(int idx)
        {
            if (idx <= FileItems.Count - 1)
            {
                lblFileList_INFO.Text = FileListInfo();
                txtEdit_Name.Text = FileItems[idx].Name;
                txtEdit_Path.Text = FileItems[idx].Path;
            }
            else
            {
                btnFileList_SaveCurr.Enabled = false;
            }
        }

        private void btnFileList_SaveCurr_Click(object sender, EventArgs e)
        {
            Items ci = new Items();
            //Category
            if (cmbEdit_Category.SelectedItem.ToString() != "<none>" && !chkEdit_Category_New.Checked)
            {
                ci.Category = cmbEdit_Category.SelectedItem.ToString();
            }
            else
            {
                if (chkEdit_Category_New.Checked)
                {
                    ci.Category = txtEdit_Category.Text;
                }
            }
            //Type
            if (cmbEdit_Type.SelectedItem.ToString() != "<none>" && !chkEdit_Type_New.Checked)
            {
                ci.Type = cmbEdit_Type.SelectedItem.ToString();
            }
            else
            {
                if (chkEdit_Type_New.Checked)
                {
                    ci.Type = txtEdit_Type.Text;
                }
            }
            //Type2
            if (cmbEdit_Type2.SelectedItem.ToString() != "<none>" && !chkEdit_Type2_New.Checked)
            {
                ci.Type2 = cmbEdit_Type2.SelectedItem.ToString();
            }
            else
            {
                if (chkEdit_Type2_New.Checked)
                {
                    ci.Type2 = txtEdit_Type2.Text;
                }
            }
            //Name
            ci.Name = txtEdit_Name.Text;
            //ItemId
            if (!string.IsNullOrEmpty(txtEdit_ItemId.Text)) ci.Itemid = txtEdit_ItemId.Text;
            //Path
            ci.Path = txtEdit_Path.Text;
            //Max
            ci.Max = txtEdit_Max.Text;

            _dbContext.Items.Add(ci);
            SaveItems.Add(ci);
            saved++;
            if (flIdx < FileItems.Count - 1)
            {
                flIdx++;
                ProcessFileItems(flIdx);
            }
            else if (flIdx == FileItems.Count - 1)
            {
                lblFileList_INFO.Text = FileListInfo();
                btnFileList_SaveCurr.Enabled = false;
                btnFileList_SkipToNext.Enabled = false;
                btnFileList_SaveToDb.Enabled = true;
            }

        }

        private void btnFileList_SaveToDb_Click(object sender, EventArgs e)
        {
            //_dbContext.Items.AttachRange(SaveItems);
            int ant = _dbContext.SaveChanges(true);
            MessageBox.Show($"{ant} new items have been added to the database!");
            
        }

        private void btnFileList_SkipToNext_Click(object sender, EventArgs e)
        {
            if (flIdx < FileItems.Count - 1)
            {
                flIdx++;
                ProcessFileItems(flIdx);
            }
            else if (flIdx == FileItems.Count - 1)
            {
                btnFileList_SaveCurr.Enabled = false;
                btnFileList_SkipToNext.Enabled = false;
                btnFileList_SaveToDb.Enabled = true;
            }
        }

        private string FileListInfo()
        {
            return $"Handling {flIdx + 1} of {FileItems.Count} - {saved} of {FileItems.Count} added for db.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Items ci = new Items();
            
            //Category
            if (cmbEdit_Category.SelectedItem.ToString() != "<none>" && !chkEdit_Category_New.Checked)
            {
                ci.Category = cmbEdit_Category.SelectedItem.ToString();
            }
            else
            {
                if (chkEdit_Category_New.Checked)
                {
                    ci.Category = txtEdit_Category.Text;
                }
            }
            //Type
            if (cmbEdit_Type.SelectedItem.ToString() != "<none>" && !chkEdit_Type_New.Checked)
            {
                ci.Type = cmbEdit_Type.SelectedItem.ToString();
            }
            else
            {
                if (chkEdit_Type_New.Checked)
                {
                    ci.Type = txtEdit_Type.Text;
                }
            }
            //Type2
            if (cmbEdit_Type2.SelectedItem.ToString() != "<none>" && !chkEdit_Type2_New.Checked)
            {
                ci.Type2 = cmbEdit_Type2.SelectedItem.ToString();
            }
            else
            {
                if (chkEdit_Type2_New.Checked)
                {
                    ci.Type2 = txtEdit_Type2.Text;
                }
            }
            //Name
            ci.Name = txtEdit_Name.Text;
            //ItemId
            if (!string.IsNullOrEmpty(txtEdit_ItemId.Text)) ci.Itemid = txtEdit_ItemId.Text;
            //Path
            ci.Path = txtEdit_Path.Text;
            //Max
            ci.Max = txtEdit_Max.Text;
            if (IsEdit)
            {
                ci.Dbid = EditId;
                var entity = _dbContext.Items.Find((long)EditId);
                if (entity == null)
                {
                    return;
                }
                _dbContext.Entry(entity).CurrentValues.SetValues(ci);
                _dbContext.Entry(entity).State = EntityState.Modified;
                int ant = _dbContext.SaveChanges(true);
                //MessageBox.Show($"{ant} items have been edited in the database!");
                Close();
            }
            else
            {
                _dbContext.Items.Add(ci);
                int ant = _dbContext.SaveChanges(true);
                MessageBox.Show($"{ant} new items have been added to the database!");
            }
            
        }
    }
}
