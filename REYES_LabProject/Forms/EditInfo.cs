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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace REYES_LabProject.Forms
{
    public partial class EditInfo : Form
    {
        public int timerValue = 0;
        bool passwordHide = true;

        public EditInfo()
        {
            InitializeComponent();
        }

        private void EditInfo_Load(object sender, EventArgs e)
        {
            timer1.Start();
            detectCapslockChange();
            userId_txt.Text = databridge.dataState.userid.ToString();
            categoryId_txt.Text = databridge.dataState.roleid.ToString();
            username_txt.Text = databridge.dataState.username;
            role_txt.Text = databridge.dataState.userrole;
            displayname_txt.Text = databridge.dataState.rolename;
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

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timerValue = 0;
                if (toolFunctions.StringSanitizer(displayname_txt.Text) || toolFunctions.ContainsOtherCharacters(username_txt.Text))
                {
                    MessageBox.Show("You can't do that oh oh");
                }
                else
                {
                    if (username_txt.Text != databridge.dataState.username && sqlFunctions.UsernameExists(username_txt.Text))
                    {
                        MessageBox.Show("Username exists already");
                    } else
                    {
                        sqlFunctions.UpdateUsername(databridge.dataState.userid, username_txt.Text);
                        databridge.dataState.username = username_txt.Text;
                    }

                    string hash = toolFunctions.CalculateMD5Hash(password_txt.Text);
                    if (password_txt.Text != "" && toolFunctions.IsStrongPassword(password_txt.Text) == false)
                    {
                        MessageBox.Show("Password must at least have one caps, one small letter, a character and a digit");
                    }
                    else if (password_txt.Text != "" && toolFunctions.IsStrongPassword(password_txt.Text))
                    {
                        sqlFunctions.UpdatePassword(databridge.dataState.userid, hash);
                    }
                    sqlFunctions.UpdateDisplayname(databridge.dataState.userid, displayname_txt.Text);
                    databridge.dataState.rolename = displayname_txt.Text;

                    sqlFunctions.InsertAuditData(databridge.dataState.userid, $"updated their user info and credentials");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
           
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            Program.OpenNewForm(frm);
            this.Close();
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

        private void EditInfo_KeyDown(object sender, KeyEventArgs e)
        {
            detectCapslockChange();
        }
    }
}
