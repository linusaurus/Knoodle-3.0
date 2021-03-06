﻿namespace Weaselware.Knoodle
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmsaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmsaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewDataFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmprojectSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabOptimizer = new System.Windows.Forms.TabControl();
            this.inputTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArchDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fohDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unitCollection1 = new BusinessObjects.UnitCollection();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.unitIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assemblyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assemblyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Find = new System.Windows.Forms.DataGridViewButtonColumn();
            this.wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentCollection1 = new BusinessObjects.ComponentCollection();
            this.outputTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buildTree = new System.Windows.Forms.TreeView();
            this.partPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.partsTab = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cutlistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAssemblyGUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partIdentifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assemblyNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assemblyIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assemblyWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assemblyHieghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assemblyDepthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assemblyAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAssemblyWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAssemblyHieghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAssemblyDepthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAssemblyAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputCollection1 = new BusinessObjects.OutputCollection();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.theExitGreedyNextFit = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.theToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.theTextBoxStatus = new System.Windows.Forms.ToolStripLabel();
            this.btnSolve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStockLength = new System.Windows.Forms.TextBox();
            this.lbSumofParts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOptimizerFilter = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.dgOptimizerItems = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.PartsStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDataPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabOptimizer.SuspendLayout();
            this.inputTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.outputTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.partsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOptimizerItems)).BeginInit();
            this.PartsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(132, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Build";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmsaveFile,
            this.tsmsaveAs,
            this.tsmNewDataFile,
            this.tsmExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fileToolStripMenuItem_DropDownItemClicked);
            // 
            // tsmsaveFile
            // 
            this.tsmsaveFile.Name = "tsmsaveFile";
            this.tsmsaveFile.Size = new System.Drawing.Size(146, 22);
            this.tsmsaveFile.Text = "Save";
            // 
            // tsmsaveAs
            // 
            this.tsmsaveAs.Name = "tsmsaveAs";
            this.tsmsaveAs.Size = new System.Drawing.Size(146, 22);
            this.tsmsaveAs.Text = "Save-As";
            // 
            // tsmNewDataFile
            // 
            this.tsmNewDataFile.Name = "tsmNewDataFile";
            this.tsmNewDataFile.Size = new System.Drawing.Size(146, 22);
            this.tsmNewDataFile.Text = "New Data File";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(146, 22);
            this.tsmExit.Text = "Exit";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSourceToolStripMenuItem,
            this.tsmprojectSettings});
            this.dataToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dataToolStripMenuItem.Image")));
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.dataToolStripMenuItem.Text = "Settings";
            this.dataToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dataToolStripMenuItem_DropDownItemClicked);
            // 
            // setSourceToolStripMenuItem
            // 
            this.setSourceToolStripMenuItem.Name = "setSourceToolStripMenuItem";
            this.setSourceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.setSourceToolStripMenuItem.Text = "Set Source";
            // 
            // tsmprojectSettings
            // 
            this.tsmprojectSettings.Name = "tsmprojectSettings";
            this.tsmprojectSettings.Size = new System.Drawing.Size(156, 22);
            this.tsmprojectSettings.Text = "Project Settings";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unitsListToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.optionToolStripMenuItem.Text = "Reports";
            // 
            // unitsListToolStripMenuItem
            // 
            this.unitsListToolStripMenuItem.Name = "unitsListToolStripMenuItem";
            this.unitsListToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.unitsListToolStripMenuItem.Text = "Units List";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mdb";
            this.openFileDialog1.Filter = "\"Knoodle Project Files|*.kpf|All Files|*.*\"";
            // 
            // tabOptimizer
            // 
            this.tabOptimizer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOptimizer.Controls.Add(this.inputTabPage);
            this.tabOptimizer.Controls.Add(this.outputTabPage);
            this.tabOptimizer.Controls.Add(this.partsTab);
            this.tabOptimizer.Controls.Add(this.tabPage1);
            this.tabOptimizer.Location = new System.Drawing.Point(12, 90);
            this.tabOptimizer.Name = "tabOptimizer";
            this.tabOptimizer.SelectedIndex = 0;
            this.tabOptimizer.Size = new System.Drawing.Size(857, 452);
            this.tabOptimizer.TabIndex = 3;
            // 
            // inputTabPage
            // 
            this.inputTabPage.Controls.Add(this.splitContainer1);
            this.inputTabPage.Location = new System.Drawing.Point(4, 22);
            this.inputTabPage.Name = "inputTabPage";
            this.inputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inputTabPage.Size = new System.Drawing.Size(849, 426);
            this.inputTabPage.TabIndex = 0;
            this.inputTabPage.Text = "Input Data";
            this.inputTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(843, 420);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIDDataGridViewTextBoxColumn,
            this.ArchDescription,
            this.unitNameDataGridViewTextBoxColumn,
            this.fowDataGridViewTextBoxColumn,
            this.fohDataGridViewTextBoxColumn,
            this.fodDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.unitCollection1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 243);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // ArchDescription
            // 
            this.ArchDescription.DataPropertyName = "ArchDescription";
            this.ArchDescription.HeaderText = "ArchDescr";
            this.ArchDescription.Name = "ArchDescription";
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            this.unitNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            this.unitNameDataGridViewTextBoxColumn.HeaderText = "UnitName";
            this.unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            // 
            // fowDataGridViewTextBoxColumn
            // 
            this.fowDataGridViewTextBoxColumn.DataPropertyName = "Fow";
            this.fowDataGridViewTextBoxColumn.HeaderText = "Fow";
            this.fowDataGridViewTextBoxColumn.Name = "fowDataGridViewTextBoxColumn";
            this.fowDataGridViewTextBoxColumn.Width = 75;
            // 
            // fohDataGridViewTextBoxColumn
            // 
            this.fohDataGridViewTextBoxColumn.DataPropertyName = "Foh";
            this.fohDataGridViewTextBoxColumn.HeaderText = "Foh";
            this.fohDataGridViewTextBoxColumn.Name = "fohDataGridViewTextBoxColumn";
            this.fohDataGridViewTextBoxColumn.Width = 75;
            // 
            // fodDataGridViewTextBoxColumn
            // 
            this.fodDataGridViewTextBoxColumn.DataPropertyName = "Fod";
            this.fodDataGridViewTextBoxColumn.HeaderText = "Fod";
            this.fodDataGridViewTextBoxColumn.Name = "fodDataGridViewTextBoxColumn";
            this.fodDataGridViewTextBoxColumn.Width = 75;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.makeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.makeDataGridViewTextBoxColumn.Width = 60;
            // 
            // unitCollection1
            // 
            this.unitCollection1.AllowDelete = true;
            this.unitCollection1.AllowEdit = true;
            this.unitCollection1.AllowNew = true;
            this.unitCollection1.EnableHierarchicalBinding = true;
            this.unitCollection1.Filter = "";
            this.unitCollection1.RowStateFilter = System.Data.DataViewRowState.None;
            this.unitCollection1.Sort = "";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIDDataGridViewTextBoxColumn1,
            this.assemblyIDDataGridViewTextBoxColumn,
            this.assemblyNameDataGridViewTextBoxColumn,
            this.makeFileDataGridViewTextBoxColumn,
            this.Find,
            this.wDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.componentCollection1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(843, 173);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // unitIDDataGridViewTextBoxColumn1
            // 
            this.unitIDDataGridViewTextBoxColumn1.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn1.HeaderText = "UnitID";
            this.unitIDDataGridViewTextBoxColumn1.Name = "unitIDDataGridViewTextBoxColumn1";
            this.unitIDDataGridViewTextBoxColumn1.Width = 60;
            // 
            // assemblyIDDataGridViewTextBoxColumn
            // 
            this.assemblyIDDataGridViewTextBoxColumn.DataPropertyName = "AssemblyID";
            this.assemblyIDDataGridViewTextBoxColumn.HeaderText = "AssemblyID";
            this.assemblyIDDataGridViewTextBoxColumn.Name = "assemblyIDDataGridViewTextBoxColumn";
            this.assemblyIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // assemblyNameDataGridViewTextBoxColumn
            // 
            this.assemblyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assemblyNameDataGridViewTextBoxColumn.DataPropertyName = "AssemblyName";
            this.assemblyNameDataGridViewTextBoxColumn.HeaderText = "AssemblyName";
            this.assemblyNameDataGridViewTextBoxColumn.Name = "assemblyNameDataGridViewTextBoxColumn";
            // 
            // makeFileDataGridViewTextBoxColumn
            // 
            this.makeFileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makeFileDataGridViewTextBoxColumn.DataPropertyName = "MakeFile";
            this.makeFileDataGridViewTextBoxColumn.HeaderText = "MakeFile";
            this.makeFileDataGridViewTextBoxColumn.Name = "makeFileDataGridViewTextBoxColumn";
            // 
            // Find
            // 
            this.Find.HeaderText = "...";
            this.Find.Name = "Find";
            this.Find.Width = 25;
            // 
            // wDataGridViewTextBoxColumn
            // 
            this.wDataGridViewTextBoxColumn.DataPropertyName = "W";
            this.wDataGridViewTextBoxColumn.HeaderText = "W";
            this.wDataGridViewTextBoxColumn.Name = "wDataGridViewTextBoxColumn";
            this.wDataGridViewTextBoxColumn.Width = 70;
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn.HeaderText = "H";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            this.hDataGridViewTextBoxColumn.Width = 70;
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "D";
            this.dDataGridViewTextBoxColumn.HeaderText = "D";
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.Width = 70;
            // 
            // componentCollection1
            // 
            this.componentCollection1.AllowDelete = true;
            this.componentCollection1.AllowEdit = true;
            this.componentCollection1.AllowNew = true;
            this.componentCollection1.EnableHierarchicalBinding = true;
            this.componentCollection1.Filter = "";
            this.componentCollection1.RowStateFilter = System.Data.DataViewRowState.None;
            this.componentCollection1.Sort = "";
            // 
            // outputTabPage
            // 
            this.outputTabPage.Controls.Add(this.splitContainer2);
            this.outputTabPage.Location = new System.Drawing.Point(4, 22);
            this.outputTabPage.Name = "outputTabPage";
            this.outputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.outputTabPage.Size = new System.Drawing.Size(849, 426);
            this.outputTabPage.TabIndex = 1;
            this.outputTabPage.Text = "Inspector";
            this.outputTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.buildTree);
            this.splitContainer2.Panel1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.partPropertyGrid);
            this.splitContainer2.Size = new System.Drawing.Size(843, 420);
            this.splitContainer2.SplitterDistance = 228;
            this.splitContainer2.TabIndex = 0;
            // 
            // buildTree
            // 
            this.buildTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildTree.Location = new System.Drawing.Point(0, 0);
            this.buildTree.Name = "buildTree";
            this.buildTree.Size = new System.Drawing.Size(228, 420);
            this.buildTree.TabIndex = 0;
            this.buildTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.buildTree_AfterSelect);
            this.buildTree.DoubleClick += new System.EventHandler(this.buildTree_DoubleClick);
            // 
            // partPropertyGrid
            // 
            this.partPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.partPropertyGrid.Name = "partPropertyGrid";
            this.partPropertyGrid.Size = new System.Drawing.Size(611, 420);
            this.partPropertyGrid.TabIndex = 0;
            this.partPropertyGrid.Click += new System.EventHandler(this.partPropertyGrid_Click);
            // 
            // partsTab
            // 
            this.partsTab.Controls.Add(this.dataGridView3);
            this.partsTab.Location = new System.Drawing.Point(4, 22);
            this.partsTab.Name = "partsTab";
            this.partsTab.Padding = new System.Windows.Forms.Padding(3);
            this.partsTab.Size = new System.Drawing.Size(849, 426);
            this.partsTab.TabIndex = 2;
            this.partsTab.Text = "Output";
            this.partsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cutlistIDDataGridViewTextBoxColumn,
            this.partIDDataGridViewTextBoxColumn,
            this.subAssemblyGUIDDataGridViewTextBoxColumn,
            this.functionalNameDataGridViewTextBoxColumn,
            this.sourceNameDataGridViewTextBoxColumn,
            this.sourceDescriptionDataGridViewTextBoxColumn,
            this.qntyDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.thickDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.partClassDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.partIdentifierDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.partLabelDataGridViewTextBoxColumn,
            this.wasteDataGridViewTextBoxColumn,
            this.markupDataGridViewTextBoxColumn,
            this.partTypeDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.laborAmountDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.assemblyNameDataGridViewTextBoxColumn1,
            this.assemblyIDDataGridViewTextBoxColumn1,
            this.taxDataGridViewTextBoxColumn,
            this.assemblyWidthDataGridViewTextBoxColumn,
            this.assemblyHieghtDataGridViewTextBoxColumn,
            this.assemblyDepthDataGridViewTextBoxColumn,
            this.assemblyAreaDataGridViewTextBoxColumn,
            this.subAssemblyWidthDataGridViewTextBoxColumn,
            this.subAssemblyHieghtDataGridViewTextBoxColumn,
            this.subAssemblyDepthDataGridViewTextBoxColumn,
            this.subAssemblyAreaDataGridViewTextBoxColumn,
            this.uomDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.outputCollection1;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(843, 420);
            this.dataGridView3.TabIndex = 0;
            // 
            // cutlistIDDataGridViewTextBoxColumn
            // 
            this.cutlistIDDataGridViewTextBoxColumn.DataPropertyName = "CutlistID";
            this.cutlistIDDataGridViewTextBoxColumn.HeaderText = "CutlistID";
            this.cutlistIDDataGridViewTextBoxColumn.Name = "cutlistIDDataGridViewTextBoxColumn";
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            // 
            // subAssemblyGUIDDataGridViewTextBoxColumn
            // 
            this.subAssemblyGUIDDataGridViewTextBoxColumn.DataPropertyName = "SubAssemblyGUID";
            this.subAssemblyGUIDDataGridViewTextBoxColumn.HeaderText = "SubAssemblyGUID";
            this.subAssemblyGUIDDataGridViewTextBoxColumn.Name = "subAssemblyGUIDDataGridViewTextBoxColumn";
            // 
            // functionalNameDataGridViewTextBoxColumn
            // 
            this.functionalNameDataGridViewTextBoxColumn.DataPropertyName = "FunctionalName";
            this.functionalNameDataGridViewTextBoxColumn.HeaderText = "FunctionalName";
            this.functionalNameDataGridViewTextBoxColumn.Name = "functionalNameDataGridViewTextBoxColumn";
            // 
            // sourceNameDataGridViewTextBoxColumn
            // 
            this.sourceNameDataGridViewTextBoxColumn.DataPropertyName = "SourceName";
            this.sourceNameDataGridViewTextBoxColumn.HeaderText = "SourceName";
            this.sourceNameDataGridViewTextBoxColumn.Name = "sourceNameDataGridViewTextBoxColumn";
            // 
            // sourceDescriptionDataGridViewTextBoxColumn
            // 
            this.sourceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SourceDescription";
            this.sourceDescriptionDataGridViewTextBoxColumn.HeaderText = "SourceDescription";
            this.sourceDescriptionDataGridViewTextBoxColumn.Name = "sourceDescriptionDataGridViewTextBoxColumn";
            // 
            // qntyDataGridViewTextBoxColumn
            // 
            this.qntyDataGridViewTextBoxColumn.DataPropertyName = "Qnty";
            this.qntyDataGridViewTextBoxColumn.HeaderText = "Qnty";
            this.qntyDataGridViewTextBoxColumn.Name = "qntyDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // thickDataGridViewTextBoxColumn
            // 
            this.thickDataGridViewTextBoxColumn.DataPropertyName = "Thick";
            this.thickDataGridViewTextBoxColumn.HeaderText = "Thick";
            this.thickDataGridViewTextBoxColumn.Name = "thickDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // partClassDataGridViewTextBoxColumn
            // 
            this.partClassDataGridViewTextBoxColumn.DataPropertyName = "PartClass";
            this.partClassDataGridViewTextBoxColumn.HeaderText = "PartClass";
            this.partClassDataGridViewTextBoxColumn.Name = "partClassDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // partIdentifierDataGridViewTextBoxColumn
            // 
            this.partIdentifierDataGridViewTextBoxColumn.DataPropertyName = "PartIdentifier";
            this.partIdentifierDataGridViewTextBoxColumn.HeaderText = "PartIdentifier";
            this.partIdentifierDataGridViewTextBoxColumn.Name = "partIdentifierDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // partLabelDataGridViewTextBoxColumn
            // 
            this.partLabelDataGridViewTextBoxColumn.DataPropertyName = "PartLabel";
            this.partLabelDataGridViewTextBoxColumn.HeaderText = "PartLabel";
            this.partLabelDataGridViewTextBoxColumn.Name = "partLabelDataGridViewTextBoxColumn";
            // 
            // wasteDataGridViewTextBoxColumn
            // 
            this.wasteDataGridViewTextBoxColumn.DataPropertyName = "Waste";
            this.wasteDataGridViewTextBoxColumn.HeaderText = "Waste";
            this.wasteDataGridViewTextBoxColumn.Name = "wasteDataGridViewTextBoxColumn";
            // 
            // markupDataGridViewTextBoxColumn
            // 
            this.markupDataGridViewTextBoxColumn.DataPropertyName = "Markup";
            this.markupDataGridViewTextBoxColumn.HeaderText = "Markup";
            this.markupDataGridViewTextBoxColumn.Name = "markupDataGridViewTextBoxColumn";
            // 
            // partTypeDataGridViewTextBoxColumn
            // 
            this.partTypeDataGridViewTextBoxColumn.DataPropertyName = "PartType";
            this.partTypeDataGridViewTextBoxColumn.HeaderText = "PartType";
            this.partTypeDataGridViewTextBoxColumn.Name = "partTypeDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // laborAmountDataGridViewTextBoxColumn
            // 
            this.laborAmountDataGridViewTextBoxColumn.DataPropertyName = "LaborAmount";
            this.laborAmountDataGridViewTextBoxColumn.HeaderText = "LaborAmount";
            this.laborAmountDataGridViewTextBoxColumn.Name = "laborAmountDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // assemblyNameDataGridViewTextBoxColumn1
            // 
            this.assemblyNameDataGridViewTextBoxColumn1.DataPropertyName = "AssemblyName";
            this.assemblyNameDataGridViewTextBoxColumn1.HeaderText = "AssemblyName";
            this.assemblyNameDataGridViewTextBoxColumn1.Name = "assemblyNameDataGridViewTextBoxColumn1";
            // 
            // assemblyIDDataGridViewTextBoxColumn1
            // 
            this.assemblyIDDataGridViewTextBoxColumn1.DataPropertyName = "AssemblyID";
            this.assemblyIDDataGridViewTextBoxColumn1.HeaderText = "AssemblyID";
            this.assemblyIDDataGridViewTextBoxColumn1.Name = "assemblyIDDataGridViewTextBoxColumn1";
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            // 
            // assemblyWidthDataGridViewTextBoxColumn
            // 
            this.assemblyWidthDataGridViewTextBoxColumn.DataPropertyName = "AssemblyWidth";
            this.assemblyWidthDataGridViewTextBoxColumn.HeaderText = "AssemblyWidth";
            this.assemblyWidthDataGridViewTextBoxColumn.Name = "assemblyWidthDataGridViewTextBoxColumn";
            // 
            // assemblyHieghtDataGridViewTextBoxColumn
            // 
            this.assemblyHieghtDataGridViewTextBoxColumn.DataPropertyName = "AssemblyHieght";
            this.assemblyHieghtDataGridViewTextBoxColumn.HeaderText = "AssemblyHieght";
            this.assemblyHieghtDataGridViewTextBoxColumn.Name = "assemblyHieghtDataGridViewTextBoxColumn";
            // 
            // assemblyDepthDataGridViewTextBoxColumn
            // 
            this.assemblyDepthDataGridViewTextBoxColumn.DataPropertyName = "AssemblyDepth";
            this.assemblyDepthDataGridViewTextBoxColumn.HeaderText = "AssemblyDepth";
            this.assemblyDepthDataGridViewTextBoxColumn.Name = "assemblyDepthDataGridViewTextBoxColumn";
            // 
            // assemblyAreaDataGridViewTextBoxColumn
            // 
            this.assemblyAreaDataGridViewTextBoxColumn.DataPropertyName = "AssemblyArea";
            this.assemblyAreaDataGridViewTextBoxColumn.HeaderText = "AssemblyArea";
            this.assemblyAreaDataGridViewTextBoxColumn.Name = "assemblyAreaDataGridViewTextBoxColumn";
            // 
            // subAssemblyWidthDataGridViewTextBoxColumn
            // 
            this.subAssemblyWidthDataGridViewTextBoxColumn.DataPropertyName = "SubAssemblyWidth";
            this.subAssemblyWidthDataGridViewTextBoxColumn.HeaderText = "SubAssemblyWidth";
            this.subAssemblyWidthDataGridViewTextBoxColumn.Name = "subAssemblyWidthDataGridViewTextBoxColumn";
            // 
            // subAssemblyHieghtDataGridViewTextBoxColumn
            // 
            this.subAssemblyHieghtDataGridViewTextBoxColumn.DataPropertyName = "SubAssemblyHieght";
            this.subAssemblyHieghtDataGridViewTextBoxColumn.HeaderText = "SubAssemblyHieght";
            this.subAssemblyHieghtDataGridViewTextBoxColumn.Name = "subAssemblyHieghtDataGridViewTextBoxColumn";
            // 
            // subAssemblyDepthDataGridViewTextBoxColumn
            // 
            this.subAssemblyDepthDataGridViewTextBoxColumn.DataPropertyName = "SubAssemblyDepth";
            this.subAssemblyDepthDataGridViewTextBoxColumn.HeaderText = "SubAssemblyDepth";
            this.subAssemblyDepthDataGridViewTextBoxColumn.Name = "subAssemblyDepthDataGridViewTextBoxColumn";
            // 
            // subAssemblyAreaDataGridViewTextBoxColumn
            // 
            this.subAssemblyAreaDataGridViewTextBoxColumn.DataPropertyName = "SubAssemblyArea";
            this.subAssemblyAreaDataGridViewTextBoxColumn.HeaderText = "SubAssemblyArea";
            this.subAssemblyAreaDataGridViewTextBoxColumn.Name = "subAssemblyAreaDataGridViewTextBoxColumn";
            // 
            // uomDataGridViewTextBoxColumn
            // 
            this.uomDataGridViewTextBoxColumn.DataPropertyName = "Uom";
            this.uomDataGridViewTextBoxColumn.HeaderText = "Uom";
            this.uomDataGridViewTextBoxColumn.Name = "uomDataGridViewTextBoxColumn";
            // 
            // outputCollection1
            // 
            this.outputCollection1.AllowDelete = true;
            this.outputCollection1.AllowEdit = true;
            this.outputCollection1.AllowNew = true;
            this.outputCollection1.EnableHierarchicalBinding = true;
            this.outputCollection1.Filter = "";
            this.outputCollection1.RowStateFilter = System.Data.DataViewRowState.None;
            this.outputCollection1.Sort = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.theExitGreedyNextFit);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.btnSolve);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbStockLength);
            this.tabPage1.Controls.Add(this.lbSumofParts);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbOptimizerFilter);
            this.tabPage1.Controls.Add(this.btn);
            this.tabPage1.Controls.Add(this.dgOptimizerItems);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 426);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Optimizer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // theExitGreedyNextFit
            // 
            this.theExitGreedyNextFit.AutoSize = true;
            this.theExitGreedyNextFit.Location = new System.Drawing.Point(25, 385);
            this.theExitGreedyNextFit.Name = "theExitGreedyNextFit";
            this.theExitGreedyNextFit.Size = new System.Drawing.Size(80, 17);
            this.theExitGreedyNextFit.TabIndex = 9;
            this.theExitGreedyNextFit.Text = "checkBox1";
            this.theExitGreedyNextFit.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theToolStripProgressBar,
            this.theTextBoxStatus});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // theToolStripProgressBar
            // 
            this.theToolStripProgressBar.Name = "theToolStripProgressBar";
            this.theToolStripProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // theTextBoxStatus
            // 
            this.theTextBoxStatus.Name = "theTextBoxStatus";
            this.theTextBoxStatus.Size = new System.Drawing.Size(86, 22);
            this.theTextBoxStatus.Text = "toolStripLabel1";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(25, 189);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(194, 23);
            this.btnSolve.TabIndex = 7;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stock Length (inches)";
            // 
            // tbStockLength
            // 
            this.tbStockLength.Location = new System.Drawing.Point(153, 125);
            this.tbStockLength.Name = "tbStockLength";
            this.tbStockLength.Size = new System.Drawing.Size(73, 20);
            this.tbStockLength.TabIndex = 5;
            // 
            // lbSumofParts
            // 
            this.lbSumofParts.AutoSize = true;
            this.lbSumofParts.Location = new System.Drawing.Point(150, 63);
            this.lbSumofParts.Name = "lbSumofParts";
            this.lbSumofParts.Size = new System.Drawing.Size(46, 13);
            this.lbSumofParts.TabIndex = 4;
            this.lbSumofParts.Text = "Total Ft.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Part ID";
            // 
            // tbOptimizerFilter
            // 
            this.tbOptimizerFilter.Location = new System.Drawing.Point(137, 40);
            this.tbOptimizerFilter.Name = "tbOptimizerFilter";
            this.tbOptimizerFilter.Size = new System.Drawing.Size(89, 20);
            this.tbOptimizerFilter.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(23, 40);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(95, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "Filter Items";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dgOptimizerItems
            // 
            this.dgOptimizerItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOptimizerItems.Location = new System.Drawing.Point(287, 40);
            this.dgOptimizerItems.Name = "dgOptimizerItems";
            this.dgOptimizerItems.Size = new System.Drawing.Size(536, 363);
            this.dgOptimizerItems.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChanges.Image")));
            this.btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanges.Location = new System.Drawing.Point(12, 40);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(114, 31);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // PartsStatus
            // 
            this.PartsStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.PartsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2,
            this.tssDataPath});
            this.PartsStatus.Location = new System.Drawing.Point(0, 557);
            this.PartsStatus.Name = "PartsStatus";
            this.PartsStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.PartsStatus.Size = new System.Drawing.Size(881, 25);
            this.PartsStatus.TabIndex = 5;
            this.PartsStatus.Text = "statusStrip1";
            this.PartsStatus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.PartsStatus_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 20);
            this.toolStripStatusLabel1.Text = "Ready!";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 19);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(65, 20);
            this.toolStripStatusLabel2.Text = "Task Status";
            // 
            // tssDataPath
            // 
            this.tssDataPath.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tssDataPath.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.tssDataPath.Image = ((System.Drawing.Image)(resources.GetObject("tssDataPath.Image")));
            this.tssDataPath.Name = "tssDataPath";
            this.tssDataPath.Size = new System.Drawing.Size(541, 20);
            this.tssDataPath.Spring = true;
            this.tssDataPath.Text = "DataPath";
            // 
            // btnWrite
            // 
            this.btnWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnWrite.Image")));
            this.btnWrite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWrite.Location = new System.Drawing.Point(206, 40);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(91, 31);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "View Parts";
            this.btnWrite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.Location = new System.Drawing.Point(303, 40);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(92, 31);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Write Data";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(754, 47);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(108, 23);
            this.btnInvert.TabIndex = 8;
            this.btnInvert.Text = "Invert Selection";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(673, 48);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 9;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(592, 48);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 10;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 582);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.PartsStatus);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.tabOptimizer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Knoodle 3.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabOptimizer.ResumeLayout(false);
            this.inputTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.outputTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.partsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOptimizerItems)).EndInit();
            this.PartsStatus.ResumeLayout(false);
            this.PartsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSourceToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BusinessObjects.UnitCollection unitCollection1;
        private System.Windows.Forms.TabControl tabOptimizer;
        private System.Windows.Forms.TabPage inputTabPage;
        private System.Windows.Forms.TabPage outputTabPage;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BusinessObjects.ComponentCollection componentCollection1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView buildTree;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.StatusStrip PartsStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage partsTab;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.PropertyGrid partPropertyGrid;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnReport;
        private BusinessObjects.OutputCollection outputCollection1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutlistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAssemblyGUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdentifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partLabelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assemblyNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assemblyIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assemblyWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assemblyHieghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assemblyDepthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assemblyAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAssemblyWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAssemblyHieghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAssemblyDepthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAssemblyAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uomDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assemblyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assemblyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Find;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArchDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fohDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem tsmsaveFile;
        private System.Windows.Forms.ToolStripMenuItem tsmsaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmNewDataFile;
        private System.Windows.Forms.ToolStripStatusLabel tssDataPath;
        private System.Windows.Forms.ToolStripMenuItem tsmprojectSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dgOptimizerItems;
        private System.Windows.Forms.TextBox tbOptimizerFilter;
        private System.Windows.Forms.Label lbSumofParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStockLength;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar theToolStripProgressBar;
        private System.Windows.Forms.CheckBox theExitGreedyNextFit;
        private System.Windows.Forms.ToolStripLabel theTextBoxStatus;
        private System.Windows.Forms.ToolStripMenuItem unitsListToolStripMenuItem;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSelectAll;
    }
}

