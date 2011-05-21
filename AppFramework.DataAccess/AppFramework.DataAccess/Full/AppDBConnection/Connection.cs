using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AppFramework.DataAccess.Full.DBDataTable;
using AppFramework.DataAccess.Full.DBSQLCommand;
using AppFramework.DataAccess.Full.DBScalarResult;

namespace AppFramework.DataAccess.Full.AppDBConnection
{
    public class Connection
    {
        protected ConnectionInfo oConnInfo;

        public string SQL { get; set; }
        public int DefaultTimeout { get; set; }

        public Connection(string ConnString)
        {
            oConnInfo = new ConnectionInfo(ConnString);
            DefaultTimeout = 60;
        }

        public Connection(string ConnString, string DB)
        {
            oConnInfo = new ConnectionInfo(ConnString, DB);
            DefaultTimeout = 60;
        }

        public Connection(string DB, string User, string Password, string DataSourceName)
        {
            oConnInfo = new ConnectionInfo(User, Password, DB, DataSourceName);
            DefaultTimeout = 60;
        }

        #region "DataTable"

        public DataTable DataTable(string cSQL)
        {
            return this.GetDataTable(cSQL, "", DefaultTimeout);
        }

        public DataTable DataTable(string cSQL, int Timeout)
        {
            return this.GetDataTable(cSQL, "", Timeout);
        }

        public DataTable DataTable(string cSQL, string DB)
        {
            return this.GetDataTable(cSQL, DB, DefaultTimeout);
        }

        public DataTable DataTable(string cSQL, string DB, int Timeout)
        {
            return this.GetDataTable(cSQL, DB, Timeout);
        }
        #endregion

        #region "SQLCommand"
        public SqlCommand SQLCommand(string SQL, string DB, int Timeout)
        {
            return this.GetSQLComand(SQL, DB, Timeout);
        }

        public SqlCommand SQLCommand(string SQL, string DB)
        {
            return this.GetSQLComand(SQL, DB, DefaultTimeout);
        }

        public SqlCommand SQLCommand(string SQL, int Timeout)
        {
            return this.GetSQLComand(SQL, "", Timeout);
        }

        public SqlCommand SQLCommand(string SQL)
        {
            return this.GetSQLComand(SQL, "", DefaultTimeout);
        }
        #endregion

        #region "RunCommand"
        public int RunCommand(string SQL, string DB, int Timeout)
        {
            return this.GetRunCommand(SQL, DB, Timeout);
        }

        public int RunCommand(string SQL, string DB)
        {
            return this.GetRunCommand(SQL, DB, DefaultTimeout);
        }

        public int RunCommand(string SQL, int Timeout)
        {
            return this.GetRunCommand(SQL, "", Timeout);
        }

        public int RunCommand(string SQL)
        {
            return this.GetRunCommand(SQL, "", DefaultTimeout);
        }
        #endregion

        #region "ScalarResult"
        public object ScalarResult(string SQL, string DB, int Timeout)
        {
            return this.GetScalarResult(SQL, DB, Timeout);
        }

        public object ScalarResult(string SQL, string DB)
        {
            return this.GetScalarResult(SQL, DB, DefaultTimeout);
        }

        public object ScalarResult(string SQL, int Timeout)
        {
            return this.GetScalarResult(SQL, "", Timeout);
        }

        public object ScalarResult(string SQL)
        {
            return this.GetScalarResult(SQL, "", DefaultTimeout);
        }
        #endregion

        #region "Private Functions"
        private DataTable GetDataTable(string SQL, string DB, int Timeout)
        {
            AppDataTable oTable;
            DataTable tblGetData;

            oConnInfo.InitialDB = DB;
            oTable = new AppDataTable(oConnInfo, SQL, Timeout);

            oTable.Open();
            tblGetData = oTable.TableRef;
            oTable.Close();

            return tblGetData;
        }

        private SqlCommand GetSQLComand(string SQL, string DB, int Timeout)
        {
            AppSQLCommand oCommand;

            oCommand = new AppSQLCommand(new ConnectionInfo(this.oConnInfo.ConnectionString, DB), SQL, Timeout);
            oCommand.Open();

            return oCommand.CommandRef;
        }

        private object GetScalarResult(string SQL, string DB, int Timeout)
        {
            AppScalarResult oScalarResult;

            oScalarResult = new AppScalarResult(new ConnectionInfo(this.oConnInfo.ConnectionString, DB), SQL, Timeout);

            return oScalarResult.Execute();
        }

        private int GetRunCommand(string SQL, string DB, int Timeout)
        {
            int iReturnVal = 0;
            AppSQLCommand oCommand;

            oCommand = new AppSQLCommand(new ConnectionInfo(this.oConnInfo.ConnectionString, DB), SQL, Timeout);

            oCommand.Open();
            iReturnVal = oCommand.CommandRef.ExecuteNonQuery();
            oCommand.Close();

            return iReturnVal;
        }
        #endregion
    }
}
