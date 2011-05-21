using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppFramework.DataAccess.CE.DBSQLCommand;
using AppFramework.DataAccess.CE.AppDBConnection;

namespace AppFramework.DataAccess.CE.DBScalarResult
{
    class AppScalarResultCE : AppSQLCommandCE
    {
        public AppScalarResultCE(string cConnectionString, string cSQL)
            : base(cConnectionString, cSQL)
        {
        }

        public AppScalarResultCE(ConnectionInfo ConnInfo, string cSQL)
            : base(ConnInfo, cSQL)
        {
        }

        public object Execute()
        {
            return this.CommandRef.ExecuteScalar();
        }
    }
}
