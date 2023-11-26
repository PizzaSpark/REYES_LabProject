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
        public EditInfo()
        {
            InitializeComponent();
        }

        private void EditInfo_Load(object sender, EventArgs e)
        {
            timer1.Start();
            userId_txt.Text = databridge.dataState.userid.ToString();
            categoryId_txt.Text = databridge.dataState.roleid.ToString();
            username_txt.Text = databridge.dataState.username;
            role_txt.Text = databridge.dataState.userrole;
            displayname_txt.Text = databridge.dataState.rolename;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            timerValue = 0;
            sqlFunctions.UpdateUsername(databridge.dataState.userid, username_txt.Text);
            sqlFunctions.UpdateDisplayname(databridge.dataState.userid, displayname_txt.Text);

            databridge.dataState.username = username_txt.Text;
            databridge.dataState.rolename = displayname_txt.Text;

            sqlFunctions.InsertAuditData(databridge.dataState.userid, $"updated their name");
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
    }
}
