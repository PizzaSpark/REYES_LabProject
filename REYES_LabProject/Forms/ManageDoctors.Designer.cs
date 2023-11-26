namespace REYES_LabProject.Forms
{
    partial class ManageDoctors
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDoctors));
            this.back_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.userId_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.doctorName_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorId_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.searchid_txt = new System.Windows.Forms.TextBox();
            this.search_ptb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.back_btn.Location = new System.Drawing.Point(603, 201);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(77, 33);
            this.back_btn.TabIndex = 64;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.update_btn.Location = new System.Drawing.Point(202, 201);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(78, 33);
            this.update_btn.TabIndex = 63;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.clear_btn.Location = new System.Drawing.Point(118, 201);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(78, 33);
            this.clear_btn.TabIndex = 60;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // userId_txt
            // 
            this.userId_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId_txt.Location = new System.Drawing.Point(480, 94);
            this.userId_txt.Name = "userId_txt";
            this.userId_txt.Size = new System.Drawing.Size(150, 30);
            this.userId_txt.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(475, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "user_id";
            // 
            // doctorName_txt
            // 
            this.doctorName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorName_txt.Location = new System.Drawing.Point(317, 94);
            this.doctorName_txt.Name = "doctorName_txt";
            this.doctorName_txt.Size = new System.Drawing.Size(142, 30);
            this.doctorName_txt.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(317, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "doctor_name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 249);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // doctorId_txt
            // 
            this.doctorId_txt.Enabled = false;
            this.doctorId_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorId_txt.Location = new System.Drawing.Point(152, 94);
            this.doctorId_txt.Name = "doctorId_txt";
            this.doctorId_txt.ReadOnly = true;
            this.doctorId_txt.Size = new System.Drawing.Size(144, 30);
            this.doctorId_txt.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(152, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "doctor_id";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(622, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 74;
            this.label5.Text = "search_id";
            // 
            // searchid_txt
            // 
            this.searchid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchid_txt.Location = new System.Drawing.Point(625, 38);
            this.searchid_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchid_txt.Name = "searchid_txt";
            this.searchid_txt.Size = new System.Drawing.Size(100, 28);
            this.searchid_txt.TabIndex = 73;
            // 
            // search_ptb
            // 
            this.search_ptb.BackColor = System.Drawing.Color.Transparent;
            this.search_ptb.Image = global::REYES_LabProject.Properties.Resources.search_icon;
            this.search_ptb.Location = new System.Drawing.Point(758, 38);
            this.search_ptb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_ptb.Name = "search_ptb";
            this.search_ptb.Size = new System.Drawing.Size(21, 22);
            this.search_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_ptb.TabIndex = 72;
            this.search_ptb.TabStop = false;
            // 
            // ManageDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 509);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchid_txt);
            this.Controls.Add(this.search_ptb);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.userId_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.doctorName_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.doctorId_txt);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDoctors";
            this.Load += new System.EventHandler(this.ManageDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox userId_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox doctorName_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox doctorId_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchid_txt;
        private System.Windows.Forms.PictureBox search_ptb;
    }
}