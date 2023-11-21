﻿namespace REYES_LabProject.Forms
{
    partial class ManageMedicalRecords
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
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorId_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patientId_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recordId_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordPrescription_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recordTreatmentplan_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.recordDiagnosis_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.recordDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.back_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(322, 174);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 38;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(241, 174);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 37;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(160, 174);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 36;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(79, 174);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 35;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "record_date";
            // 
            // doctorId_txt
            // 
            this.doctorId_txt.Location = new System.Drawing.Point(76, 85);
            this.doctorId_txt.Name = "doctorId_txt";
            this.doctorId_txt.ReadOnly = true;
            this.doctorId_txt.Size = new System.Drawing.Size(100, 22);
            this.doctorId_txt.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "doctor_id";
            // 
            // patientId_txt
            // 
            this.patientId_txt.Location = new System.Drawing.Point(241, 18);
            this.patientId_txt.Name = "patientId_txt";
            this.patientId_txt.ReadOnly = true;
            this.patientId_txt.Size = new System.Drawing.Size(100, 22);
            this.patientId_txt.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "patient_id";
            // 
            // recordId_txt
            // 
            this.recordId_txt.Location = new System.Drawing.Point(76, 18);
            this.recordId_txt.Name = "recordId_txt";
            this.recordId_txt.ReadOnly = true;
            this.recordId_txt.Size = new System.Drawing.Size(100, 22);
            this.recordId_txt.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "record_id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 249);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // recordPrescription_txt
            // 
            this.recordPrescription_txt.Location = new System.Drawing.Point(539, 85);
            this.recordPrescription_txt.Name = "recordPrescription_txt";
            this.recordPrescription_txt.ReadOnly = true;
            this.recordPrescription_txt.Size = new System.Drawing.Size(100, 22);
            this.recordPrescription_txt.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "record_prescription";
            // 
            // recordTreatmentplan_txt
            // 
            this.recordTreatmentplan_txt.Location = new System.Drawing.Point(539, 18);
            this.recordTreatmentplan_txt.Name = "recordTreatmentplan_txt";
            this.recordTreatmentplan_txt.ReadOnly = true;
            this.recordTreatmentplan_txt.Size = new System.Drawing.Size(100, 22);
            this.recordTreatmentplan_txt.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "record_treatmentplan";
            // 
            // recordDiagnosis_txt
            // 
            this.recordDiagnosis_txt.Location = new System.Drawing.Point(374, 18);
            this.recordDiagnosis_txt.Name = "recordDiagnosis_txt";
            this.recordDiagnosis_txt.ReadOnly = true;
            this.recordDiagnosis_txt.Size = new System.Drawing.Size(100, 22);
            this.recordDiagnosis_txt.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "record_diagnosis";
            // 
            // recordDate_dtp
            // 
            this.recordDate_dtp.Location = new System.Drawing.Point(241, 85);
            this.recordDate_dtp.Name = "recordDate_dtp";
            this.recordDate_dtp.Size = new System.Drawing.Size(233, 22);
            this.recordDate_dtp.TabIndex = 45;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(649, 174);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 88;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManageMedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.recordDate_dtp);
            this.Controls.Add(this.recordPrescription_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.recordTreatmentplan_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.recordDiagnosis_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doctorId_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientId_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordId_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageMedicalRecords";
            this.Text = "ManageMedicalRecords";
            this.Load += new System.EventHandler(this.ManageMedicalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doctorId_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patientId_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recordId_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox recordPrescription_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recordTreatmentplan_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox recordDiagnosis_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker recordDate_dtp;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Timer timer1;
    }
}