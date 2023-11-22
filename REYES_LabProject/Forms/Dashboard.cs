using REYES_LabProject.Classes;
using REYES_LabProject.Forms;
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
    public partial class Dashboard : Form
    {
        public int timerValue = 0;

        private Point lastMousePosition;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            timer1.Start();

            roleDisplay_txt.Text = databridge.dataState.userrole;
            usernameDisplay_txt.Text = databridge.dataState.username;
            userIdDisplay_txt.Text = databridge.dataState.userid.ToString();
            categoryIdDisplay_txt.Text = databridge.dataState.roleid.ToString();
            categoryNameDisplay_txt.Text = databridge.dataState.rolename;

            if (roleDisplay_txt.Text == "Admin")
            {
                RemoveToolStripMenuItemByText("Doctor");
                RemoveToolStripMenuItemByText("Patient");
            }
            else if(roleDisplay_txt.Text == "Doctor")
            {
                RemoveToolStripMenuItemByText("Admin");
                RemoveToolStripMenuItemByText("Patient");
            } 
            else
            {
                RemoveToolStripMenuItemByText("Admin");
                RemoveToolStripMenuItemByText("Doctor");
            }
        }

        private void RemoveToolStripMenuItemByText(string textToRemove)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.Text == textToRemove)
                {
                    menuStrip1.Items.Remove(item);
                    break; // Exit the loop after removing the item
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateDisplay_txt.Text = DateTime.Now.ToString();
            timerDisplay_txt.Text = timerValue.ToString();
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

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            // Calculate the distance the mouse has moved
            int deltaX = Cursor.Position.X - lastMousePosition.X;
            int deltaY = Cursor.Position.Y - lastMousePosition.Y;

            // Adjust the sensitivity threshold as needed
            int sensitivityThreshold = 5; // For example, consider a 5-pixel movement as significant

            if (Math.Abs(deltaX) > sensitivityThreshold || Math.Abs(deltaY) > sensitivityThreshold)
            {
                // Mouse has moved significantly, reset the timerValue to zero
                timerValue = 0;
                lastMousePosition = Cursor.Position;
            }
        }

        //
        // SETTINGS TAB
        //

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditInfo frm = new EditInfo();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This system is developed by Sean Godric F. Reyes in requirements of IAS");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlFunctions.InsertAuditData(databridge.dataState.userid, $"logged out");

            Login frm = new Login();
            Program.OpenNewForm(frm);
            this.Close();
        }

        //
        // ADMIN TAB
        //

        private void activateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateUser frm = new ActivateUser();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void manageDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDoctors frm = new ManageDoctors();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void managePatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePatients frm = new ManagePatients();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void manageMedicalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMedicalRecords frm = new ManageMedicalRecords();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void manageBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBilling frm = new ManageBilling();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void auditLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Audit frm = new Audit();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // DO BACKUP HAAHAHHAHAHAHAHAA
    

        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // DO RESTORE AHIDASKFDKASLFNSDKFNSDG HAAHAHHAHAHAHAHAA
        }

        //
        // DOCTORS TAB
        //

        private void managePatientsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePatients frm = new ManagePatients();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void manageMedicalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMedicalRecords frm = new ManageMedicalRecords();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void manageBillingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageBilling frm = new ManageBilling();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void viewDoctorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageDoctors frm = new ManageDoctors();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void viewAuditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Audit frm = new Audit();
            Program.OpenNewForm(frm);
            this.Close();
        }

        //
        // PATIENTS TAB
        //

        private void viewDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDoctors frm = new ManageDoctors();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void viewMedicalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMedicalRecords frm = new ManageMedicalRecords();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void manageBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBilling frm = new ManageBilling();
            Program.OpenNewForm(frm);
            this.Close();
        }
    }
}
