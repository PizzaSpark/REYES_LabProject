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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "user_id";
            // 
            // userId_txt
            // 
            this.userId_txt.Location = new System.Drawing.Point(12, 28);
            this.userId_txt.Name = "userId_txt";
            this.userId_txt.ReadOnly = true;
            this.userId_txt.Size = new System.Drawing.Size(100, 22);
            this.userId_txt.TabIndex = 2;
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(177, 28);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.ReadOnly = true;
            this.userName_txt.Size = new System.Drawing.Size(100, 22);
            this.userName_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "user_name";
            // 
            // userRole_txt
            // 
            this.userRole_txt.Location = new System.Drawing.Point(12, 95);
            this.userRole_txt.Name = "userRole_txt";
            this.userRole_txt.ReadOnly = true;
            this.userRole_txt.Size = new System.Drawing.Size(100, 22);
            this.userRole_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "user_role";
            // 
            // userIsactive_txt
            // 
            this.userIsactive_txt.Location = new System.Drawing.Point(177, 95);
            this.userIsactive_txt.Name = "userIsactive_txt";
            this.userIsactive_txt.ReadOnly = true;
            this.userIsactive_txt.Size = new System.Drawing.Size(100, 22);
            this.userIsactive_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "user_isactive";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(15, 189);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // activate_btn
            // 
            this.activate_btn.Location = new System.Drawing.Point(96, 189);
            this.activate_btn.Name = "activate_btn";
            this.activate_btn.Size = new System.Drawing.Size(75, 23);
            this.activate_btn.TabIndex = 10;
            this.activate_btn.Text = "Activate";
            this.activate_btn.UseVisualStyleBackColor = true;
            this.activate_btn.Click += new System.EventHandler(this.activate_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(585, 189);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 11;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // deactivate_btn
            // 
            this.deactivate_btn.Location = new System.Drawing.Point(177, 189);
            this.deactivate_btn.Name = "deactivate_btn";
            this.deactivate_btn.Size = new System.Drawing.Size(97, 23);
            this.deactivate_btn.TabIndex = 12;
            this.deactivate_btn.Text = "Suspend";
            this.deactivate_btn.UseVisualStyleBackColor = true;
            this.deactivate_btn.Click += new System.EventHandler(this.deactivate_btn_Click);
            // 
            // viewActivated_btn
            // 
            this.viewActivated_btn.Location = new System.Drawing.Point(384, 57);
            this.viewActivated_btn.Name = "viewActivated_btn";
            this.viewActivated_btn.Size = new System.Drawing.Size(141, 23);
            this.viewActivated_btn.TabIndex = 13;
            this.viewActivated_btn.Text = "View Activated";
            this.viewActivated_btn.UseVisualStyleBackColor = true;
            this.viewActivated_btn.Click += new System.EventHandler(this.viewActivated_btn_Click);
            // 
            // viewDeactivated_btn
            // 
            this.viewDeactivated_btn.Location = new System.Drawing.Point(384, 28);
            this.viewDeactivated_btn.Name = "viewDeactivated_btn";
            this.viewDeactivated_btn.Size = new System.Drawing.Size(141, 23);
            this.viewDeactivated_btn.TabIndex = 14;
            this.viewDeactivated_btn.Text = "View Deactivated";
            this.viewDeactivated_btn.UseVisualStyleBackColor = true;
            this.viewDeactivated_btn.Click += new System.EventHandler(this.viewDeactivated_btn_Click);
            // 
            // viewSuspended_btn
            // 
            this.viewSuspended_btn.Location = new System.Drawing.Point(384, 86);
            this.viewSuspended_btn.Name = "viewSuspended_btn";
            this.viewSuspended_btn.Size = new System.Drawing.Size(141, 23);
            this.viewSuspended_btn.TabIndex = 15;
            this.viewSuspended_btn.Text = "View Suspended";
            this.viewSuspended_btn.UseVisualStyleBackColor = true;
            this.viewSuspended_btn.Click += new System.EventHandler(this.viewSuspended_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ActivateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 479);
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
            this.Name = "ActivateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivateUser";
            this.Load += new System.EventHandler(this.ActivateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}