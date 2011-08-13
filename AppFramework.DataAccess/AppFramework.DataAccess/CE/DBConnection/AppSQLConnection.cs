using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppFramework.DataAccess.CE.BaseSQL;
using System.Data.SqlServerCe;
using AppFramework.DataAccess.CE.AppDBConnection;

namespace AppFramework.DataAccess.CE.DBConnection
{
    class AppSQLConnection : BaseSQLFuncCE
    {
        public SqlCeConnection ConnectionRef { get; set; }

        public AppSQLConnection(string cConnectionString, string cSQL)
            : base(cConnectionString, cSQL)
        {
        }

        public AppSQLConnection(ConnectionInfo ConnInfo, string cSQL)
            : base(ConnInfo, cSQL)
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
