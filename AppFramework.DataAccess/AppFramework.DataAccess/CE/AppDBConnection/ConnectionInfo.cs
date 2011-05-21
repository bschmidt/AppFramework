using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFramework.DataAccess.CE.AppDBConnection
{
    public class ConnectionInfo
    {
        public string Password { get; set; }
        public string DBFile { get; set; }
        public string ConnectionString { get; set; }

        public ConnectionInfo(string cDBFile)
        {
            this.DBFile = cDBFile;

            this.Assemble();
        }

        public ConnectionInfo(string cDBFile, string cPassword)
        {
            this.DBFile = cDBFile;
            this.Password = cPassword;

            this.Assemble();
        }

        #region "Private Methods"

        private void Assemble()
        {
            ConnectionString = "Data Source=" + this.DBFile + ";";
            if (!string.IsNullOrEmpty(this.Password))
            {
                ConnectionString = ConnectionString + "Password=" + this.Password + ";";
            }
                
            ConnectionString = ConnectionString + "File Mode=Read Write;Persist Security Info=False;";
        }
        #endregion
    }
}
