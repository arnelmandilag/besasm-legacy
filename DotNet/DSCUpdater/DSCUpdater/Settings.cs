﻿namespace DSCUpdater.Properties {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings {
        
        public Settings() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Add code to handle the SettingsSaving event here.
        }

        public string SetDscEditorConnectionString
        {
          set
          {
            this["DscEditorConnectionString"] = value;
          }
        }

        public string SetMasterDataConnectionString
        {
          set
          {
            this["MasterDataConnectionString"] = value;
          }
        }

        public string SetFfeDataConnectionString
        {
          set
          {
            this["FfeDataConnectionString"] = value;
          }
        }

        public string DscUpdateFile
        {
          get
          {
            System.Data.Common.DbConnectionStringBuilder csb;
            csb = new System.Data.Common.DbConnectionStringBuilder();

            csb.ConnectionString = DscUpdateConnectionString;// (string)this["DscUpdateConnectionString"];
            string dataDirectory;
            if (System.AppDomain.CurrentDomain.GetData("DataDirectory") == null)
            {
              dataDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            }
            else
            {
              dataDirectory = (string)System.AppDomain.CurrentDomain.GetData("DataDirectory");
            }

            csb.ConnectionString = csb.ConnectionString.Replace(
              "|DataDirectory|", dataDirectory);
            return System.IO.Path.GetFullPath((string)csb["Data Source"]) + "\\UserUpdate.csv";            
          }
        }     
    }
}
