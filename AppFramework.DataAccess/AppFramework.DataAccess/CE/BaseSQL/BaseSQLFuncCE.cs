using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppFramework.DataAccess.CE.AppDBConnection;
using System.Data.SqlServerCe;

namespace AppFramework.DataAccess.CE.BaseSQL
{
    abstract class BaseSQLFuncCE
    {
        protected ConnectionInfo oConnInfo;
        protected SqlCeConnection oSQLConnection;

        public string ConnectionString { get; set; }
        public string SQL { get; set; }

        public BaseSQLFuncCE(string cConnString, string cSQL)
        {
            oConnInfo = new ConnectionInfo(cConnString);
            SQL = cSQL;

            this.Initialize();
        }

        public BaseSQLFuncCE(ConnectionInfo ConnInfo, string cSQL)
        {
            oConnInfo = ConnInfo;
            SQL = cSQL;

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
