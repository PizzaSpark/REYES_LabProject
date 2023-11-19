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
    public partial class ManagePatients : Form
    {
        public int timerValue = 0;
        public ManagePatients()
        {
            InitializeComponent();
        }

        private void ManagePatients_Load(object sender, EventArgs e)
        {
            timer1.Start();

            if (databridge.dataState.userrole == "Patient")
            {
                update_btn.Visible = false;
            }

            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_patient");
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            timerValue = 0;
            userId_txt.Clear();
            patientId_txt.Clear();
            patientName_txt.Clear();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timerValue = 0;
                sqlFunctions.UpdateUserFromPatient(int.Parse(patientId_txt.Text), int.Parse(userId_txt.Text), patientName_txt.Text);
                dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_patient");
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
    }
}
