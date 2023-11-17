namespace REYES_LabProject.Forms
{
    partial class ManageRooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.roomPrice_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roomType_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomNumber_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomId_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(244, 176);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 23;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(160, 176);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 22;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(79, 176);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 21;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // roomPrice_txt
            // 
            this.roomPrice_txt.Location = new System.Drawing.Point(241, 82);
            this.roomPrice_txt.Name = "roomPrice_txt";
            this.roomPrice_txt.ReadOnly = true;
            this.roomPrice_txt.Size = new System.Drawing.Size(100, 22);
            this.roomPrice_txt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "room_price";
            // 
            // roomType_txt
            // 
            this.roomType_txt.Location = new System.Drawing.Point(76, 82);
            this.roomType_txt.Name = "roomType_txt";
            this.roomType_txt.ReadOnly = true;
            this.roomType_txt.Size = new System.Drawing.Size(100, 22);
            this.roomType_txt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "room_type";
            // 
            // roomNumber_txt
            // 
            this.roomNumber_txt.Location = new System.Drawing.Point(241, 15);
            this.roomNumber_txt.Name = "roomNumber_txt";
            this.roomNumber_txt.ReadOnly = true;
            this.roomNumber_txt.Size = new System.Drawing.Size(100, 22);
            this.roomNumber_txt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "room_number";
            // 
            // roomId_txt
            // 
            this.roomId_txt.Location = new System.Drawing.Point(76, 15);
            this.roomId_txt.Name = "roomId_txt";
            this.roomId_txt.ReadOnly = true;
            this.roomId_txt.Size = new System.Drawing.Size(100, 22);
            this.roomId_txt.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "room_id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 249);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(325, 176);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 24;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(649, 176);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 25;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.roomPrice_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomType_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomNumber_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomId_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageRooms";
            this.Text = "ManageRooms";
            this.Load += new System.EventHandler(this.ManageRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox roomPrice_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomType_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomNumber_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomId_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button back_btn;
    }
}