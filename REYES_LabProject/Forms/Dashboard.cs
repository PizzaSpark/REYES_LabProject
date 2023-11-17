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

            if(roleDisplay_txt.Text != "Admin")
            {
                RemoveToolStripMenuItemByText("Admin");
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
            timerValue++;
            timerDisplay_txt.Text = timerValue.ToString();

            if (timerValue >= 60)
            {
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void activateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateUser frm = new ActivateUser();
            Program.OpenNewForm(frm);
            this.Close();
        }

        private void auditLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Audit frm = new Audit();
            Program.OpenNewForm(frm);
            this.Close();
        }
    }
}
