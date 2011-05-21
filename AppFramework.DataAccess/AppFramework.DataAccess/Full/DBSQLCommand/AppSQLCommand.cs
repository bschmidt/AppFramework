using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AppFramework.DataAccess.Full.AppDBConnection;
using AppFramework.DataAccess.Full.BaseSQL;

namespace AppFramework.DataAccess.Full.DBSQLCommand
{
    class AppSQLCommand: BaseSQLFunc
    {
        public SqlCommand CommandRef { get; set; }

        public AppSQLCommand(string cConnectionString, string cSQL, int iTimeout)
            : base(cConnectionString, cSQL, iTimeout)
        {
        }

        public AppSQLCommand(ConnectionInfo ConnInfo, string cSQL, int iTimeout)
            : base(ConnInfo, cSQL, iTimeout)
        {
        }

        public override void Initialize()
        {
            this.CommandRef = new SqlCommand();
            this.oSQLConnection = new SqlConnection();

            this.CommandRef.CommandType = CommandType.Text;
            this.CommandRef.CommandText = this.SQL;
            this.CommandRef.CommandTimeout = this.Timeout;

            this.oSQLConnection.ConnectionString = this.oConnInfo.ConnectionString;
            this.oSQLConnection.Open();

            this.CommandRef.Connection = this.oSQLConnection;
        }

        public override void Open()
        {
            
        }
    }
}
