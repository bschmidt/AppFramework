using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppFramework.DataAccess;
using System.Data.SqlServerCe;

namespace TestDataAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetTable_Click(object sender, EventArgs e)
        {
            DataTable tblTestData = ConnectionManager.Full.Connection(DB.ConnectionString()).DataTable("select * from tblTasks");

            this.GridTestData.DataSource = tblTestData;
        }

        private void btnCELoadData_Click(object sender, EventArgs e)
        {
            //DataTable tblTestData = ConnectionManager.CE.Connection(DB.DBFile()).DataTable("select * from Categories");

            //this.CEGridData.DataSource = tblTestData;

            //this.LoadCEData();
            this.RunCECommand();
            this.GetCEValue();
        }

        private void LoadCEData()
        {
            string cSQL = "select * from tblTasks where TaskID=@TaskID";
            Guid TaskID = new Guid("c877af1d-9934-47b2-bc43-59cd665a562b");
            DataTable tblTestData = ConnectionManager.CE.Connection(DB.HomeDBFile()).DataTable(cSQL, new SqlCeParameter("TaskID", TaskID));

            this.CEGridData.DataSource = tblTestData;
        }

        private void GetCEValue()
        {
            string cSQL = "select GroupOptionID from tblTasks where TaskID=@TaskID";
            Guid TaskID = new Guid("c877af1d-9934-47b2-bc43-59cd665a562b");

            string cValue;

            cValue = ConnectionManager.CE.Connection(DB.HomeDBFile()).ScalarResult(cSQL, new SqlCeParameter("TaskID", TaskID)).ToString();

            MessageBox.Show(cValue);
        }

        private void RunCECommand()
        {
            string cSQL = "update tblTasks set GroupOptionID=5 where TaskID=@TaskID";
            Guid TaskID = new Guid("c877af1d-9934-47b2-bc43-59cd665a562b");

            ConnectionManager.CE.Connection(DB.HomeDBFile()).RunCommand(cSQL, new SqlCeParameter("TaskID", TaskID));

            MessageBox.Show("Updated");
        }
    }
}
