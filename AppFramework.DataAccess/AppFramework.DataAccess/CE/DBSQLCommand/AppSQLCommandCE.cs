using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using AppFramework.DataAccess.CE.BaseSQL;
using AppFramework.DataAccess.CE.AppDBConnection;
using System.Data;
using System.Data.SqlClient;

namespace AppFramework.DataAccess.CE.DBSQLCommand
{
    class AppSQLCommandCE : BaseSQLFuncCE
    {
        public SqlCeCommand CommandRef { get; set; }

        public AppSQLCommandCE(string cConnectionString, string cSQL, List<SqlCeParameter> Parms)
            : base(cConnectionString, cSQL, Parms)
        {
        }

        public AppSQLCommandCE(ConnectionInfo ConnInfo, string cSQL, List<SqlCeParameter> Parms)
            : base(ConnInfo, cSQL, Parms)
        {
        }

        public override void Initialize()
        {
            this.CommandRef = new SqlCeCommand();
            this.oSQLConnection = new SqlCeConnection();

            this.CommandRef.CommandType = CommandType.Text;
            if (this.ParmList.Count > 0)
            {
                this.CommandRef.Parameters.AddRange(this.ParmList.ToArray());
            }
            this.CommandRef.CommandText = this.SQL;

            this.oSQLConnection.ConnectionString = this.oConnInfo.ConnectionString;
            this.oSQLConnection.Open();

            this.CommandRef.Connection = this.oSQLConnection;
        }

        public override void Open()
        {
            if (this.oSQLConnection.State == ConnectionState.Closed)
            {
                this.oSQLConnection.Open();
            }
        }
    }
}
