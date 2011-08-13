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

        public DataTable DataTable(string cSQL, SqlParameter SingleParm)
        {
            return this.GetDataTable(cSQL, DefaultTimeout, SingleParm);
        }

        public DataTable DataTable(string cSQL, int Timeout, SqlParameter SingleParm)
        {
            return this.GetDataTable(cSQL, Timeout, SingleParm);
        }

        public DataTable DataTable(string cSQL, List<SqlParameter> Parms)
        {
            return this.GetDataTable(cSQL, DefaultTimeout, Parms);
        }

        public DataTable DataTable(string cSQL, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetDataTable(cSQL, Timeout, Parms);
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

        public SqlCeCommand SQLCommand(string SQL, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetSQLComand(SQL, Timeout, Parms);
        }

        public SqlCeCommand SQLCommand(string SQL, List<SqlParameter> Parms)
        {
            return this.GetSQLComand(SQL, DefaultTimeout, Parms);
        }

        public SqlCeCommand SQLCommand(string SQL, SqlParameter SingleParm)
        {
            return this.GetSQLComand(SQL, DefaultTimeout, SingleParm);
        }

        public SqlCeCommand SQLCommand(string SQL, int Timeout, SqlParameter SingleParm)
        {
            return this.GetSQLComand(SQL, Timeout, SingleParm);
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

        public int RunCommand(string SQL, int Timeout, SqlParameter SingleParm)
        {
            return this.GetRunCommand(SQL, Timeout, SingleParm);
        }

        public int RunCommand(string SQL, SqlParameter SingleParm)
        {
            return this.GetRunCommand(SQL, DefaultTimeout, SingleParm);
        }

        public int RunCommand(string SQL, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetRunCommand(SQL, Timeout, Parms);
        }

        public int RunCommand(string SQL, List<SqlParameter> Parms)
        {
            return this.GetRunCommand(SQL, DefaultTimeout, Parms);
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

        public object ScalarResult(string SQL, int Timeout, SqlParameter SingleParm)
        {
            return this.GetScalarResult(SQL, Timeout, SingleParm);
        }

        public object ScalarResult(string SQL, SqlParameter SingleParm)
        {
            return this.GetScalarResult(SQL, DefaultTimeout, SingleParm);
        }

        public object ScalarResult(string SQL, int Timeout, List<SqlParameter> Parms)
        {
            return this.GetScalarResult(SQL, Timeout, Parms);
        }

        public object ScalarResult(string SQL, List<SqlParameter> Parms)
        {
            return this.GetScalarResult(SQL, DefaultTimeout, Parms);
        }
        #endregion

        #region "Private Functions"
        private DataTable GetDataTable(string SQL, int Timeout)
        {
            return this.GetDataTable(SQL, Timeout, new List<SqlParameter>());
        }

        private DataTable GetDataTable(string SQL, int Timeout, SqlParameter SingleParm)
        {
            var Parms = new List<SqlParameter>();

            if (SingleParm != null)
            {
                Parms.Add(SingleParm);
            }

            return this.GetDataTable(SQL, Timeout, Parms);
        }

        private DataTable GetDataTable(string SQL, int Timeout, List<SqlParameter> Parms)
        {
            AppDataTableCE oTable;
            DataTable tblGetData;

            oTable = new AppDataTableCE(this.oConnInfo, SQL, Parms);

            oTable.Open();
            tblGetData = oTable.TableRef;
            oTable.Close();

            return tblGetData;
        }

        private SqlCeCommand GetSQLComand(string SQL, int Timeout)
        {
            return this.GetSQLComand(SQL, Timeout, new List<SqlParameter>());
        }

        private SqlCeCommand GetSQLComand(string SQL, int Timeout, SqlParameter SingleParm)
        {
            var Parms = new List<SqlParameter>();

            if (SingleParm != null)
            {
                Parms.Add(SingleParm);
            }

            return this.GetSQLComand(SQL, Timeout, Parms);
        }

        private SqlCeCommand GetSQLComand(string SQL, int Timeout, List<SqlParameter> Parms)
        {
            AppSQLCommandCE oCommand;

            oCommand = new AppSQLCommandCE(this.oConnInfo, SQL, Parms);
            if (Parms != null)
            {
                if (Parms.Count > 0)
                {
                    oCommand.CommandRef.Parameters.AddRange(Parms.ToArray());
                }
            }

            return oCommand.CommandRef;
        }

        private object GetScalarResult(string SQL, int Timeout)
        {
            return this.GetScalarResult(SQL, Timeout, new List<SqlParameter>());
        }

        private object GetScalarResult(string SQL, int Timeout, SqlParameter SingleParm)
        {
            var Parms = new List<SqlParameter>();

            if (SingleParm != null)
            {
                Parms.Add(SingleParm);
            }

            return this.GetScalarResult(SQL, Timeout, Parms);
        }

        private object GetScalarResult(string SQL, int Timeout, List<SqlParameter> Parms)
        {
            AppScalarResultCE oScalarResult;
            object Result;

            oScalarResult = new AppScalarResultCE(this.oConnInfo, SQL, Parms);

            Result = oScalarResult.Execute();
            oScalarResult.Close();

            return Result;
        }

        private int GetRunCommand(string SQL, int Timeout)
        {
            return GetRunCommand(SQL, Timeout, new List<SqlParameter>());
        }

        private int GetRunCommand(string SQL, int Timeout, SqlParameter SingleParm)
        {
            var Parms = new List<SqlParameter>();

            if (SingleParm != null)
            {
                Parms.Add(SingleParm);
            }

            return GetRunCommand(SQL, Timeout, Parms);
        }

        private int GetRunCommand(string SQL, int Timeout, List<SqlParameter> Parms)
        {
            int iReturnVal = 0;
            AppSQLCommandCE oCommand;

            oCommand = new AppSQLCommandCE(this.oConnInfo, SQL, Parms);

            oCommand.Open();
            iReturnVal = oCommand.CommandRef.ExecuteNonQuery();
            oCommand.Close();

            return iReturnVal;
        }
        #endregion
    }
}
