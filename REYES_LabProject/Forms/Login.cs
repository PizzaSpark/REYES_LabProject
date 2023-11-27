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

namespace REYES_LabProject
{
    public partial class Login : Form
    {
        //declare global boolean variable
        //only add public if you want to access this variable from another form

        int attempts = 0;
        bool passwordHide = true;
        public Login()
        {
            InitializeComponent();
        } 

        public void openMainForm()
        {
            Application.Run(new Dashboard());
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = sqlFunctions.GetDataByPrimaryKey("tbl_admin",9);
            if (sqlFunctions.TestDatabaseConnection())
            {
                MessageBox.Show("There is a connection");
            }
            passwordEye_ptb.Image = imageList1.Images[0];
            detectCapslockChange();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;
            string hashedPassword = toolFunctions.CalculateMD5Hash(password);

            if (attempts >= 3)
            {
                MessageBox.Show("You have reached the maximum number of attempts. Please try again later.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (toolFunctions.ContainsOtherCharacters(username))
            {
                MessageBox.Show("You can't do that oh oh");
            }
            else if (sqlFunctions.LoginUser(username,hashedPassword))
            {
                if (!sqlFunctions.IsActive(username))
                {
                    MessageBox.Show("Account not yet activated. Please contact your administator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Dashboard dashboard = new Dashboard();
                    databridge.dataState.userid = int.Parse(sqlFunctions.GetUserId(username));
                    databridge.dataState.userrole = sqlFunctions.GetUserRole(databridge.dataState.userid);
                    databridge.dataState.username = username;
                    databridge.dataState.roleid = sqlFunctions.GetRoleIdForUser(databridge.dataState.userid);
                    databridge.dataState.rolename = sqlFunctions.GetRoleNameForUser(databridge.dataState.userid);

                    sqlFunctions.InsertAuditData(databridge.dataState.userid, $"logged in");

                    Program.OpenNewForm(dashboard);
                    this.Close();
                }
            }
            else
            {
                attempts += 1;
                int tries = 3 - attempts;
                MessageBox.Show(String.Format("Incorrect username or password. You have {0} attempt(s) left.", tries));

                if (tries <= 0)
                {
                    MessageBox.Show("You are now locked!");
                }
            }
        }

        private void passwordEye_ptb_Click(object sender, EventArgs e)
        {
            if (passwordHide) {
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

        private void Login_KeyDown(object sender, KeyEventArgs e)
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

        private void signup_txt_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            Program.OpenNewForm(register);
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
