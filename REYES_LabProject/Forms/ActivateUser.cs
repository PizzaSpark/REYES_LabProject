using REYES_LabProject.Classes;
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
        public int isactive;
        public int timerValue;
        public ActivateUser()
        {
            InitializeComponent();
        }

        private void ActivateUser_Load(object sender, EventArgs e)
        {
            timer1.Start();
            isactive = 0;
            dataGridView1.DataSource = sqlFunctions.GetInactiveUsers(isactive);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            timerValue = 0;

            userId_txt.Clear();
            userName_txt.Clear();
            userIsactive_txt.Clear();
            userRole_txt.Clear();
        }

        private void activate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timerValue = 0;

                int userId = int.Parse(userId_txt.Text);
                sqlFunctions.ActivateUser(userId, 1);
                dataGridView1.DataSource = sqlFunctions.GetInactiveUsers(isactive);

                string userRole = sqlFunctions.GetUserRole(userId);
                sqlFunctions.InsertAuditData(databridge.dataState.userid, $"activated userID {userId}");
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
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                timerValue = 0;

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
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            Program.OpenNewForm(dashboard);
            this.Close();
        }

        private void deactivate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timerValue = 0;

                int userId = int.Parse(userId_txt.Text);
                sqlFunctions.ActivateUser(userId, 2);
                dataGridView1.DataSource = sqlFunctions.GetInactiveUsers(isactive);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewDeactivated_btn_Click(object sender, EventArgs e)
        {
            timerValue = 0;

            isactive = 0;
        }

        private void viewActivated_btn_Click(object sender, EventArgs e)
        {
            timerValue = 0;

            isactive = 1;
        }

        private void viewSuspended_btn_Click(object sender, EventArgs e)
        {
            timerValue = 0;

            isactive = 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerValue++;

            if (timerValue >= 60)
            {
                MessageBox.Show("You have timed out.");

                Login frm = new Login();
                Program.OpenNewForm(frm);
                this.Close();
            }
        }

        private void search_ptb_Click(object sender, EventArgs e)
        {
            try
            {
                int search = int.Parse(searchid_txt.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
    }
}
