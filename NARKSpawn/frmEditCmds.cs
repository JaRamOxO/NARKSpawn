using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NARKSpawn
{
    public partial class frmEditCmds : Form
    {

        private NarkspawnContext _dbContext = new NarkspawnContext();

        List<Commands> commands =new List<Commands>();


        List<Commands> FileCmds = new List<Commands>();
        List<Commands> SaveCmds = new List<Commands>();

        private int flIdx = 0;
        private int saved = 0;
        
        //Edit
        Commands EditCmd = new Commands();

        public frmEditCmds()
        {
            InitializeComponent();
            LoadCommandsList();
        }

        public frmEditCmds(int dbid)
        {
            InitializeComponent();
            LoadCommandsList();
            FillFields(dbid);
        }

        private void LoadCommandsList()
        {
            commands = _dbContext.Commands.ToList();
        }

        private void FillFields(int editId)
        {
            try
            {
                EditCmd = commands.Find(x => x.Dbid == editId);
                txtName.Text = EditCmd.Name;
                txtCommand.Text = EditCmd.Cmd;
                chkIsCheat.Checked = GetBoolFromInt(EditCmd.IsCheat);
                if (!string.IsNullOrEmpty(EditCmd.Category))
                {
                    cmbCategory.SelectedIndex = cmbCategory.Items.IndexOf(EditCmd.Category);
                }
                if (!string.IsNullOrEmpty(EditCmd.Type))
                {
                    cmbType.SelectedIndex = cmbType.Items.IndexOf(EditCmd.Type);
                }
                if (!string.IsNullOrEmpty(EditCmd.Type2))
                {
                    cmbType2.SelectedIndex = cmbType2.Items.IndexOf(EditCmd.Type2);
                }
                txtDesc.Text = EditCmd.Description;
                txtExample.Text = EditCmd.Example;
                txtArg1.Text = EditCmd.Arg1;
                txtArg2.Text = EditCmd.Arg2;
                txtArg3.Text = EditCmd.Arg3;
                txtArg4.Text = EditCmd.Arg4;
                txtArg5.Text = EditCmd.Arg5;
                txtArg6.Text = EditCmd.Arg6;
                
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}\n{e.InnerException}");
            }
        }

        private bool GetBoolFromInt(int val)
        {
            if (val == 1) return true;
            return false;
        }

        private int SetIntFromBool(bool val)
        {
            if (val) return 1;
            return 0;
        }

        private void btnFileLoad_Click(object sender, EventArgs e)
        {
            ofdLoadFile.InitialDirectory = Application.StartupPath;
            DialogResult res = ofdLoadFile.ShowDialog();
            if (res == DialogResult.OK)
            {
                FileCmds = new List<Commands>();
                SaveCmds = new List<Commands>();
                string[] lines = File.ReadAllLines(ofdLoadFile.FileName);

                Commands cmd = new Commands();
                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line) && line.Length > 5 && !line.StartsWith("***"))
                    {
                        if (line.StartsWith("CMD:"))
                        {
                            if (!string.IsNullOrEmpty(cmd.Name))
                            {
                                FileCmds.Add(cmd);
                            }
                            cmd = new Commands();
                            cmd.Cmd = line.Replace("CMD: ", "");
                            if (cmd.Cmd.Contains(" "))
                            {
                                cmd.Name = cmd.Cmd.Substring(0, cmd.Cmd.IndexOf(" "));
                            }
                            else cmd.Name = cmd.Cmd;

                        }
                        else if (line.StartsWith("Example:"))
                        {
                            cmd.Example = line.Replace("Example: ", "");
                        }
                        else if (line.StartsWith("Description:"))
                        {
                            cmd.Description = line.Replace("Description: ", "");
                        }
                        else
                        {
                            cmd.Description += line;
                        }
                    }
                }
                flIdx = 0;
                saved = 0;
                ProcessFileCmds(flIdx);
                btnFileLoad_SaveCurrent.Enabled = true;
                btnFileLoad_SaveToDb.Enabled = false;
            }
        }

        private string FileListInfo()
        {
            return $"Handling {flIdx + 1} of {FileCmds.Count} - {saved} of {FileCmds.Count} added for db.";
        }

        private void ProcessFileCmds(int idx)
        {
            if (idx <= FileCmds.Count - 1)
            {
                lblFileList_INFO.Text = FileListInfo();
                txtName.Text = FileCmds[idx].Name;
                txtCommand.Text = FileCmds[idx].Cmd;
                txtDesc.Text = FileCmds[idx].Description;
                txtExample.Text = FileCmds[idx].Example;
            }
            else
            {
                btnFileLoad_SaveCurrent.Enabled = false;
            }
        }

        private void btnFileLoad_SaveCurrent_Click(object sender, EventArgs e)
        {
            Commands cmd = new Commands();
            //Name
            cmd.Name = txtName.Text;
            //Desc
            cmd.Description = txtDesc.Text;
            //CMD
            cmd.Cmd = txtCommand.Text;
            //IsCheat
            cmd.IsCheat = SetIntFromBool(chkIsCheat.Checked);
            //Category
            if (cmbCategory.SelectedIndex != -1 && cmbCategory.SelectedItem.ToString() != "<None>")
            {
                cmd.Category = cmbCategory.SelectedItem.ToString();
            }
            //Type
            if (cmbType.SelectedIndex != -1 && cmbType.SelectedItem.ToString() != "<None>")
            {
                cmd.Type = cmbType.SelectedItem.ToString();
            }
            //Type2
            if (cmbType2.SelectedIndex != -1 && cmbType2.SelectedItem.ToString() != "<None>")
            {
                cmd.Type2 = cmbType2.SelectedItem.ToString();
            }
            //Examlpe
            cmd.Example = txtExample.Text;
            //arg1
            if (!string.IsNullOrEmpty(txtArg1.Text)) cmd.Arg1 = txtArg1.Text;
            //arg2
            if (!string.IsNullOrEmpty(txtArg2.Text)) cmd.Arg2 = txtArg2.Text;
            //arg3
            if (!string.IsNullOrEmpty(txtArg3.Text)) cmd.Arg3 = txtArg3.Text;
            //arg4
            if (!string.IsNullOrEmpty(txtArg4.Text)) cmd.Arg4 = txtArg4.Text;
            //arg5
            if (!string.IsNullOrEmpty(txtArg5.Text)) cmd.Arg5 = txtArg5.Text;
            //arg6
            if (!string.IsNullOrEmpty(txtArg6.Text)) cmd.Arg6 = txtArg6.Text;

            _dbContext.Commands.Add(cmd);
            SaveCmds.Add(cmd);
            saved++;
            if (flIdx < FileCmds.Count - 1)
            {
                flIdx++;
                ProcessFileCmds(flIdx);
            }
            else if (flIdx == FileCmds.Count - 1)
            {
                lblFileList_INFO.Text = FileListInfo();
                btnFileLoad_SaveCurrent.Enabled = false;
                btnFileLoad_SaveToDb.Enabled = true;
            }
        }

        private void btnFileLoad_SaveToDb_Click(object sender, EventArgs e)
        {
            int ant = _dbContext.SaveChanges(true);
            MessageBox.Show($"{ant} new commands have been added to the database!");
        }
    }
}
