// Project: ReportGenerator, File: ApplicationInterface.cs
// Namespace: SystemsAnalysis.Reporting, Class: ApplicationInterface
// Path: C:\Development\DotNet\ReportGenerator, Author: ARNELM
// Code lines: 342, Size of file: 13.47 KB
// Creation date: 4/1/2009 12:58 PM
// Last modified: 4/13/2009 8:00 AM

#region Using directives
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;
using ESRI.ArcGIS.esriSystem;
#endregion

namespace SystemsAnalysis.Reporting
{
  /// <summary>
  /// Main user interface for ReportGenerator
  /// </summary>
  /// <returns>Form</returns>
  public partial class ApplicationInterface : Form
  {
    private static LicenseInitializer m_AOLicenseInitializer = new LicenseInitializer();

    /// <summary>
    /// Creates application interface
    /// </summary>
    public ApplicationInterface()
    {
      System.Threading.Thread th = new System.Threading.Thread(DoSplash);
      th.Start();

      this.Hide();
      InitializeComponent();

      if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
      {
        try
        {
          ChangeStatus("Running from ClickOnce mode.");
          if (System.Deployment.Application.ApplicationDeployment.CurrentDeployment.IsFirstRun)
          {
            ChangeStatus("First run of new version... copying shortcut file.");
            File.Copy(
              String.Format("{0}\\Programs\\BES Systems Analysis\\Report Generator.appref-ms",
                Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)),
              String.Format("{0}\\EMGAATS\\Report Generator.appref-ms",
                Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)), true);
          }
        } 
        catch (System.Deployment.Application.InvalidDeploymentException ex)
        {
          statusDisplayControl.AddInfoStatus(
            String.Format("Deployment exception: {0}", ex.Message));
        } 
        catch (Exception ex)
        {
          statusDisplayControl.AddInfoStatus(ex.Message);
        } 
      } 
      ChangeStatus("Welcome to Report Generator.");

      System.Threading.Thread.Sleep(2000);
      this.Show();
      return;
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      //ESRI License Initializer generated code.
      m_AOLicenseInitializer.InitializeApplication(new esriLicenseProductCode[] { esriLicenseProductCode.esriLicenseProductCodeArcView, esriLicenseProductCode.esriLicenseProductCodeArcEditor, esriLicenseProductCode.esriLicenseProductCodeArcInfo },
      new esriLicenseExtensionCode[] { });
      Application.Run(new ApplicationInterface());
      //ESRI License Initializer generated code.
      //Do not make any call to ArcObjects after ShutDownApplication()
      m_AOLicenseInitializer.ShutdownApplication();
    } // Main()

    /// <summary>
    /// Displays splash screen (for multithreading)
    /// </summary>
    private static void DoSplash()
    {
      DoSplash(false);
    }

    /// <summary>
    /// Loads the splash screen during start-up
    /// </summary>
    private static void DoSplash(bool waitForClick)
    {
      string versionText = "x.x.x.x";
      string dateText = "1/1/1900";
      if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
      {
        Version v = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
        versionText = v.Major + "." + v.Minor + "." + v.Build + "." + v.Revision;
        dateText = File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString("MMMM dd yyyy");
      } // if
      else
      {
        System.Reflection.AssemblyName assemblyName =
        System.Reflection.Assembly.GetExecutingAssembly().GetName(false);
        int minorVersion = assemblyName.Version.Minor;
        int majorVersion = assemblyName.Version.Major;
        int build = assemblyName.Version.Build;
        int revision = assemblyName.Version.Revision;
        versionText = string.Format("{0}.{1}.{2}.{3}", majorVersion, minorVersion, build, revision);

        FileInfo fi = new FileInfo("ReportGenerator.exe");
        dateText = fi.CreationTime.Date.ToString("MMMM dd yyyy");
      } // else

      using (SplashScreen sp = new SplashScreen(versionText, dateText))
      {
        sp.ShowDialog(waitForClick);
      }
    }

    /// <summary>
    /// Exit tools strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    /// <summary>
    /// Tool bar tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      toolStrip.Visible = toolBarToolStripMenuItem.Checked;
    }

    /// <summary>
    /// Status bar tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      statusStrip.Visible = statusBarToolStripMenuItem.Checked;
    }

    /// <summary>
    /// Cascade tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.Cascade);
    }

    /// <summary>
    /// Tile vertical tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileVertical);
    }

    /// <summary>
    /// Tile horizontal tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileHorizontal);
    }

    /// <summary>
    /// Arrange icons tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.ArrangeIcons);
    }

    /// <summary>
    /// Close all tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (Form childForm in MdiChildren)
      {
        childForm.Close();
      } // foreach  (childForm)
    }

    /// <summary>
    /// Ultra explorer bar 1_ item click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        switch (e.Item.Key)
        {
          case "CreateReport":
            ActivateCreateReportForm();
            break;
          case "ManageModelCatalog":
            ActivateManageModelCatalogForm();
            break;
          case "StatusLog":
            ActivateStatusLog();
            break;
          case "DownloadXmlReader":
            DownloadXmlReader();
          break;
          default:
            return;
        } // switch
        return;
      } // try
      finally
      {
        Cursor = Cursors.Default;
      } // finally
    } // ultraExplorerBar1_ItemClick(sender, e)

    /// <summary>
    /// Activate create report form
    /// </summary>
    private void ActivateCreateReportForm()
    {
      Form childForm;
      // Create a new instance of the child form.
      ListDictionary activeFormList = ActiveFormList();
      if (activeFormList.Contains(typeof(CreateReportForm)))
      {
        childForm = (Form)activeFormList[typeof(CreateReportForm)];
      } // if
      else
      {
        ChangeStatus("Loading CreateReport Form...");
        childForm = new CreateReportForm();
        CreateReportForm rgForm;
        rgForm = (CreateReportForm)childForm;
        rgForm.StatusChanged += OnStatusChanged;
        ChangeStatus("Initializing CreateReport Data...");
        rgForm.InitializeForm();
      } // else
      // Make it a child of this MDI form before showing it.
      childForm.MdiParent = this;
      //childForm.Text = "Window " + childFormNumber++;
      childForm.WindowState = FormWindowState.Maximized;
      childForm.Show();
    }

    private void DownloadXmlReader()
    {
      SaveFileDialog sfdXmlTemplate = new SaveFileDialog();
      sfdXmlTemplate.DefaultExt = "xsl";
      sfdXmlTemplate.FileName = "XMLReportReader";
      sfdXmlTemplate.Filter = "Excel XSL Template (*.xsl)|*.xsl";
      sfdXmlTemplate.AddExtension = true;
      sfdXmlTemplate.RestoreDirectory = true;
      sfdXmlTemplate.Title = "Where do you want to save the file?";
      
      try
      {
        if (sfdXmlTemplate.ShowDialog() == DialogResult.OK)
        {
          string templatePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\xml\\excel_char.xsl";    
          File.Copy(templatePath, sfdXmlTemplate.FileName, true);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("There was a problem saving the XML reader: " + ex.Message, "Error Saving File", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        sfdXmlTemplate.Dispose();
        sfdXmlTemplate = null;
      }
    }
    
    /// <summary>
    /// Activate manage model catalog form
    /// </summary>
    private void ActivateManageModelCatalogForm()
    {
      Form childForm;
      // Create a new instance of the child form.
      ListDictionary activeFormList = ActiveFormList();
      if (activeFormList.Contains(typeof(ModelCatalogMaintForm)))
      {
        childForm = (Form)activeFormList[typeof(ModelCatalogMaintForm)];
      } // if
      else
      {
        childForm = new ModelCatalogMaintForm();
        //ModelCatalogMaintForm mcmForm;
        //mcmForm = (ModelCatalogMaintForm)childForm;
        //mcmForm.StatusChanged += new Utils.Events.OnStatusChangedEventHandler(this.OnStatusChanged);
      } // else
      // Make it a child of this MDI form before showing it.
      childForm.MdiParent = this;
      //childForm.Text = "Window " + childFormNumber++;
      childForm.WindowState = FormWindowState.Maximized;
      childForm.Show();
    }
    /// <summary>
    /// Activate status log
    /// </summary>
    private void ActivateStatusLog()
    {
      // Make it a child of this MDI form before showing it.
      //statusDisplayControl.MdiParent = this;
      //childForm.Text = "Window " + childFormNumber++;
      //statusDisplayControl.WindowState = FormWindowState.Maximized;
      //statusDisplayControl.Show();              
      ultraDockManager1.PaneFromControl(panel1).Activate();
      ultraDockManager1.PaneFromControl(panel1).Closed = false;
      //ultraDockManager1.PaneFromControl(panel1).Pin();


      //this.ultraDockManager1.PaneFromControl(panel1).Activate();

    }
    /// <summary>
    /// Active form list
    /// </summary>
    /// <returns>List dictionary</returns>
    private ListDictionary ActiveFormList()
    {
      ListDictionary activatedForms = new ListDictionary();
      foreach (Form f in MdiChildren)
      {
        activatedForms.Add(f.GetType(), f);
      } // foreach 
      return activatedForms;
    } // ActiveFormList()

    /// <summary>
    /// About tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DoSplash(true);
    }

    /// <summary>
    /// On status changed
    /// </summary>
    /// <param name="e">E</param>
    private void OnStatusChanged(Utils.Events.StatusChangedArgs e)
    {
      toolStripStatusLabel.Text = e.NewStatus;
      statusDisplayControl.AddInfoStatus(e);
      if (e.NewStatusType == SystemsAnalysis.Utils.Events.StatusChangeType.Error)
      {
        ActivateStatusLog();
      }
    }

    /// <summary>
    /// Change status
    /// </summary>
    /// <param name="newStatus">New status</param>
    private void ChangeStatus(string newStatus)
    {
      OnStatusChanged(new SystemsAnalysis.Utils.Events.StatusChangedArgs(newStatus));
    }

    /// <summary>
    /// Create report tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void createReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ActivateCreateReportForm();
    }

    /// <summary>
    /// Manage model catalog tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void manageModelCatalogToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ActivateManageModelCatalogForm();
    }

    /// <summary>
    /// Show log tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ActivateStatusLog();
    }

    /// <summary>
    /// Status strip _ item clicked
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      ActivateStatusLog();
    }

    /// <summary>
    /// Online help tool strip menu item _ click
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">E</param>
    private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("http://twiki.bes-sa.org/bin/view/Modeling/ReportGenerator");
    }

    private void ApplicationInterface_Load(object sender, EventArgs e)
    {

    }

    private void downloadEmdToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfdDownloadEmd = new SaveFileDialog();
      sfdDownloadEmd.DefaultExt = "doc";
      sfdDownloadEmd.FileName = "EMD094";
      sfdDownloadEmd.Filter = "Word Document (*.doc)|*.doc";
      sfdDownloadEmd.AddExtension = true;
      sfdDownloadEmd.RestoreDirectory = true;
      sfdDownloadEmd.Title = "Where do you want to save the file?";

      try
      {
        if (sfdDownloadEmd.ShowDialog() == DialogResult.OK)
        {
          string templatePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\doc\\EMD094.doc";
          File.Copy(templatePath, sfdDownloadEmd.FileName, true);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("There was a problem saving the EMD: " + ex.Message, "Error Saving File", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        sfdDownloadEmd.Dispose();
        sfdDownloadEmd = null;
      }
    }
  }
}
