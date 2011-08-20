using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AppFramework.DataAccess.CE.BaseSQL;
using System.Data.SqlClient;
using AppFramework.DataAccess.CE.AppDBConnection;
using System.Data.SqlServerCe;

namespace AppFramework.DataAccess.CE.DBDataTable
{
    class AppDataTableCE : BaseSQLFuncCE
    {
        public DataTable TableRef { get; set; }

        public AppDataTableCE(string cConnectionString, string cSQL, List<SqlCeParameter> Parms)
            : base(cConnectionString, cSQL, Parms)
        {
        }

        public AppDataTableCE(ConnectionInfo ConnInfo, string cSQL, List<SqlCeParameter> Parms)
            : base(ConnInfo, cSQL, Parms)
        {
        }

        public override void Initialize()
        {
            this.TableRef = new DataTable();
            SqlCeCommand oCommand = new SqlCeCommand();
            SqlCeDataAdapter oSQLAdapter = new SqlCeDataAdapter();

            this.oSQLConnection = new SqlCeConnection();
            this.oSQLConnection.ConnectionString = this.oConnInfo.ConnectionString;
            this.oSQLConnection.Open();

            oCommand.Connection = this.oSQLConnection;
            oCommand.CommandText = this.SQL;
            if (this.ParmList.Count > 0)
            {
                oCommand.Parameters.AddRange(this.ParmList.ToArray());
            }

            oSQLAdapter.SelectCommand = oCommand;
            oSQLAdapter.Fill(this.TableRef);
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
