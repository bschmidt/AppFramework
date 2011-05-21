using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFramework.DataAccess.Full.AppDBConnection
{
    public class ConnectionInfo
    {
        public string ConnectionString { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string InitialDB { get; set; }
        public string DataSourceName { get; set; }

        public ConnectionInfo(string cUserName, string cPassword, string cIntialDB, string cDataSourceName)
        {
            this.UserName = cUserName;
            this.Password = cPassword;
            this.InitialDB = cIntialDB;
            this.DataSourceName = cDataSourceName;

            this.Assemble();
        }

        public ConnectionInfo(string ConnString)
        {
            this.ConnectionString = ConnString;
            this.Decode();
        }

        public ConnectionInfo(string ConnString, string cInitialDB)
        {
            this.ConnectionString = ConnString;
            this.InitialDB = cInitialDB;
            this.Decode();
        }

        #region "Private Methods"
        private void SetUserName(string Value)
        {
            this.UserName = Value;
            this.Assemble();
        }

        private void SetPassword(string Value)
        {
            this.Password = Value;
            this.Assemble();
        }

        private void SetInitialDB(string Value)
        {
            this.InitialDB = Value;
            this.Assemble();
        }

        private void SetDataSourceName(string Value)
        {
            this.DataSourceName = Value;
            this.Assemble();
        }

        private void Decode()
        {
            this.UserName = this.GetValue(ConnectionString, "USER ID=");
            this.Password = this.GetValue(ConnectionString, "PASSWORD=");
            this.InitialDB = this.GetValue(ConnectionString, "INITIAL CATALOG=");
            this.DataSourceName = this.GetValue(ConnectionString, "DATA SOURCE=");
        }

        private void Assemble()
        {
            ConnectionString = "Data Source=" + this.DataSourceName + ";" + "Initial Catalog=" + this.InitialDB + ";" + "Persist Security Info=True;" + "User ID=" + this.UserName + ";" + "Password=" + this.Password;
        }

        private string GetValue(string cTarget, string cSource)
        {
            string cTemp;
            string cValue = "";

            try
            {
                cTemp = cSource.Substring(cSource.ToUpper().IndexOf(cTarget) - 1, cSource.Length - cSource.ToUpper().IndexOf(cTarget) + 1);  

                //cTemp = Mid(cSource, InStr(cSource.ToUpper, cTarget), Len(cSource) - InStr(cSource.ToUpper, cTarget) + 1);

                if (cTemp.IndexOf(";") > 0)
                {
                    cTemp = cTemp.Substring(1, cTemp.IndexOf(";") - 1);
                }

                //If InStr(cTemp, ";") > 0 Then
                //    cTemp = Mid(cTemp, 1, InStr(cTemp, ";") - 1);
                //End If
            
                cValue = cTemp.Substring(cTarget.Length + 1, cTemp.Length - cTarget.Length);

                //cValue = Mid(cTemp, Len(cTarget) + 1, Len(cTemp) - Len(cTarget));     
            }
            catch 
            {
                cValue = "";
            }

            return cValue;
        }

        #endregion
    }
}
