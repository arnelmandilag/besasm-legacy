namespace SystemsAnalysis.ModelConstruction.AlternativesToolkit
{
    partial class AlternativeEngineForm
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
            System.IO.Stream configStream = GetType().Assembly.GetManifestResourceStream("SystemsAnalysis.ModelConstruction.AlternativesToolkit.Default_Settings.xml");
            System.IO.Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);
            this.config.WriteXml(this.configPath);	
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
          this.components = new System.ComponentModel.Container();
          Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl2;
          Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
          Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("History", -1);
          Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Date");
          Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("User");
          Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Action", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
          Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
          SystemsAnalysis.Modeling.Alternatives.AlternativeConfiguration altConfigFile;
          Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
          Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
          Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Focus Area");
          Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Alt. 1");
          Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Alt. 2");
          Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
          Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem7 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem8 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
          Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem9 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
          Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
          Infragistics.Win.UltraWinTabControl.UltraTab ultraTab7 = new Infragistics.Win.UltraWinTabControl.UltraTab();
          Infragistics.Win.UltraWinTabControl.UltraTab ultraTab8 = new Infragistics.Win.UltraWinTabControl.UltraTab(true);
          Infragistics.Win.UltraWinTabControl.UltraTab ultraTab9 = new Infragistics.Win.UltraWinTabControl.UltraTab();
          Infragistics.Win.UltraWinTabControl.UltraTab ultraTab10 = new Infragistics.Win.UltraWinTabControl.UltraTab();
          Infragistics.Win.UltraWinTabControl.UltraTab ultraTab11 = new Infragistics.Win.UltraWinTabControl.UltraTab();
          Infragistics.Win.UltraWinTabControl.UltraTab ultraTab12 = new Infragistics.Win.UltraWinTabControl.UltraTab();
          Infragistics.Win.UltraWinTabControl.UltraTab ultraTab1 = new Infragistics.Win.UltraWinTabControl.UltraTab();
          Infragistics.Win.UltraWinTabControl.UltraTab ultraTab2 = new Infragistics.Win.UltraWinTabControl.UltraTab();
          Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel1 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlternativeEngineForm));
          this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
          this.chkFocusAreaTargets = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
          this.chkFocusAreaCatchments = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
          this.chkFocusAreaLinks = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
          this.btnRefreshFocusAreas = new Infragistics.Win.Misc.UltraButton();
          this.txtFocusAreas = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
          this.altEngineConfiguration = new SystemsAnalysis.ModelConstruction.AlternativesToolkit.AltEngineConfiguration();
          this.lblFocusAreas = new Infragistics.Win.Misc.UltraLabel();
          this.btnBrowseFocusAreas = new Infragistics.Win.Misc.UltraButton();
          this.grpAlternativeManagement = new Infragistics.Win.Misc.UltraGroupBox();
          this.btnNewAlternative = new Infragistics.Win.Misc.UltraButton();
          this.btnEditAlternative = new Infragistics.Win.Misc.UltraButton();
          this.btnDeleteAlternative = new Infragistics.Win.Misc.UltraButton();
          this.btnCopyAlternative = new Infragistics.Win.Misc.UltraButton();
          this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
          this.grdAlternativeHistory = new Infragistics.Win.UltraWinGrid.UltraGrid();
          this.altConfigFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.lblDefaultNodeName = new Infragistics.Win.Misc.UltraLabel();
          this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
          this.txtDefaultNodeName = new System.Windows.Forms.TextBox();
          this.btnCancel = new Infragistics.Win.Misc.UltraButton();
          this.cmbAlternativeList = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
          this.lblAlternativeName = new Infragistics.Win.Misc.UltraLabel();
          this.lblBaseModel = new Infragistics.Win.Misc.UltraLabel();
          this.cmbBaseModel = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
          this.btnBrowseBaseModel = new Infragistics.Win.Misc.UltraButton();
          this.ultraTabPageControl1 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
          this.engineOutput = new SystemsAnalysis.Utils.StatusTextBox.StatusTextBox();
          this.panel2 = new System.Windows.Forms.Panel();
          this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
          this.ultraTabPageControl3 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
          this.cmbOutputModel = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
          this.btnBrowseOutput = new Infragistics.Win.Misc.UltraButton();
          this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
          this.btnApplyAlternative = new Infragistics.Win.Misc.UltraButton();
          this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
          this.ultraTabPageControl4 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
          this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
          this.ultraTabPageControl5 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
          this.btnLoadDebugSettings = new Infragistics.Win.Misc.UltraButton();
          this.lblCurrentConfigFile = new Infragistics.Win.Misc.UltraLabel();
          this.btnRestoreDefault = new Infragistics.Win.Misc.UltraButton();
          this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
          this.txtDebugMode = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
          this.ultraTabPageControl6 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
          this.btnEditAutoConveyance = new Infragistics.Win.Misc.UltraButton();
          this.btnGenerateConveyance = new Infragistics.Win.Misc.UltraButton();
          this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
          this.autoConveyanceInterface = new SystemsAnalysis.ModelConstruction.AlternativesToolkit.AutoConveyanceInterface();
          this.ultraTabPageControl7 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
          this.chkRemoveRIK = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
          this.btnAggregate = new Infragistics.Win.Misc.UltraButton();
          this.grdFocusAreaChooser = new Infragistics.Win.UltraWinGrid.UltraGrid();
          this.btnReadFocusAreas = new Infragistics.Win.Misc.UltraButton();
          this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
          this.ultraTabPageControl8 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
          this.ultraLabel14 = new Infragistics.Win.Misc.UltraLabel();
          this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
          this.ultraTextEditor3 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
          this.btnMoveAlternative = new Infragistics.Win.Misc.UltraButton();
          this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
          this.txtNewAltName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
          this.txtNewModel = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
          this.btnBrowseNewModel = new Infragistics.Win.Misc.UltraButton();
          this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
          this.programSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.altEngineConfiguration1 = new SystemsAnalysis.ModelConstruction.AlternativesToolkit.AltEngineConfiguration();
          this.alternativeExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
          this.tabControl = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
          this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
          this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
          this.statusBar = new Infragistics.Win.UltraWinStatusBar.UltraStatusBar();
          this.menuStrip1 = new System.Windows.Forms.MenuStrip();
          this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
          this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
          this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
          this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
          this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
          this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
          this.ultraGridBagLayoutManager1 = new Infragistics.Win.Misc.UltraGridBagLayoutManager(this.components);
          ultraTabPageControl2 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
          altConfigFile = new SystemsAnalysis.Modeling.Alternatives.AlternativeConfiguration();
          ultraTabPageControl2.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
          this.ultraGroupBox1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.chkFocusAreaTargets)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.chkFocusAreaCatchments)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.chkFocusAreaLinks)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.txtFocusAreas)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.altEngineConfiguration)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.grpAlternativeManagement)).BeginInit();
          this.grpAlternativeManagement.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.grdAlternativeHistory)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.altConfigFileBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(altConfigFile)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.cmbAlternativeList)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.cmbBaseModel)).BeginInit();
          this.ultraTabPageControl1.SuspendLayout();
          this.panel2.SuspendLayout();
          this.ultraTabPageControl3.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.cmbOutputModel)).BeginInit();
          this.ultraTabPageControl4.SuspendLayout();
          this.ultraTabPageControl5.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.txtDebugMode)).BeginInit();
          this.ultraTabPageControl6.SuspendLayout();
          this.ultraTabPageControl7.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.chkRemoveRIK)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.grdFocusAreaChooser)).BeginInit();
          this.ultraTabPageControl8.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor3)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.txtNewAltName)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.txtNewModel)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.programSettingsBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.altEngineConfiguration1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.alternativeExplorerBar)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
          this.tabControl.SuspendLayout();
          this.ultraTabSharedControlsPage1.SuspendLayout();
          this.menuStrip1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.ultraGridBagLayoutManager1)).BeginInit();
          this.SuspendLayout();
          // 
          // ultraTabPageControl2
          // 
          ultraTabPageControl2.Controls.Add(this.ultraGroupBox1);
          ultraTabPageControl2.Controls.Add(this.txtFocusAreas);
          ultraTabPageControl2.Controls.Add(this.lblFocusAreas);
          ultraTabPageControl2.Controls.Add(this.btnBrowseFocusAreas);
          ultraTabPageControl2.Controls.Add(this.grpAlternativeManagement);
          ultraTabPageControl2.Controls.Add(this.ultraLabel13);
          ultraTabPageControl2.Controls.Add(this.grdAlternativeHistory);
          ultraTabPageControl2.Controls.Add(this.lblDefaultNodeName);
          ultraTabPageControl2.Controls.Add(this.ultraLabel3);
          ultraTabPageControl2.Controls.Add(this.txtDefaultNodeName);
          ultraTabPageControl2.Location = new System.Drawing.Point(-10000, -10000);
          ultraTabPageControl2.Name = "ultraTabPageControl2";
          ultraTabPageControl2.Size = new System.Drawing.Size(923, 615);
          // 
          // ultraGroupBox1
          // 
          this.ultraGroupBox1.Controls.Add(this.chkFocusAreaTargets);
          this.ultraGroupBox1.Controls.Add(this.chkFocusAreaCatchments);
          this.ultraGroupBox1.Controls.Add(this.chkFocusAreaLinks);
          this.ultraGroupBox1.Controls.Add(this.btnRefreshFocusAreas);
          this.ultraGroupBox1.Location = new System.Drawing.Point(502, 125);
          this.ultraGroupBox1.Name = "ultraGroupBox1";
          this.ultraGroupBox1.Size = new System.Drawing.Size(331, 66);
          this.ultraGroupBox1.TabIndex = 48;
          this.ultraGroupBox1.Text = "Focus Area Management";
          // 
          // chkFocusAreaTargets
          // 
          this.chkFocusAreaTargets.Location = new System.Drawing.Point(213, 40);
          this.chkFocusAreaTargets.Name = "chkFocusAreaTargets";
          this.chkFocusAreaTargets.Size = new System.Drawing.Size(90, 20);
          this.chkFocusAreaTargets.TabIndex = 3;
          this.chkFocusAreaTargets.Text = "IC Targets";
          // 
          // chkFocusAreaCatchments
          // 
          this.chkFocusAreaCatchments.Location = new System.Drawing.Point(117, 40);
          this.chkFocusAreaCatchments.Name = "chkFocusAreaCatchments";
          this.chkFocusAreaCatchments.Size = new System.Drawing.Size(90, 20);
          this.chkFocusAreaCatchments.TabIndex = 2;
          this.chkFocusAreaCatchments.Text = "Catchments";
          // 
          // chkFocusAreaLinks
          // 
          this.chkFocusAreaLinks.Location = new System.Drawing.Point(7, 40);
          this.chkFocusAreaLinks.Name = "chkFocusAreaLinks";
          this.chkFocusAreaLinks.Size = new System.Drawing.Size(104, 20);
          this.chkFocusAreaLinks.TabIndex = 1;
          this.chkFocusAreaLinks.Text = "Links & Nodes";
          // 
          // btnRefreshFocusAreas
          // 
          this.btnRefreshFocusAreas.Location = new System.Drawing.Point(7, 16);
          this.btnRefreshFocusAreas.Name = "btnRefreshFocusAreas";
          this.btnRefreshFocusAreas.Size = new System.Drawing.Size(141, 23);
          this.btnRefreshFocusAreas.TabIndex = 0;
          this.btnRefreshFocusAreas.Text = "Refresh Focus Areas";
          this.btnRefreshFocusAreas.Click += new System.EventHandler(this.btnRefreshFocusAreas_Click);
          // 
          // txtFocusAreas
          // 
          this.txtFocusAreas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.altEngineConfiguration, "ProgramSettings.FocusAreasTable", true));
          this.txtFocusAreas.Location = new System.Drawing.Point(20, 141);
          this.txtFocusAreas.Name = "txtFocusAreas";
          this.txtFocusAreas.Size = new System.Drawing.Size(406, 21);
          this.txtFocusAreas.TabIndex = 47;
          // 
          // altEngineConfiguration
          // 
          this.altEngineConfiguration.DataSetName = "AltEngineConfiguration";
          this.altEngineConfiguration.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // lblFocusAreas
          // 
          appearance20.TextVAlignAsString = "Bottom";
          this.lblFocusAreas.Appearance = appearance20;
          this.lblFocusAreas.Location = new System.Drawing.Point(20, 123);
          this.lblFocusAreas.Name = "lblFocusAreas";
          this.lblFocusAreas.Size = new System.Drawing.Size(73, 17);
          this.lblFocusAreas.TabIndex = 46;
          this.lblFocusAreas.Text = "Focus Areas:";
          // 
          // btnBrowseFocusAreas
          // 
          this.btnBrowseFocusAreas.Location = new System.Drawing.Point(432, 141);
          this.btnBrowseFocusAreas.Name = "btnBrowseFocusAreas";
          this.btnBrowseFocusAreas.Size = new System.Drawing.Size(64, 23);
          this.btnBrowseFocusAreas.TabIndex = 45;
          this.btnBrowseFocusAreas.Text = "Browse...";
          this.btnBrowseFocusAreas.Click += new System.EventHandler(this.btnBrowseFocusAreas_Click);
          // 
          // grpAlternativeManagement
          // 
          this.grpAlternativeManagement.Controls.Add(this.btnNewAlternative);
          this.grpAlternativeManagement.Controls.Add(this.btnEditAlternative);
          this.grpAlternativeManagement.Controls.Add(this.btnDeleteAlternative);
          this.grpAlternativeManagement.Controls.Add(this.btnCopyAlternative);
          this.grpAlternativeManagement.Location = new System.Drawing.Point(345, 77);
          this.grpAlternativeManagement.Name = "grpAlternativeManagement";
          this.grpAlternativeManagement.Size = new System.Drawing.Size(374, 49);
          this.grpAlternativeManagement.TabIndex = 44;
          this.grpAlternativeManagement.Text = "Configure Alternative";
          // 
          // btnNewAlternative
          // 
          this.btnNewAlternative.Location = new System.Drawing.Point(6, 17);
          this.btnNewAlternative.Name = "btnNewAlternative";
          this.btnNewAlternative.Size = new System.Drawing.Size(103, 25);
          this.btnNewAlternative.TabIndex = 1;
          this.btnNewAlternative.Text = "New Alternative";
          this.btnNewAlternative.Click += new System.EventHandler(this.btnNewAlternative_Click);
          // 
          // btnEditAlternative
          // 
          this.btnEditAlternative.Location = new System.Drawing.Point(115, 17);
          this.btnEditAlternative.Name = "btnEditAlternative";
          this.btnEditAlternative.Size = new System.Drawing.Size(88, 25);
          this.btnEditAlternative.TabIndex = 2;
          this.btnEditAlternative.Text = "Edit";
          this.btnEditAlternative.Click += new System.EventHandler(this.btnEditAlternative_Click);
          // 
          // btnDeleteAlternative
          // 
          this.btnDeleteAlternative.Location = new System.Drawing.Point(290, 18);
          this.btnDeleteAlternative.Name = "btnDeleteAlternative";
          this.btnDeleteAlternative.Size = new System.Drawing.Size(75, 25);
          this.btnDeleteAlternative.TabIndex = 4;
          this.btnDeleteAlternative.Text = "Delete";
          this.btnDeleteAlternative.Click += new System.EventHandler(this.btnDeleteAlternative_Click);
          // 
          // btnCopyAlternative
          // 
          this.btnCopyAlternative.Location = new System.Drawing.Point(209, 17);
          this.btnCopyAlternative.Name = "btnCopyAlternative";
          this.btnCopyAlternative.Size = new System.Drawing.Size(75, 25);
          this.btnCopyAlternative.TabIndex = 3;
          this.btnCopyAlternative.Text = "Copy";
          this.btnCopyAlternative.Click += new System.EventHandler(this.btnCopyAlternative_Click);
          // 
          // ultraLabel13
          // 
          appearance21.TextVAlignAsString = "Bottom";
          this.ultraLabel13.Appearance = appearance21;
          this.ultraLabel13.Location = new System.Drawing.Point(20, 173);
          this.ultraLabel13.Name = "ultraLabel13";
          this.ultraLabel13.Size = new System.Drawing.Size(159, 18);
          this.ultraLabel13.TabIndex = 43;
          this.ultraLabel13.Text = "History:";
          // 
          // grdAlternativeHistory
          // 
          this.grdAlternativeHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.grdAlternativeHistory.DataMember = "History";
          this.grdAlternativeHistory.DataSource = this.altConfigFileBindingSource;
          appearance22.BackColor = System.Drawing.SystemColors.Window;
          appearance22.BorderColor = System.Drawing.SystemColors.InactiveCaption;
          this.grdAlternativeHistory.DisplayLayout.Appearance = appearance22;
          this.grdAlternativeHistory.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
          ultraGridColumn1.Header.VisiblePosition = 0;
          ultraGridColumn1.Width = 152;
          ultraGridColumn2.Header.VisiblePosition = 1;
          ultraGridColumn3.Header.VisiblePosition = 2;
          ultraGridColumn3.Width = 345;
          ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
          this.grdAlternativeHistory.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
          this.grdAlternativeHistory.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
          this.grdAlternativeHistory.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
          appearance23.BackColor = System.Drawing.SystemColors.ActiveBorder;
          appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark;
          appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
          appearance23.BorderColor = System.Drawing.SystemColors.Window;
          this.grdAlternativeHistory.DisplayLayout.GroupByBox.Appearance = appearance23;
          appearance24.ForeColor = System.Drawing.SystemColors.GrayText;
          this.grdAlternativeHistory.DisplayLayout.GroupByBox.BandLabelAppearance = appearance24;
          this.grdAlternativeHistory.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
          appearance25.BackColor = System.Drawing.SystemColors.ControlLightLight;
          appearance25.BackColor2 = System.Drawing.SystemColors.Control;
          appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
          appearance25.ForeColor = System.Drawing.SystemColors.GrayText;
          this.grdAlternativeHistory.DisplayLayout.GroupByBox.PromptAppearance = appearance25;
          this.grdAlternativeHistory.DisplayLayout.MaxColScrollRegions = 1;
          this.grdAlternativeHistory.DisplayLayout.MaxRowScrollRegions = 1;
          appearance26.BackColor = System.Drawing.SystemColors.Window;
          appearance26.ForeColor = System.Drawing.SystemColors.ControlText;
          this.grdAlternativeHistory.DisplayLayout.Override.ActiveCellAppearance = appearance26;
          appearance27.BackColor = System.Drawing.SystemColors.Highlight;
          appearance27.ForeColor = System.Drawing.SystemColors.HighlightText;
          this.grdAlternativeHistory.DisplayLayout.Override.ActiveRowAppearance = appearance27;
          this.grdAlternativeHistory.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
          this.grdAlternativeHistory.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
          appearance28.BackColor = System.Drawing.SystemColors.Window;
          this.grdAlternativeHistory.DisplayLayout.Override.CardAreaAppearance = appearance28;
          appearance29.BorderColor = System.Drawing.Color.Silver;
          appearance29.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
          this.grdAlternativeHistory.DisplayLayout.Override.CellAppearance = appearance29;
          this.grdAlternativeHistory.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
          this.grdAlternativeHistory.DisplayLayout.Override.CellPadding = 0;
          appearance30.BackColor = System.Drawing.SystemColors.Control;
          appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
          appearance30.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
          appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
          appearance30.BorderColor = System.Drawing.SystemColors.Window;
          this.grdAlternativeHistory.DisplayLayout.Override.GroupByRowAppearance = appearance30;
          appearance31.TextHAlignAsString = "Left";
          this.grdAlternativeHistory.DisplayLayout.Override.HeaderAppearance = appearance31;
          this.grdAlternativeHistory.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
          this.grdAlternativeHistory.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
          appearance32.BackColor = System.Drawing.SystemColors.Window;
          appearance32.BorderColor = System.Drawing.Color.Silver;
          this.grdAlternativeHistory.DisplayLayout.Override.RowAppearance = appearance32;
          this.grdAlternativeHistory.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
          appearance33.BackColor = System.Drawing.SystemColors.ControlLight;
          this.grdAlternativeHistory.DisplayLayout.Override.TemplateAddRowAppearance = appearance33;
          this.grdAlternativeHistory.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
          this.grdAlternativeHistory.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
          this.grdAlternativeHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.grdAlternativeHistory.Location = new System.Drawing.Point(20, 197);
          this.grdAlternativeHistory.Name = "grdAlternativeHistory";
          this.grdAlternativeHistory.Size = new System.Drawing.Size(893, 380);
          this.grdAlternativeHistory.TabIndex = 0;
          this.grdAlternativeHistory.Text = "ultraGrid2";
          // 
          // altConfigFileBindingSource
          // 
          this.altConfigFileBindingSource.DataSource = altConfigFile;
          this.altConfigFileBindingSource.Position = 0;
          // 
          // altConfigFile
          // 
          altConfigFile.DataSetName = "AltConfigFile";
          altConfigFile.DefaultNodeSuffix = "ALT";
          altConfigFile.Locale = new System.Globalization.CultureInfo("");
          altConfigFile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // lblDefaultNodeName
          // 
          appearance34.TextVAlignAsString = "Bottom";
          this.lblDefaultNodeName.Appearance = appearance34;
          this.lblDefaultNodeName.Location = new System.Drawing.Point(229, 78);
          this.lblDefaultNodeName.Name = "lblDefaultNodeName";
          this.lblDefaultNodeName.Size = new System.Drawing.Size(158, 16);
          this.lblDefaultNodeName.TabIndex = 41;
          this.lblDefaultNodeName.Text = "Default Node Name:";
          // 
          // ultraLabel3
          // 
          this.ultraLabel3.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.ultraLabel3.Location = new System.Drawing.Point(5, 10);
          this.ultraLabel3.Name = "ultraLabel3";
          this.ultraLabel3.Size = new System.Drawing.Size(426, 27);
          this.ultraLabel3.TabIndex = 21;
          this.ultraLabel3.Text = "Manage Alternatives";
          // 
          // txtDefaultNodeName
          // 
          this.txtDefaultNodeName.Location = new System.Drawing.Point(229, 97);
          this.txtDefaultNodeName.MaxLength = 3;
          this.txtDefaultNodeName.Name = "txtDefaultNodeName";
          this.txtDefaultNodeName.Size = new System.Drawing.Size(73, 20);
          this.txtDefaultNodeName.TabIndex = 3;
          this.txtDefaultNodeName.Text = "ALT";
          // 
          // btnCancel
          // 
          this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this.btnCancel.Location = new System.Drawing.Point(846, 582);
          this.btnCancel.Name = "btnCancel";
          this.btnCancel.Size = new System.Drawing.Size(66, 25);
          this.btnCancel.TabIndex = 46;
          this.btnCancel.Text = "Close";
          // 
          // cmbAlternativeList
          // 
          this.cmbAlternativeList.DisplayMember = "";
          this.cmbAlternativeList.Location = new System.Drawing.Point(22, 96);
          this.cmbAlternativeList.Name = "cmbAlternativeList";
          this.cmbAlternativeList.Size = new System.Drawing.Size(204, 21);
          this.cmbAlternativeList.TabIndex = 43;
          this.cmbAlternativeList.ValueMember = "";
          this.cmbAlternativeList.SelectionChanged += new System.EventHandler(this.cmbAlternativeList_SelectionChanged);
          // 
          // lblAlternativeName
          // 
          appearance19.TextVAlignAsString = "Bottom";
          this.lblAlternativeName.Appearance = appearance19;
          this.lblAlternativeName.Location = new System.Drawing.Point(22, 77);
          this.lblAlternativeName.Name = "lblAlternativeName";
          this.lblAlternativeName.Size = new System.Drawing.Size(159, 17);
          this.lblAlternativeName.TabIndex = 45;
          this.lblAlternativeName.Text = "Alternative Name:";
          // 
          // lblBaseModel
          // 
          appearance2.TextVAlignAsString = "Bottom";
          this.lblBaseModel.Appearance = appearance2;
          this.lblBaseModel.Location = new System.Drawing.Point(22, 33);
          this.lblBaseModel.Name = "lblBaseModel";
          this.lblBaseModel.Size = new System.Drawing.Size(73, 17);
          this.lblBaseModel.TabIndex = 44;
          this.lblBaseModel.Text = "Base Model:";
          // 
          // cmbBaseModel
          // 
          this.cmbBaseModel.DisplayMember = "BaseModel_text";
          this.cmbBaseModel.Location = new System.Drawing.Point(22, 51);
          this.cmbBaseModel.Name = "cmbBaseModel";
          this.cmbBaseModel.Size = new System.Drawing.Size(504, 21);
          this.cmbBaseModel.TabIndex = 41;
          this.cmbBaseModel.ValueMember = "BaseModel_text";
          this.cmbBaseModel.SelectionChanged += new System.EventHandler(this.cmbBaseModel_SelectedIndexChanged);
          this.cmbBaseModel.ValueChanged += new System.EventHandler(this.cmbBaseModel_ValueChanged);
          // 
          // btnBrowseBaseModel
          // 
          this.btnBrowseBaseModel.Location = new System.Drawing.Point(531, 51);
          this.btnBrowseBaseModel.Name = "btnBrowseBaseModel";
          this.btnBrowseBaseModel.Size = new System.Drawing.Size(64, 21);
          this.btnBrowseBaseModel.TabIndex = 42;
          this.btnBrowseBaseModel.Text = "Browse...";
          this.btnBrowseBaseModel.Click += new System.EventHandler(this.btnBrowseBaseModel_Click);
          // 
          // ultraTabPageControl1
          // 
          this.ultraTabPageControl1.Controls.Add(this.engineOutput);
          this.ultraTabPageControl1.Controls.Add(this.panel2);
          this.ultraTabPageControl1.Location = new System.Drawing.Point(-10000, -10000);
          this.ultraTabPageControl1.Name = "ultraTabPageControl1";
          this.ultraTabPageControl1.Size = new System.Drawing.Size(923, 615);
          // 
          // engineOutput
          // 
          this.engineOutput.BackColor = System.Drawing.Color.White;
          this.engineOutput.Dock = System.Windows.Forms.DockStyle.Fill;
          this.engineOutput.Location = new System.Drawing.Point(0, 44);
          this.engineOutput.Name = "engineOutput";
          this.engineOutput.ReadOnly = true;
          this.engineOutput.Size = new System.Drawing.Size(923, 571);
          this.engineOutput.TabIndex = 0;
          this.engineOutput.Text = "";
          this.engineOutput.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.engineOutput_LinkClicked);
          this.engineOutput.TextChanged += new System.EventHandler(this.engineOutput_TextChanged);
          // 
          // panel2
          // 
          this.panel2.Controls.Add(this.ultraLabel7);
          this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
          this.panel2.Location = new System.Drawing.Point(0, 0);
          this.panel2.Name = "panel2";
          this.panel2.Size = new System.Drawing.Size(923, 44);
          this.panel2.TabIndex = 2;
          // 
          // ultraLabel7
          // 
          this.ultraLabel7.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.ultraLabel7.Location = new System.Drawing.Point(2, 10);
          this.ultraLabel7.Name = "ultraLabel7";
          this.ultraLabel7.Size = new System.Drawing.Size(426, 27);
          this.ultraLabel7.TabIndex = 22;
          this.ultraLabel7.Text = "Status Log";
          // 
          // ultraTabPageControl3
          // 
          this.ultraTabPageControl3.Controls.Add(this.cmbOutputModel);
          this.ultraTabPageControl3.Controls.Add(this.btnBrowseOutput);
          this.ultraTabPageControl3.Controls.Add(this.ultraLabel8);
          this.ultraTabPageControl3.Controls.Add(this.btnApplyAlternative);
          this.ultraTabPageControl3.Controls.Add(this.ultraLabel4);
          this.ultraTabPageControl3.Location = new System.Drawing.Point(-10000, -10000);
          this.ultraTabPageControl3.Name = "ultraTabPageControl3";
          this.ultraTabPageControl3.Size = new System.Drawing.Size(923, 615);
          // 
          // cmbOutputModel
          // 
          this.cmbOutputModel.DisplayMember = "OutputModel_text";
          this.cmbOutputModel.Location = new System.Drawing.Point(22, 144);
          this.cmbOutputModel.Name = "cmbOutputModel";
          this.cmbOutputModel.Size = new System.Drawing.Size(503, 21);
          this.cmbOutputModel.TabIndex = 0;
          this.cmbOutputModel.ValueMember = "OutputModel_text";
          // 
          // btnBrowseOutput
          // 
          this.btnBrowseOutput.Location = new System.Drawing.Point(530, 144);
          this.btnBrowseOutput.Name = "btnBrowseOutput";
          this.btnBrowseOutput.Size = new System.Drawing.Size(64, 21);
          this.btnBrowseOutput.TabIndex = 1;
          this.btnBrowseOutput.Text = "Browse...";
          this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
          // 
          // ultraLabel8
          // 
          appearance3.TextVAlignAsString = "Bottom";
          this.ultraLabel8.Appearance = appearance3;
          this.ultraLabel8.Location = new System.Drawing.Point(22, 123);
          this.ultraLabel8.Name = "ultraLabel8";
          this.ultraLabel8.Size = new System.Drawing.Size(96, 16);
          this.ultraLabel8.TabIndex = 29;
          this.ultraLabel8.Text = "Output Directory:";
          // 
          // btnApplyAlternative
          // 
          this.btnApplyAlternative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.btnApplyAlternative.Location = new System.Drawing.Point(745, 582);
          this.btnApplyAlternative.Name = "btnApplyAlternative";
          this.btnApplyAlternative.Size = new System.Drawing.Size(99, 24);
          this.btnApplyAlternative.TabIndex = 5;
          this.btnApplyAlternative.Text = "Apply Alternative";
          this.btnApplyAlternative.Click += new System.EventHandler(this.btnApplyAlternative_Click);
          // 
          // ultraLabel4
          // 
          this.ultraLabel4.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.ultraLabel4.Location = new System.Drawing.Point(2, 10);
          this.ultraLabel4.Name = "ultraLabel4";
          this.ultraLabel4.Size = new System.Drawing.Size(421, 27);
          this.ultraLabel4.TabIndex = 22;
          this.ultraLabel4.Text = "Apply Alternative to Model";
          // 
          // ultraTabPageControl4
          // 
          this.ultraTabPageControl4.Controls.Add(this.ultraLabel5);
          this.ultraTabPageControl4.Location = new System.Drawing.Point(-10000, -10000);
          this.ultraTabPageControl4.Name = "ultraTabPageControl4";
          this.ultraTabPageControl4.Size = new System.Drawing.Size(923, 615);
          // 
          // ultraLabel5
          // 
          this.ultraLabel5.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.ultraLabel5.Location = new System.Drawing.Point(5, 10);
          this.ultraLabel5.Name = "ultraLabel5";
          this.ultraLabel5.Size = new System.Drawing.Size(421, 27);
          this.ultraLabel5.TabIndex = 23;
          this.ultraLabel5.Text = "QC Alternative";
          // 
          // ultraTabPageControl5
          // 
          this.ultraTabPageControl5.Controls.Add(this.btnLoadDebugSettings);
          this.ultraTabPageControl5.Controls.Add(this.lblCurrentConfigFile);
          this.ultraTabPageControl5.Controls.Add(this.btnRestoreDefault);
          this.ultraTabPageControl5.Controls.Add(this.ultraLabel6);
          this.ultraTabPageControl5.Controls.Add(this.txtDebugMode);
          this.ultraTabPageControl5.Location = new System.Drawing.Point(-10000, -10000);
          this.ultraTabPageControl5.Name = "ultraTabPageControl5";
          this.ultraTabPageControl5.Size = new System.Drawing.Size(923, 615);
          // 
          // btnLoadDebugSettings
          // 
          this.btnLoadDebugSettings.Location = new System.Drawing.Point(156, 68);
          this.btnLoadDebugSettings.Name = "btnLoadDebugSettings";
          this.btnLoadDebugSettings.Size = new System.Drawing.Size(138, 20);
          this.btnLoadDebugSettings.TabIndex = 2;
          this.btnLoadDebugSettings.Text = "Load Debug Settings";
          this.btnLoadDebugSettings.Click += new System.EventHandler(this.btnLoadDebugSettings_Click);
          // 
          // lblCurrentConfigFile
          // 
          this.lblCurrentConfigFile.Location = new System.Drawing.Point(12, 94);
          this.lblCurrentConfigFile.Name = "lblCurrentConfigFile";
          this.lblCurrentConfigFile.Size = new System.Drawing.Size(611, 65);
          this.lblCurrentConfigFile.TabIndex = 27;
          this.lblCurrentConfigFile.Text = "Current Settings File:";
          // 
          // btnRestoreDefault
          // 
          this.btnRestoreDefault.Location = new System.Drawing.Point(12, 68);
          this.btnRestoreDefault.Name = "btnRestoreDefault";
          this.btnRestoreDefault.Size = new System.Drawing.Size(139, 20);
          this.btnRestoreDefault.TabIndex = 1;
          this.btnRestoreDefault.Text = "Restore Default Settings";
          this.btnRestoreDefault.Click += new System.EventHandler(this.btnRestoreDefault_Click);
          // 
          // ultraLabel6
          // 
          this.ultraLabel6.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.ultraLabel6.Location = new System.Drawing.Point(5, 10);
          this.ultraLabel6.Name = "ultraLabel6";
          this.ultraLabel6.Size = new System.Drawing.Size(421, 27);
          this.ultraLabel6.TabIndex = 23;
          this.ultraLabel6.Text = "Alternative Toolkit Settings";
          // 
          // txtDebugMode
          // 
          this.txtDebugMode.Location = new System.Drawing.Point(12, 42);
          this.txtDebugMode.Name = "txtDebugMode";
          this.txtDebugMode.Size = new System.Drawing.Size(239, 21);
          this.txtDebugMode.TabIndex = 0;
          this.txtDebugMode.Text = "Manually Execute MapBasic Code?";
          this.txtDebugMode.CheckedChanged += new System.EventHandler(this.txtDebugMode_CheckedChanged);
          // 
          // ultraTabPageControl6
          // 
          this.ultraTabPageControl6.Controls.Add(this.btnEditAutoConveyance);
          this.ultraTabPageControl6.Controls.Add(this.btnGenerateConveyance);
          this.ultraTabPageControl6.Controls.Add(this.ultraLabel10);
          this.ultraTabPageControl6.Controls.Add(this.autoConveyanceInterface);
          this.ultraTabPageControl6.Controls.Add(this.btnCancel);
          this.ultraTabPageControl6.Controls.Add(this.cmbAlternativeList);
          this.ultraTabPageControl6.Controls.Add(this.lblAlternativeName);
          this.ultraTabPageControl6.Controls.Add(this.lblBaseModel);
          this.ultraTabPageControl6.Controls.Add(this.cmbBaseModel);
          this.ultraTabPageControl6.Controls.Add(this.btnBrowseBaseModel);
          this.ultraTabPageControl6.Location = new System.Drawing.Point(0, 0);
          this.ultraTabPageControl6.Name = "ultraTabPageControl6";
          this.ultraTabPageControl6.Size = new System.Drawing.Size(923, 615);
          // 
          // btnEditAutoConveyance
          // 
          this.btnEditAutoConveyance.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this.btnEditAutoConveyance.Location = new System.Drawing.Point(229, 97);
          this.btnEditAutoConveyance.Name = "btnEditAutoConveyance";
          this.btnEditAutoConveyance.Size = new System.Drawing.Size(190, 22);
          this.btnEditAutoConveyance.TabIndex = 3;
          this.btnEditAutoConveyance.Text = "Prepare Conveyance Alternative";
          this.btnEditAutoConveyance.Click += new System.EventHandler(this.btnEditAutoConveyance_Click);
          // 
          // btnGenerateConveyance
          // 
          this.btnGenerateConveyance.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this.btnGenerateConveyance.Enabled = false;
          this.btnGenerateConveyance.Location = new System.Drawing.Point(424, 97);
          this.btnGenerateConveyance.Name = "btnGenerateConveyance";
          this.btnGenerateConveyance.Size = new System.Drawing.Size(132, 22);
          this.btnGenerateConveyance.TabIndex = 4;
          this.btnGenerateConveyance.Text = "Generate Alternative";
          this.btnGenerateConveyance.Click += new System.EventHandler(this.btnGenerateConveyance_Click);
          // 
          // ultraLabel10
          // 
          this.ultraLabel10.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.ultraLabel10.Location = new System.Drawing.Point(5, 10);
          this.ultraLabel10.Name = "ultraLabel10";
          this.ultraLabel10.Size = new System.Drawing.Size(426, 27);
          this.ultraLabel10.TabIndex = 7;
          this.ultraLabel10.Text = "Auto-Generate Conveyance Alternative";
          // 
          // autoConveyanceInterface
          // 
          this.autoConveyanceInterface.AlternativeName = null;
          this.autoConveyanceInterface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.autoConveyanceInterface.BackColor = System.Drawing.Color.Transparent;
          this.autoConveyanceInterface.BaseModel = "\\";
          this.autoConveyanceInterface.Location = new System.Drawing.Point(17, 123);
          this.autoConveyanceInterface.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.autoConveyanceInterface.Name = "autoConveyanceInterface";
          this.autoConveyanceInterface.Size = new System.Drawing.Size(898, 492);
          this.autoConveyanceInterface.TabIndex = 5;
          this.autoConveyanceInterface.Visible = false;
          // 
          // ultraTabPageControl7
          // 
          this.ultraTabPageControl7.Controls.Add(this.chkRemoveRIK);
          this.ultraTabPageControl7.Controls.Add(this.btnAggregate);
          this.ultraTabPageControl7.Controls.Add(this.grdFocusAreaChooser);
          this.ultraTabPageControl7.Controls.Add(this.btnReadFocusAreas);
          this.ultraTabPageControl7.Controls.Add(this.ultraLabel9);
          this.ultraTabPageControl7.Location = new System.Drawing.Point(-10000, -10000);
          this.ultraTabPageControl7.Name = "ultraTabPageControl7";
          this.ultraTabPageControl7.Size = new System.Drawing.Size(923, 615);
          // 
          // chkRemoveRIK
          // 
          this.chkRemoveRIK.Checked = true;
          this.chkRemoveRIK.CheckState = System.Windows.Forms.CheckState.Checked;
          this.chkRemoveRIK.Location = new System.Drawing.Point(20, 434);
          this.chkRemoveRIK.Name = "chkRemoveRIK";
          this.chkRemoveRIK.Size = new System.Drawing.Size(380, 20);
          this.chkRemoveRIK.TabIndex = 46;
          this.chkRemoveRIK.Text = "Remove RIK Links from Aggregated Alternative?";
          // 
          // btnAggregate
          // 
          this.btnAggregate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.btnAggregate.Location = new System.Drawing.Point(20, 402);
          this.btnAggregate.Name = "btnAggregate";
          this.btnAggregate.Size = new System.Drawing.Size(153, 25);
          this.btnAggregate.TabIndex = 45;
          this.btnAggregate.Text = "Aggregate Selected";
          this.btnAggregate.Click += new System.EventHandler(this.btnAggregate_Click);
          // 
          // grdFocusAreaChooser
          // 
          appearance14.BackColor = System.Drawing.SystemColors.Window;
          appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption;
          this.grdFocusAreaChooser.DisplayLayout.Appearance = appearance14;
          ultraGridColumn4.Header.VisiblePosition = 0;
          ultraGridColumn5.Header.VisiblePosition = 1;
          ultraGridColumn6.Header.VisiblePosition = 2;
          ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
          this.grdFocusAreaChooser.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
          this.grdFocusAreaChooser.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
          this.grdFocusAreaChooser.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
          appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder;
          appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark;
          appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
          appearance15.BorderColor = System.Drawing.SystemColors.Window;
          this.grdFocusAreaChooser.DisplayLayout.GroupByBox.Appearance = appearance15;
          appearance16.ForeColor = System.Drawing.SystemColors.GrayText;
          this.grdFocusAreaChooser.DisplayLayout.GroupByBox.BandLabelAppearance = appearance16;
          this.grdFocusAreaChooser.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
          appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight;
          appearance17.BackColor2 = System.Drawing.SystemColors.Control;
          appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
          appearance17.ForeColor = System.Drawing.SystemColors.GrayText;
          this.grdFocusAreaChooser.DisplayLayout.GroupByBox.PromptAppearance = appearance17;
          appearance18.BackColor = System.Drawing.SystemColors.Window;
          appearance18.ForeColor = System.Drawing.SystemColors.ControlText;
          this.grdFocusAreaChooser.DisplayLayout.Override.ActiveCellAppearance = appearance18;
          appearance35.BackColor = System.Drawing.SystemColors.Highlight;
          appearance35.ForeColor = System.Drawing.SystemColors.HighlightText;
          this.grdFocusAreaChooser.DisplayLayout.Override.ActiveRowAppearance = appearance35;
          this.grdFocusAreaChooser.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
          this.grdFocusAreaChooser.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
          this.grdFocusAreaChooser.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
          this.grdFocusAreaChooser.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
          this.grdFocusAreaChooser.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
          this.grdFocusAreaChooser.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
          this.grdFocusAreaChooser.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
          this.grdFocusAreaChooser.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
          appearance37.BackColor = System.Drawing.SystemColors.Window;
          this.grdFocusAreaChooser.DisplayLayout.Override.CardAreaAppearance = appearance37;
          appearance38.BorderColor = System.Drawing.Color.Silver;
          appearance38.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
          this.grdFocusAreaChooser.DisplayLayout.Override.CellAppearance = appearance38;
          this.grdFocusAreaChooser.DisplayLayout.Override.CellPadding = 0;
          this.grdFocusAreaChooser.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly;
          appearance39.BackColor = System.Drawing.SystemColors.Control;
          appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark;
          appearance39.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
          appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
          appearance39.BorderColor = System.Drawing.SystemColors.Window;
          this.grdFocusAreaChooser.DisplayLayout.Override.GroupByRowAppearance = appearance39;
          appearance40.TextHAlignAsString = "Left";
          this.grdFocusAreaChooser.DisplayLayout.Override.HeaderAppearance = appearance40;
          this.grdFocusAreaChooser.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
          this.grdFocusAreaChooser.DisplayLayout.Override.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Never;
          appearance41.BackColor = System.Drawing.SystemColors.Window;
          appearance41.BorderColor = System.Drawing.Color.Silver;
          this.grdFocusAreaChooser.DisplayLayout.Override.RowAppearance = appearance41;
          this.grdFocusAreaChooser.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
          this.grdFocusAreaChooser.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFixed;
          appearance42.BackColor = System.Drawing.SystemColors.ControlLight;
          this.grdFocusAreaChooser.DisplayLayout.Override.TemplateAddRowAppearance = appearance42;
          this.grdFocusAreaChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.grdFocusAreaChooser.Location = new System.Drawing.Point(20, 106);
          this.grdFocusAreaChooser.Name = "grdFocusAreaChooser";
          this.grdFocusAreaChooser.Size = new System.Drawing.Size(896, 290);
          this.grdFocusAreaChooser.TabIndex = 44;
          this.grdFocusAreaChooser.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.grdFocusAreaChooser_CellChange);
          // 
          // btnReadFocusAreas
          // 
          this.btnReadFocusAreas.Location = new System.Drawing.Point(20, 78);
          this.btnReadFocusAreas.Name = "btnReadFocusAreas";
          this.btnReadFocusAreas.Size = new System.Drawing.Size(153, 22);
          this.btnReadFocusAreas.TabIndex = 41;
          this.btnReadFocusAreas.Text = "Read Focus Areas";
          this.btnReadFocusAreas.Click += new System.EventHandler(this.btnReadFocusAreas_Click);
          // 
          // ultraLabel9
          // 
          this.ultraLabel9.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.ultraLabel9.Location = new System.Drawing.Point(5, 10);
          this.ultraLabel9.Name = "ultraLabel9";
          this.ultraLabel9.Size = new System.Drawing.Size(631, 27);
          this.ultraLabel9.TabIndex = 32;
          this.ultraLabel9.Text = "Aggregate Multiple Alternatives to New Alternative";
          // 
          // ultraTabPageControl8
          // 
          this.ultraTabPageControl8.Controls.Add(this.ultraLabel14);
          this.ultraTabPageControl8.Controls.Add(this.ultraLabel12);
          this.ultraTabPageControl8.Controls.Add(this.ultraTextEditor3);
          this.ultraTabPageControl8.Controls.Add(this.btnMoveAlternative);
          this.ultraTabPageControl8.Controls.Add(this.ultraLabel2);
          this.ultraTabPageControl8.Controls.Add(this.txtNewAltName);
          this.ultraTabPageControl8.Controls.Add(this.txtNewModel);
          this.ultraTabPageControl8.Controls.Add(this.btnBrowseNewModel);
          this.ultraTabPageControl8.Controls.Add(this.ultraLabel1);
          this.ultraTabPageControl8.Location = new System.Drawing.Point(-10000, -10000);
          this.ultraTabPageControl8.Name = "ultraTabPageControl8";
          this.ultraTabPageControl8.Size = new System.Drawing.Size(923, 615);
          // 
          // ultraLabel14
          // 
          this.ultraLabel14.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.ultraLabel14.Location = new System.Drawing.Point(6, 3);
          this.ultraLabel14.Name = "ultraLabel14";
          this.ultraLabel14.Size = new System.Drawing.Size(631, 27);
          this.ultraLabel14.TabIndex = 58;
          this.ultraLabel14.Text = "Move Alternative to New Base Model";
          // 
          // ultraLabel12
          // 
          appearance1.TextVAlignAsString = "Bottom";
          this.ultraLabel12.Appearance = appearance1;
          this.ultraLabel12.Location = new System.Drawing.Point(22, 289);
          this.ultraLabel12.Name = "ultraLabel12";
          this.ultraLabel12.Size = new System.Drawing.Size(254, 16);
          this.ultraLabel12.TabIndex = 57;
          this.ultraLabel12.Text = "Reconciliation Report:";
          // 
          // ultraTextEditor3
          // 
          this.ultraTextEditor3.Location = new System.Drawing.Point(22, 305);
          this.ultraTextEditor3.Multiline = true;
          this.ultraTextEditor3.Name = "ultraTextEditor3";
          this.ultraTextEditor3.ReadOnly = true;
          this.ultraTextEditor3.Size = new System.Drawing.Size(818, 302);
          this.ultraTextEditor3.TabIndex = 56;
          // 
          // btnMoveAlternative
          // 
          this.btnMoveAlternative.Enabled = false;
          this.btnMoveAlternative.Location = new System.Drawing.Point(22, 260);
          this.btnMoveAlternative.Name = "btnMoveAlternative";
          this.btnMoveAlternative.Size = new System.Drawing.Size(172, 23);
          this.btnMoveAlternative.TabIndex = 55;
          this.btnMoveAlternative.Text = "Move Alternative";
          this.btnMoveAlternative.Click += new System.EventHandler(this.btnMoveAlternative_Click);
          // 
          // ultraLabel2
          // 
          appearance4.TextVAlignAsString = "Bottom";
          this.ultraLabel2.Appearance = appearance4;
          this.ultraLabel2.Location = new System.Drawing.Point(22, 210);
          this.ultraLabel2.Name = "ultraLabel2";
          this.ultraLabel2.Size = new System.Drawing.Size(254, 16);
          this.ultraLabel2.TabIndex = 54;
          this.ultraLabel2.Text = "New Alternative Name:";
          // 
          // txtNewAltName
          // 
          this.txtNewAltName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.altEngineConfiguration, "ProgramSettings.FocusAreasTable", true));
          this.txtNewAltName.Location = new System.Drawing.Point(22, 232);
          this.txtNewAltName.Name = "txtNewAltName";
          this.txtNewAltName.Size = new System.Drawing.Size(504, 21);
          this.txtNewAltName.TabIndex = 53;
          // 
          // txtNewModel
          // 
          this.txtNewModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.altEngineConfiguration, "ProgramSettings.FocusAreasTable", true));
          this.txtNewModel.Location = new System.Drawing.Point(22, 186);
          this.txtNewModel.Name = "txtNewModel";
          this.txtNewModel.Size = new System.Drawing.Size(504, 21);
          this.txtNewModel.TabIndex = 52;
          // 
          // btnBrowseNewModel
          // 
          this.btnBrowseNewModel.Location = new System.Drawing.Point(531, 184);
          this.btnBrowseNewModel.Name = "btnBrowseNewModel";
          this.btnBrowseNewModel.Size = new System.Drawing.Size(64, 23);
          this.btnBrowseNewModel.TabIndex = 51;
          this.btnBrowseNewModel.Text = "Browse...";
          // 
          // ultraLabel1
          // 
          appearance5.TextVAlignAsString = "Bottom";
          this.ultraLabel1.Appearance = appearance5;
          this.ultraLabel1.Location = new System.Drawing.Point(22, 153);
          this.ultraLabel1.Name = "ultraLabel1";
          this.ultraLabel1.Size = new System.Drawing.Size(254, 27);
          this.ultraLabel1.TabIndex = 49;
          this.ultraLabel1.Text = "Move Alternative to Model:";
          // 
          // programSettingsBindingSource
          // 
          this.programSettingsBindingSource.DataMember = "ProgramSettings";
          this.programSettingsBindingSource.DataSource = this.altEngineConfiguration1;
          // 
          // altEngineConfiguration1
          // 
          this.altEngineConfiguration1.DataSetName = "AltEngineConfiguration";
          this.altEngineConfiguration1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // alternativeExplorerBar
          // 
          this.alternativeExplorerBar.Dock = System.Windows.Forms.DockStyle.Left;
          ultraExplorerBarItem1.Key = "ManageAlternatives";
          ultraExplorerBarItem1.Settings.UseDefaultImage = Infragistics.Win.DefaultableBoolean.False;
          ultraExplorerBarItem1.Text = "Manage Alternatives";
          ultraExplorerBarItem2.Key = "ApplyAlternative";
          ultraExplorerBarItem2.Text = "Apply Alternative";
          ultraExplorerBarItem2.ToolTipText = "Create a new model based on an alternative";
          ultraExplorerBarItem3.Key = "AlternativeQC";
          ultraExplorerBarItem3.Settings.Enabled = Infragistics.Win.DefaultableBoolean.False;
          ultraExplorerBarItem3.Text = "Create QC Report";
          ultraExplorerBarItem3.ToolTipText = "Perform Alternative QAQC";
          ultraExplorerBarItem3.Visible = false;
          ultraExplorerBarItem4.Key = "AutoConveyance";
          ultraExplorerBarItem4.Text = "Conveyance Alternative";
          ultraExplorerBarItem4.ToolTipText = "Automatically Generate a Conveyance Alternative";
          ultraExplorerBarItem5.Key = "Aggregator";
          ultraExplorerBarItem5.Text = "Aggregator";
          ultraExplorerBarItem6.Key = "MoveAlternative";
          ultraExplorerBarItem6.Text = "Move Alternative";
          ultraExplorerBarGroup1.Items.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem[] {
            ultraExplorerBarItem1,
            ultraExplorerBarItem2,
            ultraExplorerBarItem3,
            ultraExplorerBarItem4,
            ultraExplorerBarItem5,
            ultraExplorerBarItem6});
          ultraExplorerBarGroup1.Settings.ContainerHeight = 19;
          ultraExplorerBarGroup1.Text = "Tools";
          ultraExplorerBarItem7.Key = "EngineStatus";
          ultraExplorerBarItem7.Text = "Status Log";
          ultraExplorerBarItem8.Checked = true;
          ultraExplorerBarItem8.Key = "ModifySettings";
          ultraExplorerBarItem8.Text = "Settings";
          ultraExplorerBarItem9.Key = "Exit";
          ultraExplorerBarItem9.Text = "Exit";
          ultraExplorerBarGroup2.Items.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem[] {
            ultraExplorerBarItem7,
            ultraExplorerBarItem8,
            ultraExplorerBarItem9});
          ultraExplorerBarGroup2.Text = "Application";
          this.alternativeExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2});
          this.alternativeExplorerBar.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText;
          this.alternativeExplorerBar.ItemSettings.UseDefaultImage = Infragistics.Win.DefaultableBoolean.False;
          this.alternativeExplorerBar.Location = new System.Drawing.Point(0, 24);
          this.alternativeExplorerBar.Name = "alternativeExplorerBar";
          this.alternativeExplorerBar.Size = new System.Drawing.Size(171, 615);
          this.alternativeExplorerBar.TabIndex = 2;
          this.alternativeExplorerBar.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.VisualStudio2005;
          this.alternativeExplorerBar.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.alternativeExplorerBar_ItemClick);
          // 
          // tabControl
          // 
          appearance36.BackColor = System.Drawing.SystemColors.Control;
          appearance36.BackColor2 = System.Drawing.SystemColors.Control;
          appearance36.ForeColor = System.Drawing.SystemColors.Control;
          this.tabControl.Appearance = appearance36;
          this.tabControl.Controls.Add(this.ultraTabSharedControlsPage1);
          this.tabControl.Controls.Add(ultraTabPageControl2);
          this.tabControl.Controls.Add(this.ultraTabPageControl1);
          this.tabControl.Controls.Add(this.ultraTabPageControl3);
          this.tabControl.Controls.Add(this.ultraTabPageControl4);
          this.tabControl.Controls.Add(this.ultraTabPageControl5);
          this.tabControl.Controls.Add(this.ultraTabPageControl6);
          this.tabControl.Controls.Add(this.ultraTabPageControl7);
          this.tabControl.Controls.Add(this.ultraTabPageControl8);
          this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tabControl.Location = new System.Drawing.Point(171, 24);
          this.tabControl.Name = "tabControl";
          this.tabControl.SharedControls.AddRange(new System.Windows.Forms.Control[] {
            this.btnCancel,
            this.cmbAlternativeList,
            this.lblAlternativeName,
            this.lblBaseModel,
            this.cmbBaseModel,
            this.btnBrowseBaseModel});
          this.tabControl.SharedControlsPage = this.ultraTabSharedControlsPage1;
          this.tabControl.Size = new System.Drawing.Size(923, 615);
          this.tabControl.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard;
          this.tabControl.TabIndex = 0;
          ultraTab7.ExcludedSharedControls.AddRange(new System.Windows.Forms.Control[] {
            this.cmbAlternativeList,
            this.lblAlternativeName,
            this.lblBaseModel,
            this.cmbBaseModel,
            this.btnBrowseBaseModel});
          ultraTab7.Key = "EngineStatus";
          ultraTab7.TabPage = this.ultraTabPageControl1;
          ultraTab7.Text = "tab1";
          ultraTab8.Key = "ManageAlternatives";
          ultraTab8.TabPage = ultraTabPageControl2;
          ultraTab8.Text = "tab2";
          ultraTab9.Key = "ApplyAlternative";
          ultraTab9.TabPage = this.ultraTabPageControl3;
          ultraTab9.Text = "tab3";
          ultraTab10.Key = "AlternativeQC";
          ultraTab10.TabPage = this.ultraTabPageControl4;
          ultraTab10.Text = "tab4";
          ultraTab11.ExcludedSharedControls.AddRange(new System.Windows.Forms.Control[] {
            this.cmbAlternativeList,
            this.lblAlternativeName,
            this.lblBaseModel,
            this.cmbBaseModel,
            this.btnBrowseBaseModel});
          ultraTab11.Key = "ModifySettings";
          ultraTab11.TabPage = this.ultraTabPageControl5;
          ultraTab11.Text = "tab5";
          ultraTab12.Key = "AutoConveyance";
          ultraTab12.TabPage = this.ultraTabPageControl6;
          ultraTab12.Text = "tab6";
          ultraTab1.ExcludedSharedControls.AddRange(new System.Windows.Forms.Control[] {
            this.cmbAlternativeList,
            this.lblAlternativeName});
          ultraTab1.Key = "Aggregator";
          ultraTab1.TabPage = this.ultraTabPageControl7;
          ultraTab1.Text = "tab7";
          ultraTab2.Key = "MoveAlternative";
          ultraTab2.TabPage = this.ultraTabPageControl8;
          ultraTab2.Text = "Move Alternative";
          this.tabControl.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab7,
            ultraTab8,
            ultraTab9,
            ultraTab10,
            ultraTab11,
            ultraTab12,
            ultraTab1,
            ultraTab2});
          this.tabControl.SelectedTabChanging += new Infragistics.Win.UltraWinTabControl.SelectedTabChangingEventHandler(this.tabControl_SelectedTabChanging);
          // 
          // ultraTabSharedControlsPage1
          // 
          this.ultraTabSharedControlsPage1.Controls.Add(this.btnCancel);
          this.ultraTabSharedControlsPage1.Controls.Add(this.cmbAlternativeList);
          this.ultraTabSharedControlsPage1.Controls.Add(this.lblAlternativeName);
          this.ultraTabSharedControlsPage1.Controls.Add(this.lblBaseModel);
          this.ultraTabSharedControlsPage1.Controls.Add(this.cmbBaseModel);
          this.ultraTabSharedControlsPage1.Controls.Add(this.btnBrowseBaseModel);
          this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(-10000, -10000);
          this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
          this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(923, 615);
          // 
          // statusBar
          // 
          this.statusBar.Location = new System.Drawing.Point(0, 639);
          this.statusBar.Name = "statusBar";
          ultraStatusPanel1.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft;
          ultraStatusPanel1.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Spring;
          this.statusBar.Panels.AddRange(new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel[] {
            ultraStatusPanel1});
          this.statusBar.Size = new System.Drawing.Size(1094, 20);
          this.statusBar.TabIndex = 4;
          // 
          // menuStrip1
          // 
          this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
          this.menuStrip1.Location = new System.Drawing.Point(0, 0);
          this.menuStrip1.Name = "menuStrip1";
          this.menuStrip1.Size = new System.Drawing.Size(1094, 24);
          this.menuStrip1.TabIndex = 5;
          this.menuStrip1.Text = "menuStrip1";
          // 
          // fileToolStripMenuItem
          // 
          this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
          this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
          this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
          this.fileToolStripMenuItem.Text = "&File";
          // 
          // exitToolStripMenuItem
          // 
          this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
          this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
          this.exitToolStripMenuItem.Text = "E&xit";
          this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
          // 
          // helpToolStripMenuItem
          // 
          this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
          this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
          this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
          this.helpToolStripMenuItem.Text = "&Help";
          // 
          // aboutToolStripMenuItem
          // 
          this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
          this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
          this.aboutToolStripMenuItem.Text = "About";
          this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
          // 
          // contentsToolStripMenuItem
          // 
          this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
          this.contentsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.contentsToolStripMenuItem.Text = "&Contents";
          // 
          // indexToolStripMenuItem
          // 
          this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
          this.indexToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.indexToolStripMenuItem.Text = "&Index";
          // 
          // searchToolStripMenuItem
          // 
          this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
          this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.searchToolStripMenuItem.Text = "&Search";
          // 
          // toolStripSeparator5
          // 
          this.toolStripSeparator5.Name = "toolStripSeparator5";
          this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
          // 
          // customizeToolStripMenuItem
          // 
          this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
          this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.customizeToolStripMenuItem.Text = "&Customize";
          // 
          // optionsToolStripMenuItem
          // 
          this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
          this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.optionsToolStripMenuItem.Text = "&Options";
          // 
          // undoToolStripMenuItem
          // 
          this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
          this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
          this.undoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.undoToolStripMenuItem.Text = "&Undo";
          // 
          // redoToolStripMenuItem
          // 
          this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
          this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
          this.redoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.redoToolStripMenuItem.Text = "&Redo";
          // 
          // toolStripSeparator3
          // 
          this.toolStripSeparator3.Name = "toolStripSeparator3";
          this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
          // 
          // cutToolStripMenuItem
          // 
          this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
          this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
          this.cutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.cutToolStripMenuItem.Text = "Cu&t";
          // 
          // copyToolStripMenuItem
          // 
          this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
          this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
          this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.copyToolStripMenuItem.Text = "&Copy";
          // 
          // pasteToolStripMenuItem
          // 
          this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
          this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
          this.pasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.pasteToolStripMenuItem.Text = "&Paste";
          // 
          // toolStripSeparator4
          // 
          this.toolStripSeparator4.Name = "toolStripSeparator4";
          this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
          // 
          // selectAllToolStripMenuItem
          // 
          this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
          this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
          this.selectAllToolStripMenuItem.Text = "Select &All";
          // 
          // openFileDialog1
          // 
          this.openFileDialog1.DefaultExt = "*.out";
          this.openFileDialog1.Filter = "*.out|*.out";
          this.openFileDialog1.RestoreDirectory = true;
          // 
          // ultraLabel11
          // 
          this.ultraLabel11.Location = new System.Drawing.Point(0, 0);
          this.ultraLabel11.Name = "ultraLabel11";
          this.ultraLabel11.Size = new System.Drawing.Size(100, 23);
          this.ultraLabel11.TabIndex = 6;
          this.ultraLabel11.Text = "ultraLabel11";
          // 
          // AlternativeEngineForm
          // 
          this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
          this.ClientSize = new System.Drawing.Size(1094, 659);
          this.Controls.Add(this.tabControl);
          this.Controls.Add(this.alternativeExplorerBar);
          this.Controls.Add(this.statusBar);
          this.Controls.Add(this.menuStrip1);
          this.Controls.Add(this.ultraLabel11);
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.Name = "AlternativeEngineForm";
          this.Text = "Alternatives Toolkit";
          ultraTabPageControl2.ResumeLayout(false);
          ultraTabPageControl2.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
          this.ultraGroupBox1.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.chkFocusAreaTargets)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.chkFocusAreaCatchments)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.chkFocusAreaLinks)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.txtFocusAreas)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.altEngineConfiguration)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.grpAlternativeManagement)).EndInit();
          this.grpAlternativeManagement.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.grdAlternativeHistory)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.altConfigFileBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(altConfigFile)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.cmbAlternativeList)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.cmbBaseModel)).EndInit();
          this.ultraTabPageControl1.ResumeLayout(false);
          this.panel2.ResumeLayout(false);
          this.ultraTabPageControl3.ResumeLayout(false);
          this.ultraTabPageControl3.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.cmbOutputModel)).EndInit();
          this.ultraTabPageControl4.ResumeLayout(false);
          this.ultraTabPageControl5.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.txtDebugMode)).EndInit();
          this.ultraTabPageControl6.ResumeLayout(false);
          this.ultraTabPageControl6.PerformLayout();
          this.ultraTabPageControl7.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.chkRemoveRIK)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.grdFocusAreaChooser)).EndInit();
          this.ultraTabPageControl8.ResumeLayout(false);
          this.ultraTabPageControl8.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor3)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.txtNewAltName)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.txtNewModel)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.programSettingsBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.altEngineConfiguration1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.alternativeExplorerBar)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
          this.tabControl.ResumeLayout(false);
          this.ultraTabSharedControlsPage1.ResumeLayout(false);
          this.ultraTabSharedControlsPage1.PerformLayout();
          this.menuStrip1.ResumeLayout(false);
          this.menuStrip1.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.ultraGridBagLayoutManager1)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinStatusBar.UltraStatusBar statusBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;        
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Infragistics.Win.UltraWinTabControl.UltraTabControl tabControl;
        private Infragistics.Win.Misc.UltraButton btnCopyAlternative;
        private Infragistics.Win.Misc.UltraLabel lblDefaultNodeName;
        private Infragistics.Win.Misc.UltraButton btnDeleteAlternative;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraButton btnNewAlternative;
        private System.Windows.Forms.TextBox txtDefaultNodeName;
        private Infragistics.Win.Misc.UltraButton btnEditAlternative;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl1;
        private SystemsAnalysis.Utils.StatusTextBox.StatusTextBox engineOutput;
        private System.Windows.Forms.Panel panel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl3;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbOutputModel;
        private Infragistics.Win.Misc.UltraButton btnBrowseOutput;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraButton btnApplyAlternative;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl5;
        private Infragistics.Win.Misc.UltraButton btnRestoreDefault;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor txtDebugMode;
        
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar alternativeExplorerBar;
        private AltEngineConfiguration altEngineConfiguration;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Infragistics.Win.Misc.UltraLabel lblCurrentConfigFile;
        private Infragistics.Win.Misc.UltraButton btnLoadDebugSettings;
        private Infragistics.Win.UltraWinGrid.UltraGrid grdAlternativeHistory;
        private System.Windows.Forms.BindingSource altConfigFileBindingSource;
        private Infragistics.Win.Misc.UltraLabel ultraLabel13;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl6;
        private Infragistics.Win.Misc.UltraButton btnGenerateConveyance;
        private Infragistics.Win.Misc.UltraLabel ultraLabel10;        
        private AutoConveyanceInterface autoConveyanceInterface;
        private Infragistics.Win.Misc.UltraButton btnEditAutoConveyance;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl7;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
        private Infragistics.Win.Misc.UltraButton btnReadFocusAreas;
        private Infragistics.Win.Misc.UltraLabel ultraLabel11;
        private Infragistics.Win.Misc.UltraGridBagLayoutManager ultraGridBagLayoutManager1;
        private Infragistics.Win.UltraWinGrid.UltraGrid grdFocusAreaChooser;
        private Infragistics.Win.Misc.UltraButton btnAggregate;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkRemoveRIK;
        private Infragistics.Win.Misc.UltraGroupBox grpAlternativeManagement;
        private Infragistics.Win.Misc.UltraLabel lblFocusAreas;
        private Infragistics.Win.Misc.UltraButton btnBrowseFocusAreas;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtFocusAreas;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbAlternativeList;
        private Infragistics.Win.Misc.UltraLabel lblAlternativeName;
        private Infragistics.Win.Misc.UltraLabel lblBaseModel;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbBaseModel;
        private Infragistics.Win.Misc.UltraButton btnBrowseBaseModel;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkFocusAreaLinks;
        private Infragistics.Win.Misc.UltraButton btnRefreshFocusAreas;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkFocusAreaTargets;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkFocusAreaCatchments;
        private System.Windows.Forms.BindingSource programSettingsBindingSource;
        private AltEngineConfiguration altEngineConfiguration1;
        private Infragistics.Win.Misc.UltraButton btnCancel;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtNewModel;
        private Infragistics.Win.Misc.UltraButton btnBrowseNewModel;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtNewAltName;
        private Infragistics.Win.Misc.UltraLabel ultraLabel12;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor3;
        private Infragistics.Win.Misc.UltraButton btnMoveAlternative;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel14;
    }
}