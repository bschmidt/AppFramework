using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using AppFramework.DataAccess.CE.BaseSQL;
using AppFramework.DataAccess.CE.AppDBConnection;
using System.Data;

namespace AppFramework.DataAccess.CE.DBSQLCommand
{
    class AppSQLCommandCE : BaseSQLFuncCE
    {
        public SqlCeCommand CommandRef { get; set; }

        public AppSQLCommandCE(string cConnectionString, string cSQL)
            : base(cConnectionString, cSQL)
        {
        }

        public AppSQLCommandCE(ConnectionInfo ConnInfo, string cSQL)
            : base(ConnInfo, cSQL)
        {
        }

        public override void Initialize()
        {
            this.CommandRef = new SqlCeCommand();
            this.oSQLConnection = new SqlCeConnection();

            this.CommandRef.CommandType = CommandType.Text;
            this.CommandRef.CommandText = this.SQL;

            this.oSQLConnection.ConnectionString = this.oConnInfo.ConnectionString;
            this.oSQLConnection.Open();

            this.CommandRef.Connection = this.oSQLConnection;
        }

        public override void Open()
        {

        }
    }
}
