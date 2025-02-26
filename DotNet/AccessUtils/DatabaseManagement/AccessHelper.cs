﻿using System;
using System.Collections;
using System.Collections.Generic;
using Access = Microsoft.Office.Interop.Access;
using dao = Microsoft.Office.Interop.Access.Dao;
using System.Reflection;

//using Microsoft.Office.Interop.Access.Dao;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Text;
using System.Management;
using System.Security.AccessControl;

namespace SystemsAnalysis.Utils.AccessUtils
{
  /// <summary>
  /// Provides a wrapper class around an instance of Microsoft Access. This class
  /// should shield any calling classes from DAO calls, COM Interop and Tracking the MS Access executable.
  /// Publicly accessible members within this class should not return any MS Access or DAO 
  /// objects, rather only primitives and .NET standard objects (List, DatTime, etc).
  /// </summary>
  public class AccessHelper : IDisposable
  {
    private Access.Application accessApp;
    private bool disposed;
    private DateTime startTime;
    private Microsoft.Office.Interop.Access.Dao.Database CurrentDB;
    //private SqlConnection CurrentSQLDB;

    public static void CreateNewMdb(string database)
    {
      Assembly ass = Assembly.GetExecutingAssembly();
      System.IO.Stream stream = ass.GetManifestResourceStream("SystemsAnalysis.Utils.AccessUtils._empty.mdb");
      System.IO.Stream output = new FileStream(database, FileMode.Create);

      byte[] buffer = new byte[32 * 1024];
      int read;

      while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
      {
        output.Write(buffer, 0, read);
      }

      output.Close();
    }

    /// <summary>
    /// Creates a new AccessHelper for manipulating the specified database.
    /// The database must be opened exclusively (this may be conservative,
    /// could refactor to allow shared access).
    /// </summary>
    /// <param name="databaseName">The fully qualifed path to an existing
    /// Access database.  </param>
    public AccessHelper(string databaseName)
    {
      //force shutdown of access before we try to open a new instance of ms Access
      //This is necessary because if we are doing many many runs, eventually
      //access will fail to close completely (managed code doesn't always
      //implement a destructor completely).
      startTime = System.DateTime.Now;
      accessApp = ShellGetDB(databaseName, 2000);
      //accessApp = new Access.Application();
      CurrentDB = accessApp.CurrentDb();

      disposed = false;
    }

    public AccessHelper(string databaseName, string SQLDatabaseName)
    {
      //force shutdown of access before we try to open a new instance of ms Access
      //This is necessary because if we are doing many many runs, eventually
      //access will fail to close completely (managed code doesn't always
      //implement a destructor completely).
      startTime = System.DateTime.Now;
      accessApp = ShellGetDB(databaseName, 2000);
      //accessApp = new Access.Application();
      CurrentDB = this.accessApp.CurrentDb();

      disposed = false;
    }

    public AccessHelper()
    {
      //force shutdown of access before we try to open a new instance of ms Access
      //This is necessary because if we are doing many many runs, eventually
      //access will fail to close completely (managed code doesn't always
      //implement a destructor completely).
      startTime = System.DateTime.Now;
      //accessApp = ShellGetDB(databaseName, 2000);
      //accessApp = new Access.Application();
      CurrentDB = null;

      disposed = false;
    }


    /// <summary>
    /// Links a single table in the specified Access database. The table will first be 
    /// deleted if it already exists. The linked table will have the same name as the
    /// source table.
    /// </summary>
    /// <param name="tableName">The name of the table in the source database</param>
    /// <param name="sourceDatabase">The full path of an Access Database containing the table to link</param>
    public void LinkTable(string tableName, string sourceDatabase)
    {
      LinkTable(tableName, sourceDatabase, tableName);
    }

    /// <summary>
    /// Links a single table in the specified Access database. The table will first be 
    /// deleted if it already exists. The linked table will have the same name as the
    /// source table.
    /// </summary>
    /// <param name="tableName">The name of the table in the source database</param>
    /// <param name="sourceDatabase">The full path of an Access Database containing the table to link</param>
    /// <param name="linkName">The name of the linked table</param>
    public void LinkTable(string tableName, string sourceDatabase, string linkName)
    {
      if (TableExists(linkName))
      {
        DeleteTable(linkName);
      }

      dao.TableDef linkTable;
      linkTable = CurrentDB.CreateTableDef(linkName, Type.Missing, Type.Missing, Type.Missing);
      linkTable.Connect = ";DATABASE=" + sourceDatabase;
      linkTable.SourceTableName = tableName;
      CurrentDB.TableDefs.Append(linkTable);
    }
    public static void AccessDropTable(string AccessTableName, string outputDatabase)
    {
      string linkTableConnection = outputDatabase;
      //linkTable.SourceTableName = tableName;
      dao.DBEngine dbEng = new dao.DBEngine();
      dao.Workspace ws = dbEng.CreateWorkspace("", "admin", "", dao.WorkspaceTypeEnum.dbUseJet);
      dao.Database db = ws.OpenDatabase(outputDatabase, true, false, "");

      //get rid of the table if it already exists in access
      try
      {
        db.Execute("DROP TABLE " + AccessTableName, Type.Missing);
      }
      catch (Exception ex)
      {
        //table doesnt exist
      }

      db.Close();
      ws.Close();
    }

    public static void AccessDropQuery(string AccessQueryName, string outputDatabase)
    {
      string linkTableConnection = outputDatabase;
      //linkTable.SourceTableName = tableName;
      dao.DBEngine dbEng = new dao.DBEngine();
      dao.Workspace ws = dbEng.CreateWorkspace("", "admin", "", dao.WorkspaceTypeEnum.dbUseJet);
      dao.Database db = ws.OpenDatabase(outputDatabase, true, false, "");

      //get rid of the table if it already exists in access
      try
      {
        db.DeleteQueryDef(AccessQueryName);
      }
      catch (Exception ex)
      {
        //table doesnt exist
      }

      db.Close();
      ws.Close();
    }

    public static void AccessCopyTable(string CopiedTableName, string OriginalTableName, string outputDatabase)
    {
      string linkTableConnection = outputDatabase;
      //linkTable.SourceTableName = tableName;
      dao.DBEngine dbEng = new dao.DBEngine();
      dao.Workspace ws = dbEng.CreateWorkspace("", "admin", "", dao.WorkspaceTypeEnum.dbUseJet);
      dao.Database db = ws.OpenDatabase(outputDatabase, true, false, "");

      //get rid of the table if it already exists in access
      try
      {
        db.Execute("DROP TABLE " + CopiedTableName, Type.Missing);
      }
      catch (Exception ex)
      {
        //table doesn't exist
      }

      try
      {
        db.Execute("SELECT * INTO " + CopiedTableName + " FROM " + OriginalTableName, Type.Missing);
      }
      catch (Exception ex)
      {
        //table doesn't exist
      }

      db.Close();
      ws.Close();
    }

    /// <summary>
    /// Checks to see if a table exists.
    /// </summary>
    /// <param name="databaseName">The full path to an Access Database</param>
    /// <param name="tableName">The table to check for existence</param>
    /// <returns>True is tableName exists in databaseName, otherwise false</returns>
    public bool TableExists(string tableName)
    {
      return GetTableDef(tableName) != null;
    }
    /// <summary>
    /// Returns a TableDef that matches the provided table name.
    /// </summary>
    /// <param name="tableName">The name of the table to find</param>
    /// <returns>A TableDef in the current database matching table name,
    /// or null if no table is found  </returns>
    private dao.TableDef GetTableDef(string tableName)
    {
      dao.TableDefs tableDefs = CurrentDB.TableDefs;

      for (int i = 0; i < tableDefs.Count; i++)
      {
        dao.TableDef tableDef = tableDefs[i];
        if (tableDef.Name.ToUpper() == tableName.ToUpper())
        {
          return tableDef;
        }
      }
      return null;
    }

    /// <summary>
    /// Returns a QueryDef that matches the provided query name.
    /// </summary>
    /// <param name="queryName">The name of the query to find</param>
    /// <returns>A QueryDef in the current database matching query name,
    /// or null if no query is found  </returns>
    private dao.QueryDef GetQueryDef(string queryName)
    {
      dao.QueryDefs queryDefs = CurrentDB.QueryDefs;

      for (int i = 0; i < queryDefs.Count; i++)
      {
        dao.QueryDef queryDef = queryDefs[i];
        if (queryName.ToUpper() == queryDef.Name.ToUpper())
        {
          return queryDef;
        }
      }
      return null;
    }

    /// <summary>
    /// Deletes the specified table from the current database, if it exists.
    /// </summary>
    /// <param name="tableName">The name of the table to delete</param>
    public void DeleteTable(string tableName)
    {
      if (TableExists(tableName))
      {
        CurrentDB.TableDefs.Delete(tableName);
      }
    }

    /// <summary>
    /// Executes a paremeterless macro within the current database.
    /// </summary>
    /// <param name="macroName">The name of the macro to execute</param>
    public void ExecuteMacro(string macroName)
    {
      accessApp.DoCmd.RunMacro(macroName, Type.Missing, Type.Missing);
    }

    /// <summary>
    /// The name of a query to create in a database.
    /// The name of the database to create the query in
    /// </summary>
    /// <param name="queryName">The name of the query to create</param>
    /// <param name="queryText">An SQL statement to store in a query in the database</param>
    /// <param name="DatabaseName">The location of the access database in which to place the query</param>
    public static void AccessCreateQuery(string queryName, string queryText, string accessDBLocation)
    {
      //delete the query, if it already exists
      AccessDropQuery(queryName, accessDBLocation);

      dao.DBEngine dbEng = new dao.DBEngine();
      dao.Workspace ws = dbEng.CreateWorkspace("", "admin", "", dao.WorkspaceTypeEnum.dbUseJet);
      dao.Database db = ws.OpenDatabase(accessDBLocation, true, false, "");

      try
      {
        db.CreateQueryDef(queryName, queryText);
      }
      catch (Exception ex)
      {
        //
      }

      db.Close();
      ws.Close();
    }

    /// <summary>
    /// The name of a query to create in the current database.
    /// </summary>
    /// <param name="queryName">The name of the query to create</param>
    /// <param name="queryText">An SQL statement to store in a query in the 
    /// current database  </param>
    public void CreateQuery(string queryName, string queryText)
    {
      DeleteQuery(queryName);
      CurrentDB.CreateQueryDef(queryName, queryText);
    }

    /// <summary>
    /// Deletes a query from the current database.
    /// </summary>
    /// <param name="queryName">The name of the query to delete</param>
    public void DeleteQuery(string queryName)
    {
      if (GetQueryDef(queryName) != null)
      {
        CurrentDB.QueryDefs.Delete(queryName);
      }
      return;
    }

    /// <summary>
    /// Executes an action query in the current database.
    /// </summary>
    /// <param name="queryName">The name of the action query to execute</param>
    public void ExecuteActionQuery(string queryName)
    {
      dao.QueryDef queryDef;
      queryDef = GetQueryDef(queryName);
      queryDef.Execute(null);
    }

    /// <summary>
    /// Executes an action query in the provided database
    /// </summary>
    /// <param name="queryName">The name of the action query to execute</param>
    /// <param name="accessDBLocation">The location of the database in which to execute the action query</param>
    public static void AccessExecuteActionQuery(string queryName, string accessDBLocation)
    {
        dao.DBEngine dbEng = new dao.DBEngine();
        dao.Workspace ws = dbEng.CreateWorkspace("", "admin", "", dao.WorkspaceTypeEnum.dbUseJet);
      dao.Database db = ws.OpenDatabase(accessDBLocation, true, false, "");

      try
      {
        dao.QueryDef queryDef = null;

        dao.QueryDefs queryDefs = db.QueryDefs;

        for (int i = 0; i < queryDefs.Count; i++)
        {
          dao.QueryDef queryDefMatch = queryDefs[i];
          if (queryName.ToUpper() == queryDefMatch.Name.ToUpper())
          {
            queryDef = queryDefMatch;
          }
        }

        queryDef.Execute(null);
      }
      catch (Exception ex)
      {
        //
      }

      db.Close();
      ws.Close();
    }

    /// <summary>
    /// translates a CSV file to an access file for MapInfo consumption
    /// </summary>
    /// <param name="CSVFilePath">The full path to the CSV file</param>
    /// <param name="AccessOutputPath">The full path of the method's output</param>
    /// <param name="AccessOutputTableName">The intended name of the Access table to be created</param>
    public void ImportTable(string fileName, string tableName, FileType importType)
    {
      //Transfer the data from the csv file to the new Access Database
      //TransferText will have an exception for improper file names.
      if (IsBadFileName(fileName))
        throw new Exception("Bad file name: " + fileName);
      else
        this.accessApp.DoCmd.TransferText(Microsoft.Office.Interop.Access.AcTextTransferType.acImportDelim, Type.Missing, tableName, fileName, true, Type.Missing, Type.Missing);
    }

    /// <summary>
    /// IsBadFileName should be used when importing a .csv file to
    /// access.  Access normally will have trouble with long file names.
    /// </summary>
    /// <param name="fileName">The name of the file (full path inclusive).</param>
    /// <returns>True for file names greater than 60 characters.  False otherwise.</returns>
    private bool IsBadFileName(string fileName)
    {
      string shortFileName;
      bool returnValue = false;

      shortFileName = System.IO.Path.GetFileName(fileName);
      if (shortFileName.Length > 60)
        returnValue = true;

      return returnValue;
    }

    /// <summary>
    /// AppendTable is a simple process for appending one access table to another
    /// access table.  Both tables must belong to the same database.
    /// </summary>
    /// <param name="sourceTable">The contents of the source table will be copied and added to the
    /// destination table.  The source table will remain fully populated after the process.  </param>
    /// <param name="destinationTable">The destination table will retain the original values
    /// as well as a copy of the records in the sourceTable.  It is recommended that the
    /// function which calls AppendTable first checks that the two tables are compatible.  </param>
    public void AppendTable(string sourceTable, string destinationTable)
    {
      CurrentDB.Execute("INSERT INTO " + destinationTable + " SELECT * FROM " + sourceTable, Type.Missing);

      //CreateQuery("AppendTableQuery", );            
      //ExecuteActionQuery("AppendTableQuery");
      //DeleteQuery("AppendTableQuery");
      //DeleteTable("_" + tableName);
    }

    /// <summary>
    /// This function will check table schemas of two different tables to see if they match.
    /// The schemas will match only if both tables have the same number of fields, both 
    /// table's fields have the same names, and both table's fields use the same datatype.
    /// Some leeway may be required in fields such as TEXT, but those are special cases
    /// that should be accomodated and adjusted for before this function is called.
    /// </summary>
    /// <param name="tableA">Table A is one of two tables to check for schema compatibility.</param>
    /// <param name="tableB">Table B is one of two tables to check for schema compatibility.</param>
    /// <returns>Returns boolean fieldsMatch, which is false if the fields do not match, and 
    /// true if the fields do match.  </returns>
    public bool SchemasMatch(string tableA, string tableB)
    {
      int namesMatch = 0;
      int numCols = 0;
      string fieldName = "";
      bool fieldsMatch = true;
      //number of fields must match
      if (CurrentDB.TableDefs[tableA].Fields.Count == CurrentDB.TableDefs[tableB].Fields.Count)
      {
        numCols = CurrentDB.TableDefs[tableA].Fields.Count;
        //names of fields must match
        for (int i = 0; i < numCols; i++)
        {
          for (int j = 0; j < numCols; j++)
          {
            if (string.Compare(CurrentDB.TableDefs[tableA].Fields[i].Name, CurrentDB.TableDefs[tableB].Fields[j].Name) == 0)
            {
              namesMatch++;
            }
          }
        }

        if (namesMatch == numCols)
        {
          //Types of fields must match
          for (int i = 0; i < numCols; i++)
          {
            fieldName = CurrentDB.TableDefs[tableA].Fields[i].Name;
            if (CurrentDB.TableDefs[tableA].Fields[fieldName].Type.CompareTo(CurrentDB.TableDefs[tableB].Fields[fieldName].Type) != 0)
            {
              fieldsMatch = false;
            }
          }
        }
        else
        {
          fieldsMatch = false;
        }
      }

      //types of fields must match
      return fieldsMatch;
    }

    /// <summary>
    /// Exports the contents of a query to an output file in the specified format. Note: Only 
    /// .csv file type is implemented.
    /// </summary>
    /// <param name="queryName">The name of the query in the current database to export</param>
    /// <param name="outputFile">The file contents of the table should be exported to</param>
    /// <param name="exportType">The type of file to write to; .csv file is the only implemented
    /// type at this time, although .xml file should be implemented  </param>
    public void ExportQuery(string queryName, string outputFile, FileType exportType)
    {
      StreamWriter streamWriter;

      try
      {
        if (File.Exists(outputFile))
        {
          File.Delete(outputFile);
        }
        streamWriter = new StreamWriter(outputFile);
      }
      catch (Exception ex)
      {
        throw new Exception("Could not create file ' " + outputFile + "': " + ex.Message);
      }

      try
      {
        dao.QueryDef queryDef;
        queryDef = GetQueryDef(queryName);
        if (queryDef == null)
        {
          throw new Exception("Query " + queryName + " not found");
        }
        dao.Recordset recordSet;
        recordSet = queryDef.OpenRecordset(Type.Missing, Type.Missing, Type.Missing);
        while (recordSet.NextRecordset())
        {
          dao.Fields fields = recordSet.Fields;
          for (int i = 0; i < fields.Count; i++)
          {
            streamWriter.Write((string)fields[i].Value);
            streamWriter.Write(", ");
          }
          streamWriter.WriteLine(fields[fields.Count]);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Could not write ' " + outputFile + "': " + ex.Message);
      }
      finally
      {
        streamWriter.Close();
      }
      return;
    }

    /// <summary>
    /// Exports the contents of a table to an output file in the specified format. Note: Only 
    /// .csv file type is implemented.
    /// </summary>
    /// <param name="tableName">The name of the table in the current database to export</param>
    /// <param name="outputFile">The file contents of the table should be exported to</param>
    /// <param name="exportType">The type of file to write to; .csv file is the only implemented
    /// type at this time, although .xml file should be implemented  </param>
    public void ExportTable(string tableName, string outputFile, FileType exportType)
    {
      accessApp.DoCmd.TransferText(Microsoft.Office.Interop.Access.AcTextTransferType.acExportDelim,
      Type.Missing, tableName, outputFile, true, Type.Missing, Type.Missing);
      return;
    }

    /// <summary>
    /// Writes a value to a field in a key/value table.
    /// </summary>
    /// <param name="tableName">The name of the table to write to.</param>
    /// <param name="keyField">The field containing the key that indentifies the record to be modified</param>
    /// <param name="key">The key indicating the record to be updated</param>
    /// <param name="valueField">The field containing the value that should be modified</param>
    /// <param name="value">The new value to be placed in the value field</param>
    public void WriteKeyValueTable(string tableName, string keyField, string key, string valueField, object value)
    {
      dao.TableDef keyValueTable;
      keyValueTable = GetTableDef(tableName);
      dao.Recordset rs = keyValueTable.OpenRecordset(Type.Missing, Type.Missing);

      if (FindField(rs, keyField) == null)
      {
        throw new Exception("UpdateKeyValueTable Exception: Key Field '" + keyField + "' not found.");
      }
      if (FindField(rs, valueField) == null)
      {
        throw new Exception("UpdateKeyValueTable Exception: Value Field '" + valueField + "' not found.");
      }

      rs.MoveFirst();
      while (!rs.EOF)
      {
        if (((string)rs.Fields[keyField].ToString()).ToUpper() == key.ToUpper())
        {
          rs.Edit();
          rs.Fields[valueField].Value = value;
          rs.Update(1, false);
          return;
        }
        rs.MoveNext();
      }
      throw new Exception("UpdateKeyValueTable Exception: Key '" + key + "' not found.");
    }

    /// <summary>
    /// Returns a Field in the specified Recordset matching the provided field name.
    /// </summary>
    /// <param name="rs">The Recordset containing the field to be located</param>
    /// <param name="fieldName">The name of the field to be found</param>
    /// <returns>The field in the provided recordset that matches the provided field name, or null if the
    /// field is not found  </returns>
    private dao.Field FindField(dao.Recordset rs, string fieldName)
    {
      rs.MoveFirst();
      for (int i = 0; i < rs.Fields.Count; i++)
      {
        dao.Field field;
        field = rs.Fields[i];
        if (field.Name.ToUpper() == fieldName.ToUpper())
        {
          return field;
        }
      }
      return null;
    }

    /// <summary>
    /// Enumerated type indicating file format to use when exporting or importing data.
    /// When adding new Types to this enum, please assign an integer value.
    /// </summary>
    public enum FileType
    {
      CSV = 1
    }
    /// <summary>
    /// Enumerated type indicating field format for access, csv, excel, etc.
    /// When adding new Types to this enum, please assign an integer value.
    /// </summary>
    public enum FieldType
    {
      //String should apply to text, string or char types.  Access
      //will differentiate between the three, but excel and csv
      //will simply consider them all strings.
      STRING = 1
    }

    #region IDisposable Members
    /// <summary>
    /// Releases unmanaged resources (particularly, will kill MSAccess.exe).
    /// Should be called manually since GC does not occur deterministically.
    /// </summary>
    public void Dispose()
    {
      if (this.disposed)
      {
        return;
      }

      try
      {
        if (accessApp.CurrentDb() != null)
        {
          accessApp.CurrentDb().Close();
        }
        System.Runtime.InteropServices.Marshal.ReleaseComObject(accessApp.CurrentDb());
      }
      catch
      {
      }

      try
      {
        //HACK: Access does not get disposed of properly - After GarbageCollection has
        //occured, MSACCESS.EXE continues to run independently of the process that created it.
        //The following code finds the Access Process and kills it.
        System.Diagnostics.Process[] proc;
        System.Diagnostics.Process killProc = null;
        proc = System.Diagnostics.Process.GetProcesses();

        TimeSpan deltaStart = System.TimeSpan.MaxValue;
        foreach (System.Diagnostics.Process p in proc)
        {
          int mainWindowHandle;
          mainWindowHandle = (int)p.MainWindowHandle;
          if (p.ProcessName == "MSACCESS")
          {
            TimeSpan newDeltaStart;
            newDeltaStart = startTime.Subtract(p.StartTime);

            if (Math.Abs(newDeltaStart.Ticks) < Math.Abs(deltaStart.Ticks))
            {
              deltaStart = newDeltaStart;
              killProc = p;
            }
          }
        }
        if (Math.Abs(deltaStart.Seconds) < 5 && killProc != null)
        {
          killProc.Kill();
        }
        System.Runtime.InteropServices.Marshal.ReleaseComObject(accessApp);
      }
      catch
      {
      }

      accessApp = null;
      this.disposed = true;
    }

    /// <summary>
    /// Destructor, called automatically when this instance is Garbage Collected
    /// </summary>
    ~AccessHelper()
    {
      //Release unmanaged resources
      this.Dispose();
    }

    #endregion

    #region Code taken from: "How to automate Microsoft Access by using Visual C#" http://support.microsoft.com/kb/317114
    private Access.Application ShellGetDB(string sDBPath, int iSleepTime)
    {
      //Launches a new instance of Access with a database (sDBPath)
      //using System.Diagnostics.Process.Start. Then, returns the
      //Application object via calling: BindToMoniker(sDBPath). Returns
      //the Application object of the new instance of Access, assuming that
      //sDBPath is not already opened in another instance of Access. To
      //ensure the Application object of the new instance is returned, make
      //sure sDBPath is not already opened in another instance of Access
      //before calling this function.
      // 
      //Example:
      //Access.Application oAccess = null;
      //oAccess = ShellGetDB("c:\\mydb.mdb", null,
      //  ProcessWindowStyle.Minimized, 1000);
      Access.Application oAccess = null;
      string sAccPath = null; //path to msaccess.exe
      string sCmdLine = null;
      System.Diagnostics.Process p = null;
      System.Diagnostics.ProcessWindowStyle enumWindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

      // Enable exception handler:
      try
      {
        // Obtain the path to msaccess.exe:
        sAccPath = GetOfficeAppPath("Access.Application", "msaccess.exe") + "\"";
        if (sAccPath == null)
        {
          throw new Exception("AccessHelper can't determine path to msaccess.exe");
        }

        // Make sure specified database (sDBPath) exists:
        if (!System.IO.File.Exists(sDBPath))
        {
          throw new Exception("AccessHelper can't find the file '" + sDBPath + "'");
        }

        // Start a new instance of Access passing sDBPath and sCmdLine:
        if (sCmdLine == null)
          sCmdLine = @"""" + sDBPath + @"""";
        else
          sCmdLine = @"""" + sDBPath + @"""" + " " + sCmdLine;
        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        startInfo.FileName = sAccPath;
        startInfo.Arguments = sCmdLine;
        startInfo.WindowStyle = enumWindowStyle;
        p = System.Diagnostics.Process.Start(startInfo);
        p.WaitForInputIdle(60000); //max 1 minute wait for idle input state

        // Move focus back to this form. This ensures that Access
        // registers itself in the ROT:
        //this.Activate();

        // Pause before trying to get Application object:
        System.Threading.Thread.Sleep(iSleepTime);

        // Obtain Application object of the instance of Access
        // that has the database open:
        oAccess = (Access.Application)System.Runtime.InteropServices.Marshal.BindToMoniker(sDBPath);
        return oAccess;
      }
      catch (Exception ex)
      {
        // Try to quit Access due to an unexpected error:
        try // use try..catch in case oAccess is not set
        {
          oAccess.Quit(Access.AcQuitOption.acQuitSaveNone);
        }
        finally
        {
          oAccess = null;
          throw ex;
        }
      }
    }
    private string GetOfficeAppPath(string sProgId, string sEXE)
    {
      //Returns path of the Office application. e.g.
      //GetOfficeAppPath("Access.Application", "msaccess.exe") returns
      //full path to Microsoft Access. Approach based on Q240794.
      //Returns null if path not found in registry.

      // Enable exception handler:
      try
      {
        Microsoft.Win32.RegistryKey oReg =
        Microsoft.Win32.Registry.LocalMachine;
        Microsoft.Win32.RegistryKey oKey = null;
        string sCLSID = null;
        string sPath = null;
        int iPos = 0;

        // First, get the clsid from the progid from the registry key
        // HKEY_LOCAL_MACHINE\Software\Classes\<PROGID>\CLSID:
        oKey = oReg.OpenSubKey(@"Software\Classes\" + sProgId + @"\CLSID");
        sCLSID = oKey.GetValue("").ToString();
        oKey.Close();

        // Now that we have the CLSID, locate the server path at
        // HKEY_LOCAL_MACHINE\Software\Classes\CLSID\ 
        // {xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxx}\LocalServer32:
        if (Is64BitOS())
        {
          oKey = oReg.OpenSubKey(@"Software\Classes\Wow6432Node\CLSID\" + sCLSID +
         @"\LocalServer32");
        }
        else
        {
          oKey = oReg.OpenSubKey(@"Software\Classes\CLSID\" + sCLSID +
          @"\LocalServer32");
        }
        sPath = oKey.GetValue("").ToString();
        oKey.Close();

        // Remove any characters beyond the exe name:
        iPos = sPath.ToUpper().IndexOf(sEXE.ToUpper()); // 0-based position
        sPath = sPath.Substring(0, iPos + sEXE.Length);
        return sPath.Trim();
      }
      catch
      {
        return null;
      }
    }
    #endregion

    public bool Is64BitOS()
    {
      if (IntPtr.Size == 8)
        return true;
      else
        return false;
    }

    public void AddField(string tableName, string fieldName, FieldType fieldType)
    {
      string fieldTypeToString = "";
      switch ((FieldType)fieldType)
      {
        case (FieldType.STRING):
          fieldTypeToString = "TEXT(128)";
          break;
        default:
          throw new Exception("Field type not implemented");
      }
      //Check if the new field exists 
      if (FieldNameExists(tableName, fieldName, fieldType) == true)
      {
        throw new Exception("Bad field name or type \n Name : " + fieldName + "\n Type : " + fieldTypeToString + "\n");
      }
      else
      {
        CurrentDB.Execute("ALTER TABLE " + tableName + " ADD COLUMN " + fieldName + " " + fieldTypeToString + ";", Type.Missing);
      }
    }

    /// <summary>
    /// FieldNameExists is meant to be called before adding a new field to a 
    /// table.  This function will return true if the table already contains a
    /// field with the proposed field name.
    /// </summary>
    /// <param name="tableName">The table to check for the field name</param>
    /// <param name="fieldName">The name of the field to look for</param>
    /// <param name="fieldType">Unused.  Symmetry</param>
    /// <returns>Returns boolean true if the table already contains a field
    /// with the proposed field name, false otherwise.  </returns>
    public bool FieldNameExists(string tableName, string fieldName, FieldType fieldType)
    {
      dao.TableDef tbl;
      bool returnValue = false;

      tbl = GetTableDef(tableName);
      foreach (dao.Field fld in tbl.Fields)
      {
        if (fld.Name == fieldName)
        {
          returnValue = true;
        }
      }

      return returnValue;
    }
    /// <summary>
    /// FieldTypeMatches checks to see if the field in question has a
    /// field type that is expected.
    /// </summary>
    /// <param name="tableName">The table to check for the field type</param>
    /// <param name="fieldName">The name of the field to check</param>
    /// <param name="fieldType">The type expected</param>
    /// <returns>Returns true if the field has a matching field type, false otherwise.</returns>
    public bool FieldTypeMatches(string tableName, string fieldName, FieldType fieldType)
    {
      dao.TableDef tbl = GetTableDef(tableName);
      dao.Field fld = tbl.Fields[fieldName];
      bool fieldTypeMatches = false;

      switch ((FieldType)fieldType)
      {
        case (FieldType.STRING):
          fieldTypeMatches = (dao.DataTypeEnum)fld.Type == dao.DataTypeEnum.dbText;
          break;
        default:
          throw new Exception("Field type not implemented");
      }
      return fieldTypeMatches;
    }

    public void UpdateField(string tableName, string fieldName, object value)
    {
      CurrentDB.Execute("UPDATE " + tableName + " SET " + fieldName + " = '" + value.ToString() + "';", Type.Missing);
    }

    public Dictionary<string, object> ExecuteAggregateQuery(string queryName)
    {
      dao.QueryDef queryDef;
      queryDef = this.GetQueryDef(queryName);
      Dictionary<string, object> aggregateQueryResults;
      aggregateQueryResults = new Dictionary<string, object>();

      dao.Recordset recordSet;
      recordSet = queryDef.OpenRecordset(Type.Missing, Type.Missing, Type.Missing);

      dao.Fields fields = recordSet.Fields;
      for (int i = 0; i < fields.Count; i++)
      {
        aggregateQueryResults.Add(fields[i].Name, fields[i].Value);
      }
      return aggregateQueryResults;
    }

    public Dictionary<string, double> ExecuteAggregateQueryDoubles(string queryName)
    {
      dao.QueryDef queryDef;
      queryDef = this.GetQueryDef(queryName);
      Dictionary<string, double> aggregateQueryResults;
      aggregateQueryResults = new Dictionary<string, double>();

      dao.Recordset recordSet;
      recordSet = queryDef.OpenRecordset(Type.Missing, Type.Missing, Type.Missing);

      dao.Fields fields = recordSet.Fields;
      for (int i = 0; i < fields.Count; i++)
      {
        if (!Convert.IsDBNull(fields[i].Value))
        {
          aggregateQueryResults.Add(fields[i].Name, (double)fields[i].Value);
        }
        else
        {
          aggregateQueryResults.Add(fields[i].Name, (double)0);
        }
      }
      return aggregateQueryResults;
    }
  }
}
