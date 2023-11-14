using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REYES_LabProject.Forms
{
    public partial class Audit : Form
    {
        public string username;
        public string userrole;
        public Audit()
        {
            InitializeComponent();
        }

        private void Audit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_audit");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.userrole = userrole;
            dashboard.username = username;
            Program.OpenNewForm(dashboard);
            this.Close();
        }
    }
}
