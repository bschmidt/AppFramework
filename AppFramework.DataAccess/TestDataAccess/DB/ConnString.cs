using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDataAccess
{
    class DB
    {
        public static string ConnectionString()
        {
            return "Data Source=EXPRESSDEV\\SQL2008;Initial Catalog=Home;Persist Security Info=True;User ID=sa;Password=saaccess";
        }

        public static string DBFile()
        {
            return "C:\\Program Files\\Microsoft SQL Server Compact Edition\\v3.5\\Samples\\Northwind.sdf";
        }
    }
}
