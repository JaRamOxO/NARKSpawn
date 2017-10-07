namespace NARKSpawn
{
    partial class frmEditCmds
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBDid = new System.Windows.Forms.Label();
            this.lblBDid_Value = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblArg1 = new System.Windows.Forms.Label();
            this.lblArg2 = new System.Windows.Forms.Label();
            this.lblArg3 = new System.Windows.Forms.Label();
            this.lblArg4 = new System.Windows.Forms.Label();
            this.lblArg5 = new System.Windows.Forms.Label();
            this.lblArg6 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtArg1 = new System.Windows.Forms.TextBox();
            this.txtArg2 = new System.Windows.Forms.TextBox();
            this.txtArg3 = new System.Windows.Forms.TextBox();
            this.txtArg4 = new System.Windows.Forms.TextBox();
            this.txtArg5 = new System.Windows.Forms.TextBox();
            this.txtArg6 = new System.Windows.Forms.TextBox();
            this.btnFileLoad = new System.Windows.Forms.Button();
            this.btnFileLoad_SaveCurrent = new System.Windows.Forms.Button();
            this.btnFileLoad_SaveToDb = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ofdLoadFile = new System.Windows.Forms.OpenFileDialog();
            this.lblExample = new System.Windows.Forms.Label();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.lblFileList_INFO = new System.Windows.Forms.Label();
            this.chkIsCheat = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbType2 = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBDid
            // 
            this.lblBDid.AutoSize = true;
            this.lblBDid.Location = new System.Drawing.Point(86, 32);
            this.lblBDid.Name = "lblBDid";
            this.lblBDid.Size = new System.Drawing.Size(36, 13);
            this.lblBDid.TabIndex = 0;
            this.lblBDid.Text = "DB id:";
            // 
            // lblBDid_Value
            // 
            this.lblBDid_Value.AutoSize = true;
            this.lblBDid_Value.Location = new System.Drawing.Point(127, 32);
            this.lblBDid_Value.Name = "lblBDid_Value";
            this.lblBDid_Value.Size = new System.Drawing.Size(13, 13);
            this.lblBDid_Value.TabIndex = 0;
            this.lblBDid_Value.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(65, 99);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(57, 13);
            this.lblCommand.TabIndex = 0;
            this.lblCommand.Text = "Command:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(58, 206);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Description:";
            // 
            // lblArg1
            // 
            this.lblArg1.AutoSize = true;
            this.lblArg1.Location = new System.Drawing.Point(58, 338);
            this.lblArg1.Name = "lblArg1";
            this.lblArg1.Size = new System.Drawing.Size(64, 13);
            this.lblArg1.TabIndex = 1;
            this.lblArg1.Text = "Argument 1:";
            // 
            // lblArg2
            // 
            this.lblArg2.AutoSize = true;
            this.lblArg2.Location = new System.Drawing.Point(58, 371);
            this.lblArg2.Name = "lblArg2";
            this.lblArg2.Size = new System.Drawing.Size(64, 13);
            this.lblArg2.TabIndex = 1;
            this.lblArg2.Text = "Argument 2:";
            // 
            // lblArg3
            // 
            this.lblArg3.AutoSize = true;
            this.lblArg3.Location = new System.Drawing.Point(58, 404);
            this.lblArg3.Name = "lblArg3";
            this.lblArg3.Size = new System.Drawing.Size(64, 13);
            this.lblArg3.TabIndex = 1;
            this.lblArg3.Text = "Argument 3:";
            // 
            // lblArg4
            // 
            this.lblArg4.AutoSize = true;
            this.lblArg4.Location = new System.Drawing.Point(58, 437);
            this.lblArg4.Name = "lblArg4";
            this.lblArg4.Size = new System.Drawing.Size(64, 13);
            this.lblArg4.TabIndex = 1;
            this.lblArg4.Text = "Argument 4:";
            // 
            // lblArg5
            // 
            this.lblArg5.AutoSize = true;
            this.lblArg5.Location = new System.Drawing.Point(58, 470);
            this.lblArg5.Name = "lblArg5";
            this.lblArg5.Size = new System.Drawing.Size(64, 13);
            this.lblArg5.TabIndex = 1;
            this.lblArg5.Text = "Argument 5:";
            // 
            // lblArg6
            // 
            this.lblArg6.AutoSize = true;
            this.lblArg6.Location = new System.Drawing.Point(58, 503);
            this.lblArg6.Name = "lblArg6";
            this.lblArg6.Size = new System.Drawing.Size(64, 13);
            this.lblArg6.TabIndex = 1;
            this.lblArg6.Text = "Argument 6:";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(130, 96);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(580, 20);
            this.txtCommand.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(130, 203);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(580, 92);
            this.txtDesc.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(580, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtArg1
            // 
            this.txtArg1.Location = new System.Drawing.Point(130, 335);
            this.txtArg1.Name = "txtArg1";
            this.txtArg1.Size = new System.Drawing.Size(319, 20);
            this.txtArg1.TabIndex = 2;
            // 
            // txtArg2
            // 
            this.txtArg2.Location = new System.Drawing.Point(130, 368);
            this.txtArg2.Name = "txtArg2";
            this.txtArg2.Size = new System.Drawing.Size(319, 20);
            this.txtArg2.TabIndex = 2;
            // 
            // txtArg3
            // 
            this.txtArg3.Location = new System.Drawing.Point(130, 401);
            this.txtArg3.Name = "txtArg3";
            this.txtArg3.Size = new System.Drawing.Size(319, 20);
            this.txtArg3.TabIndex = 2;
            // 
            // txtArg4
            // 
            this.txtArg4.Location = new System.Drawing.Point(130, 434);
            this.txtArg4.Name = "txtArg4";
            this.txtArg4.Size = new System.Drawing.Size(319, 20);
            this.txtArg4.TabIndex = 2;
            // 
            // txtArg5
            // 
            this.txtArg5.Location = new System.Drawing.Point(130, 467);
            this.txtArg5.Name = "txtArg5";
            this.txtArg5.Size = new System.Drawing.Size(319, 20);
            this.txtArg5.TabIndex = 2;
            // 
            // txtArg6
            // 
            this.txtArg6.Location = new System.Drawing.Point(130, 500);
            this.txtArg6.Name = "txtArg6";
            this.txtArg6.Size = new System.Drawing.Size(319, 20);
            this.txtArg6.TabIndex = 2;
            // 
            // btnFileLoad
            // 
            this.btnFileLoad.Location = new System.Drawing.Point(130, 581);
            this.btnFileLoad.Name = "btnFileLoad";
            this.btnFileLoad.Size = new System.Drawing.Size(75, 23);
            this.btnFileLoad.TabIndex = 3;
            this.btnFileLoad.Text = "Load file...";
            this.btnFileLoad.UseVisualStyleBackColor = true;
            this.btnFileLoad.Click += new System.EventHandler(this.btnFileLoad_Click);
            // 
            // btnFileLoad_SaveCurrent
            // 
            this.btnFileLoad_SaveCurrent.Location = new System.Drawing.Point(211, 581);
            this.btnFileLoad_SaveCurrent.Name = "btnFileLoad_SaveCurrent";
            this.btnFileLoad_SaveCurrent.Size = new System.Drawing.Size(94, 23);
            this.btnFileLoad_SaveCurrent.TabIndex = 3;
            this.btnFileLoad_SaveCurrent.Text = "Save current";
            this.btnFileLoad_SaveCurrent.UseVisualStyleBackColor = true;
            this.btnFileLoad_SaveCurrent.Click += new System.EventHandler(this.btnFileLoad_SaveCurrent_Click);
            // 
            // btnFileLoad_SaveToDb
            // 
            this.btnFileLoad_SaveToDb.Location = new System.Drawing.Point(311, 581);
            this.btnFileLoad_SaveToDb.Name = "btnFileLoad_SaveToDb";
            this.btnFileLoad_SaveToDb.Size = new System.Drawing.Size(75, 23);
            this.btnFileLoad_SaveToDb.TabIndex = 3;
            this.btnFileLoad_SaveToDb.Text = "Save to DB";
            this.btnFileLoad_SaveToDb.UseVisualStyleBackColor = true;
            this.btnFileLoad_SaveToDb.Click += new System.EventHandler(this.btnFileLoad_SaveToDb_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(558, 581);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(639, 581);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ofdLoadFile
            // 
            this.ofdLoadFile.Filter = "Text files|*.txt";
            this.ofdLoadFile.Title = "Find file to load commands from...";
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(65, 307);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(50, 13);
            this.lblExample.TabIndex = 0;
            this.lblExample.Text = "Example:";
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(130, 304);
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(580, 20);
            this.txtExample.TabIndex = 2;
            // 
            // lblFileList_INFO
            // 
            this.lblFileList_INFO.AutoSize = true;
            this.lblFileList_INFO.Location = new System.Drawing.Point(127, 550);
            this.lblFileList_INFO.Name = "lblFileList_INFO";
            this.lblFileList_INFO.Size = new System.Drawing.Size(76, 13);
            this.lblFileList_INFO.TabIndex = 4;
            this.lblFileList_INFO.Text = "Load file info...";
            // 
            // chkIsCheat
            // 
            this.chkIsCheat.AutoSize = true;
            this.chkIsCheat.Location = new System.Drawing.Point(131, 126);
            this.chkIsCheat.Name = "chkIsCheat";
            this.chkIsCheat.Size = new System.Drawing.Size(65, 17);
            this.chkIsCheat.TabIndex = 5;
            this.chkIsCheat.Text = "Is Cheat";
            this.chkIsCheat.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(130, 167);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(185, 21);
            this.cmbCategory.TabIndex = 6;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(328, 167);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(185, 21);
            this.cmbType.TabIndex = 6;
            // 
            // cmbType2
            // 
            this.cmbType2.FormattingEnabled = true;
            this.cmbType2.Location = new System.Drawing.Point(525, 167);
            this.cmbType2.Name = "cmbType2";
            this.cmbType2.Size = new System.Drawing.Size(185, 21);
            this.cmbType2.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(127, 151);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(325, 151);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type:";
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Location = new System.Drawing.Point(522, 151);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(40, 13);
            this.lblType2.TabIndex = 7;
            this.lblType2.Text = "Type2:";
            // 
            // frmEditCmds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 626);
            this.Controls.Add(this.lblType2);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbType2);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.chkIsCheat);
            this.Controls.Add(this.lblFileList_INFO);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFileLoad_SaveToDb);
            this.Controls.Add(this.btnFileLoad_SaveCurrent);
            this.Controls.Add(this.btnFileLoad);
            this.Controls.Add(this.txtArg6);
            this.Controls.Add(this.txtArg5);
            this.Controls.Add(this.txtArg4);
            this.Controls.Add(this.txtArg3);
            this.Controls.Add(this.txtArg2);
            this.Controls.Add(this.txtArg1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtExample);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.lblArg6);
            this.Controls.Add(this.lblArg5);
            this.Controls.Add(this.lblArg4);
            this.Controls.Add(this.lblArg3);
            this.Controls.Add(this.lblArg2);
            this.Controls.Add(this.lblArg1);
            this.Controls.Add(this.lblBDid_Value);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBDid);
            this.Name = "frmEditCmds";
            this.Text = "Edit Commands";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBDid;
        private System.Windows.Forms.Label lblBDid_Value;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblArg1;
        private System.Windows.Forms.Label lblArg2;
        private System.Windows.Forms.Label lblArg3;
        private System.Windows.Forms.Label lblArg4;
        private System.Windows.Forms.Label lblArg5;
        private System.Windows.Forms.Label lblArg6;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtArg1;
        private System.Windows.Forms.TextBox txtArg2;
        private System.Windows.Forms.TextBox txtArg3;
        private System.Windows.Forms.TextBox txtArg4;
        private System.Windows.Forms.TextBox txtArg5;
        private System.Windows.Forms.TextBox txtArg6;
        private System.Windows.Forms.Button btnFileLoad;
        private System.Windows.Forms.Button btnFileLoad_SaveCurrent;
        private System.Windows.Forms.Button btnFileLoad_SaveToDb;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog ofdLoadFile;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.Label lblFileList_INFO;
        private System.Windows.Forms.CheckBox chkIsCheat;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbType2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblType2;
    }
}