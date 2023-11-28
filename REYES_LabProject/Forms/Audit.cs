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
    public partial class Audit : Form
    {
        public int timerValue = 0;
        public Audit()
        {
            InitializeComponent();
        }

        private void Audit_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_audit");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            Program.OpenNewForm(dashboard);
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

        private void search_ptb_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchid_txt.Text == "")
                {
                    dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_audit");
                }
                else
                {
                    int id = int.Parse(searchid_txt.Text);
                    dataGridView1.DataSource = sqlFunctions.GetDataByPrimaryKey("tbl_audit", id);
                }    
            } 
            catch(Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
            
        }
    }
}
