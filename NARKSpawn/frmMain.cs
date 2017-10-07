using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace NARKSpawn
{
    public partial class frmMain : Form
    {
        private enum enuLists
        {
            COMMANDS,
            DINOS,
            ITEMS
        }

        private enuLists Lists = enuLists.ITEMS;

        private NarkspawnContext _dbContext = new NarkspawnContext();
        
        private List<Commands> cmds;
        private List<Dinos> dinos;
        private List<Items> items;

        private List<string> cat;
        private List<string> type;
        private List<string> type2;

        private List<Category> catNodes;
        private List<CatType> catTypeNodes;
        private List<CatType2> catType2Nodes;
        
        //Items...
        List<Items> selItems = new List<Items>();

        //Dinos
        List<Dinos> selDinos = new List<Dinos>();

        //Commands
        List<Commands> selCmds = new List<Commands>();

        //search
        private bool IsSearching = false;

        private string Search = "";

        //selected TreeIdx
        private TreeNode SelectedTreeNode;
        public frmMain()
        {
            InitializeComponent();
            cmds = _dbContext.Commands.ToList();
            dinos = _dbContext.Dinos.ToList();
            items = _dbContext.Items.ToList();
            
            cat = new List<string>();
            type = new List<string>();
            type2 = new List<string>();
            catNodes = new List<Category>();
            catTypeNodes = new List<CatType>();
            catType2Nodes = new List<CatType2>();
            FillCategoryList();

            FillTreeView();
            Populate(Lists);
            trwNS_Nodes.ExpandAll();
            trwNS_Nodes.SelectedNode = trwNS_Nodes.Nodes[0];
        }

        private void FreshStart()
        {
            _dbContext = new NarkspawnContext();
            cmds = _dbContext.Commands.ToList();
            dinos = _dbContext.Dinos.ToList();
            items = _dbContext.Items.ToList();

            cat = new List<string>();
            type = new List<string>();
            type2 = new List<string>();
            catNodes = new List<Category>();
            catTypeNodes = new List<CatType>();
            catType2Nodes = new List<CatType2>();
            FillCategoryList();

            FillTreeView();
            Populate(Lists);
            trwNS_Nodes.ExpandAll();
            try
            {
                if (SelectedTreeNode != null)
                {
                    trwNS_Nodes.SelectedNode = trwNS_Nodes.Nodes.Find(SelectedTreeNode.Name, true)[0];
                }
            }
            catch (Exception e)
            {
                trwNS_Nodes.SelectedNode = trwNS_Nodes.Nodes[0];
            }
            //if (SelectedTreeNode != null)
            //{
            //    trwNS_Nodes.SelectedNode = trwNS_Nodes.Nodes.Find(SelectedTreeNode.Name, true)[0];
            //}
            //else
            //{
            //    trwNS_Nodes.SelectedNode = trwNS_Nodes.Nodes[0];
            //}
            
        }

        private void FillCatNodes()
        {
            catNodes = new List<Category>();
            catTypeNodes = new List<CatType>();
            catType2Nodes = new List<CatType2>();
            switch (Lists)
            {
                case enuLists.COMMANDS:
                    break;
                case enuLists.DINOS:
                    foreach (var dino in dinos)
                    {

                        if (!string.IsNullOrEmpty(dino.Category))
                        {

                            //category
                            Category tCatNode = new Category(dino.Category);
                            //!catNodes.Contains(tCatNode)
                            if (!catNodes.Exists(x => x.Name == dino.Category))
                            {
                                catNodes.Add(tCatNode);
                            }
                        }
                        if (!string.IsNullOrEmpty(dino.Type))
                        {
                            CatType tCatType = new CatType(dino.Type, dino.Category);
                            //!catTypeNodes.Contains(tCatType)
                            if (!catTypeNodes.Exists(x => x.Name == dino.Type && x.ParentCat == dino.Category))
                            {
                                catTypeNodes.Add(tCatType);
                            }
                        }
                        if (!string.IsNullOrEmpty(dino.Type2))
                        {
                            CatType2 tCatType2 = new CatType2(dino.Type2, dino.Category, dino.Type);
                            //!catType2Nodes.Contains(tCatType2)
                            if (!catType2Nodes.Exists(x => x.Name == dino.Type2 && x.ParentType == dino.Type && x.ParentCat == dino.Category))
                            {
                                catType2Nodes.Add(tCatType2);
                            }
                        }
                    }
                    catNodes = catNodes.OrderBy(r => r.Name).ToList();
                    catTypeNodes = catTypeNodes.OrderBy(r => r.Name).ToList();
                    catType2Nodes = catType2Nodes.OrderBy(r => r.Name).ToList();
                    break;
                case enuLists.ITEMS:
                    foreach (var item in items)
                        {

                            if (!string.IsNullOrEmpty(item.Category))
                            {

                                //category
                                Category tCatNode = new Category(item.Category);
                                //!catNodes.Contains(tCatNode)
                                if (!catNodes.Exists(x => x.Name == item.Category))
                                {
                                    catNodes.Add(tCatNode);
                                }
                            }
                            if (!string.IsNullOrEmpty(item.Type))
                            {
                                CatType tCatType = new CatType(item.Type, item.Category);
                                //!catTypeNodes.Contains(tCatType)
                                if (!catTypeNodes.Exists(x => x.Name == item.Type && x.ParentCat == item.Category))
                                {
                                    catTypeNodes.Add(tCatType);
                                }
                            }
                            if (!string.IsNullOrEmpty(item.Type2))
                            {
                                CatType2 tCatType2 = new CatType2(item.Type2, item.Category, item.Type);
                                //!catType2Nodes.Contains(tCatType2)
                                if (!catType2Nodes.Exists(x => x.Name == item.Type2 && x.ParentType == item.Type && x.ParentCat == item.Category))
                                {
                                    catType2Nodes.Add(tCatType2);
                                }
                            }
                        }

                        catNodes = catNodes.OrderBy(r => r.Name).ToList();
                        catTypeNodes = catTypeNodes.OrderBy(r => r.Name).ToList();
                        catType2Nodes = catType2Nodes.OrderBy(r => r.Name).ToList();
                    break;
            }
            
            //MessageBox.Show($"Ant Cat: {catNodes.Count}\nAnt Type: {catTypeNodes.Count}\nAnt Type2: {catType2Nodes.Count}");
        }

       

        private void FillTreeView()
        {
            switch (Lists)
            {
                //COMMANDS
                case enuLists.COMMANDS:
                    break;
                //DINOS
                case enuLists.DINOS:
                    trwNS_Nodes.Nodes.Clear();
                    FillCatNodes();
                    var dinoTopNode = new TreeNode("Dinos");
                    trwNS_Nodes.Nodes.Add(dinoTopNode);

                    foreach (var c in catNodes)
                    {
                        trwNS_Nodes.Nodes[0].Nodes.Add(c.Name, c.Name);
                    }

                    foreach (var ct in catTypeNodes)
                    {
                        foreach (TreeNode tn in trwNS_Nodes.Nodes[0].Nodes)
                        {
                            if (tn.Text == ct.ParentCat)
                            {
                                tn.Nodes.Add($"Type{ct.Name}", ct.Name);
                            }
                        }
                    }

                    foreach (var ct2 in catType2Nodes)
                    {
                        TreeNode[] found = trwNS_Nodes.Nodes.Find($"Type{ct2.ParentType}", true);
                        found[0].Nodes.Add(ct2.Name);
                    }
                    break;
                //ITEMS
                case enuLists.ITEMS:
                    trwNS_Nodes.Nodes.Clear();
                    FillCatNodes();
                    var itemTopNode = new TreeNode("Items");
                    trwNS_Nodes.Nodes.Add(itemTopNode);

                    foreach (var c in catNodes)
                    {
                        trwNS_Nodes.Nodes[0].Nodes.Add(c.Name, c.Name);
                    }

                    foreach (var ct in catTypeNodes)
                    {
                        foreach (TreeNode tn in trwNS_Nodes.Nodes[0].Nodes)
                        {
                            if (tn.Text == ct.ParentCat)
                            {
                                tn.Nodes.Add($"Type{ct.Name}", ct.Name);
                            }
                        }
                    }

                    foreach (var ct2 in catType2Nodes)
                    {
                        TreeNode[] found = trwNS_Nodes.Nodes.Find($"Type{ct2.ParentType}", true);
                        found[0].Nodes.Add(ct2.Name);
                    }
                    break;
            }
            
        }

        private void FillCategoryList()
        {
            foreach (var item in items)
            {
                if (!cat.Contains(item.Category))
                {
                    if (!string.IsNullOrEmpty(item.Category))
                    {
                        cat.Add(item.Category);
                    }
                }
            }
        }

        private void FillTypeList(string CAT)
        {
            type = new List<string>();
            foreach (var item in items)
            {
                if (item.Category == CAT)
                {
                    if (!type.Contains(item.Type))
                    {
                        if (!string.IsNullOrEmpty(item.Type))
                        {
                            type.Add(item.Type);
                        }    
                    }
                }
            }
        }


        private void FillType2List(string TYPE)
        {
            type2 = new List<string>();
            foreach (var item in items)
            {
                if (item.Type == TYPE)
                {
                    if (!type2.Contains(item.Type2))
                    {
                        if (!string.IsNullOrEmpty(item.Type2))
                        {
                            type.Add(item.Type2);
                        }
                    }
                }
            }
        }

        private void Populate(enuLists list)
        {
            lstNS_Results.Items.Clear();
            switch (list)
            {
                case enuLists.COMMANDS:
                    cmds = cmds.OrderBy(x => x.Name).ToList();
                    selCmds = new List<Commands>();
                    foreach (var cmd in cmds)
                    {
                        lstNS_Results.Items.Add(cmd.Name);
                        selCmds.Add(cmd);
                    }
                    break;
                case enuLists.DINOS:
                    dinos = dinos.OrderBy(x => x.Name).ToList();
                    selDinos = new List<Dinos>();
                    foreach (var dino in dinos)
                    {
                        lstNS_Results.Items.Add(dino.Name);
                        selDinos.Add(dino);
                    }
                    break;
                case enuLists.ITEMS:
                    items = items.OrderBy(x => x.Name).ToList();
                    selItems = new List<Items>();
                    foreach (var item in items)
                    {
                        lstNS_Results.Items.Add(item.Name);
                        selItems.Add(item);
                    }
                    break;
            }
        }

        private void Populate(enuLists list, string path = null)
        {
            lstNS_Results.Items.Clear();
            
            switch (list)
            {
                case enuLists.COMMANDS:

                    foreach (var cmd in cmds)
                    {
                        lstNS_Results.Items.Add(cmd.Name);
                    }
                    break;
                case enuLists.DINOS:
                    selDinos = new List<Dinos>();
                    if (!string.IsNullOrEmpty(path))
                    {
                        if (path.Contains("\\"))
                        {
                            string[] aPath = path.Split('\\');
                            switch (aPath.Length)
                            {
                                case 2:
                                    foreach (var dino in dinos)
                                    {
                                        if (dino.Category == aPath[1])
                                        {
                                            if (IsSearching)
                                            {
                                                if (dino.Name.ToLower().Contains(Search))
                                                {
                                                    lstNS_Results.Items.Add(dino.Name);
                                                    selDinos.Add(dino);
                                                }
                                            }
                                            else
                                            {
                                                lstNS_Results.Items.Add(dino.Name);
                                                selDinos.Add(dino);
                                            }
                                        }
                                    }
                                    break;
                                case 3:
                                    foreach (var dino in dinos)
                                    {
                                        if (dino.Category == aPath[1] && dino.Type == aPath[2])
                                        {
                                            if (IsSearching)
                                            {
                                                if (dino.Name.ToLower().Contains(Search))
                                                {
                                                    lstNS_Results.Items.Add(dino.Name);
                                                    selDinos.Add(dino);
                                                }
                                            }
                                            else
                                            {
                                                lstNS_Results.Items.Add(dino.Name);
                                                selDinos.Add(dino);
                                            }
                                        }
                                    }
                                    break;
                                case 4:
                                    foreach (var dino in dinos)
                                    {
                                        if (dino.Category == aPath[1] && dino.Type == aPath[2] && dino.Type2 == aPath[3])
                                        {
                                            if (IsSearching)
                                            {
                                                if (dino.Name.ToLower().Contains(Search))
                                                {
                                                    lstNS_Results.Items.Add(dino.Name);
                                                    selDinos.Add(dino);
                                                }
                                            }
                                            else
                                            {
                                                lstNS_Results.Items.Add(dino.Name);
                                                selDinos.Add(dino);
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            dinos = dinos.OrderBy(x => x.Name).ToList();
                            foreach (var dino in dinos)
                            {
                                if (IsSearching)
                                {
                                    if (dino.Name.ToLower().Contains(Search))
                                    {
                                        lstNS_Results.Items.Add(dino.Name);
                                        selDinos.Add(dino);
                                    }
                                }
                                else
                                {
                                    lstNS_Results.Items.Add(dino.Name);
                                    selDinos.Add(dino);
                                }
                            }
                        }
                    }
                    else
                    {
                        dinos = dinos.OrderBy(x => x.Name).ToList();
                        foreach (var dino in dinos)
                        {
                            if (IsSearching)
                            {
                                if (dino.Name.ToLower().Contains(Search))
                                {
                                    lstNS_Results.Items.Add(dino.Name);
                                    selDinos.Add(dino);
                                }
                            }
                            else
                            {
                                lstNS_Results.Items.Add(dino.Name);
                                selDinos.Add(dino);
                            }
                        }
                    }
                    break;
                case enuLists.ITEMS:
                    selItems = new List<Items>();
                    if (!string.IsNullOrEmpty(path))
                    {
                        if (path.Contains("\\"))
                        {
                            string[] aPath = path.Split('\\');
                            switch (aPath.Length)
                            {
                                case 2:
                                    foreach (var item in items)
                                    {
                                        if (item.Category == aPath[1])
                                        {
                                            if (IsSearching)
                                            {
                                                if (item.Name.ToLower().Contains(Search))
                                                {
                                                    lstNS_Results.Items.Add(item.Name);
                                                    selItems.Add(item);
                                                }
                                            }
                                            else
                                            {
                                                lstNS_Results.Items.Add(item.Name);
                                                selItems.Add(item);
                                            }
                                        }
                                    }
                                    break;
                                case 3:
                                    foreach (var item in items)
                                    {
                                        if (item.Category == aPath[1] && item.Type == aPath[2])
                                        {
                                            if (IsSearching)
                                            {
                                                if (item.Name.ToLower().Contains(Search))
                                                {
                                                    lstNS_Results.Items.Add(item.Name);
                                                    selItems.Add(item);
                                                }
                                            }
                                            else
                                            {
                                                lstNS_Results.Items.Add(item.Name);
                                                selItems.Add(item);
                                            }
                                        }
                                    }
                                    break;
                                case 4:
                                    foreach (var item in items)
                                    {
                                        if (item.Category == aPath[1] && item.Type == aPath[2] && item.Type2 == aPath[3])
                                        {
                                            if (IsSearching)
                                            {
                                                if (item.Name.ToLower().Contains(Search))
                                                {
                                                    lstNS_Results.Items.Add(item.Name);
                                                    selItems.Add(item);
                                                }
                                            }
                                            else
                                            {
                                                lstNS_Results.Items.Add(item.Name);
                                                selItems.Add(item);
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            items = items.OrderBy(x => x.Name).ToList();
                            foreach (var item in items)
                            {
                                if (IsSearching)
                                {
                                    if (item.Name.ToLower().Contains(Search))
                                    {
                                        lstNS_Results.Items.Add(item.Name);
                                        selItems.Add(item);
                                    }
                                }
                                else
                                {
                                    lstNS_Results.Items.Add(item.Name);
                                    selItems.Add(item);
                                }
                            }
                        }
                    }
                    else
                    {
                        items = items.OrderBy(x => x.Name).ToList();
                        foreach (var item in items)
                        {
                            if (IsSearching)
                            {
                                if (item.Name.ToLower().Contains(Search))
                                {
                                    lstNS_Results.Items.Add(item.Name);
                                    selItems.Add(item);
                                }
                            }
                            else
                            {
                                lstNS_Results.Items.Add(item.Name);
                                selItems.Add(item);
                            }
                        }
                    }
                    break;
            }
        }


        private void AddToCopyText(object sender, EventArgs e)
        {
            string entry = AddFrom(Lists);
            if (txtNS_CopyText.Text != "")
            {
                if (entry != "")
                    txtNS_CopyText.Text += $"|{AddFrom(Lists)}";
            }
            else
            {
                if (entry != "")
                    txtNS_CopyText.Text = AddFrom(Lists);
            }
        }

        private bool GetBoolFromInt(int val)
        {
            if (val == 1) return true;
            return false;
        }

        private string AddFrom(enuLists lists)
        {
            
            int idx = lstNS_Results.SelectedIndex;
            string svar = "";
            switch (lists)
            {
                case enuLists.COMMANDS:
                    svar = GetBoolFromInt(cmds[idx].IsCheat) ? $"cheat {cmds[idx].Cmd}" : $"{cmds[idx].Cmd}";
                    break;
                case enuLists.DINOS:
                    if (chkNS_Settings_Dinos_SpecifyLvl.Checked)
                    {
                        //GMSummon "Dodo_Character_BP_C" 100
                        if (chkNS_Settings_Dinos_Tamed.Checked)
                        {
                            if (!string.IsNullOrEmpty(selDinos[idx].Shortpath) && selDinos[idx].Shortpath != "-")
                            {
                                svar = $"cheat GMSummon \"{selDinos[idx].Shortpath}\" {nudNS_Settings_Dinos_Level.Value}";
                            }
                        }
                        else
                        {
                            svar =
                                $"cheat spawndino {selDinos[idx].Longpath} {nudNS_Settings_Dinos_Distance.Value} {nudNS_Settings_Dinos_Y.Value} {nudNS_Settings_Dinos_Z.Value} {nudNS_Settings_Dinos_Level.Value}";
                        }
                        
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(selDinos[idx].Shortpath) && selDinos[idx].Shortpath != "-")
                        {
                            svar = $"cheat summon {selDinos[idx].Shortpath}";
                        }
                    }
                    if (chkNS_Settings_Dinos_ForceTamed.Checked)
                    {
                        if (!string.IsNullOrEmpty(selDinos[idx].Shortpath) && selDinos[idx].Shortpath != "-")
                        {
                            svar = $"cheat summontamed {selDinos[idx].Shortpath}";
                        }
                    }
                    break;
                case enuLists.ITEMS:
                    int amount = (int)nudNS_Settings_Items_amount.Value;
                    int quality = (int)nudNS_Settings_Items_Quality.Value;
                    int blueprint = ReturnIntFromBool(chkNS_Settings_Items_Blueprint.Checked);
                    if (amount == 10000)
                    {
                        amount = int.Parse(selItems[idx].Max);
                    }
                    
                    if (!string.IsNullOrEmpty(selItems[idx].Itemid))
                    {
                        svar = $"cheat giveitemnum {selItems[idx].Itemid} {amount} {quality} {blueprint}";
                    }
                    else
                    {
                        svar = $"cheat giveitem {selItems[idx].Path} {amount} {quality} {blueprint}";
                    }
                    break;
            }
            return svar;
        }


        private int Save()
        {
            return _dbContext.SaveChanges();
        }

        private int Save(bool acceptAllChangesOnSucess)
        {
            return _dbContext.SaveChanges(acceptAllChangesOnSucess);
        }

        private void AddCommandToDb(Commands cmd)
        {
            _dbContext.Commands.Add(cmd);
        }

        private void AddDinoToDb(Dinos dino)
        {
            _dbContext.Dinos.Add(dino);
        }

        private void AddItemToDb(Items item)
        {
            _dbContext.Items.Add(item);
        }

        private void AddFromFile(string file, enuLists list)
        {
            string[] lines = File.ReadAllLines(file);

            if (list == enuLists.ITEMS)
            {
                string cat = "";
                string type = "";
                string type2 = "";
                //string[] content;
                foreach (var line in lines)
                {
                    if (line.Length > 5)
                    {
                        if (!line.StartsWith("//"))
                        {
                            if (line.StartsWith("----"))
                            {
                                type2 = line.Replace("----", "");
                            }
                            else if (line.StartsWith("---"))
                            {
                                type = line.Replace("---", "");
                                type2 = "";
                            }
                            else if (line.StartsWith("--"))
                            {
                                cat = line.Replace("--", "");
                                type = "";
                                type2 = "";
                            }
                            else
                            {
                                if (!line.StartsWith("-Items"))
                                {
                                    string[] content = line.Split(',');
                                    Items conItem = new Items { Name = content[0], Category = cat, Type = type, Type2 = type2, Itemid = content[1], Path = content[2], Max = content[3] };
                                    if (!_dbContext.Items.Contains(conItem))
                                    {
                                        AddItemToDb(conItem);
                                    }
                                }
                            }
                        }
                    }
                }
                int ant = Save(true);
                MessageBox.Show($"Det ble lagt til {ant} items i databasen");
            }
            else if (list == enuLists.DINOS)
            {
                foreach (var line in lines)
                {
                    string[] content = line.Split(',');
                    Dinos conDino = new Dinos
                    {
                        Name = content[0],
                        Shortpath = content[1],
                        Longpath = content[2]
                    };
                    if (!_dbContext.Dinos.Contains(conDino))
                    {
                        AddDinoToDb(conDino);
                    }
                }
                int ant = Save(true);
                MessageBox.Show($"Det ble lagt til {ant} dinos i databasen");
            }
            else //commands
            {
                
            }

            
            
        }

        private void btnNS_LeggTilItems_Click(object sender, EventArgs e)
        {
            AddFromFile("database/items.txt", enuLists.ITEMS);
        }

        private void trwNS_Nodes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show($"Full path: {trwNS_Nodes.SelectedNode.FullPath}");
            Populate(Lists, trwNS_Nodes.SelectedNode.FullPath);
            SelectedTreeNode = trwNS_Nodes.SelectedNode;
        }

        private void txtNS_Search_TextChanged(object sender, EventArgs e)
        {
            Search = txtNS_Search.Text.ToLower();
            if (!string.IsNullOrEmpty(Search))
            {
                //Do the search
                IsSearching = true;
                Populate(Lists, trwNS_Nodes.SelectedNode.FullPath);
            }
            else
            {
                IsSearching = false;
                Populate(Lists, trwNS_Nodes.SelectedNode.FullPath);
            }
            btnNS_Search_Reset.Enabled = IsSearching;
        }

        private void btnNS_Search_Reset_Click(object sender, EventArgs e)
        {
            txtNS_Search.Text = "";
        }

        private void ListsSelectionChanged(object sender, EventArgs e)
        {
            switch (GetSelectedLists())
            {
                case "Commands":
                    Lists = enuLists.COMMANDS;
                    grpNS_Settings_Items.Visible = false;
                    grpNS_Settings_Dinos.Visible = false;
                    pnlNS_CmdInfo.Visible = true;
                    trwNS_Nodes.Enabled = false;
                    break;
                case "Dinos":
                    Lists = enuLists.DINOS;
                    trwNS_Nodes.Enabled = true;
                    grpNS_Settings_Dinos.Visible = true;
                    grpNS_Settings_Items.Visible = false;
                    pnlNS_CmdInfo.Visible = false;
                    break;
                case "Items":
                    Lists = enuLists.ITEMS;
                    trwNS_Nodes.Enabled = true;
                    grpNS_Settings_Items.Visible = true;
                    grpNS_Settings_Dinos.Visible = false;
                    pnlNS_CmdInfo.Visible = false;
                    break;
            }
            FillCategoryList();
            FillTreeView();
            Populate(Lists);
            SetListsChange();
            trwNS_Nodes.ExpandAll();
        }

        private string GetSelectedLists()
        {
            string svar = "";
            if (rbtnNS_Lists_Commands.Checked)
            {
                svar = "Commands";
            }
            else if (rbtnNS_Lists_Dinos.Checked)
            {
                svar = "Dinos";
            }
            else
            {
                svar = "Items";
            }
            return svar;
        }

        private int ReturnIntFromBool(bool val)
        {
            if (val) return 1;
            return 0;
        }

        private void SettItemsAmount(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            int val = 0;
            switch (name.Replace("btnNS_Settings_Items_Amount_", ""))
            {
                case "1":
                    val = 1;
                    break;
                case "10":
                    val = 10;
                    break;
                case "100":
                    val = 100;
                    break;
                case "MAX":
                    val = 10000;
                    break;
            }
            nudNS_Settings_Items_amount.Value = val;
        }

        private void SettItemsQuality(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            int val = 0;
            switch (name.Replace("btnNS_Settings_Items_Quality_", ""))
            {
                case "PRI":
                    val = 0;
                    break;
                case "ASC":
                    val = 100;
                    break;
            }
            nudNS_Settings_Items_Quality.Value = val;
        }

        private void btnNS_CopyText_Clear_Click(object sender, EventArgs e)
        {
            txtNS_CopyText.Text = "";
        }

        private void btnNS_CopyText_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtNS_CopyText.Text);
            if (chkNS_CopyText_ClearAfterCopy.Checked) txtNS_CopyText.Text = "";
        }

        private void btnAddDinos_Click(object sender, EventArgs e)
        {
            AddFromFile("database/dinos.txt", enuLists.DINOS);
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (lstNS_Results.SelectedIndex != -1)
            {
                switch (Lists)
                {
                    case enuLists.COMMANDS:
                        frmEditCmds frmEditC = new frmEditCmds((int)selCmds[lstNS_Results.SelectedIndex].Dbid);
                        DialogResult resC = frmEditC.ShowDialog();
                        break;
                    case enuLists.DINOS:
                        frmEditDinos frmEditD = new frmEditDinos((int)selDinos[lstNS_Results.SelectedIndex].Dbid);
                        DialogResult resD = frmEditD.ShowDialog();
                        break;
                    case enuLists.ITEMS:
                        frmEditItems frmEditI = new frmEditItems((int)selItems[lstNS_Results.SelectedIndex].Dbid);
                        DialogResult resI = frmEditI.ShowDialog(this);
                        if (resI == DialogResult.OK)
                        {
                            
                        }
                        break;
                }
                _dbContext.ChangeTracker.DetectChanges();
                FreshStart();
            } 
        }

        private void lstNS_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetListsChange();
        }

        private void SetListsChange()
        {
            if (lstNS_Results.SelectedIndex != -1)
            {
                btnNS_EditSelected.Enabled = true;
                if (Lists == enuLists.COMMANDS)
                {
                    lblNS_CmdInfo_Ex.Text = $"Example: {selCmds[lstNS_Results.SelectedIndex].Example}";
                    lblNS_CmdInfo_Desc.Text = $"Description: {selCmds[lstNS_Results.SelectedIndex].Description}";
                }
            }
            else
            {
                lblNS_CmdInfo_Desc.Text = "Description:";
                lblNS_CmdInfo_Ex.Text = "Example:";
            }
        }

        private void btnNS_AddNew_Click(object sender, EventArgs e)
        {
            switch (Lists)
            {
                case enuLists.COMMANDS:
                    frmEditCmds frmEditC = new frmEditCmds();
                    DialogResult resC = frmEditC.ShowDialog();
                    break;
                case enuLists.DINOS:
                    frmEditDinos frmEditD = new frmEditDinos();
                    DialogResult resD = frmEditD.ShowDialog();
                    break;
                case enuLists.ITEMS:
                    frmEditItems frmEditI = new frmEditItems();
                    DialogResult resI = frmEditI.ShowDialog();
                    if (resI == DialogResult.OK)
                    {
                        
                    }
                    break;
            }
            FreshStart();
        }

        private void chkNS_Settings_Dinos_SpecifyLvl_CheckedChanged(object sender, EventArgs e)
        {
            nudNS_Settings_Dinos_Level.Enabled = chkNS_Settings_Dinos_SpecifyLvl.Checked;
            nudNS_Settings_Dinos_Distance.Enabled = chkNS_Settings_Dinos_SpecifyLvl.Checked;
            nudNS_Settings_Dinos_Y.Enabled = chkNS_Settings_Dinos_SpecifyLvl.Checked;
            nudNS_Settings_Dinos_Z.Enabled = chkNS_Settings_Dinos_SpecifyLvl.Checked;
        }

        private void chkNS_Settings_Dinos_ForceTamed_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                if (chkNS_Settings_Dinos_Tamed.Checked)
                    chkNS_Settings_Dinos_Tamed.Checked = false;
            }
            
        }

        private void SetTameBonus()
        {
            lblNS_Settings_Dinos_levelBonus.Text = $"+{(double)nudNS_Settings_Dinos_Level.Value * 0.5} lvl ({(double)nudNS_Settings_Dinos_Level.Value * 1.5})";
        }

        private void chkNS_Settings_Dinos_Tamed_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                if (chkNS_Settings_Dinos_ForceTamed.Checked)
                {
                    chkNS_Settings_Dinos_ForceTamed.Checked = false;
                }
            }
            lblNS_Settings_Dinos_levelBonus.Visible = chkNS_Settings_Dinos_Tamed.Checked;
            SetTameBonus();
        }


        private void nudNS_Settings_Dinos_Level_ValueChanged(object sender, EventArgs e)
        {
            SetTameBonus();
        }
    }
}
