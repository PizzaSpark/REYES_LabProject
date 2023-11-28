namespace REYES_LabProject.Forms
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.capslock_indicator = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.role_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userId_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.passwordEye_ptb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchid_txt = new System.Windows.Forms.TextBox();
            this.search_ptb = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye_ptb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // capslock_indicator
            // 
            this.capslock_indicator.AutoSize = true;
            this.capslock_indicator.BackColor = System.Drawing.Color.Transparent;
            this.capslock_indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capslock_indicator.ForeColor = System.Drawing.Color.Red;
            this.capslock_indicator.Location = new System.Drawing.Point(437, 231);
            this.capslock_indicator.Name = "capslock_indicator";
            this.capslock_indicator.Size = new System.Drawing.Size(107, 18);
            this.capslock_indicator.TabIndex = 34;
            this.capslock_indicator.Text = "Capslock is on";
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(52, 252);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(492, 28);
            this.password_txt.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(48, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "password";
            // 
            // role_txt
            // 
            this.role_txt.Enabled = false;
            this.role_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_txt.Location = new System.Drawing.Point(309, 176);
            this.role_txt.Name = "role_txt";
            this.role_txt.ReadOnly = true;
            this.role_txt.Size = new System.Drawing.Size(235, 28);
            this.role_txt.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(306, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "role";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.back_btn.Location = new System.Drawing.Point(292, 305);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(125, 43);
            this.back_btn.TabIndex = 28;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.save_btn.Location = new System.Drawing.Point(162, 305);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(125, 43);
            this.save_btn.TabIndex = 27;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // username_txt
            // 
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(52, 176);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(236, 28);
            this.username_txt.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(49, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "username";
            // 
            // userId_txt
            // 
            this.userId_txt.Enabled = false;
            this.userId_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId_txt.Location = new System.Drawing.Point(51, 95);
            this.userId_txt.Name = "userId_txt";
            this.userId_txt.ReadOnly = true;
            this.userId_txt.Size = new System.Drawing.Size(236, 28);
            this.userId_txt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(48, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "userID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 211);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // passwordEye_ptb
            // 
            this.passwordEye_ptb.Image = global::REYES_LabProject.Properties.Resources.closedEye;
            this.passwordEye_ptb.Location = new System.Drawing.Point(550, 252);
            this.passwordEye_ptb.Name = "passwordEye_ptb";
            this.passwordEye_ptb.Size = new System.Drawing.Size(30, 30);
            this.passwordEye_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordEye_ptb.TabIndex = 33;
            this.passwordEye_ptb.TabStop = false;
            this.passwordEye_ptb.Click += new System.EventHandler(this.passwordEye_ptb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(329, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 77;
            this.label2.Text = "search_id";
            // 
            // searchid_txt
            // 
            this.searchid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchid_txt.Location = new System.Drawing.Point(437, 16);
            this.searchid_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchid_txt.Name = "searchid_txt";
            this.searchid_txt.Size = new System.Drawing.Size(130, 28);
            this.searchid_txt.TabIndex = 76;
            // 
            // search_ptb
            // 
            this.search_ptb.BackColor = System.Drawing.Color.Transparent;
            this.search_ptb.Image = global::REYES_LabProject.Properties.Resources.search_icon;
            this.search_ptb.Location = new System.Drawing.Point(585, 16);
            this.search_ptb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_ptb.Name = "search_ptb";
            this.search_ptb.Size = new System.Drawing.Size(21, 22);
            this.search_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_ptb.TabIndex = 75;
            this.search_ptb.TabStop = false;
            this.search_ptb.Click += new System.EventHandler(this.search_ptb_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "closedEye.png");
            this.imageList1.Images.SetKeyName(1, "openEye.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 590);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchid_txt);
            this.Controls.Add(this.search_ptb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.capslock_indicator);
            this.Controls.Add(this.passwordEye_ptb);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.role_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userId_txt);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManageUsers_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye_ptb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label capslock_indicator;
        private System.Windows.Forms.PictureBox passwordEye_ptb;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox role_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userId_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchid_txt;
        private System.Windows.Forms.PictureBox search_ptb;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}