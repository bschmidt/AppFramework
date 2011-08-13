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

        public DataTable DataTable(string cSQL, List<SqlParameter> Parms)
        {
            return this.GetDataTable(cSQL, "", DefaultTimeout, Parms);
        }

        public DataTable DataTable(string cSQL, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetDataTable(cSQL, "", Timeout, Parms);
        }

        public DataTable DataTable(string cSQL, string DB, List<SqlParameter> Parms)
        {
            return this.GetDataTable(cSQL, DB, DefaultTimeout, Parms);
        }

        public DataTable DataTable(string cSQL, string DB, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetDataTable(cSQL, DB, Timeout, Parms);
        }

        public DataTable DataTable(string cSQL, SqlParameter SingleParm)
        {
            return this.GetDataTable(cSQL, "", DefaultTimeout, SingleParm);
        }

        public DataTable DataTable(string cSQL, int Timeout, SqlParameter SingleParm)
        {
            return this.GetDataTable(cSQL, "", Timeout, SingleParm);
        }

        public DataTable DataTable(string cSQL, string DB, SqlParameter SingleParm)
        {
            return this.GetDataTable(cSQL, DB, DefaultTimeout, SingleParm);
        }

        public DataTable DataTable(string cSQL, string DB, int Timeout, SqlParameter SingleParm)
        {
            return this.GetDataTable(cSQL, DB, Timeout, SingleParm);
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

        public SqlCommand SQLCommand(string SQL, string DB, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetSQLComand(SQL, DB, Timeout, Parms);
        }

        public SqlCommand SQLCommand(string SQL, string DB, List<SqlParameter> Parms)
        {
            return this.GetSQLComand(SQL, DB, DefaultTimeout, Parms);
        }

        public SqlCommand SQLCommand(string SQL, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetSQLComand(SQL, "", Timeout, Parms);
        }

        public SqlCommand SQLCommand(string SQL, List<SqlParameter> Parms)
        {
            return this.GetSQLComand(SQL, "", DefaultTimeout, Parms);
        }

        public SqlCommand SQLCommand(string SQL, string DB, int Timeout, SqlParameter SingleParm)
        {
            return this.GetSQLComand(SQL, DB, Timeout, SingleParm);
        }

        public SqlCommand SQLCommand(string SQL, string DB, SqlParameter SingleParm)
        {
            return this.GetSQLComand(SQL, DB, DefaultTimeout, SingleParm);
        }

        public SqlCommand SQLCommand(string SQL, int Timeout, SqlParameter SingleParm)
        {
            return this.GetSQLComand(SQL, "", Timeout, SingleParm);
        }

        public SqlCommand SQLCommand(string SQL, SqlParameter SingleParm)
        {
            return this.GetSQLComand(SQL, "", DefaultTimeout, SingleParm);
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

        public int RunCommand(string SQL, string DB, int Timeout, SqlParameter SingleParm)
        {
            return this.GetRunCommand(SQL, DB, Timeout, SingleParm);
        }

        public int RunCommand(string SQL, string DB, SqlParameter SingleParm)
        {
            return this.GetRunCommand(SQL, DB, DefaultTimeout, SingleParm);
        }

        public int RunCommand(string SQL, int Timeout, SqlParameter SingleParm)
        {
            return this.GetRunCommand(SQL, "", Timeout, SingleParm);
        }

        public int RunCommand(string SQL, SqlParameter SingleParm)
        {
            return this.GetRunCommand(SQL, "", DefaultTimeout, SingleParm);
        }

        public int RunCommand(string SQL, string DB, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetRunCommand(SQL, DB, Timeout, Parms);
        }

        public int RunCommand(string SQL, string DB, List<SqlParameter> Parms)
        {
            return this.GetRunCommand(SQL, DB, DefaultTimeout, Parms);
        }

        public int RunCommand(string SQL, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetRunCommand(SQL, "", Timeout, Parms);
        }

        public int RunCommand(string SQL, List<SqlParameter> Parms)
        {
            return this.GetRunCommand(SQL, "", DefaultTimeout, Parms);
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

        public object ScalarResult(string SQL, string DB, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetScalarResult(SQL, DB, Timeout, Parms);
        }

        public object ScalarResult(string SQL, string DB, List<SqlParameter> Parms)
        {
            return this.GetScalarResult(SQL, DB, DefaultTimeout, Parms);
        }

        public object ScalarResult(string SQL, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetScalarResult(SQL, "", Timeout, Parms);
        }

        public object ScalarResult(string SQL, List<SqlParameter> Parms)
        {
            return this.GetScalarResult(SQL, "", DefaultTimeout, Parms);
        }

        public object ScalarResult(string SQL, string DB, int Timeout, SqlParameter SingleParm)
        {
            return this.GetScalarResult(SQL, DB, Timeout, SingleParm);
        }

        public object ScalarResult(string SQL, string DB, SqlParameter SingleParm)
        {
            return this.GetScalarResult(SQL, DB, DefaultTimeout, SingleParm);
        }

        public object ScalarResult(string SQL, int Timeout, SqlParameter SingleParm)
        {
            return this.GetScalarResult(SQL, "", Timeout, SingleParm);
        }

        public object ScalarResult(string SQL, SqlParameter SingleParm)
        {
            return this.GetScalarResult(SQL, "", DefaultTimeout, SingleParm);
        }
        #endregion

        #region "Private Functions"
        private DataTable GetDataTable(string SQL, string DB, int Timeout)
        {
            return this.GetDataTable(SQL, DB, Timeout, new List<SqlParameter>());
        }
    
        private DataTable GetDataTable(string SQL, string DB, int Timeout, SqlParameter SingleParm)
        {
            var Parms = new List<SqlParameter>();

            if (SingleParm != null)
            {
                Parms.Add(SingleParm);
            }

            return this.GetDataTable(SQL, DB, Timeout, Parms);
        }

        private DataTable GetDataTable(string SQL, string DB, int Timeout, List<SqlParameter> Parms)
        {
            AppDataTable oTable;
            DataTable tblGetData;

            oConnInfo.InitialDB = DB;
            oTable = new AppDataTable(oConnInfo, SQL, Timeout, Parms);

            oTable.Open();
            tblGetData = oTable.TableRef;
            oTable.Close();

            return tblGetData;
        }

        private SqlCommand GetSQLComand(string SQL, string DB, int Timeout)
        {
            AppSQLCommand oCommand;

            oCommand = new AppSQLCommand(new ConnectionInfo(this.oConnInfo.ConnectionString, DB), SQL, Timeout, new List<SqlParameter>());

            return oCommand.CommandRef;
        }

        private SqlCommand GetSQLComand(string SQL, string DB, int Timeout, List<SqlParameter> Parms)
        {
            AppSQLCommand oCommand;

            oCommand = new AppSQLCommand(new ConnectionInfo(this.oConnInfo.ConnectionString, DB), SQL, Timeout, Parms);

            return oCommand.CommandRef;
        }

        private SqlCommand GetSQLComand(string SQL, string DB, int Timeout, SqlParameter SingleParm)
        {
            AppSQLCommand oCommand;
            var Parms = new List<SqlParameter>();

            if (SingleParm != null)
            {
                Parms.Add(SingleParm);
            }

            oCommand = new AppSQLCommand(new ConnectionInfo(this.oConnInfo.ConnectionString, DB), SQL, Timeout, Parms);

            return oCommand.CommandRef;
        }

        private object GetScalarResult(string SQL, string DB, int Timeout)
        {
            AppScalarResult oScalarResult;

            oScalarResult = new AppScalarResult(new ConnectionInfo(this.oConnInfo.ConnectionString, DB), SQL, Timeout, new List<SqlParameter>());

            return oScalarResult.Execute();
        }

        private object GetScalarResult(string SQL, string DB, int Timeout, SqlParameter SingleParm)
        {
            AppScalarResult oScalarResult;
            var Parms = new List<SqlParameter>();

            if (SingleParm != null)
            {
                Parms.Add(SingleParm);
            }

            oScalarResult = new AppScalarResult(new ConnectionInfo(this.oConnInfo.ConnectionString, DB), SQL, Timeout, Parms);

            return oScalarResult.Execute();
        }

        private object GetScalarResult(string SQL, string DB, int Timeout, List<SqlParameter> Parms)
        {
            AppScalarResult oScalarResult;

            oScalarResult = new AppScalarResult(new ConnectionInfo(this.oConnInfo.ConnectionString, DB), SQL, Timeout, Parms);

            return oScalarResult.Execute();
        }

        private int GetRunCommand(string SQL, string DB, int Timeout)
        {
            return this.GetRunCommand(SQL, DB, Timeout, new List<SqlParameter>());
        }

        private int GetRunCommand(string SQL, string DB, int Timeout, SqlParameter SingleParm)
        {
            var Parms = new List<SqlParameter>();

            if (SingleParm != null)
            {
                Parms.Add(SingleParm);
            }

            return this.GetRunCommand(SQL, DB, Timeout, Parms);
        }

        private int GetRunCommand(string SQL, string DB, int Timeout, List<SqlParameter> Parms)
        {
            int iReturnVal = 0;
            AppSQLCommand oCommand;

            oCommand = new AppSQLCommand(new ConnectionInfo(this.oConnInfo.ConnectionString, DB), SQL, Timeout, Parms);

            oCommand.Open();
            iReturnVal = oCommand.CommandRef.ExecuteNonQuery();
            oCommand.Close();

            return iReturnVal;
        }
        #endregion
    }
}
