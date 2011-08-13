using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppFramework.DataAccess.Full.DBSQLCommand;
using AppFramework.DataAccess.Full.AppDBConnection;
using System.Data.SqlClient;

namespace AppFramework.DataAccess.Full.DBScalarResult
{
    class AppScalarResult: AppSQLCommand
    {
        public AppScalarResult(string cConnectionString, string cSQL, int iTimeout, List<SqlParameter> Parms)
            : base(cConnectionString, cSQL, iTimeout, Parms)
        {
        }

        public AppScalarResult(ConnectionInfo ConnInfo, string cSQL, int iTimeout, List<SqlParameter> Parms)
            : base(ConnInfo, cSQL, iTimeout, Parms)
        {
        }

        public object Execute()
        {
            return this.CommandRef.ExecuteScalar();
        }
    }
}
