namespace NARKSpawn
{
    partial class frmMain
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
            this.lstNS_Results = new System.Windows.Forms.ListBox();
            this.lblNS_Search = new System.Windows.Forms.Label();
            this.txtNS_Search = new System.Windows.Forms.TextBox();
            this.txtNS_CopyText = new System.Windows.Forms.TextBox();
            this.btnNS_LeggTilItems = new System.Windows.Forms.Button();
            this.trwNS_Nodes = new System.Windows.Forms.TreeView();
            this.btnNS_Search_Reset = new System.Windows.Forms.Button();
            this.grpNS_ListsSelect = new System.Windows.Forms.GroupBox();
            this.rbtnNS_Lists_Items = new System.Windows.Forms.RadioButton();
            this.rbtnNS_Lists_Dinos = new System.Windows.Forms.RadioButton();
            this.rbtnNS_Lists_Commands = new System.Windows.Forms.RadioButton();
            this.grpNS_Settings_Items = new System.Windows.Forms.GroupBox();
            this.btnNS_Settings_Items_Quality_ASC = new System.Windows.Forms.Button();
            this.btnNS_Settings_Items_Quality_PRI = new System.Windows.Forms.Button();
            this.btnNS_Settings_Items_Amount_MAX = new System.Windows.Forms.Button();
            this.btnNS_Settings_Items_Amount_100 = new System.Windows.Forms.Button();
            this.btnNS_Settings_Items_Amount_10 = new System.Windows.Forms.Button();
            this.btnNS_Settings_Items_Amount_1 = new System.Windows.Forms.Button();
            this.lblNS_Settings_Items_Quality = new System.Windows.Forms.Label();
            this.nudNS_Settings_Items_Quality = new System.Windows.Forms.NumericUpDown();
            this.lblNS_Settings_Items_Amount = new System.Windows.Forms.Label();
            this.nudNS_Settings_Items_amount = new System.Windows.Forms.NumericUpDown();
            this.chkNS_Settings_Items_Blueprint = new System.Windows.Forms.CheckBox();
            this.chkNS_CopyText_ClearAfterCopy = new System.Windows.Forms.CheckBox();
            this.btnNS_CopyText_Copy = new System.Windows.Forms.Button();
            this.btnNS_CopyText_Clear = new System.Windows.Forms.Button();
            this.btnAddDinos = new System.Windows.Forms.Button();
            this.btnNS_EditSelected = new System.Windows.Forms.Button();
            this.pnlNS_Settings = new System.Windows.Forms.Panel();
            this.grpNS_Settings_Dinos = new System.Windows.Forms.GroupBox();
            this.lblNS_Settings_Dinos_levelBonus = new System.Windows.Forms.Label();
            this.chkNS_Settings_Dinos_Tamed = new System.Windows.Forms.CheckBox();
            this.chkNS_Settings_Dinos_ForceTamed = new System.Windows.Forms.CheckBox();
            this.nudNS_Settings_Dinos_Z = new System.Windows.Forms.NumericUpDown();
            this.lblNS_Settings_Dinos_Z = new System.Windows.Forms.Label();
            this.nudNS_Settings_Dinos_Y = new System.Windows.Forms.NumericUpDown();
            this.lblNS_Settings_Dinos_Y = new System.Windows.Forms.Label();
            this.nudNS_Settings_Dinos_Distance = new System.Windows.Forms.NumericUpDown();
            this.lblNS_Settings_Dinos_Distance = new System.Windows.Forms.Label();
            this.nudNS_Settings_Dinos_Level = new System.Windows.Forms.NumericUpDown();
            this.lblNS_Settings_Dinos_level = new System.Windows.Forms.Label();
            this.chkNS_Settings_Dinos_SpecifyLvl = new System.Windows.Forms.CheckBox();
            this.lblNS_Settings_Info = new System.Windows.Forms.Label();
            this.btnNS_AddNew = new System.Windows.Forms.Button();
            this.grpNS_DB_Edit = new System.Windows.Forms.GroupBox();
            this.pnlNS_CmdInfo = new System.Windows.Forms.Panel();
            this.lblNS_CmdInfo_Desc = new System.Windows.Forms.Label();
            this.lblNS_CmdInfo_Ex = new System.Windows.Forms.Label();
            this.grpNS_ListsSelect.SuspendLayout();
            this.grpNS_Settings_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Items_Quality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Items_amount)).BeginInit();
            this.pnlNS_Settings.SuspendLayout();
            this.grpNS_Settings_Dinos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Dinos_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Dinos_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Dinos_Distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Dinos_Level)).BeginInit();
            this.grpNS_DB_Edit.SuspendLayout();
            this.pnlNS_CmdInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNS_Results
            // 
            this.lstNS_Results.FormattingEnabled = true;
            this.lstNS_Results.Location = new System.Drawing.Point(252, 110);
            this.lstNS_Results.Name = "lstNS_Results";
            this.lstNS_Results.Size = new System.Drawing.Size(377, 446);
            this.lstNS_Results.TabIndex = 2;
            this.lstNS_Results.SelectedIndexChanged += new System.EventHandler(this.lstNS_Results_SelectedIndexChanged);
            this.lstNS_Results.DoubleClick += new System.EventHandler(this.AddToCopyText);
            // 
            // lblNS_Search
            // 
            this.lblNS_Search.AutoSize = true;
            this.lblNS_Search.Location = new System.Drawing.Point(348, 88);
            this.lblNS_Search.Name = "lblNS_Search";
            this.lblNS_Search.Size = new System.Drawing.Size(44, 13);
            this.lblNS_Search.TabIndex = 3;
            this.lblNS_Search.Text = "Search:";
            // 
            // txtNS_Search
            // 
            this.txtNS_Search.Location = new System.Drawing.Point(398, 84);
            this.txtNS_Search.Name = "txtNS_Search";
            this.txtNS_Search.Size = new System.Drawing.Size(208, 20);
            this.txtNS_Search.TabIndex = 4;
            this.txtNS_Search.TextChanged += new System.EventHandler(this.txtNS_Search_TextChanged);
            // 
            // txtNS_CopyText
            // 
            this.txtNS_CopyText.Location = new System.Drawing.Point(251, 566);
            this.txtNS_CopyText.Multiline = true;
            this.txtNS_CopyText.Name = "txtNS_CopyText";
            this.txtNS_CopyText.Size = new System.Drawing.Size(771, 111);
            this.txtNS_CopyText.TabIndex = 5;
            // 
            // btnNS_LeggTilItems
            // 
            this.btnNS_LeggTilItems.Location = new System.Drawing.Point(1029, 37);
            this.btnNS_LeggTilItems.Name = "btnNS_LeggTilItems";
            this.btnNS_LeggTilItems.Size = new System.Drawing.Size(114, 23);
            this.btnNS_LeggTilItems.TabIndex = 6;
            this.btnNS_LeggTilItems.Text = "Legg til Items";
            this.btnNS_LeggTilItems.UseVisualStyleBackColor = true;
            this.btnNS_LeggTilItems.Visible = false;
            this.btnNS_LeggTilItems.Click += new System.EventHandler(this.btnNS_LeggTilItems_Click);
            // 
            // trwNS_Nodes
            // 
            this.trwNS_Nodes.Location = new System.Drawing.Point(12, 12);
            this.trwNS_Nodes.Name = "trwNS_Nodes";
            this.trwNS_Nodes.Size = new System.Drawing.Size(234, 665);
            this.trwNS_Nodes.TabIndex = 7;
            this.trwNS_Nodes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trwNS_Nodes_AfterSelect);
            // 
            // btnNS_Search_Reset
            // 
            this.btnNS_Search_Reset.Enabled = false;
            this.btnNS_Search_Reset.Location = new System.Drawing.Point(608, 83);
            this.btnNS_Search_Reset.Name = "btnNS_Search_Reset";
            this.btnNS_Search_Reset.Size = new System.Drawing.Size(21, 22);
            this.btnNS_Search_Reset.TabIndex = 8;
            this.btnNS_Search_Reset.Text = "X";
            this.btnNS_Search_Reset.UseVisualStyleBackColor = true;
            this.btnNS_Search_Reset.Click += new System.EventHandler(this.btnNS_Search_Reset_Click);
            // 
            // grpNS_ListsSelect
            // 
            this.grpNS_ListsSelect.Controls.Add(this.rbtnNS_Lists_Items);
            this.grpNS_ListsSelect.Controls.Add(this.rbtnNS_Lists_Dinos);
            this.grpNS_ListsSelect.Controls.Add(this.rbtnNS_Lists_Commands);
            this.grpNS_ListsSelect.Location = new System.Drawing.Point(251, 12);
            this.grpNS_ListsSelect.Name = "grpNS_ListsSelect";
            this.grpNS_ListsSelect.Size = new System.Drawing.Size(91, 92);
            this.grpNS_ListsSelect.TabIndex = 9;
            this.grpNS_ListsSelect.TabStop = false;
            this.grpNS_ListsSelect.Text = "Lists";
            // 
            // rbtnNS_Lists_Items
            // 
            this.rbtnNS_Lists_Items.AutoSize = true;
            this.rbtnNS_Lists_Items.Checked = true;
            this.rbtnNS_Lists_Items.Location = new System.Drawing.Point(12, 66);
            this.rbtnNS_Lists_Items.Name = "rbtnNS_Lists_Items";
            this.rbtnNS_Lists_Items.Size = new System.Drawing.Size(50, 17);
            this.rbtnNS_Lists_Items.TabIndex = 0;
            this.rbtnNS_Lists_Items.TabStop = true;
            this.rbtnNS_Lists_Items.Text = "Items";
            this.rbtnNS_Lists_Items.UseVisualStyleBackColor = true;
            this.rbtnNS_Lists_Items.Click += new System.EventHandler(this.ListsSelectionChanged);
            // 
            // rbtnNS_Lists_Dinos
            // 
            this.rbtnNS_Lists_Dinos.AutoSize = true;
            this.rbtnNS_Lists_Dinos.Location = new System.Drawing.Point(12, 43);
            this.rbtnNS_Lists_Dinos.Name = "rbtnNS_Lists_Dinos";
            this.rbtnNS_Lists_Dinos.Size = new System.Drawing.Size(52, 17);
            this.rbtnNS_Lists_Dinos.TabIndex = 0;
            this.rbtnNS_Lists_Dinos.Text = "Dinos";
            this.rbtnNS_Lists_Dinos.UseVisualStyleBackColor = true;
            this.rbtnNS_Lists_Dinos.Click += new System.EventHandler(this.ListsSelectionChanged);
            // 
            // rbtnNS_Lists_Commands
            // 
            this.rbtnNS_Lists_Commands.AutoSize = true;
            this.rbtnNS_Lists_Commands.Location = new System.Drawing.Point(12, 20);
            this.rbtnNS_Lists_Commands.Name = "rbtnNS_Lists_Commands";
            this.rbtnNS_Lists_Commands.Size = new System.Drawing.Size(77, 17);
            this.rbtnNS_Lists_Commands.TabIndex = 0;
            this.rbtnNS_Lists_Commands.Text = "Commands";
            this.rbtnNS_Lists_Commands.UseVisualStyleBackColor = true;
            this.rbtnNS_Lists_Commands.Click += new System.EventHandler(this.ListsSelectionChanged);
            // 
            // grpNS_Settings_Items
            // 
            this.grpNS_Settings_Items.Controls.Add(this.btnNS_Settings_Items_Quality_ASC);
            this.grpNS_Settings_Items.Controls.Add(this.btnNS_Settings_Items_Quality_PRI);
            this.grpNS_Settings_Items.Controls.Add(this.btnNS_Settings_Items_Amount_MAX);
            this.grpNS_Settings_Items.Controls.Add(this.btnNS_Settings_Items_Amount_100);
            this.grpNS_Settings_Items.Controls.Add(this.btnNS_Settings_Items_Amount_10);
            this.grpNS_Settings_Items.Controls.Add(this.btnNS_Settings_Items_Amount_1);
            this.grpNS_Settings_Items.Controls.Add(this.lblNS_Settings_Items_Quality);
            this.grpNS_Settings_Items.Controls.Add(this.nudNS_Settings_Items_Quality);
            this.grpNS_Settings_Items.Controls.Add(this.lblNS_Settings_Items_Amount);
            this.grpNS_Settings_Items.Controls.Add(this.nudNS_Settings_Items_amount);
            this.grpNS_Settings_Items.Controls.Add(this.chkNS_Settings_Items_Blueprint);
            this.grpNS_Settings_Items.Location = new System.Drawing.Point(20, 30);
            this.grpNS_Settings_Items.Name = "grpNS_Settings_Items";
            this.grpNS_Settings_Items.Size = new System.Drawing.Size(200, 172);
            this.grpNS_Settings_Items.TabIndex = 10;
            this.grpNS_Settings_Items.TabStop = false;
            this.grpNS_Settings_Items.Text = "Items";
            // 
            // btnNS_Settings_Items_Quality_ASC
            // 
            this.btnNS_Settings_Items_Quality_ASC.Location = new System.Drawing.Point(150, 90);
            this.btnNS_Settings_Items_Quality_ASC.Name = "btnNS_Settings_Items_Quality_ASC";
            this.btnNS_Settings_Items_Quality_ASC.Size = new System.Drawing.Size(39, 23);
            this.btnNS_Settings_Items_Quality_ASC.TabIndex = 5;
            this.btnNS_Settings_Items_Quality_ASC.Text = "ASC";
            this.btnNS_Settings_Items_Quality_ASC.UseVisualStyleBackColor = true;
            this.btnNS_Settings_Items_Quality_ASC.Click += new System.EventHandler(this.SettItemsQuality);
            // 
            // btnNS_Settings_Items_Quality_PRI
            // 
            this.btnNS_Settings_Items_Quality_PRI.Location = new System.Drawing.Point(105, 90);
            this.btnNS_Settings_Items_Quality_PRI.Name = "btnNS_Settings_Items_Quality_PRI";
            this.btnNS_Settings_Items_Quality_PRI.Size = new System.Drawing.Size(39, 23);
            this.btnNS_Settings_Items_Quality_PRI.TabIndex = 5;
            this.btnNS_Settings_Items_Quality_PRI.Text = "PRI";
            this.btnNS_Settings_Items_Quality_PRI.UseVisualStyleBackColor = true;
            this.btnNS_Settings_Items_Quality_PRI.Click += new System.EventHandler(this.SettItemsQuality);
            // 
            // btnNS_Settings_Items_Amount_MAX
            // 
            this.btnNS_Settings_Items_Amount_MAX.Location = new System.Drawing.Point(150, 21);
            this.btnNS_Settings_Items_Amount_MAX.Name = "btnNS_Settings_Items_Amount_MAX";
            this.btnNS_Settings_Items_Amount_MAX.Size = new System.Drawing.Size(39, 23);
            this.btnNS_Settings_Items_Amount_MAX.TabIndex = 5;
            this.btnNS_Settings_Items_Amount_MAX.Text = "MAX";
            this.btnNS_Settings_Items_Amount_MAX.UseVisualStyleBackColor = true;
            this.btnNS_Settings_Items_Amount_MAX.Click += new System.EventHandler(this.SettItemsAmount);
            // 
            // btnNS_Settings_Items_Amount_100
            // 
            this.btnNS_Settings_Items_Amount_100.Location = new System.Drawing.Point(105, 21);
            this.btnNS_Settings_Items_Amount_100.Name = "btnNS_Settings_Items_Amount_100";
            this.btnNS_Settings_Items_Amount_100.Size = new System.Drawing.Size(39, 23);
            this.btnNS_Settings_Items_Amount_100.TabIndex = 5;
            this.btnNS_Settings_Items_Amount_100.Text = "100";
            this.btnNS_Settings_Items_Amount_100.UseVisualStyleBackColor = true;
            this.btnNS_Settings_Items_Amount_100.Click += new System.EventHandler(this.SettItemsAmount);
            // 
            // btnNS_Settings_Items_Amount_10
            // 
            this.btnNS_Settings_Items_Amount_10.Location = new System.Drawing.Point(60, 21);
            this.btnNS_Settings_Items_Amount_10.Name = "btnNS_Settings_Items_Amount_10";
            this.btnNS_Settings_Items_Amount_10.Size = new System.Drawing.Size(39, 23);
            this.btnNS_Settings_Items_Amount_10.TabIndex = 5;
            this.btnNS_Settings_Items_Amount_10.Text = "10";
            this.btnNS_Settings_Items_Amount_10.UseVisualStyleBackColor = true;
            this.btnNS_Settings_Items_Amount_10.Click += new System.EventHandler(this.SettItemsAmount);
            // 
            // btnNS_Settings_Items_Amount_1
            // 
            this.btnNS_Settings_Items_Amount_1.Location = new System.Drawing.Point(15, 21);
            this.btnNS_Settings_Items_Amount_1.Name = "btnNS_Settings_Items_Amount_1";
            this.btnNS_Settings_Items_Amount_1.Size = new System.Drawing.Size(39, 23);
            this.btnNS_Settings_Items_Amount_1.TabIndex = 5;
            this.btnNS_Settings_Items_Amount_1.Text = "1";
            this.btnNS_Settings_Items_Amount_1.UseVisualStyleBackColor = true;
            this.btnNS_Settings_Items_Amount_1.Click += new System.EventHandler(this.SettItemsAmount);
            // 
            // lblNS_Settings_Items_Quality
            // 
            this.lblNS_Settings_Items_Quality.AutoSize = true;
            this.lblNS_Settings_Items_Quality.Location = new System.Drawing.Point(6, 94);
            this.lblNS_Settings_Items_Quality.Name = "lblNS_Settings_Items_Quality";
            this.lblNS_Settings_Items_Quality.Size = new System.Drawing.Size(42, 13);
            this.lblNS_Settings_Items_Quality.TabIndex = 4;
            this.lblNS_Settings_Items_Quality.Text = "Quality:";
            // 
            // nudNS_Settings_Items_Quality
            // 
            this.nudNS_Settings_Items_Quality.Location = new System.Drawing.Point(55, 92);
            this.nudNS_Settings_Items_Quality.Name = "nudNS_Settings_Items_Quality";
            this.nudNS_Settings_Items_Quality.Size = new System.Drawing.Size(44, 20);
            this.nudNS_Settings_Items_Quality.TabIndex = 3;
            // 
            // lblNS_Settings_Items_Amount
            // 
            this.lblNS_Settings_Items_Amount.AutoSize = true;
            this.lblNS_Settings_Items_Amount.Location = new System.Drawing.Point(40, 56);
            this.lblNS_Settings_Items_Amount.Name = "lblNS_Settings_Items_Amount";
            this.lblNS_Settings_Items_Amount.Size = new System.Drawing.Size(46, 13);
            this.lblNS_Settings_Items_Amount.TabIndex = 2;
            this.lblNS_Settings_Items_Amount.Text = "Amount:";
            // 
            // nudNS_Settings_Items_amount
            // 
            this.nudNS_Settings_Items_amount.Location = new System.Drawing.Point(93, 54);
            this.nudNS_Settings_Items_amount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNS_Settings_Items_amount.Name = "nudNS_Settings_Items_amount";
            this.nudNS_Settings_Items_amount.Size = new System.Drawing.Size(62, 20);
            this.nudNS_Settings_Items_amount.TabIndex = 1;
            this.nudNS_Settings_Items_amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkNS_Settings_Items_Blueprint
            // 
            this.chkNS_Settings_Items_Blueprint.AutoSize = true;
            this.chkNS_Settings_Items_Blueprint.Location = new System.Drawing.Point(20, 138);
            this.chkNS_Settings_Items_Blueprint.Name = "chkNS_Settings_Items_Blueprint";
            this.chkNS_Settings_Items_Blueprint.Size = new System.Drawing.Size(67, 17);
            this.chkNS_Settings_Items_Blueprint.TabIndex = 0;
            this.chkNS_Settings_Items_Blueprint.Text = "Blueprint";
            this.chkNS_Settings_Items_Blueprint.UseVisualStyleBackColor = true;
            // 
            // chkNS_CopyText_ClearAfterCopy
            // 
            this.chkNS_CopyText_ClearAfterCopy.AutoSize = true;
            this.chkNS_CopyText_ClearAfterCopy.Checked = true;
            this.chkNS_CopyText_ClearAfterCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNS_CopyText_ClearAfterCopy.Location = new System.Drawing.Point(1028, 566);
            this.chkNS_CopyText_ClearAfterCopy.Name = "chkNS_CopyText_ClearAfterCopy";
            this.chkNS_CopyText_ClearAfterCopy.Size = new System.Drawing.Size(100, 17);
            this.chkNS_CopyText_ClearAfterCopy.TabIndex = 11;
            this.chkNS_CopyText_ClearAfterCopy.Text = "Clear after copy";
            this.chkNS_CopyText_ClearAfterCopy.UseVisualStyleBackColor = true;
            // 
            // btnNS_CopyText_Copy
            // 
            this.btnNS_CopyText_Copy.Location = new System.Drawing.Point(1044, 598);
            this.btnNS_CopyText_Copy.Name = "btnNS_CopyText_Copy";
            this.btnNS_CopyText_Copy.Size = new System.Drawing.Size(75, 23);
            this.btnNS_CopyText_Copy.TabIndex = 12;
            this.btnNS_CopyText_Copy.Text = "Copy";
            this.btnNS_CopyText_Copy.UseVisualStyleBackColor = true;
            this.btnNS_CopyText_Copy.Click += new System.EventHandler(this.btnNS_CopyText_Copy_Click);
            // 
            // btnNS_CopyText_Clear
            // 
            this.btnNS_CopyText_Clear.Location = new System.Drawing.Point(1044, 644);
            this.btnNS_CopyText_Clear.Name = "btnNS_CopyText_Clear";
            this.btnNS_CopyText_Clear.Size = new System.Drawing.Size(75, 23);
            this.btnNS_CopyText_Clear.TabIndex = 12;
            this.btnNS_CopyText_Clear.Text = "Clear";
            this.btnNS_CopyText_Clear.UseVisualStyleBackColor = true;
            this.btnNS_CopyText_Clear.Click += new System.EventHandler(this.btnNS_CopyText_Clear_Click);
            // 
            // btnAddDinos
            // 
            this.btnAddDinos.Location = new System.Drawing.Point(1029, 12);
            this.btnAddDinos.Name = "btnAddDinos";
            this.btnAddDinos.Size = new System.Drawing.Size(114, 23);
            this.btnAddDinos.TabIndex = 13;
            this.btnAddDinos.Text = "Add dinos";
            this.btnAddDinos.UseVisualStyleBackColor = true;
            this.btnAddDinos.Visible = false;
            this.btnAddDinos.Click += new System.EventHandler(this.btnAddDinos_Click);
            // 
            // btnNS_EditSelected
            // 
            this.btnNS_EditSelected.Enabled = false;
            this.btnNS_EditSelected.Location = new System.Drawing.Point(30, 25);
            this.btnNS_EditSelected.Name = "btnNS_EditSelected";
            this.btnNS_EditSelected.Size = new System.Drawing.Size(79, 23);
            this.btnNS_EditSelected.TabIndex = 14;
            this.btnNS_EditSelected.Text = "Edit selected";
            this.btnNS_EditSelected.UseVisualStyleBackColor = true;
            this.btnNS_EditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // pnlNS_Settings
            // 
            this.pnlNS_Settings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlNS_Settings.Controls.Add(this.grpNS_Settings_Dinos);
            this.pnlNS_Settings.Controls.Add(this.lblNS_Settings_Info);
            this.pnlNS_Settings.Controls.Add(this.grpNS_Settings_Items);
            this.pnlNS_Settings.Location = new System.Drawing.Point(635, 110);
            this.pnlNS_Settings.Name = "pnlNS_Settings";
            this.pnlNS_Settings.Size = new System.Drawing.Size(243, 273);
            this.pnlNS_Settings.TabIndex = 15;
            // 
            // grpNS_Settings_Dinos
            // 
            this.grpNS_Settings_Dinos.Controls.Add(this.lblNS_Settings_Dinos_levelBonus);
            this.grpNS_Settings_Dinos.Controls.Add(this.chkNS_Settings_Dinos_Tamed);
            this.grpNS_Settings_Dinos.Controls.Add(this.chkNS_Settings_Dinos_ForceTamed);
            this.grpNS_Settings_Dinos.Controls.Add(this.nudNS_Settings_Dinos_Z);
            this.grpNS_Settings_Dinos.Controls.Add(this.lblNS_Settings_Dinos_Z);
            this.grpNS_Settings_Dinos.Controls.Add(this.nudNS_Settings_Dinos_Y);
            this.grpNS_Settings_Dinos.Controls.Add(this.lblNS_Settings_Dinos_Y);
            this.grpNS_Settings_Dinos.Controls.Add(this.nudNS_Settings_Dinos_Distance);
            this.grpNS_Settings_Dinos.Controls.Add(this.lblNS_Settings_Dinos_Distance);
            this.grpNS_Settings_Dinos.Controls.Add(this.nudNS_Settings_Dinos_Level);
            this.grpNS_Settings_Dinos.Controls.Add(this.lblNS_Settings_Dinos_level);
            this.grpNS_Settings_Dinos.Controls.Add(this.chkNS_Settings_Dinos_SpecifyLvl);
            this.grpNS_Settings_Dinos.Location = new System.Drawing.Point(6, 31);
            this.grpNS_Settings_Dinos.Name = "grpNS_Settings_Dinos";
            this.grpNS_Settings_Dinos.Size = new System.Drawing.Size(234, 234);
            this.grpNS_Settings_Dinos.TabIndex = 16;
            this.grpNS_Settings_Dinos.TabStop = false;
            this.grpNS_Settings_Dinos.Text = "Dinos";
            this.grpNS_Settings_Dinos.Visible = false;
            // 
            // lblNS_Settings_Dinos_levelBonus
            // 
            this.lblNS_Settings_Dinos_levelBonus.AutoSize = true;
            this.lblNS_Settings_Dinos_levelBonus.Location = new System.Drawing.Point(127, 83);
            this.lblNS_Settings_Dinos_levelBonus.Name = "lblNS_Settings_Dinos_levelBonus";
            this.lblNS_Settings_Dinos_levelBonus.Size = new System.Drawing.Size(19, 13);
            this.lblNS_Settings_Dinos_levelBonus.TabIndex = 5;
            this.lblNS_Settings_Dinos_levelBonus.Text = "<>";
            this.lblNS_Settings_Dinos_levelBonus.Visible = false;
            // 
            // chkNS_Settings_Dinos_Tamed
            // 
            this.chkNS_Settings_Dinos_Tamed.AutoSize = true;
            this.chkNS_Settings_Dinos_Tamed.Location = new System.Drawing.Point(9, 51);
            this.chkNS_Settings_Dinos_Tamed.Name = "chkNS_Settings_Dinos_Tamed";
            this.chkNS_Settings_Dinos_Tamed.Size = new System.Drawing.Size(187, 17);
            this.chkNS_Settings_Dinos_Tamed.TabIndex = 4;
            this.chkNS_Settings_Dinos_Tamed.Text = "Tamed (Regular - 1.5 tame bonus)";
            this.chkNS_Settings_Dinos_Tamed.UseVisualStyleBackColor = true;
            this.chkNS_Settings_Dinos_Tamed.CheckedChanged += new System.EventHandler(this.chkNS_Settings_Dinos_Tamed_CheckedChanged);
            // 
            // chkNS_Settings_Dinos_ForceTamed
            // 
            this.chkNS_Settings_Dinos_ForceTamed.AutoSize = true;
            this.chkNS_Settings_Dinos_ForceTamed.Location = new System.Drawing.Point(9, 202);
            this.chkNS_Settings_Dinos_ForceTamed.Name = "chkNS_Settings_Dinos_ForceTamed";
            this.chkNS_Settings_Dinos_ForceTamed.Size = new System.Drawing.Size(121, 17);
            this.chkNS_Settings_Dinos_ForceTamed.TabIndex = 3;
            this.chkNS_Settings_Dinos_ForceTamed.Text = "Spawn Force-tamed";
            this.chkNS_Settings_Dinos_ForceTamed.UseVisualStyleBackColor = true;
            this.chkNS_Settings_Dinos_ForceTamed.CheckedChanged += new System.EventHandler(this.chkNS_Settings_Dinos_ForceTamed_CheckedChanged);
            // 
            // nudNS_Settings_Dinos_Z
            // 
            this.nudNS_Settings_Dinos_Z.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNS_Settings_Dinos_Z.Location = new System.Drawing.Point(62, 165);
            this.nudNS_Settings_Dinos_Z.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNS_Settings_Dinos_Z.Name = "nudNS_Settings_Dinos_Z";
            this.nudNS_Settings_Dinos_Z.Size = new System.Drawing.Size(63, 20);
            this.nudNS_Settings_Dinos_Z.TabIndex = 2;
            // 
            // lblNS_Settings_Dinos_Z
            // 
            this.lblNS_Settings_Dinos_Z.AutoSize = true;
            this.lblNS_Settings_Dinos_Z.Location = new System.Drawing.Point(39, 168);
            this.lblNS_Settings_Dinos_Z.Name = "lblNS_Settings_Dinos_Z";
            this.lblNS_Settings_Dinos_Z.Size = new System.Drawing.Size(17, 13);
            this.lblNS_Settings_Dinos_Z.TabIndex = 1;
            this.lblNS_Settings_Dinos_Z.Text = "Z:";
            // 
            // nudNS_Settings_Dinos_Y
            // 
            this.nudNS_Settings_Dinos_Y.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNS_Settings_Dinos_Y.Location = new System.Drawing.Point(62, 139);
            this.nudNS_Settings_Dinos_Y.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNS_Settings_Dinos_Y.Name = "nudNS_Settings_Dinos_Y";
            this.nudNS_Settings_Dinos_Y.Size = new System.Drawing.Size(63, 20);
            this.nudNS_Settings_Dinos_Y.TabIndex = 2;
            // 
            // lblNS_Settings_Dinos_Y
            // 
            this.lblNS_Settings_Dinos_Y.AutoSize = true;
            this.lblNS_Settings_Dinos_Y.Location = new System.Drawing.Point(39, 141);
            this.lblNS_Settings_Dinos_Y.Name = "lblNS_Settings_Dinos_Y";
            this.lblNS_Settings_Dinos_Y.Size = new System.Drawing.Size(17, 13);
            this.lblNS_Settings_Dinos_Y.TabIndex = 1;
            this.lblNS_Settings_Dinos_Y.Text = "Y:";
            // 
            // nudNS_Settings_Dinos_Distance
            // 
            this.nudNS_Settings_Dinos_Distance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudNS_Settings_Dinos_Distance.Location = new System.Drawing.Point(62, 113);
            this.nudNS_Settings_Dinos_Distance.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNS_Settings_Dinos_Distance.Name = "nudNS_Settings_Dinos_Distance";
            this.nudNS_Settings_Dinos_Distance.Size = new System.Drawing.Size(63, 20);
            this.nudNS_Settings_Dinos_Distance.TabIndex = 2;
            this.nudNS_Settings_Dinos_Distance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblNS_Settings_Dinos_Distance
            // 
            this.lblNS_Settings_Dinos_Distance.AutoSize = true;
            this.lblNS_Settings_Dinos_Distance.Location = new System.Drawing.Point(9, 115);
            this.lblNS_Settings_Dinos_Distance.Name = "lblNS_Settings_Dinos_Distance";
            this.lblNS_Settings_Dinos_Distance.Size = new System.Drawing.Size(52, 13);
            this.lblNS_Settings_Dinos_Distance.TabIndex = 1;
            this.lblNS_Settings_Dinos_Distance.Text = "Distance:";
            // 
            // nudNS_Settings_Dinos_Level
            // 
            this.nudNS_Settings_Dinos_Level.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNS_Settings_Dinos_Level.Location = new System.Drawing.Point(62, 81);
            this.nudNS_Settings_Dinos_Level.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNS_Settings_Dinos_Level.Name = "nudNS_Settings_Dinos_Level";
            this.nudNS_Settings_Dinos_Level.Size = new System.Drawing.Size(63, 20);
            this.nudNS_Settings_Dinos_Level.TabIndex = 2;
            this.nudNS_Settings_Dinos_Level.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudNS_Settings_Dinos_Level.ValueChanged += new System.EventHandler(this.nudNS_Settings_Dinos_Level_ValueChanged);
            // 
            // lblNS_Settings_Dinos_level
            // 
            this.lblNS_Settings_Dinos_level.AutoSize = true;
            this.lblNS_Settings_Dinos_level.Location = new System.Drawing.Point(20, 83);
            this.lblNS_Settings_Dinos_level.Name = "lblNS_Settings_Dinos_level";
            this.lblNS_Settings_Dinos_level.Size = new System.Drawing.Size(36, 13);
            this.lblNS_Settings_Dinos_level.TabIndex = 1;
            this.lblNS_Settings_Dinos_level.Text = "Level:";
            // 
            // chkNS_Settings_Dinos_SpecifyLvl
            // 
            this.chkNS_Settings_Dinos_SpecifyLvl.AutoSize = true;
            this.chkNS_Settings_Dinos_SpecifyLvl.Checked = true;
            this.chkNS_Settings_Dinos_SpecifyLvl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNS_Settings_Dinos_SpecifyLvl.Location = new System.Drawing.Point(9, 24);
            this.chkNS_Settings_Dinos_SpecifyLvl.Name = "chkNS_Settings_Dinos_SpecifyLvl";
            this.chkNS_Settings_Dinos_SpecifyLvl.Size = new System.Drawing.Size(86, 17);
            this.chkNS_Settings_Dinos_SpecifyLvl.TabIndex = 0;
            this.chkNS_Settings_Dinos_SpecifyLvl.Text = "Specify level";
            this.chkNS_Settings_Dinos_SpecifyLvl.UseVisualStyleBackColor = true;
            this.chkNS_Settings_Dinos_SpecifyLvl.CheckedChanged += new System.EventHandler(this.chkNS_Settings_Dinos_SpecifyLvl_CheckedChanged);
            // 
            // lblNS_Settings_Info
            // 
            this.lblNS_Settings_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNS_Settings_Info.Location = new System.Drawing.Point(3, 4);
            this.lblNS_Settings_Info.Name = "lblNS_Settings_Info";
            this.lblNS_Settings_Info.Size = new System.Drawing.Size(237, 23);
            this.lblNS_Settings_Info.TabIndex = 15;
            this.lblNS_Settings_Info.Text = "Settings";
            this.lblNS_Settings_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNS_AddNew
            // 
            this.btnNS_AddNew.Location = new System.Drawing.Point(166, 25);
            this.btnNS_AddNew.Name = "btnNS_AddNew";
            this.btnNS_AddNew.Size = new System.Drawing.Size(66, 23);
            this.btnNS_AddNew.TabIndex = 16;
            this.btnNS_AddNew.Text = "Add new...";
            this.btnNS_AddNew.UseVisualStyleBackColor = true;
            this.btnNS_AddNew.Click += new System.EventHandler(this.btnNS_AddNew_Click);
            // 
            // grpNS_DB_Edit
            // 
            this.grpNS_DB_Edit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpNS_DB_Edit.Controls.Add(this.btnNS_EditSelected);
            this.grpNS_DB_Edit.Controls.Add(this.btnNS_AddNew);
            this.grpNS_DB_Edit.Location = new System.Drawing.Point(348, 12);
            this.grpNS_DB_Edit.Name = "grpNS_DB_Edit";
            this.grpNS_DB_Edit.Size = new System.Drawing.Size(281, 66);
            this.grpNS_DB_Edit.TabIndex = 17;
            this.grpNS_DB_Edit.TabStop = false;
            this.grpNS_DB_Edit.Text = "Database";
            // 
            // pnlNS_CmdInfo
            // 
            this.pnlNS_CmdInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlNS_CmdInfo.Controls.Add(this.lblNS_CmdInfo_Desc);
            this.pnlNS_CmdInfo.Controls.Add(this.lblNS_CmdInfo_Ex);
            this.pnlNS_CmdInfo.Location = new System.Drawing.Point(636, 390);
            this.pnlNS_CmdInfo.Name = "pnlNS_CmdInfo";
            this.pnlNS_CmdInfo.Size = new System.Drawing.Size(499, 166);
            this.pnlNS_CmdInfo.TabIndex = 18;
            this.pnlNS_CmdInfo.Visible = false;
            // 
            // lblNS_CmdInfo_Desc
            // 
            this.lblNS_CmdInfo_Desc.Location = new System.Drawing.Point(19, 44);
            this.lblNS_CmdInfo_Desc.Name = "lblNS_CmdInfo_Desc";
            this.lblNS_CmdInfo_Desc.Size = new System.Drawing.Size(464, 113);
            this.lblNS_CmdInfo_Desc.TabIndex = 1;
            this.lblNS_CmdInfo_Desc.Text = "Description:";
            // 
            // lblNS_CmdInfo_Ex
            // 
            this.lblNS_CmdInfo_Ex.AutoSize = true;
            this.lblNS_CmdInfo_Ex.Location = new System.Drawing.Point(19, 17);
            this.lblNS_CmdInfo_Ex.Name = "lblNS_CmdInfo_Ex";
            this.lblNS_CmdInfo_Ex.Size = new System.Drawing.Size(50, 13);
            this.lblNS_CmdInfo_Ex.TabIndex = 0;
            this.lblNS_CmdInfo_Ex.Text = "Example:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 689);
            this.Controls.Add(this.pnlNS_CmdInfo);
            this.Controls.Add(this.grpNS_DB_Edit);
            this.Controls.Add(this.pnlNS_Settings);
            this.Controls.Add(this.btnAddDinos);
            this.Controls.Add(this.btnNS_CopyText_Clear);
            this.Controls.Add(this.btnNS_CopyText_Copy);
            this.Controls.Add(this.chkNS_CopyText_ClearAfterCopy);
            this.Controls.Add(this.grpNS_ListsSelect);
            this.Controls.Add(this.btnNS_Search_Reset);
            this.Controls.Add(this.trwNS_Nodes);
            this.Controls.Add(this.btnNS_LeggTilItems);
            this.Controls.Add(this.txtNS_CopyText);
            this.Controls.Add(this.txtNS_Search);
            this.Controls.Add(this.lblNS_Search);
            this.Controls.Add(this.lstNS_Results);
            this.Name = "frmMain";
            this.Text = "NARK Spawn";
            this.grpNS_ListsSelect.ResumeLayout(false);
            this.grpNS_ListsSelect.PerformLayout();
            this.grpNS_Settings_Items.ResumeLayout(false);
            this.grpNS_Settings_Items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Items_Quality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Items_amount)).EndInit();
            this.pnlNS_Settings.ResumeLayout(false);
            this.grpNS_Settings_Dinos.ResumeLayout(false);
            this.grpNS_Settings_Dinos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Dinos_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Dinos_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Dinos_Distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_Settings_Dinos_Level)).EndInit();
            this.grpNS_DB_Edit.ResumeLayout(false);
            this.pnlNS_CmdInfo.ResumeLayout(false);
            this.pnlNS_CmdInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstNS_Results;
        private System.Windows.Forms.Label lblNS_Search;
        private System.Windows.Forms.TextBox txtNS_Search;
        private System.Windows.Forms.TextBox txtNS_CopyText;
        private System.Windows.Forms.Button btnNS_LeggTilItems;
        private System.Windows.Forms.TreeView trwNS_Nodes;
        private System.Windows.Forms.Button btnNS_Search_Reset;
        private System.Windows.Forms.GroupBox grpNS_ListsSelect;
        private System.Windows.Forms.RadioButton rbtnNS_Lists_Items;
        private System.Windows.Forms.RadioButton rbtnNS_Lists_Dinos;
        private System.Windows.Forms.RadioButton rbtnNS_Lists_Commands;
        private System.Windows.Forms.GroupBox grpNS_Settings_Items;
        private System.Windows.Forms.Button btnNS_Settings_Items_Quality_ASC;
        private System.Windows.Forms.Button btnNS_Settings_Items_Quality_PRI;
        private System.Windows.Forms.Button btnNS_Settings_Items_Amount_MAX;
        private System.Windows.Forms.Button btnNS_Settings_Items_Amount_100;
        private System.Windows.Forms.Button btnNS_Settings_Items_Amount_10;
        private System.Windows.Forms.Button btnNS_Settings_Items_Amount_1;
        private System.Windows.Forms.Label lblNS_Settings_Items_Quality;
        private System.Windows.Forms.NumericUpDown nudNS_Settings_Items_Quality;
        private System.Windows.Forms.Label lblNS_Settings_Items_Amount;
        private System.Windows.Forms.NumericUpDown nudNS_Settings_Items_amount;
        private System.Windows.Forms.CheckBox chkNS_Settings_Items_Blueprint;
        private System.Windows.Forms.CheckBox chkNS_CopyText_ClearAfterCopy;
        private System.Windows.Forms.Button btnNS_CopyText_Copy;
        private System.Windows.Forms.Button btnNS_CopyText_Clear;
        private System.Windows.Forms.Button btnAddDinos;
        private System.Windows.Forms.Button btnNS_EditSelected;
        private System.Windows.Forms.Panel pnlNS_Settings;
        private System.Windows.Forms.Label lblNS_Settings_Info;
        private System.Windows.Forms.Button btnNS_AddNew;
        private System.Windows.Forms.GroupBox grpNS_Settings_Dinos;
        private System.Windows.Forms.NumericUpDown nudNS_Settings_Dinos_Z;
        private System.Windows.Forms.Label lblNS_Settings_Dinos_Z;
        private System.Windows.Forms.NumericUpDown nudNS_Settings_Dinos_Y;
        private System.Windows.Forms.Label lblNS_Settings_Dinos_Y;
        private System.Windows.Forms.NumericUpDown nudNS_Settings_Dinos_Distance;
        private System.Windows.Forms.Label lblNS_Settings_Dinos_Distance;
        private System.Windows.Forms.NumericUpDown nudNS_Settings_Dinos_Level;
        private System.Windows.Forms.Label lblNS_Settings_Dinos_level;
        private System.Windows.Forms.CheckBox chkNS_Settings_Dinos_SpecifyLvl;
        private System.Windows.Forms.CheckBox chkNS_Settings_Dinos_ForceTamed;
        private System.Windows.Forms.Label lblNS_Settings_Dinos_levelBonus;
        private System.Windows.Forms.CheckBox chkNS_Settings_Dinos_Tamed;
        private System.Windows.Forms.GroupBox grpNS_DB_Edit;
        private System.Windows.Forms.Panel pnlNS_CmdInfo;
        private System.Windows.Forms.Label lblNS_CmdInfo_Ex;
        private System.Windows.Forms.Label lblNS_CmdInfo_Desc;
    }
}

