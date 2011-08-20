using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppFramework.DataAccess.CE.BaseSQL;
using System.Data.SqlServerCe;
using AppFramework.DataAccess.CE.AppDBConnection;
using System.Data.SqlClient;

namespace AppFramework.DataAccess.CE.DBConnection
{
    class AppSQLConnection : BaseSQLFuncCE
    {
        public SqlCeConnection ConnectionRef { get; set; }

        public AppSQLConnection(string cConnectionString, string cSQL)
            : base(cConnectionString, cSQL, new List<SqlCeParameter>())
        {
        }

        public AppSQLConnection(ConnectionInfo ConnInfo, string cSQL)
            : base(ConnInfo, cSQL, new List<SqlCeParameter>())
        {
        }

        public override void Initialize()
        {
            this.oSQLConnection = new SqlCeConnection();

            this.oSQLConnection.ConnectionString = this.oConnInfo.ConnectionString;
            this.oSQLConnection.Open();
        }

        public override void Open()
        {
            if (this.oSQLConnection.State == System.Data.ConnectionState.Closed)
            {
                this.oSQLConnection.Open();
            }
        }

    }
}
