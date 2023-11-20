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
    public partial class ManageBilling : Form
    {
        public int timerValue = 0;
        public ManageBilling()
        {
            InitializeComponent();
        }

        private void ManageBilling_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (databridge.dataState.userrole == "Patient")
            {
                add_btn.Visible = false;
                delete_btn.Visible = false;
                update_btn.Visible = false;
            }

            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_billing");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                timerValue = 0;
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    billingId_txt.Text = selectedRow.Cells["billing_id"].Value.ToString();
                    doctorId_txt.Text = selectedRow.Cells["doctor_id"].Value.ToString();
                    patientId_txt.Text = selectedRow.Cells["patient_id"].Value.ToString();
                    recordId_txt.Text = selectedRow.Cells["record_id"].Value.ToString();
                    billingDate_dtp.Text = selectedRow.Cells["billing_date"].Value.ToString();
                    billingTotal_txt.Text = selectedRow.Cells["billing_total"].Value.ToString();
                    billingPaymentstatus_cmb.Text = selectedRow.Cells["billing_paymentstatus"].Value.ToString();
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
            billingId_txt.Clear();
            doctorId_txt.Clear();
            patientId_txt.Clear();
            recordId_txt.Clear();
            billingDate_dtp.Text = DateTime.Now.ToString();
            billingTotal_txt.Clear();
            billingPaymentstatus_cmb.SelectedIndex = -1;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timerValue = 0;
                int bid = int.Parse(billingId_txt.Text);
                int pid = int.Parse(patientId_txt.Text);
                int did = int.Parse(doctorId_txt.Text);
                int rid = int.Parse(recordId_txt.Text);
                string date = billingDate_dtp.Text;
                string total = billingTotal_txt.Text;
                string status = billingPaymentstatus_cmb.Text;

                sqlFunctions.AddBilling(bid, pid, did, rid, date, total, status);
                sqlFunctions.InsertAuditData(databridge.dataState.userid, $"added billing");
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
                int bid = int.Parse(billingId_txt.Text);

                sqlFunctions.DeleteBilling(bid);
                sqlFunctions.InsertAuditData(databridge.dataState.userid, $"deleted billing");
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
                int bid = int.Parse(billingId_txt.Text);
                int pid = int.Parse(patientId_txt.Text);
                int did = int.Parse(doctorId_txt.Text);
                int rid = int.Parse(recordId_txt.Text);
                string date = billingDate_dtp.Text;
                string total = billingTotal_txt.Text;
                string status = billingPaymentstatus_cmb.Text;

                sqlFunctions.UpdateBilling(bid, pid, did, rid, date, total, status);
                sqlFunctions.InsertAuditData(databridge.dataState.userid, $"updated billing");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timerValue = 0;
                int bid = int.Parse(billingId_txt.Text);

                sqlFunctions.MarkBillingAsPaid(bid);
                sqlFunctions.InsertAuditData(databridge.dataState.userid, $"paid billing");
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            Program.OpenNewForm(frm);
            this.Close();
        }
    }
}
