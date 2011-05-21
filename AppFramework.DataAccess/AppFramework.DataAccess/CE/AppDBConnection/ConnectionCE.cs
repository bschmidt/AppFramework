using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AppFramework.DataAccess.CE.DBDataTable;
using System.Data.SqlClient;
using AppFramework.DataAccess.CE.DBSQLCommand;
using AppFramework.DataAccess.CE.DBScalarResult;
using System.Data.SqlServerCe;

namespace AppFramework.DataAccess.CE.AppDBConnection
{
    public class ConnectionCE
    {
        protected ConnectionInfo oConnInfo;

        public string SQL { get; set; }
        public int DefaultTimeout { get; set; }

        public ConnectionCE(string cDBFile)
        {
            oConnInfo = new ConnectionInfo(cDBFile);
            DefaultTimeout = 60;
        }

        public ConnectionCE(string cDBFile, string cPassword)
        {
            oConnInfo = new ConnectionInfo(cDBFile, cPassword);
            DefaultTimeout = 60;
        }

        #region "DataTable"
        public DataTable DataTable(string cSQL)
        {
            return this.GetDataTable(cSQL, DefaultTimeout);
        }

        public DataTable DataTable(string cSQL, int Timeout)
        {
            return this.GetDataTable(cSQL, Timeout);
        }
        #endregion

        #region "SQLCommand"
        public SqlCeCommand SQLCommand(string SQL, int Timeout)
        {
            return this.GetSQLComand(SQL, Timeout);
        }

        public SqlCeCommand SQLCommand(string SQL)
        {
            return this.GetSQLComand(SQL, DefaultTimeout);
        }
        #endregion

        #region "RunCommand"
        public int RunCommand(string SQL, int Timeout)
        {
            return this.GetRunCommand(SQL, Timeout);
        }

        public int RunCommand(string SQL)
        {
            return this.GetRunCommand(SQL, DefaultTimeout);
        }
        #endregion

        #region "ScalarResult"
        public object ScalarResult(string SQL, int Timeout)
        {
            return this.GetScalarResult(SQL, Timeout);
        }

        public object ScalarResult(string SQL)
        {
            return this.GetScalarResult(SQL, DefaultTimeout);
        }
        #endregion

        #region "Private Functions"
        private DataTable GetDataTable(string SQL, int Timeout)
        {
            AppDataTableCE oTable;
            DataTable tblGetData;

            oTable = new AppDataTableCE(this.oConnInfo, SQL);

            oTable.Open();
            tblGetData = oTable.TableRef;
            oTable.Close();

            return tblGetData;
        }

        private SqlCeCommand GetSQLComand(string SQL, int Timeout)
        {
            AppSQLCommandCE oCommand;

            oCommand = new AppSQLCommandCE(this.oConnInfo, SQL);
            oCommand.Open();

            return oCommand.CommandRef;
        }

        private object GetScalarResult(string SQL, int Timeout)
        {
            AppScalarResultCE oScalarResult;
            object Result;

            oScalarResult = new AppScalarResultCE(this.oConnInfo, SQL);

            Result = oScalarResult.Execute();
            oScalarResult.Close();

            return Result;
        }

        private int GetRunCommand(string SQL, int Timeout)
        {
            int iReturnVal = 0;
            AppSQLCommandCE oCommand;

            oCommand = new AppSQLCommandCE(this.oConnInfo, SQL);

            oCommand.Open();
            iReturnVal = oCommand.CommandRef.ExecuteNonQuery();
            oCommand.Close();

            return iReturnVal;
        }
        #endregion
    }
}
