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
    public partial class Register : Form
    {
        //for picture box if password is hidden or not
        bool passwordHide = true;
        bool confirmPasswordHide = true;

        //for checking if we interacted with textbox
        bool passwordFocus = false;
        bool confirmPasswordFocus = false;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            detectCapslockChange();
        }

        private void password_txt_Enter(object sender, EventArgs e)
        {
            passwordFocus = true;
            detectCapslockChange();
        }

        private void password_txt_Leave(object sender, EventArgs e)
        {
            passwordFocus = false;
            capslock_indicator.Visible = false;
        }

        private void confirmPassword_txt_Enter(object sender, EventArgs e)
        {
            confirmPasswordFocus = true;
            detectCapslockChange();
        }

        private void confirmPassword_txt_Leave(object sender, EventArgs e)
        {
            confirmPasswordFocus = false;
            capslockConfirm_indicator.Visible = false;
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

        private void passwordConfirmEye_ptb_Click(object sender, EventArgs e)
        {
            if (confirmPasswordHide)
            {
                confirmPasswordEye_ptb.Image = imageList1.Images[1];
                confirmPasswordHide = false;
                confirmPassword_txt.PasswordChar = '\0';
            }
            else
            {
                confirmPasswordEye_ptb.Image = imageList1.Images[0];
                confirmPasswordHide = true;
                confirmPassword_txt.PasswordChar = '*';
            }
        }

        private void Register_KeyDown(object sender, KeyEventArgs e)
        {
            detectCapslockChange();
        }

        private void detectCapslockChange()
        {
            bool isCapsLockOn = Control.IsKeyLocked(Keys.CapsLock);

            if (isCapsLockOn)
            {
                if (passwordFocus)
                {
                    capslock_indicator.Visible = true;
                }
                else if (confirmPasswordFocus)
                {
                    capslockConfirm_indicator.Visible = true;
                }
            }
            else
            {
                capslock_indicator.Visible = false;
                capslockConfirm_indicator.Visible = false;
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            String username = username_txt.Text;
            String password = password_txt.Text;
            String confirmPassword = confirmPassword_txt.Text;
            String hashedPassword = toolFunctions.CalculateMD5Hash(password);
            String role = role_cmb.Text;

            if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("Password do not match");
            }
            else if (sqlFunctions.UsernameExists(username))
            {
                MessageBox.Show("Username already exists");
            }
            else if (toolFunctions.ContainsOtherCharacters(username))
            {
                MessageBox.Show("Username must only consist of lowercase and digits");
            }
            else if (username == "" || password == "" || role == "")
            {
                MessageBox.Show("Incomplete details. Please fill in all textboxes");
            }
            else if (toolFunctions.IsStrongPassword(password) == false)
            {
                MessageBox.Show("Password does not have at least one capital, one small letter, one digit, and one special character either ?!_");
            }
            else
            {
                if(sqlFunctions.RegisterUser(username, hashedPassword, role, 0))
                {
                    MessageBox.Show("Successfully registered");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void signin_txt_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Program.OpenNewForm(login);
            this.Close();
        }
    }
}
