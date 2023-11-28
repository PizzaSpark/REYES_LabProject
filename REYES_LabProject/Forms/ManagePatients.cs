using REYES_LabProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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

                if (toolFunctions.StringSanitizer(patientName_txt.Text))
                {
                    MessageBox.Show("You can't do that oh oh");
                }
                else
                {
                    sqlFunctions.UpdateUserFromPatient(int.Parse(patientId_txt.Text), int.Parse(userId_txt.Text), patientName_txt.Text);
                    dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_patient");
                    sqlFunctions.InsertAuditData(databridge.dataState.userid, $"updated patient info");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                timerValue = 0;
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    patientId_txt.Text = selectedRow.Cells["patient_id"].Value.ToString();
                    userId_txt.Text = selectedRow.Cells["user_id"].Value.ToString();
                    patientName_txt.Text = selectedRow.Cells["patient_name"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void search_ptb_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchid_txt.Text == "")
                {
                    dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_patient");
                }
                else
                {
                    int id = int.Parse(searchid_txt.Text);
                    dataGridView1.DataSource = sqlFunctions.GetDataByPrimaryKey("tbl_patient", id);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }
    }
}
