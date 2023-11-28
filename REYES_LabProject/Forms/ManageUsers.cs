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
    public partial class ManageUsers : Form
    {
        int timerValue = 0;
        bool passwordHide = true;

        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_user");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                timerValue = 0;
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];


                    userId_txt.Text = selectedRow.Cells["user_id"].Value.ToString();
                    username_txt.Text = selectedRow.Cells["user_name"].Value.ToString();
                    role_txt.Text = selectedRow.Cells["user_role"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerValue++;

            if (timerValue >= 60)
            {
                timer1.Stop();
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
                int id = int.Parse(searchid_txt.Text);
                dataGridView1.DataSource = sqlFunctions.GetDataByPrimaryKey("tbl_user", id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        private void ManageUsers_KeyDown(object sender, KeyEventArgs e)
        {
            detectCapslockChange();
        }

        private void detectCapslockChange()
        {
            bool isCapsLockOn = Control.IsKeyLocked(Keys.CapsLock);

            if (isCapsLockOn)
            {
                capslock_indicator.Visible = true;
            }
            else
            {
                capslock_indicator.Visible = false;
            }
        }

        private void passwordEye_ptb_Click(object sender, EventArgs e)
        {
            if (passwordHide)
            {
                passwordEye_ptb.Image = imageList1.Images[1];
                passwordHide = false;
                password_txt.PasswordChar = '\0';
            }
            else
            {
                passwordEye_ptb.Image = imageList1.Images[0];
                passwordHide = true;
                password_txt.PasswordChar = '*';
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolFunctions.ContainsOtherCharacters(username_txt.Text))
                {
                    MessageBox.Show("You can't do that oh oh");
                }
                else
                {

                    if (username_txt.Text != sqlFunctions.GetUsername(int.Parse(userId_txt.Text)) && sqlFunctions.UsernameExists(username_txt.Text))
                    {
                        MessageBox.Show("Username exists already");
                    }
                    else
                    {
                        sqlFunctions.UpdateUsername(int.Parse(userId_txt.Text), username_txt.Text);
                    }

                    string hash = toolFunctions.CalculateMD5Hash(password_txt.Text);
                    if (password_txt.Text != "" && toolFunctions.IsStrongPassword(password_txt.Text) == false)
                    {
                        MessageBox.Show("Password must at least have one caps, one small letter, a character and a digit");
                    }
                    else if (password_txt.Text != "" && toolFunctions.IsStrongPassword(password_txt.Text))
                    {
                        sqlFunctions.UpdatePassword(int.Parse(userId_txt.Text), hash);
                    }

                    dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_user");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            Program.OpenNewForm(frm);
            this.Close();
        }
    }
}
