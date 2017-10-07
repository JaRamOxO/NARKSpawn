namespace NARKSpawn
{
    partial class frmEditDinos
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbEdit_Type2 = new System.Windows.Forms.ComboBox();
            this.cmbEdit_Type = new System.Windows.Forms.ComboBox();
            this.cmbEdit_Category = new System.Windows.Forms.ComboBox();
            this.chkEdit_Type2_New = new System.Windows.Forms.CheckBox();
            this.chkEdit_Type_New = new System.Windows.Forms.CheckBox();
            this.chkEdit_Category_New = new System.Windows.Forms.CheckBox();
            this.txtEdit_FullPath = new System.Windows.Forms.TextBox();
            this.txtEdit_ShortPath = new System.Windows.Forms.TextBox();
            this.txtEdit_Name = new System.Windows.Forms.TextBox();
            this.txtEdit_Type2 = new System.Windows.Forms.TextBox();
            this.txtEdit_Type = new System.Windows.Forms.TextBox();
            this.txtEdit_Category = new System.Windows.Forms.TextBox();
            this.lblEdit_FullPath = new System.Windows.Forms.Label();
            this.lblEdit_Type2 = new System.Windows.Forms.Label();
            this.lblEdit_ShortPath = new System.Windows.Forms.Label();
            this.lblEdit_Type = new System.Windows.Forms.Label();
            this.lblEdit_Name = new System.Windows.Forms.Label();
            this.lblEdit_Category = new System.Windows.Forms.Label();
            this.lblEdit_DBid_Value = new System.Windows.Forms.Label();
            this.lblEdit_DBid = new System.Windows.Forms.Label();
            this.cmbEdit_SelectEdit = new System.Windows.Forms.ComboBox();
            this.lblEdit_SelectEdit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEdit_SaveInfo = new System.Windows.Forms.Label();
            this.btnAddChanges = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Location = new System.Drawing.Point(181, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(181, 58);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // cmbEdit_Type2
            // 
            this.cmbEdit_Type2.FormattingEnabled = true;
            this.cmbEdit_Type2.Items.AddRange(new object[] {
            "<none>"});
            this.cmbEdit_Type2.Location = new System.Drawing.Point(104, 206);
            this.cmbEdit_Type2.Name = "cmbEdit_Type2";
            this.cmbEdit_Type2.Size = new System.Drawing.Size(147, 21);
            this.cmbEdit_Type2.TabIndex = 10;
            // 
            // cmbEdit_Type
            // 
            this.cmbEdit_Type.FormattingEnabled = true;
            this.cmbEdit_Type.Items.AddRange(new object[] {
            "<none>"});
            this.cmbEdit_Type.Location = new System.Drawing.Point(104, 181);
            this.cmbEdit_Type.Name = "cmbEdit_Type";
            this.cmbEdit_Type.Size = new System.Drawing.Size(147, 21);
            this.cmbEdit_Type.TabIndex = 7;
            // 
            // cmbEdit_Category
            // 
            this.cmbEdit_Category.FormattingEnabled = true;
            this.cmbEdit_Category.Items.AddRange(new object[] {
            "<none>"});
            this.cmbEdit_Category.Location = new System.Drawing.Point(104, 154);
            this.cmbEdit_Category.Name = "cmbEdit_Category";
            this.cmbEdit_Category.Size = new System.Drawing.Size(147, 21);
            this.cmbEdit_Category.TabIndex = 4;
            // 
            // chkEdit_Type2_New
            // 
            this.chkEdit_Type2_New.AutoSize = true;
            this.chkEdit_Type2_New.Location = new System.Drawing.Point(257, 208);
            this.chkEdit_Type2_New.Name = "chkEdit_Type2_New";
            this.chkEdit_Type2_New.Size = new System.Drawing.Size(48, 17);
            this.chkEdit_Type2_New.TabIndex = 11;
            this.chkEdit_Type2_New.Text = "New";
            this.chkEdit_Type2_New.UseVisualStyleBackColor = true;
            // 
            // chkEdit_Type_New
            // 
            this.chkEdit_Type_New.AutoSize = true;
            this.chkEdit_Type_New.Location = new System.Drawing.Point(257, 183);
            this.chkEdit_Type_New.Name = "chkEdit_Type_New";
            this.chkEdit_Type_New.Size = new System.Drawing.Size(48, 17);
            this.chkEdit_Type_New.TabIndex = 8;
            this.chkEdit_Type_New.Text = "New";
            this.chkEdit_Type_New.UseVisualStyleBackColor = true;
            // 
            // chkEdit_Category_New
            // 
            this.chkEdit_Category_New.AutoSize = true;
            this.chkEdit_Category_New.Location = new System.Drawing.Point(257, 156);
            this.chkEdit_Category_New.Name = "chkEdit_Category_New";
            this.chkEdit_Category_New.Size = new System.Drawing.Size(48, 17);
            this.chkEdit_Category_New.TabIndex = 5;
            this.chkEdit_Category_New.Text = "New";
            this.chkEdit_Category_New.UseVisualStyleBackColor = true;
            // 
            // txtEdit_FullPath
            // 
            this.txtEdit_FullPath.Location = new System.Drawing.Point(104, 128);
            this.txtEdit_FullPath.Name = "txtEdit_FullPath";
            this.txtEdit_FullPath.Size = new System.Drawing.Size(552, 20);
            this.txtEdit_FullPath.TabIndex = 3;
            // 
            // txtEdit_ShortPath
            // 
            this.txtEdit_ShortPath.Location = new System.Drawing.Point(104, 102);
            this.txtEdit_ShortPath.Name = "txtEdit_ShortPath";
            this.txtEdit_ShortPath.Size = new System.Drawing.Size(351, 20);
            this.txtEdit_ShortPath.TabIndex = 2;
            // 
            // txtEdit_Name
            // 
            this.txtEdit_Name.Location = new System.Drawing.Point(104, 77);
            this.txtEdit_Name.Name = "txtEdit_Name";
            this.txtEdit_Name.Size = new System.Drawing.Size(351, 20);
            this.txtEdit_Name.TabIndex = 0;
            // 
            // txtEdit_Type2
            // 
            this.txtEdit_Type2.Location = new System.Drawing.Point(311, 206);
            this.txtEdit_Type2.Name = "txtEdit_Type2";
            this.txtEdit_Type2.Size = new System.Drawing.Size(144, 20);
            this.txtEdit_Type2.TabIndex = 12;
            // 
            // txtEdit_Type
            // 
            this.txtEdit_Type.Location = new System.Drawing.Point(311, 181);
            this.txtEdit_Type.Name = "txtEdit_Type";
            this.txtEdit_Type.Size = new System.Drawing.Size(144, 20);
            this.txtEdit_Type.TabIndex = 9;
            // 
            // txtEdit_Category
            // 
            this.txtEdit_Category.Location = new System.Drawing.Point(311, 154);
            this.txtEdit_Category.Name = "txtEdit_Category";
            this.txtEdit_Category.Size = new System.Drawing.Size(144, 20);
            this.txtEdit_Category.TabIndex = 6;
            // 
            // lblEdit_FullPath
            // 
            this.lblEdit_FullPath.AutoSize = true;
            this.lblEdit_FullPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_FullPath.Location = new System.Drawing.Point(38, 131);
            this.lblEdit_FullPath.Name = "lblEdit_FullPath";
            this.lblEdit_FullPath.Size = new System.Drawing.Size(60, 13);
            this.lblEdit_FullPath.TabIndex = 14;
            this.lblEdit_FullPath.Text = "Full path:";
            // 
            // lblEdit_Type2
            // 
            this.lblEdit_Type2.AutoSize = true;
            this.lblEdit_Type2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_Type2.Location = new System.Drawing.Point(48, 209);
            this.lblEdit_Type2.Name = "lblEdit_Type2";
            this.lblEdit_Type2.Size = new System.Drawing.Size(50, 13);
            this.lblEdit_Type2.TabIndex = 13;
            this.lblEdit_Type2.Text = "Type 2:";
            // 
            // lblEdit_ShortPath
            // 
            this.lblEdit_ShortPath.AutoSize = true;
            this.lblEdit_ShortPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_ShortPath.Location = new System.Drawing.Point(28, 105);
            this.lblEdit_ShortPath.Name = "lblEdit_ShortPath";
            this.lblEdit_ShortPath.Size = new System.Drawing.Size(70, 13);
            this.lblEdit_ShortPath.TabIndex = 12;
            this.lblEdit_ShortPath.Text = "Short path:";
            // 
            // lblEdit_Type
            // 
            this.lblEdit_Type.AutoSize = true;
            this.lblEdit_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_Type.Location = new System.Drawing.Point(59, 184);
            this.lblEdit_Type.Name = "lblEdit_Type";
            this.lblEdit_Type.Size = new System.Drawing.Size(39, 13);
            this.lblEdit_Type.TabIndex = 11;
            this.lblEdit_Type.Text = "Type:";
            // 
            // lblEdit_Name
            // 
            this.lblEdit_Name.AutoSize = true;
            this.lblEdit_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_Name.Location = new System.Drawing.Point(55, 80);
            this.lblEdit_Name.Name = "lblEdit_Name";
            this.lblEdit_Name.Size = new System.Drawing.Size(43, 13);
            this.lblEdit_Name.TabIndex = 10;
            this.lblEdit_Name.Text = "Name:";
            // 
            // lblEdit_Category
            // 
            this.lblEdit_Category.AutoSize = true;
            this.lblEdit_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_Category.Location = new System.Drawing.Point(37, 157);
            this.lblEdit_Category.Name = "lblEdit_Category";
            this.lblEdit_Category.Size = new System.Drawing.Size(61, 13);
            this.lblEdit_Category.TabIndex = 9;
            this.lblEdit_Category.Text = "Category:";
            // 
            // lblEdit_DBid_Value
            // 
            this.lblEdit_DBid_Value.AutoSize = true;
            this.lblEdit_DBid_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_DBid_Value.Location = new System.Drawing.Point(104, 46);
            this.lblEdit_DBid_Value.Name = "lblEdit_DBid_Value";
            this.lblEdit_DBid_Value.Size = new System.Drawing.Size(14, 13);
            this.lblEdit_DBid_Value.TabIndex = 16;
            this.lblEdit_DBid_Value.Text = "0";
            // 
            // lblEdit_DBid
            // 
            this.lblEdit_DBid.AutoSize = true;
            this.lblEdit_DBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_DBid.Location = new System.Drawing.Point(56, 46);
            this.lblEdit_DBid.Name = "lblEdit_DBid";
            this.lblEdit_DBid.Size = new System.Drawing.Size(42, 13);
            this.lblEdit_DBid.TabIndex = 8;
            this.lblEdit_DBid.Text = "DB id:";
            // 
            // cmbEdit_SelectEdit
            // 
            this.cmbEdit_SelectEdit.FormattingEnabled = true;
            this.cmbEdit_SelectEdit.Location = new System.Drawing.Point(475, 12);
            this.cmbEdit_SelectEdit.Name = "cmbEdit_SelectEdit";
            this.cmbEdit_SelectEdit.Size = new System.Drawing.Size(193, 21);
            this.cmbEdit_SelectEdit.TabIndex = 38;
            this.cmbEdit_SelectEdit.SelectedIndexChanged += new System.EventHandler(this.cmbEdit_SelectEdit_SelectedIndexChanged);
            // 
            // lblEdit_SelectEdit
            // 
            this.lblEdit_SelectEdit.AutoSize = true;
            this.lblEdit_SelectEdit.Location = new System.Drawing.Point(397, 15);
            this.lblEdit_SelectEdit.Name = "lblEdit_SelectEdit";
            this.lblEdit_SelectEdit.Size = new System.Drawing.Size(72, 13);
            this.lblEdit_SelectEdit.TabIndex = 39;
            this.lblEdit_SelectEdit.Text = "Select to edit:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEdit_SaveInfo);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(400, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 100);
            this.panel1.TabIndex = 40;
            // 
            // lblEdit_SaveInfo
            // 
            this.lblEdit_SaveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_SaveInfo.Location = new System.Drawing.Point(15, 12);
            this.lblEdit_SaveInfo.Name = "lblEdit_SaveInfo";
            this.lblEdit_SaveInfo.Size = new System.Drawing.Size(160, 76);
            this.lblEdit_SaveInfo.TabIndex = 38;
            this.lblEdit_SaveInfo.Text = "No changes are made!";
            this.lblEdit_SaveInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddChanges
            // 
            this.btnAddChanges.Location = new System.Drawing.Point(469, 274);
            this.btnAddChanges.Name = "btnAddChanges";
            this.btnAddChanges.Size = new System.Drawing.Size(92, 23);
            this.btnAddChanges.TabIndex = 41;
            this.btnAddChanges.Text = "Add changes";
            this.btnAddChanges.UseVisualStyleBackColor = true;
            this.btnAddChanges.Click += new System.EventHandler(this.btnAddChanges_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(581, 274);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 42;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmEditDinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 432);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnAddChanges);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEdit_SelectEdit);
            this.Controls.Add(this.cmbEdit_SelectEdit);
            this.Controls.Add(this.cmbEdit_Type2);
            this.Controls.Add(this.cmbEdit_Type);
            this.Controls.Add(this.cmbEdit_Category);
            this.Controls.Add(this.chkEdit_Type2_New);
            this.Controls.Add(this.chkEdit_Type_New);
            this.Controls.Add(this.chkEdit_Category_New);
            this.Controls.Add(this.txtEdit_FullPath);
            this.Controls.Add(this.txtEdit_ShortPath);
            this.Controls.Add(this.txtEdit_Name);
            this.Controls.Add(this.txtEdit_Type2);
            this.Controls.Add(this.txtEdit_Type);
            this.Controls.Add(this.txtEdit_Category);
            this.Controls.Add(this.lblEdit_FullPath);
            this.Controls.Add(this.lblEdit_Type2);
            this.Controls.Add(this.lblEdit_ShortPath);
            this.Controls.Add(this.lblEdit_Type);
            this.Controls.Add(this.lblEdit_Name);
            this.Controls.Add(this.lblEdit_Category);
            this.Controls.Add(this.lblEdit_DBid_Value);
            this.Controls.Add(this.lblEdit_DBid);
            this.Name = "frmEditDinos";
            this.Text = "Edit Dinos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbEdit_Type2;
        private System.Windows.Forms.ComboBox cmbEdit_Type;
        private System.Windows.Forms.ComboBox cmbEdit_Category;
        private System.Windows.Forms.CheckBox chkEdit_Type2_New;
        private System.Windows.Forms.CheckBox chkEdit_Type_New;
        private System.Windows.Forms.CheckBox chkEdit_Category_New;
        private System.Windows.Forms.TextBox txtEdit_FullPath;
        private System.Windows.Forms.TextBox txtEdit_ShortPath;
        private System.Windows.Forms.TextBox txtEdit_Name;
        private System.Windows.Forms.TextBox txtEdit_Type2;
        private System.Windows.Forms.TextBox txtEdit_Type;
        private System.Windows.Forms.TextBox txtEdit_Category;
        private System.Windows.Forms.Label lblEdit_FullPath;
        private System.Windows.Forms.Label lblEdit_Type2;
        private System.Windows.Forms.Label lblEdit_ShortPath;
        private System.Windows.Forms.Label lblEdit_Type;
        private System.Windows.Forms.Label lblEdit_Name;
        private System.Windows.Forms.Label lblEdit_Category;
        private System.Windows.Forms.Label lblEdit_DBid_Value;
        private System.Windows.Forms.Label lblEdit_DBid;
        private System.Windows.Forms.ComboBox cmbEdit_SelectEdit;
        private System.Windows.Forms.Label lblEdit_SelectEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEdit_SaveInfo;
        private System.Windows.Forms.Button btnAddChanges;
        private System.Windows.Forms.Button btnAddNew;
    }
}