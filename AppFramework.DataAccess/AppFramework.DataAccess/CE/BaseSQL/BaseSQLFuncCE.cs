using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppFramework.DataAccess.CE.AppDBConnection;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace AppFramework.DataAccess.CE.BaseSQL
{
    abstract class BaseSQLFuncCE
    {
        protected ConnectionInfo oConnInfo;
        protected SqlCeConnection oSQLConnection;
        protected List<SqlCeParameter> ParmList;

        public string ConnectionString { get; set; }
        public string SQL { get; set; }

        public BaseSQLFuncCE(string cConnString, string cSQL, List<SqlCeParameter> Parms)
        {
            oConnInfo = new ConnectionInfo(cConnString);
            SQL = cSQL;

            this.ParmList = Parms;

            this.Initialize();
        }

        public BaseSQLFuncCE(ConnectionInfo ConnInfo, string cSQL, List<SqlCeParameter> Parms)
        {
            oConnInfo = ConnInfo;
            SQL = cSQL;

            this.ParmList = Parms;

            this.Initialize();
        }

        public abstract void Initialize();
        public abstract void Open();

        public void Close()
        {
            if (this.oSQLConnection != null)
            {
                this.oSQLConnection.Dispose();
            }
        }
    }
}
