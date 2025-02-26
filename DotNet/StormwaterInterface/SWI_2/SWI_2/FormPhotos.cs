﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWI_2
{
    public partial class FormPhotos : Form
    {
        private int _GlobalID;

        public FormPhotos()
        {
            InitializeComponent();
        }

        public int GlobalID
        {
            get { return _GlobalID; }
            set { _GlobalID = value; }
        }


        private void FormPhotos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sANDBOXDataSet.SWSP_PHOTO' table. You can move, or remove it, as needed.
            this.sWSP_PHOTOTableAdapter.FillByGlobalID((SANDBOXDataSet.SWSP_PHOTODataTable)((SANDBOXDataSet)this.sWSPPHOTOBindingSource.DataSource).SWSP_PHOTO, _GlobalID);
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            this.sWSP_PHOTOTableAdapter.InsertQuery(_GlobalID, "", "");
            this.sWSP_PHOTOTableAdapter.FillByGlobalID((SANDBOXDataSet.SWSP_PHOTODataTable)((SANDBOXDataSet)this.sWSPPHOTOBindingSource.DataSource).SWSP_PHOTO, _GlobalID);
        }

        private void buttonDeletePhoto_Click(object sender, EventArgs e)
        {
            this.sWSP_PHOTOTableAdapter.DeleteQuery((int)this.dataGridViewPhotos.CurrentRow.Cells[0].Value);
            this.sWSP_PHOTOTableAdapter.FillByGlobalID((SANDBOXDataSet.SWSP_PHOTODataTable)((SANDBOXDataSet)this.sWSPPHOTOBindingSource.DataSource).SWSP_PHOTO, _GlobalID);
        }

        private void buttonUpdatePhoto_Click(object sender, EventArgs e)
        {
            string infos = "";
            string location = "";
            if (this.dataGridViewPhotos.CurrentRow.Cells[3].Value is System.DBNull)
            {
                infos = "";
            }
            else
            {
                infos = ((string)this.dataGridViewPhotos.CurrentRow.Cells[3].Value);
            }

            if (this.dataGridViewPhotos.CurrentRow.Cells[2].Value is System.DBNull)
            {
                location = "";
            }
            else
            {
                location = ((string)this.dataGridViewPhotos.CurrentRow.Cells[2].Value);
            }

            this.sWSP_PHOTOTableAdapter.UpdateQuery(_GlobalID, location, infos, (int)this.dataGridViewPhotos.CurrentRow.Cells[0].Value, _GlobalID, (int)this.dataGridViewPhotos.CurrentRow.Cells[0].Value);
            this.sWSP_PHOTOTableAdapter.FillByGlobalID((SANDBOXDataSet.SWSP_PHOTODataTable)((SANDBOXDataSet)this.sWSPPHOTOBindingSource.DataSource).SWSP_PHOTO, _GlobalID);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
