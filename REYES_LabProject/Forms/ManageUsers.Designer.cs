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
            this.back_btn = new System.Windows.Forms.Button();
            this.activate_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.userIsactive_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userRole_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userId_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(244, 176);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 23;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // activate_btn
            // 
            this.activate_btn.Location = new System.Drawing.Point(160, 176);
            this.activate_btn.Name = "activate_btn";
            this.activate_btn.Size = new System.Drawing.Size(75, 23);
            this.activate_btn.TabIndex = 22;
            this.activate_btn.Text = "Activate";
            this.activate_btn.UseVisualStyleBackColor = true;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(79, 176);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 21;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            // 
            // userIsactive_txt
            // 
            this.userIsactive_txt.Location = new System.Drawing.Point(241, 82);
            this.userIsactive_txt.Name = "userIsactive_txt";
            this.userIsactive_txt.ReadOnly = true;
            this.userIsactive_txt.Size = new System.Drawing.Size(100, 22);
            this.userIsactive_txt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "user_isactive";
            // 
            // userRole_txt
            // 
            this.userRole_txt.Location = new System.Drawing.Point(76, 82);
            this.userRole_txt.Name = "userRole_txt";
            this.userRole_txt.ReadOnly = true;
            this.userRole_txt.Size = new System.Drawing.Size(100, 22);
            this.userRole_txt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "user_role";
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(241, 15);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.ReadOnly = true;
            this.userName_txt.Size = new System.Drawing.Size(100, 22);
            this.userName_txt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "user_name";
            // 
            // userId_txt
            // 
            this.userId_txt.Location = new System.Drawing.Point(76, 15);
            this.userId_txt.Name = "userId_txt";
            this.userId_txt.ReadOnly = true;
            this.userId_txt.Size = new System.Drawing.Size(100, 22);
            this.userId_txt.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "user_id";
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
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button activate_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox userIsactive_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userRole_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userId_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}