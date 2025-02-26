﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace FFEUpdater
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnCloseAboutForm_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            string txtFilePath;
            txtFilePath = "C:\\Documents and Settings\\rgonzalez\\My Documents\\FFEUpdater\\FFEUpdater.sln";
            ShowFileInfo(txtFilePath);
        }

        private void ShowFileInfo(string sFilePath)
        {
            System.Diagnostics.FileVersionInfo fileVersInfo =
            System.Diagnostics.FileVersionInfo.GetVersionInfo(sFilePath);
            lblVersion.Text = "Version:  " + fileVersInfo.FileVersion;
        }
    }
}
