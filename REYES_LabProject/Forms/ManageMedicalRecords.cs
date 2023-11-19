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
    public partial class ManageMedicalRecords : Form
    {
        public int timerValue = 0;
        public ManageMedicalRecords()
        {
            InitializeComponent();
        }

        private void ManageMedicalRecords_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (databridge.dataState.userrole == "Patient")
            {
                add_btn.Visible = false;
                delete_btn.Visible = false;
                update_btn.Visible = false;
            }

            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_medical_record");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                timerValue = 0;
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    
                    recordId_txt.Text = selectedRow.Cells["record_id"].Value.ToString();
                    patientId_txt.Text = selectedRow.Cells["patient_id"].Value.ToString();
                    doctorId_txt.Text = selectedRow.Cells["doctor_id"].Value.ToString();
                    recordDate_dtp.Text = selectedRow.Cells["record_date"].Value.ToString();
                    recordDiagnosis_txt.Text = selectedRow.Cells["record_diagnosis"].Value.ToString();
                    recordPrescription_txt.Text = selectedRow.Cells["record_prescription"].Value.ToString();
                    recordTreatmentplan_txt.Text = selectedRow.Cells["record_treatmentplan"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            timerValue = 0;
            recordId_txt.Clear();
            patientId_txt.Clear();
            doctorId_txt.Clear();
            recordDate_dtp.Text = DateTime.Now.ToString();
            recordDiagnosis_txt.Clear();
            recordPrescription_txt.Clear();
            recordTreatmentplan_txt.Clear();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timerValue = 0;
                int rid = int.Parse(recordId_txt.Text);
                int pid = int.Parse(patientId_txt.Text);
                int did = int.Parse(doctorId_txt.Text);
                string date = recordDate_dtp.Text;
                string diagnosis = recordDiagnosis_txt.Text;
                string prescription = recordPrescription_txt.Text;
                string plan = recordTreatmentplan_txt.Text;

                sqlFunctions.AddMedicalRecord(rid, pid, did, date, diagnosis, prescription, plan);
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timerValue = 0;
                int rid = int.Parse(recordId_txt.Text);

                sqlFunctions.DeleteMedicalRecord(rid);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timerValue = 0;
                int rid = int.Parse(recordId_txt.Text);
                int pid = int.Parse(patientId_txt.Text);
                int did = int.Parse(doctorId_txt.Text);
                string date = recordDate_dtp.Text;
                string diagnosis = recordDiagnosis_txt.Text;
                string prescription = recordPrescription_txt.Text;
                string plan = recordTreatmentplan_txt.Text;

                sqlFunctions.UpdateMedicalRecord(rid, pid, did, date, diagnosis, prescription, plan);
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
                MessageBox.Show("You have timed out.");

                Login frm = new Login();
                Program.OpenNewForm(frm);
                this.Close();
            }
        }
    }
}
