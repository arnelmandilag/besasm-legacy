namespace SystemsAnalysis.Reporting
{
    partial class AddModelForm
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ModelScenario", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ScenarioID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StormID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ModelScenario_LinkHydraulics");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ModelScenario_NodeHydraulics");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ModelScenario_DscHydraulics");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ModelScenario_LinkHydraulics", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("LinkHydraulicsID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ScenarioID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MLinkID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ModelID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MaxQ");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TimeOfMaxQ");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MaxV");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TimeOfMaxV");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("QQRatio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MaxUsElev");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MaxDsElev");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ModelScenario_NodeHydraulics", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NodeHydraulicsID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ScenarioID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ModelID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NodeName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MaxElevation");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TimeOfMaxElev");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Surcharge");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Freeboard");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SurchargeTime");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FloodedTime");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ModelScenario_DscHydraulics", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DscHydraulicsID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ScenarioID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DscID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ModelID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HGL");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DeltaHGL");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Surcharge");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.txtModelName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtModelDescription = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtModelPath = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtOutputFilePath = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtModeler = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtStudyArea = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnAddToModelCatalog = new Infragistics.Win.Misc.UltraButton();
            this.btnBrowseModel = new Infragistics.Win.Misc.UltraButton();
            this.btnBrowseOutput = new Infragistics.Win.Misc.UltraButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new Infragistics.Win.Misc.UltraButton();
            this.optModelType = new Infragistics.Win.UltraWinEditors.UltraOptionSet();
            this.cmbScenario = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.modelCatalogDataSet = new SystemsAnalysis.DataAccess.ModelCatalogDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optModelType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbScenario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCatalogDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(12, 70);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(146, 23);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "Project Description:";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(12, 12);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(146, 23);
            this.ultraLabel2.TabIndex = 1;
            this.ultraLabel2.Text = "Model Path:";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(12, 221);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(146, 23);
            this.ultraLabel3.TabIndex = 2;
            this.ultraLabel3.Text = "Model Type:";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Location = new System.Drawing.Point(11, 186);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(146, 23);
            this.ultraLabel4.TabIndex = 3;
            this.ultraLabel4.Text = "Modeler:";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Location = new System.Drawing.Point(12, 99);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(146, 23);
            this.ultraLabel6.TabIndex = 5;
            this.ultraLabel6.Text = "Output File Path:";
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.Location = new System.Drawing.Point(12, 128);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(146, 23);
            this.ultraLabel7.TabIndex = 6;
            this.ultraLabel7.Text = "Model Name:";
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Location = new System.Drawing.Point(11, 41);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(146, 23);
            this.ultraLabel8.TabIndex = 7;
            this.ultraLabel8.Text = "Basin or Study Area:";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Location = new System.Drawing.Point(11, 157);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(146, 23);
            this.ultraLabel5.TabIndex = 8;
            this.ultraLabel5.Text = "Scenario:";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(165, 127);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(228, 24);
            this.txtModelName.TabIndex = 2;
            // 
            // txtModelDescription
            // 
            this.txtModelDescription.Location = new System.Drawing.Point(165, 69);
            this.txtModelDescription.Name = "txtModelDescription";
            this.txtModelDescription.Size = new System.Drawing.Size(228, 24);
            this.txtModelDescription.TabIndex = 3;
            // 
            // txtModelPath
            // 
            this.txtModelPath.Location = new System.Drawing.Point(165, 11);
            this.txtModelPath.Name = "txtModelPath";
            this.txtModelPath.Size = new System.Drawing.Size(354, 24);
            this.txtModelPath.TabIndex = 0;
            // 
            // txtOutputFilePath
            // 
            this.txtOutputFilePath.Location = new System.Drawing.Point(165, 98);
            this.txtOutputFilePath.Name = "txtOutputFilePath";
            this.txtOutputFilePath.Size = new System.Drawing.Size(354, 24);
            this.txtOutputFilePath.TabIndex = 4;
            // 
            // txtModeler
            // 
            this.txtModeler.Location = new System.Drawing.Point(165, 185);
            this.txtModeler.Name = "txtModeler";
            this.txtModeler.Size = new System.Drawing.Size(228, 24);
            this.txtModeler.TabIndex = 7;
            // 
            // txtStudyArea
            // 
            this.txtStudyArea.Location = new System.Drawing.Point(165, 40);
            this.txtStudyArea.Name = "txtStudyArea";
            this.txtStudyArea.Size = new System.Drawing.Size(228, 24);
            this.txtStudyArea.TabIndex = 8;
            // 
            // btnAddToModelCatalog
            // 
            this.btnAddToModelCatalog.ButtonStyle = Infragistics.Win.UIElementButtonStyle.VisualStudio2005Button;
            this.btnAddToModelCatalog.Location = new System.Drawing.Point(94, 265);
            this.btnAddToModelCatalog.Name = "btnAddToModelCatalog";
            this.btnAddToModelCatalog.Size = new System.Drawing.Size(228, 29);
            this.btnAddToModelCatalog.TabIndex = 10;
            this.btnAddToModelCatalog.Text = "Add Model to Catalog";
            this.btnAddToModelCatalog.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // btnBrowseModel
            // 
            this.btnBrowseModel.ButtonStyle = Infragistics.Win.UIElementButtonStyle.VisualStudio2005Button;
            this.btnBrowseModel.Location = new System.Drawing.Point(524, 12);
            this.btnBrowseModel.Name = "btnBrowseModel";
            this.btnBrowseModel.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseModel.TabIndex = 1;
            this.btnBrowseModel.Text = "Browse...";
            this.btnBrowseModel.Click += new System.EventHandler(this.btnBrowseModel_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.ButtonStyle = Infragistics.Win.UIElementButtonStyle.VisualStudio2005Button;
            this.btnBrowseOutput.Location = new System.Drawing.Point(525, 99);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "Browse...";
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.ini";
            this.openFileDialog1.FileName = "Model.ini";
            this.openFileDialog1.Filter = "*.ini|*.ini";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Select Model to Upload";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "*.out";
            this.openFileDialog2.FileName = "model.out";
            this.openFileDialog2.Filter = "*.out|*.out";
            this.openFileDialog2.Title = "Select Model Output File";
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = Infragistics.Win.UIElementButtonStyle.VisualStudio2005Button;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(328, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // optModelType
            // 
            this.optModelType.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1;
            this.optModelType.CheckedIndex = 0;
            appearance1.TextVAlignAsString = "Middle";
            this.optModelType.ItemAppearance = appearance1;
            this.optModelType.ItemOrigin = new System.Drawing.Point(5, 5);
            valueListItem1.DataValue = "BAS";
            valueListItem1.DisplayText = "Basin";
            valueListItem2.DataValue = "INT";
            valueListItem2.DisplayText = "Interceptor";
            this.optModelType.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2});
            this.optModelType.ItemSpacingHorizontal = 5;
            this.optModelType.Location = new System.Drawing.Point(165, 216);
            this.optModelType.Name = "optModelType";
            this.optModelType.Size = new System.Drawing.Size(227, 32);
            this.optModelType.TabIndex = 12;
            this.optModelType.Text = "Basin";
            // 
            // cmbScenario
            // 
            this.cmbScenario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbScenario.DataMember = "ModelScenario";
            this.cmbScenario.DataSource = this.modelCatalogDataSet;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbScenario.DisplayLayout.Appearance = appearance2;
            this.cmbScenario.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn3.Header.Caption = "Description";
            ultraGridColumn3.Header.Enabled = false;
            ultraGridColumn3.Header.VisiblePosition = 4;
            ultraGridColumn3.Width = 336;
            ultraGridColumn4.Header.VisiblePosition = 2;
            ultraGridColumn5.Header.VisiblePosition = 3;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            ultraGridColumn7.Header.VisiblePosition = 0;
            ultraGridColumn8.Header.VisiblePosition = 1;
            ultraGridColumn9.Header.VisiblePosition = 2;
            ultraGridColumn10.Header.VisiblePosition = 3;
            ultraGridColumn11.Header.VisiblePosition = 4;
            ultraGridColumn12.Header.VisiblePosition = 5;
            ultraGridColumn13.Header.VisiblePosition = 6;
            ultraGridColumn14.Header.VisiblePosition = 7;
            ultraGridColumn15.Header.VisiblePosition = 8;
            ultraGridColumn16.Header.VisiblePosition = 9;
            ultraGridColumn17.Header.VisiblePosition = 10;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17});
            ultraGridColumn18.Header.VisiblePosition = 0;
            ultraGridColumn19.Header.VisiblePosition = 1;
            ultraGridColumn20.Header.VisiblePosition = 2;
            ultraGridColumn21.Header.VisiblePosition = 3;
            ultraGridColumn22.Header.VisiblePosition = 4;
            ultraGridColumn23.Header.VisiblePosition = 5;
            ultraGridColumn24.Header.VisiblePosition = 6;
            ultraGridColumn25.Header.VisiblePosition = 7;
            ultraGridColumn26.Header.VisiblePosition = 8;
            ultraGridColumn27.Header.VisiblePosition = 9;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27});
            ultraGridColumn28.Header.VisiblePosition = 0;
            ultraGridColumn29.Header.VisiblePosition = 1;
            ultraGridColumn30.Header.VisiblePosition = 2;
            ultraGridColumn31.Header.VisiblePosition = 3;
            ultraGridColumn32.Header.VisiblePosition = 4;
            ultraGridColumn33.Header.VisiblePosition = 5;
            ultraGridColumn34.Header.VisiblePosition = 6;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34});
            this.cmbScenario.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.cmbScenario.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.cmbScenario.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.cmbScenario.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.cmbScenario.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cmbScenario.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbScenario.DisplayLayout.GroupByBox.Appearance = appearance3;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbScenario.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.cmbScenario.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackColor2 = System.Drawing.SystemColors.Control;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbScenario.DisplayLayout.GroupByBox.PromptAppearance = appearance5;
            this.cmbScenario.DisplayLayout.MaxColScrollRegions = 1;
            this.cmbScenario.DisplayLayout.MaxRowScrollRegions = 1;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            appearance6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbScenario.DisplayLayout.Override.ActiveCellAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.Highlight;
            appearance7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbScenario.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            this.cmbScenario.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cmbScenario.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            this.cmbScenario.DisplayLayout.Override.CardAreaAppearance = appearance8;
            appearance9.BorderColor = System.Drawing.Color.Silver;
            appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cmbScenario.DisplayLayout.Override.CellAppearance = appearance9;
            this.cmbScenario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cmbScenario.DisplayLayout.Override.CellPadding = 0;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance10.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbScenario.DisplayLayout.Override.GroupByRowAppearance = appearance10;
            appearance11.TextHAlignAsString = "Left";
            this.cmbScenario.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.cmbScenario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cmbScenario.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            appearance12.BorderColor = System.Drawing.Color.Silver;
            this.cmbScenario.DisplayLayout.Override.RowAppearance = appearance12;
            this.cmbScenario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbScenario.DisplayLayout.Override.TemplateAddRowAppearance = appearance13;
            this.cmbScenario.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cmbScenario.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cmbScenario.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cmbScenario.DisplayMember = "Description";
            this.cmbScenario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.VisualStudio2005;
            this.cmbScenario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbScenario.LimitToList = true;
            this.cmbScenario.Location = new System.Drawing.Point(165, 156);
            this.cmbScenario.Name = "cmbScenario";
            this.cmbScenario.Size = new System.Drawing.Size(354, 25);
            this.cmbScenario.TabIndex = 6;
            this.cmbScenario.ValueMember = "ScenarioID";
            // 
            // modelCatalogDataSet
            // 
            this.modelCatalogDataSet.DataSetName = "ModelCatalogDataSet";
            this.modelCatalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 306);
            this.ControlBox = false;
            this.Controls.Add(this.cmbScenario);
            this.Controls.Add(this.optModelType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.btnBrowseModel);
            this.Controls.Add(this.btnAddToModelCatalog);
            this.Controls.Add(this.txtStudyArea);
            this.Controls.Add(this.txtOutputFilePath);
            this.Controls.Add(this.txtModelPath);
            this.Controls.Add(this.txtModelDescription);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.ultraLabel5);
            this.Controls.Add(this.ultraLabel8);
            this.Controls.Add(this.ultraLabel7);
            this.Controls.Add(this.ultraLabel6);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.txtModeler);
            this.Name = "AddModelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Model";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtModelName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optModelType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbScenario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCatalogDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SystemsAnalysis.DataAccess.ModelCatalogDataSet modelCatalogDataSet;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtModelName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtModelDescription;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtModelPath;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtOutputFilePath;
        private Infragistics.Win.UltraWinGrid.UltraCombo cmbScenario;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtModeler;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtStudyArea;
        private Infragistics.Win.Misc.UltraButton btnAddToModelCatalog;
        private Infragistics.Win.Misc.UltraButton btnBrowseModel;
        private Infragistics.Win.Misc.UltraButton btnBrowseOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private Infragistics.Win.Misc.UltraButton btnCancel;
        private Infragistics.Win.UltraWinEditors.UltraOptionSet optModelType;
    }
}