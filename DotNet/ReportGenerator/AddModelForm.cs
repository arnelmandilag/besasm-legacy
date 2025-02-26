using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using SystemsAnalysis.DataAccess;
using SystemsAnalysis.Modeling;

namespace SystemsAnalysis.Reporting
{
    public partial class AddModelForm : Form
    {
        public AddModelForm(ModelCatalogDataSet modelCatalogDataSet)
        {
            InitializeComponent();
            this.modelCatalogDataSet = modelCatalogDataSet;
            cmbScenario.DataSource = modelCatalogDataSet;
            cmbScenario.DataMember = "ModelScenario";
            cmbScenario.DisplayMember = "Description";
            cmbScenario.ValueMember = "ScenarioID";
        }

        private void AddModelForm_Load(object sender, EventArgs e)
        {
            txtModeler.Value = System.Environment.UserName;
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess.ModelCatalogDataSet.ModelCatalogRow modelRow;
                modelRow = modelCatalogDataSet.ModelCatalog.NewModelCatalogRow();
                modelRow.ModelDescription = txtModelDescription.Text;
                modelRow.ModelName = txtModelName.Text;
                modelRow.ModelOutputFile = txtOutputFilePath.Text;
                modelRow.ModelPath = txtModelPath.Text;
                modelRow.ModelType = optModelType.Value.ToString();
                modelRow.StudyArea = txtStudyArea.Text;
                modelRow.UploadedBy = System.DBNull.Value.ToString();
                modelRow.IsUploaded = 0;
                modelRow.TimeFrame = "";
                //modelRow.UploadDate = System.DBNull.Value.ToString();
                modelRow.Modeler = txtModeler.Text;
                modelRow.ScenarioID = Convert.ToInt32(cmbScenario.Value);

                modelCatalogDataSet.ModelCatalog.AddModelCatalogRow(modelRow);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not create new model entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBrowseModel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFileDialog1.FileName;
                txtModelPath.Text = Path.GetDirectoryName(fullPath) + "\\";
                txtStudyArea.Text = Path.GetDirectoryName(fullPath).Remove(0, Path.GetDirectoryName(fullPath).LastIndexOf("\\") + 1);
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = Path.GetFullPath(txtModelPath.Text);
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFileDialog2.FileName;
                txtOutputFilePath.Text = fullPath;
                txtModelName.Text = Path.GetFileNameWithoutExtension(fullPath);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}