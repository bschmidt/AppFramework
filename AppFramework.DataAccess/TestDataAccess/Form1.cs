using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppFramework.DataAccess;

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
            DataTable tblTestData = ConnectionManager.CE.Connection(DB.DBFile()).DataTable("select * from Categories");

            this.CEGridData.DataSource = tblTestData;
        }
    }
}
