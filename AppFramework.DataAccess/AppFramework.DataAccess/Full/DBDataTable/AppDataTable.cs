using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AppFramework.DataAccess.Full.AppDBConnection;
using AppFramework.DataAccess.Full.BaseSQL;
using System.Data.SqlClient;

namespace AppFramework.DataAccess.Full.DBDataTable
{
    class AppDataTable : BaseSQLFunc
    {
        public DataTable TableRef { get; set; }

        public AppDataTable(string cConnectionString, string cSQL, int iTimeout, List<SqlParameter> Parms)
            : base(cConnectionString, cSQL, iTimeout, Parms)
        {
        }

        public AppDataTable(ConnectionInfo ConnInfo, string cSQL, int iTimeout, List<SqlParameter> Parms)
            : base(ConnInfo, cSQL, iTimeout, Parms)
        {
        }

        public override void Initialize()
        {
            this.TableRef = new DataTable();
            SqlCommand oCommand = new SqlCommand();
            SqlDataAdapter oSQLAdapter = new SqlDataAdapter();

            this.oSQLConnection = new SqlConnection();
            this.oSQLConnection.ConnectionString = this.oConnInfo.ConnectionString;
            this.oSQLConnection.Open();

            oCommand.Connection = this.oSQLConnection;
            oCommand.CommandText = this.SQL;
            if (this.ParmList.Count > 0)
            {
                oCommand.Parameters.AddRange(this.ParmList.ToArray());
            }
            oCommand.CommandTimeout = this.Timeout;

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
