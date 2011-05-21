using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppFramework.DataAccess.Full.DBSQLCommand;
using AppFramework.DataAccess.Full.AppDBConnection;

namespace AppFramework.DataAccess.Full.DBScalarResult
{
    class AppScalarResult: AppSQLCommand
    {
        public AppScalarResult(string cConnectionString, string cSQL, int iTimeout)
            : base(cConnectionString, cSQL, iTimeout)
        {
        }

        public AppScalarResult(ConnectionInfo ConnInfo, string cSQL, int iTimeout)
            : base(ConnInfo, cSQL, iTimeout)
        {
        }

        public object Execute()
        {
            return this.CommandRef.ExecuteScalar();
        }
    }
}
