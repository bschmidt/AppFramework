using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppFramework.DataAccess.Full.AppDBConnection;
using AppFramework.DataAccess.CE.AppDBConnection;

namespace AppFramework.DataAccess
{
    public class ConnectionManager
    {
        public class Full
        {
            public static Connection Connection(string ConnString)
            {
                return new Connection(ConnString);
            }

            public static Connection Connection(string ConnString, string DB)
            {
                return new Connection(ConnString, DB);
            }

            public static Connection Connection(string DB, string User, string Password, string DataSourceName)
            {
                return new Connection(DB, User, Password, DataSourceName);
            }
        }

        public class CE
        {
            public static ConnectionCE Connection(string DBFile)
            {
                return new ConnectionCE(DBFile);
            }

            public static ConnectionCE Connection(string DBFile, string Password)
            {
                return new ConnectionCE(DBFile, Password);
            }
        }
    }
}
