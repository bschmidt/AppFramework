using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AppFramework.DataAccess.Full.AppDBConnection;

namespace AppFramework.DataAccess.Full.BaseSQL
{
    abstract class BaseSQLFunc
    {
        protected ConnectionInfo oConnInfo;
        protected SqlConnection oSQLConnection;
        protected List<SqlParameter> ParmList;

        public string ConnectionString { get; set; }
        public string SQL { get; set; }
        public int Timeout { get; set; }

        public BaseSQLFunc(string cConnString, string cSQL, int iTimeout, List<SqlParameter> Parms)
        {
            oConnInfo = new ConnectionInfo(cConnString);
            SQL = cSQL;
            Timeout = iTimeout;

            this.ParmList = Parms;

            this.Initialize();
        }

        public BaseSQLFunc(ConnectionInfo ConnInfo, string cSQL, int iTimeout, List<SqlParameter> Parms)
        {
            oConnInfo = ConnInfo;
            SQL = cSQL;
            Timeout = iTimeout;

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
