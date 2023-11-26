namespace REYES_LabProject.Forms
{
    partial class Audit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audit));
            this.back_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.back_btn.Location = new System.Drawing.Point(812, 25);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(84, 39);
            this.back_btn.TabIndex = 12;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 374);
            this.dataGridView1.TabIndex = 13;
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
            this.label5.Location = new System.Drawing.Point(20, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 74;
            this.label5.Text = "search_id";
            // 
            // searchid_txt
            // 
            this.searchid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchid_txt.Location = new System.Drawing.Point(23, 36);
            this.searchid_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchid_txt.Name = "searchid_txt";
            this.searchid_txt.Size = new System.Drawing.Size(100, 28);
            this.searchid_txt.TabIndex = 73;
            // 
            // search_ptb
            // 
            this.search_ptb.BackColor = System.Drawing.Color.Transparent;
            this.search_ptb.Image = global::REYES_LabProject.Properties.Resources.search_icon;
            this.search_ptb.Location = new System.Drawing.Point(156, 36);
            this.search_ptb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_ptb.Name = "search_ptb";
            this.search_ptb.Size = new System.Drawing.Size(21, 22);
            this.search_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_ptb.TabIndex = 72;
            this.search_ptb.TabStop = false;
            this.search_ptb.Click += new System.EventHandler(this.search_ptb_Click);
            // 
            // Audit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 574);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchid_txt);
            this.Controls.Add(this.search_ptb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Audit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audit";
            this.Load += new System.EventHandler(this.Audit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchid_txt;
        private System.Windows.Forms.PictureBox search_ptb;
    }
}