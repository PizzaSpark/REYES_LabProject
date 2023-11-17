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
    public partial class ManageRooms : Form
    {
        public ManageRooms()
        {
            InitializeComponent();
        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_room");
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            roomId_txt.Clear();
            roomNumber_txt.Clear();
            roomType_txt.Clear();
            roomPrice_txt.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Assuming that the DataGridView columns are named user_id, user_name, user_isactive, and user_role
                roomId_txt.Text = selectedRow.Cells["user_id"].Value.ToString();
                roomNumber_txt.Text = selectedRow.Cells["user_name"].Value.ToString();
                roomType_txt.Text = selectedRow.Cells["user_isactive"].Value.ToString();
                roomPrice_txt.Text = selectedRow.Cells["user_role"].Value.ToString();
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            Program.OpenNewForm(dashboard);
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            String number = roomNumber_txt.Text;
            String type = roomType_txt.Text;
            String price = roomPrice_txt.Text;


            sqlFunctions.InsertRoom(number,type,price);
            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_room");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            String id = roomId_txt.Text;

            sqlFunctions.DeleteRowByPrimaryKey("tbl_room", "room_id", int.Parse(id));
            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_room");
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(roomId_txt.Text);
            String number = roomNumber_txt.Text;
            String type = roomType_txt.Text;
            String price = roomPrice_txt.Text;

            sqlFunctions.UpdateRoom(id, number, type, price);
            dataGridView1.DataSource = sqlFunctions.GetTableData("tbl_room");
        }
    }
}
