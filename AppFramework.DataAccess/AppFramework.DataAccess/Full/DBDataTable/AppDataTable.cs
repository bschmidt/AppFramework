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

        public AppDataTable(string cConnectionString, string cSQL, int iTimeout)
            : base(cConnectionString, cSQL, iTimeout)
        {
        }

        public AppDataTable(ConnectionInfo ConnInfo, string cSQL, int iTimeout)
            : base(ConnInfo, cSQL, iTimeout)
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
