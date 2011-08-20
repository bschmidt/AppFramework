using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppFramework.DataAccess.CE.DBSQLCommand;
using AppFramework.DataAccess.CE.AppDBConnection;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace AppFramework.DataAccess.CE.DBScalarResult
{
    class AppScalarResultCE : AppSQLCommandCE
    {
        public AppScalarResultCE(string cConnectionString, string cSQL, List<SqlCeParameter> Parms)
            : base(cConnectionString, cSQL, Parms)
        {
        }

        public AppScalarResultCE(ConnectionInfo ConnInfo, string cSQL, List<SqlCeParameter> Parms)
            : base(ConnInfo, cSQL, Parms)
        {
        }

        public object Execute()
        {
            return this.CommandRef.ExecuteScalar();
        }
    }
}
