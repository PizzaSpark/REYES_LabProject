namespace REYES_LabProject.Forms
{
    partial class ActivateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivateUser));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.userId_txt = new System.Windows.Forms.TextBox();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userRole_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userIsactive_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.activate_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.deactivate_btn = new System.Windows.Forms.Button();
            this.viewActivated_btn = new System.Windows.Forms.Button();
            this.viewDeactivated_btn = new System.Windows.Forms.Button();
            this.viewSuspended_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.search_ptb = new System.Windows.Forms.PictureBox();
            this.searchid_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "user_id";
            // 
            // userId_txt
            // 
            this.userId_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId_txt.Location = new System.Drawing.Point(52, 71);
            this.userId_txt.Name = "userId_txt";
            this.userId_txt.ReadOnly = true;
            this.userId_txt.Size = new System.Drawing.Size(100, 28);
            this.userId_txt.TabIndex = 2;
            // 
            // userName_txt
            // 
            this.userName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_txt.Location = new System.Drawing.Point(217, 71);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.ReadOnly = true;
            this.userName_txt.Size = new System.Drawing.Size(228, 28);
            this.userName_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(217, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "user_name";
            // 
            // userRole_txt
            // 
            this.userRole_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRole_txt.Location = new System.Drawing.Point(52, 138);
            this.userRole_txt.Name = "userRole_txt";
            this.userRole_txt.ReadOnly = true;
            this.userRole_txt.Size = new System.Drawing.Size(140, 28);
            this.userRole_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(52, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "user_role";
            // 
            // userIsactive_txt
            // 
            this.userIsactive_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIsactive_txt.Location = new System.Drawing.Point(217, 138);
            this.userIsactive_txt.Name = "userIsactive_txt";
            this.userIsactive_txt.ReadOnly = true;
            this.userIsactive_txt.Size = new System.Drawing.Size(128, 28);
            this.userIsactive_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(217, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "user_isactive";
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.clear_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.clear_btn.Location = new System.Drawing.Point(20, 238);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(63, 37);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // activate_btn
            // 
            this.activate_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.activate_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.activate_btn.Location = new System.Drawing.Point(101, 238);
            this.activate_btn.Name = "activate_btn";
            this.activate_btn.Size = new System.Drawing.Size(75, 37);
            this.activate_btn.TabIndex = 10;
            this.activate_btn.Text = "Activate";
            this.activate_btn.UseVisualStyleBackColor = false;
            this.activate_btn.Click += new System.EventHandler(this.activate_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.back_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.back_btn.Location = new System.Drawing.Point(590, 238);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(63, 37);
            this.back_btn.TabIndex = 11;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // deactivate_btn
            // 
            this.deactivate_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.deactivate_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.deactivate_btn.Location = new System.Drawing.Point(182, 238);
            this.deactivate_btn.Name = "deactivate_btn";
            this.deactivate_btn.Size = new System.Drawing.Size(100, 37);
            this.deactivate_btn.TabIndex = 12;
            this.deactivate_btn.Text = "Suspend";
            this.deactivate_btn.UseVisualStyleBackColor = false;
            this.deactivate_btn.Click += new System.EventHandler(this.deactivate_btn_Click);
            // 
            // viewActivated_btn
            // 
            this.viewActivated_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.viewActivated_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.viewActivated_btn.Location = new System.Drawing.Point(524, 133);
            this.viewActivated_btn.Name = "viewActivated_btn";
            this.viewActivated_btn.Size = new System.Drawing.Size(129, 37);
            this.viewActivated_btn.TabIndex = 13;
            this.viewActivated_btn.Text = "View Activated";
            this.viewActivated_btn.UseVisualStyleBackColor = false;
            this.viewActivated_btn.Click += new System.EventHandler(this.viewActivated_btn_Click);
            // 
            // viewDeactivated_btn
            // 
            this.viewDeactivated_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.viewDeactivated_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.viewDeactivated_btn.Location = new System.Drawing.Point(524, 98);
            this.viewDeactivated_btn.Name = "viewDeactivated_btn";
            this.viewDeactivated_btn.Size = new System.Drawing.Size(129, 37);
            this.viewDeactivated_btn.TabIndex = 14;
            this.viewDeactivated_btn.Text = "View Deactivated";
            this.viewDeactivated_btn.UseVisualStyleBackColor = false;
            this.viewDeactivated_btn.Click += new System.EventHandler(this.viewDeactivated_btn_Click);
            // 
            // viewSuspended_btn
            // 
            this.viewSuspended_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.viewSuspended_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.viewSuspended_btn.Location = new System.Drawing.Point(524, 168);
            this.viewSuspended_btn.Name = "viewSuspended_btn";
            this.viewSuspended_btn.Size = new System.Drawing.Size(129, 37);
            this.viewSuspended_btn.TabIndex = 15;
            this.viewSuspended_btn.Text = "View Suspended";
            this.viewSuspended_btn.UseVisualStyleBackColor = false;
            this.viewSuspended_btn.Click += new System.EventHandler(this.viewSuspended_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // search_ptb
            // 
            this.search_ptb.BackColor = System.Drawing.Color.Transparent;
            this.search_ptb.Image = global::REYES_LabProject.Properties.Resources.search_icon;
            this.search_ptb.Location = new System.Drawing.Point(637, 34);
            this.search_ptb.Name = "search_ptb";
            this.search_ptb.Size = new System.Drawing.Size(22, 22);
            this.search_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_ptb.TabIndex = 16;
            this.search_ptb.TabStop = false;
            this.search_ptb.Click += new System.EventHandler(this.search_ptb_Click);
            // 
            // searchid_txt
            // 
            this.searchid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchid_txt.Location = new System.Drawing.Point(531, 34);
            this.searchid_txt.Name = "searchid_txt";
            this.searchid_txt.Size = new System.Drawing.Size(100, 28);
            this.searchid_txt.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(528, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "search_id";
            // 
            // ActivateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchid_txt);
            this.Controls.Add(this.search_ptb);
            this.Controls.Add(this.viewSuspended_btn);
            this.Controls.Add(this.viewDeactivated_btn);
            this.Controls.Add(this.viewActivated_btn);
            this.Controls.Add(this.deactivate_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.activate_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.userIsactive_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userRole_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userName_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userId_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivateUser";
            this.Load += new System.EventHandler(this.ActivateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userId_txt;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userRole_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userIsactive_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button activate_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button deactivate_btn;
        private System.Windows.Forms.Button viewActivated_btn;
        private System.Windows.Forms.Button viewDeactivated_btn;
        private System.Windows.Forms.Button viewSuspended_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox search_ptb;
        private System.Windows.Forms.TextBox searchid_txt;
        private System.Windows.Forms.Label label5;
    }
}