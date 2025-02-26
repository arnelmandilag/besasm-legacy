using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SystemsAnalysis.ModelConstruction;
using SystemsAnalysis.Utils.AccessUtils;
using SystemsAnalysis.Utils.Events;

namespace SystemsAnalysis.ModelConstruction
{
  /// <summary>
  /// Intended to serve as the entry point for building EMGAATS models in .NET.
  /// </summary>
  public static class ModelBuilder
  {
    /// <summary>
    /// Relinks all linked tables in a model's required Access Databases.
    /// </summary>
    public static void RelinkModel(string modelRoot)
    {
      ModelConfigurationDataSet modelConfigDS;
      modelConfigDS = new ModelConfigurationDataSet(modelRoot);

      AccessHelper accessHelper;// = new AccessHelper();

      Dictionary<string, string> databases;
      databases = modelConfigDS.GetRequiredDatabases();

      foreach (string dbName in databases.Keys)
      {
        accessHelper = new AccessHelper(databases[dbName]);

        Dictionary<string, string> linkedTableSources;
        linkedTableSources = modelConfigDS.GetLinkedTableSources(dbName);

        foreach (string table in linkedTableSources.Keys)
        {
          accessHelper.LinkTable(table, linkedTableSources[table]);
        }
      }
    }

    /// <summary>
    /// Relinks all tables in DataAccess.mdb to point relative to modelPath. Exception will be thrown if a linked file is missing.
    /// </summary>
    public static void RefreshDataAccess(string modelRoot)
    {
      RefreshDataAccess(modelRoot, false);      
    }

    /// <summary>
    /// Relinks all tables in DataAccess.mdb to point relative to modelPath. Exception will optionally be thrown if a linked file is missing.
    /// </summary>    
    public static void RefreshDataAccess(string modelRoot, bool allowMissingLinks)
    {
      modelRoot += modelRoot.EndsWith("\\") ? "" : "\\";

      ModelConfigurationDataSet modelConfigDS;
      modelConfigDS = new ModelConfigurationDataSet(modelRoot);

      AccessHelper accessHelper;// = new AccessHelper();

      try
      {
        string dataAccessFileName = modelConfigDS.GetDataAccessFileName();
        Dictionary<string, string[]> dataAccessTables;
        dataAccessTables = modelConfigDS.GetDataAccessTables();

        accessHelper = new AccessHelper(modelRoot + dataAccessFileName);

        foreach (string linkName in dataAccessTables.Keys)
        {
          string tableName = dataAccessTables[linkName][0];
          string databasePath = modelRoot + dataAccessTables[linkName][1];

          try
          {
            accessHelper.LinkTable(tableName, databasePath, linkName);
          }
          catch (Exception ex)
          {
            if (!allowMissingLinks || !(ex.Message.Contains("Could not find file") || ex.Message.Contains("not a valid path")))
            {
              throw new Exception("Failed to relink table '" + tableName + "': " + ex.Message);
            }
          }
        }
        accessHelper.Dispose();
      }
      catch (Exception ex)
      {
        throw new Exception("Could not refresh the DataAccess tables.", ex);
      }
      finally
      {
        accessHelper = null;
      }
    }


  }


}
