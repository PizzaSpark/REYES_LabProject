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
    public partial class ActivateUser : Form
    {
        public string username;
        public string userrole;
        public ActivateUser()
        {
            InitializeComponent();
        }

        private void ActivateUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sqlFunctions.GetInactiveUsers();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            userId_txt.Clear();
            userName_txt.Clear();
            userIsactive_txt.Clear();
            userRole_txt.Clear();
        }

        private void activate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(userId_txt.Text);
                sqlFunctions.ActivateUser(userId);
                dataGridView1.DataSource = sqlFunctions.GetInactiveUsers();

                string userRole = sqlFunctions.GetUserRole(userId);

                if (userRole == "Admin")
                {
                    sqlFunctions.InsertUserIdIntoTable("tbl_admin", userId);
                }
                else if (userRole == "Doctor")
                {
                    sqlFunctions.InsertUserIdIntoTable("tbl_doctor", userId);
                }
                else if (userRole == "Patient")
                {
                    sqlFunctions.InsertUserIdIntoTable("tbl_patient", userId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error idk wot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Assuming that the DataGridView columns are named user_id, user_name, user_isactive, and user_role
                userId_txt.Text = selectedRow.Cells["user_id"].Value.ToString();
                userName_txt.Text = selectedRow.Cells["user_name"].Value.ToString();
                userIsactive_txt.Text = selectedRow.Cells["user_isactive"].Value.ToString();
                userRole_txt.Text = selectedRow.Cells["user_role"].Value.ToString();
            }
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
