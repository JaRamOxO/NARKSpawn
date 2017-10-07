using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace NARKSpawn
{
    public partial class frmEditDinos : Form
    {
        private NarkspawnContext _dbContext = new NarkspawnContext();

        List<Dinos> dinos = new List<Dinos>();

        private List<string> cat = new List<string>();
        private List<string> type = new List<string>();
        private List<string> type2 = new List<string>();

        private List<string> dinoNames = new List<string>();

        private Dinos editDino;

        private bool IsEdit = false;
        private int EditId = -1;
        private int ChangesMade = 0;
        private int NewEntrys = 0;

        private int NextEdit = 0;

        public frmEditDinos()
        {
            InitializeComponent();
            LoadDinosList();
            MakeLists();
            cmbEdit_SelectEdit.Visible = false;
        }

        public frmEditDinos(int dbid)
        {
            InitializeComponent();
            LoadDinosList();
            editDino = dinos.Find(x => x.Dbid == dbid);
            MakeLists();
            IsEdit = true;
            EditId = dbid;
            cmbEdit_SelectEdit.Visible = true;
            FillFieldsWithItem(editDino);
        }

        private void LoadDinosList()
        {
            dinos = _dbContext.Dinos.ToList();
        }

        private void ResetCmb(ComboBox cmb)
        {
            cmb.Items.Clear();
            cmb.Items.Add("<none>");
            cmb.SelectedIndex = 0;
        }
        private void FillFieldsWithItem(Dinos dino)
        {
            lblEdit_DBid_Value.Text = dino.Dbid.ToString();
            cmbEdit_Category.SelectedIndex = !string.IsNullOrEmpty(dino.Category) ? cmbEdit_Category.Items.IndexOf(dino.Category) : 0;
            cmbEdit_Type.SelectedIndex = !string.IsNullOrEmpty(dino.Type) ? cmbEdit_Type.Items.IndexOf(dino.Type) : 0;
            cmbEdit_Type2.SelectedIndex = !string.IsNullOrEmpty(dino.Type2) ? cmbEdit_Type2.Items.IndexOf(dino.Type2) : 0;
            txtEdit_Name.Text = dino.Name;
            if (!string.IsNullOrEmpty(dino.Shortpath)) txtEdit_ShortPath.Text = dino.Shortpath;
            if (!string.IsNullOrEmpty(dino.Longpath)) txtEdit_FullPath.Text = dino.Longpath;
        }

        private void MakeLists()
        {
            cat = new List<string>();
            type = new List<string>();
            type2 = new List<string>();
            dinoNames = new List<string>();

            foreach (var dino in dinos)
            {
                dinoNames.Add(dino.Name);
                if (!string.IsNullOrEmpty(dino.Category) && !cat.Contains(dino.Category))
                {
                    cat.Add(dino.Category);
                }
                if (!string.IsNullOrEmpty(dino.Type) && !type.Contains(dino.Type))
                {
                    type.Add(dino.Type);
                }
                if (!string.IsNullOrEmpty(dino.Type2) && !type2.Contains(dino.Type2))
                {
                    type2.Add(dino.Type2);
                }
            }

            if (dinoNames.Count > 0)
            {
                dinoNames.Sort();
                cmbEdit_SelectEdit.Items.Clear();
                cmbEdit_SelectEdit.Items.AddRange(dinoNames.ToArray());
            }
            ResetCmb(cmbEdit_Category);
            ResetCmb(cmbEdit_Type);
            ResetCmb(cmbEdit_Type2);
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

        private void ResetNewFields()
        {
            chkEdit_Category_New.Checked = false;
            chkEdit_Type_New.Checked = false;
            chkEdit_Type2_New.Checked = false;
            txtEdit_Name.Text = "";
            txtEdit_Category.Text = "";
            txtEdit_FullPath.Text = "";
            txtEdit_ShortPath.Text = "";
            txtEdit_Type.Text = "";
            txtEdit_Type2.Text = "";
        }

        private void cmbEdit_SelectEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEdit_SelectEdit.SelectedIndex != -1)
            {
                editDino = dinos.Find(x => x.Name == cmbEdit_SelectEdit.SelectedItem.ToString());
                FillFieldsWithItem(editDino);
                EditId = (int)editDino.Dbid;
                btnAddChanges.Visible = true;
                NextEdit = cmbEdit_SelectEdit.SelectedIndex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Dinos eDino = new Dinos();

            //try
            //{
            //    //Category
            //    if (cmbEdit_Category.SelectedIndex == 0)
            //    {
            //        if (chkEdit_Category_New.Checked)
            //        {
            //            if (!string.IsNullOrEmpty(txtEdit_Category.Text))
            //            {
            //                eDino.Category = txtEdit_Category.Text;
            //            }
            //            else throw new ArgumentNullException("Category", "You have selected new category, but not typed anything as new category!");
            //        }
            //    }
            //    else
            //    {
            //        eDino.Category = cmbEdit_Category.SelectedItem.ToString();
            //    }
            //    //Type
            //    if (cmbEdit_Type.SelectedIndex == 0)
            //    {
            //        if (chkEdit_Type_New.Checked)
            //        {
            //            if (!string.IsNullOrEmpty(txtEdit_Type.Text))
            //            {
            //                eDino.Type = txtEdit_Type.Text;
            //            }
            //            else throw new ArgumentNullException("Type", "You have selected new type, but not typed anything as new type!");

            //        }
            //    }
            //    else
            //    {
            //        eDino.Type = cmbEdit_Type.SelectedItem.ToString();
            //    }
            //    //Type2
            //    if (cmbEdit_Type2.SelectedIndex == 0)
            //    {
            //        if (chkEdit_Type2_New.Checked)
            //        {
            //            if (!string.IsNullOrEmpty(txtEdit_Type2.Text))
            //            {
            //                eDino.Type2 = txtEdit_Type2.Text;
            //            }
            //            else throw new ArgumentNullException("Type2", "You have selected new type2, but not typed anything as new type2!");
            //        }
            //    }
            //    else
            //    {
            //        eDino.Type2 = cmbEdit_Type2.SelectedItem.ToString();
            //    }
            //    //Name
            //    if (!string.IsNullOrEmpty(txtEdit_Name.Text))
            //    {
            //        eDino.Name = txtEdit_Name.Text;
            //    }
            //    else throw new ArgumentNullException("Name", "We need a name for this dino, don't we?");

            //    //ShortPath
            //    if (!string.IsNullOrEmpty(txtEdit_ShortPath.Text))
            //    {
            //        eDino.Shortpath = txtEdit_ShortPath.Text;
            //    }
            //    //LongPath
            //    if (!string.IsNullOrEmpty(txtEdit_FullPath.Text))
            //    {
            //        eDino.Longpath = txtEdit_FullPath.Text;
            //    }
            //    else throw new ArgumentNullException("FullPath", "We need a full path for this dino, don't we?");
            //    //Add new/edit dino to database
            //    //edit
            //    if (IsEdit)
            //    {
            //        eDino.Dbid = EditId;
            //        var entity = _dbContext.Dinos.Find((long)EditId);
            //        if (entity == null)
            //        {
            //            return;
            //        }
            //        _dbContext.Entry(entity).CurrentValues.SetValues(eDino);
            //        _dbContext.Entry(entity).State = EntityState.Modified;
            //        int ant = _dbContext.SaveChanges(true);
            //        //MessageBox.Show($"{ant} items have been edited in the database!");
            //        Close();
            //        //ChangesMade++;
            //        //lblEdit_SaveInfo.Text = $"{ChangesMade} changes made to the db.\n\n{NewEntrys} dino(s) added to the db.";
            //    }
            //    else //new
            //    {
            //        _dbContext.Dinos.Add(eDino);
            //        int ant = _dbContext.SaveChanges(true);
            //        //MessageBox.Show($"{ant} new dinos have been added to the database!");
            //        //NewEntrys++;
            //        //lblEdit_SaveInfo.Text = $"{ChangesMade} changes made to the db.\n\n{NewEntrys} dino(s) added to the db.";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(this,ex.Message, "Something wrong is not right!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            int ant = _dbContext.SaveChanges(true);
            Close();
        }

        private void btnAddChanges_Click(object sender, EventArgs e)
        {
            Dinos eDino = new Dinos();

            try
            {
                //Category
                if (cmbEdit_Category.SelectedIndex == 0)
                {
                    if (chkEdit_Category_New.Checked)
                    {
                        if (!string.IsNullOrEmpty(txtEdit_Category.Text))
                        {
                            eDino.Category = txtEdit_Category.Text;
                        }
                        else throw new ArgumentNullException("Category", "You have selected new category, but not typed anything as new category!");
                    }
                }
                else
                {
                    eDino.Category = cmbEdit_Category.SelectedItem.ToString();
                }
                //Type
                if (cmbEdit_Type.SelectedIndex == 0)
                {
                    if (chkEdit_Type_New.Checked)
                    {
                        if (!string.IsNullOrEmpty(txtEdit_Type.Text))
                        {
                            eDino.Type = txtEdit_Type.Text;
                        }
                        else throw new ArgumentNullException("Type", "You have selected new type, but not typed anything as new type!");

                    }
                }
                else
                {
                    eDino.Type = cmbEdit_Type.SelectedItem.ToString();
                }
                //Type2
                if (cmbEdit_Type2.SelectedIndex == 0)
                {
                    if (chkEdit_Type2_New.Checked)
                    {
                        if (!string.IsNullOrEmpty(txtEdit_Type2.Text))
                        {
                            eDino.Type2 = txtEdit_Type2.Text;
                        }
                        else throw new ArgumentNullException("Type2", "You have selected new type2, but not typed anything as new type2!");
                    }
                }
                else
                {
                    eDino.Type2 = cmbEdit_Type2.SelectedItem.ToString();
                }
                //Name
                if (!string.IsNullOrEmpty(txtEdit_Name.Text))
                {
                    eDino.Name = txtEdit_Name.Text;
                }
                else throw new ArgumentNullException("Name", "We need a name for this dino, don't we?");

                //ShortPath
                if (!string.IsNullOrEmpty(txtEdit_ShortPath.Text))
                {
                    eDino.Shortpath = txtEdit_ShortPath.Text;
                }
                //LongPath
                if (!string.IsNullOrEmpty(txtEdit_FullPath.Text))
                {
                    eDino.Longpath = txtEdit_FullPath.Text;
                }
                else throw new ArgumentNullException("FullPath", "We need a full path for this dino, don't we?");
                //Add new/edit dino to database
                //edit
                if (IsEdit)
                {
                    eDino.Dbid = EditId;
                    var entity = _dbContext.Dinos.Find((long)EditId);
                    if (entity == null)
                    {
                        return;
                    }
                    _dbContext.Entry(entity).CurrentValues.SetValues(eDino);
                    _dbContext.Entry(entity).State = EntityState.Modified;
                    //int ant = _dbContext.SaveChanges(true);
                    //MessageBox.Show($"{ant} items have been edited in the database!");
                    //Close();
                    ChangesMade++;
                    lblEdit_SaveInfo.Text = $"{ChangesMade} changes made to the db.\n\n{NewEntrys} dino(s) added to the db.";
                }
                ResetNewFields();
                MakeLists();
                NextEdit++;
                if (NextEdit < cmbEdit_SelectEdit.Items.Count - 1) cmbEdit_SelectEdit.SelectedIndex = NextEdit;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Something wrong is not right!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Dinos eDino = new Dinos();

            try
            {
                //Category
                if (cmbEdit_Category.SelectedIndex == 0)
                {
                    if (chkEdit_Category_New.Checked)
                    {
                        if (!string.IsNullOrEmpty(txtEdit_Category.Text))
                        {
                            eDino.Category = txtEdit_Category.Text;
                        }
                        else throw new ArgumentNullException("Category", "You have selected new category, but not typed anything as new category!");
                    }
                }
                else
                {
                    eDino.Category = cmbEdit_Category.SelectedItem.ToString();
                }
                //Type
                if (cmbEdit_Type.SelectedIndex == 0)
                {
                    if (chkEdit_Type_New.Checked)
                    {
                        if (!string.IsNullOrEmpty(txtEdit_Type.Text))
                        {
                            eDino.Type = txtEdit_Type.Text;
                        }
                        else throw new ArgumentNullException("Type", "You have selected new type, but not typed anything as new type!");

                    }
                }
                else
                {
                    eDino.Type = cmbEdit_Type.SelectedItem.ToString();
                }
                //Type2
                if (cmbEdit_Type2.SelectedIndex == 0)
                {
                    if (chkEdit_Type2_New.Checked)
                    {
                        if (!string.IsNullOrEmpty(txtEdit_Type2.Text))
                        {
                            eDino.Type2 = txtEdit_Type2.Text;
                        }
                        else throw new ArgumentNullException("Type2", "You have selected new type2, but not typed anything as new type2!");
                    }
                }
                else
                {
                    eDino.Type2 = cmbEdit_Type2.SelectedItem.ToString();
                }
                //Name
                if (!string.IsNullOrEmpty(txtEdit_Name.Text))
                {
                    eDino.Name = txtEdit_Name.Text;
                }
                else throw new ArgumentNullException("Name", "We need a name for this dino, don't we?");

                //ShortPath
                if (!string.IsNullOrEmpty(txtEdit_ShortPath.Text))
                {
                    eDino.Shortpath = txtEdit_ShortPath.Text;
                }
                //LongPath
                if (!string.IsNullOrEmpty(txtEdit_FullPath.Text))
                {
                    eDino.Longpath = txtEdit_FullPath.Text;
                }
                else throw new ArgumentNullException("FullPath", "We need a full path for this dino, don't we?");
                //Add new/edit dino to database
                
                _dbContext.Dinos.Add(eDino);
                NewEntrys++;
                lblEdit_SaveInfo.Text = $"{ChangesMade} changes made to the db.\n\n{NewEntrys} dino(s) added to the db.";
                ResetNewFields();
                MakeLists();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Something wrong is not right!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
