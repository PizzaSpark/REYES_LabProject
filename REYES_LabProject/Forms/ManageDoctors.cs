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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace REYES_LabProject.Forms
{
    public partial class ManageDoctors : Form
    {
        public int timerValue = 0;
        public ManageDoctors()
        {
            InitializeComponent();
        }

        private void ManageDoctors_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (databridge.dataState.userrole == "Patient" || databridge.dataState.userrole == "Doctor")
            {
                update_btn.Visible = false;
            }

            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_doctor");
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            timerValue = 0;
            userId_txt.Clear();
            doctorId_txt.Clear();
            doctorName_txt.Clear();
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                timerValue = 0;

                if (toolFunctions.StringSanitizer(doctorId_txt.Text, doctorName_txt.Text))
                {
                    MessageBox.Show("You can't do that oh oh");
                }
                else
                {
                    sqlFunctions.UpdateUserFromDoctor(int.Parse(doctorId_txt.Text), int.Parse(userId_txt.Text), doctorName_txt.Text);
                    dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_doctor");
                    sqlFunctions.InsertAuditData(databridge.dataState.userid, $"updated doctor info");

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

                    
                    doctorId_txt.Text = selectedRow.Cells["doctor_id"].Value.ToString();
                    doctorName_txt.Text = selectedRow.Cells["doctor_name"].Value.ToString();
                    userId_txt.Text = selectedRow.Cells["user_id"].Value.ToString();

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
                    dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_doctor");
                }
                else
                {
                    int id = int.Parse(searchid_txt.Text);
                    dataGridView1.DataSource = sqlFunctions.GetDataByPrimaryKey("tbl_doctor", id);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }
    }
}
