namespace REYES_LabProject
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMedicalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePatientsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMedicalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBillingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDoctorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAuditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMedicalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.usernameDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.roleDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.userIdDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.categoryIdDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.categoryNameDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.patientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.profileToolStripMenuItem.Text = "Settings";
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.userInfoToolStripMenuItem.Text = "Edit Info";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateUserToolStripMenuItem,
            this.manageDoctorsToolStripMenuItem,
            this.managePatientsToolStripMenuItem,
            this.manageMedicalRecordsToolStripMenuItem,
            this.manageBillingToolStripMenuItem,
            this.auditLogToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // activateUserToolStripMenuItem
            // 
            this.activateUserToolStripMenuItem.Name = "activateUserToolStripMenuItem";
            this.activateUserToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.activateUserToolStripMenuItem.Text = "User Activation";
            this.activateUserToolStripMenuItem.Click += new System.EventHandler(this.activateUserToolStripMenuItem_Click);
            // 
            // manageDoctorsToolStripMenuItem
            // 
            this.manageDoctorsToolStripMenuItem.Name = "manageDoctorsToolStripMenuItem";
            this.manageDoctorsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageDoctorsToolStripMenuItem.Text = "Manage Doctors";
            this.manageDoctorsToolStripMenuItem.Click += new System.EventHandler(this.manageDoctorsToolStripMenuItem_Click);
            // 
            // managePatientsToolStripMenuItem
            // 
            this.managePatientsToolStripMenuItem.Name = "managePatientsToolStripMenuItem";
            this.managePatientsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.managePatientsToolStripMenuItem.Text = "Manage Patients";
            this.managePatientsToolStripMenuItem.Click += new System.EventHandler(this.managePatientsToolStripMenuItem_Click);
            // 
            // manageMedicalRecordsToolStripMenuItem
            // 
            this.manageMedicalRecordsToolStripMenuItem.Name = "manageMedicalRecordsToolStripMenuItem";
            this.manageMedicalRecordsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageMedicalRecordsToolStripMenuItem.Text = "Manage Medical Records";
            this.manageMedicalRecordsToolStripMenuItem.Click += new System.EventHandler(this.manageMedicalRecordsToolStripMenuItem_Click);
            // 
            // manageBillingToolStripMenuItem
            // 
            this.manageBillingToolStripMenuItem.Name = "manageBillingToolStripMenuItem";
            this.manageBillingToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageBillingToolStripMenuItem.Text = "Manage Billing";
            this.manageBillingToolStripMenuItem.Click += new System.EventHandler(this.manageBillingToolStripMenuItem_Click);
            // 
            // auditLogToolStripMenuItem
            // 
            this.auditLogToolStripMenuItem.Name = "auditLogToolStripMenuItem";
            this.auditLogToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.auditLogToolStripMenuItem.Text = "Audit Log";
            this.auditLogToolStripMenuItem.Click += new System.EventHandler(this.auditLogToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePatientsListToolStripMenuItem,
            this.manageMedicalRecordToolStripMenuItem,
            this.manageBillingToolStripMenuItem1,
            this.viewDoctorsToolStripMenuItem1,
            this.viewAuditToolStripMenuItem1});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // managePatientsListToolStripMenuItem
            // 
            this.managePatientsListToolStripMenuItem.Name = "managePatientsListToolStripMenuItem";
            this.managePatientsListToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.managePatientsListToolStripMenuItem.Text = "Manage Patients";
            this.managePatientsListToolStripMenuItem.Click += new System.EventHandler(this.managePatientsListToolStripMenuItem_Click);
            // 
            // manageMedicalRecordToolStripMenuItem
            // 
            this.manageMedicalRecordToolStripMenuItem.Name = "manageMedicalRecordToolStripMenuItem";
            this.manageMedicalRecordToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageMedicalRecordToolStripMenuItem.Text = "Manage Medical Records";
            this.manageMedicalRecordToolStripMenuItem.Click += new System.EventHandler(this.manageMedicalRecordToolStripMenuItem_Click);
            // 
            // manageBillingToolStripMenuItem1
            // 
            this.manageBillingToolStripMenuItem1.Name = "manageBillingToolStripMenuItem1";
            this.manageBillingToolStripMenuItem1.Size = new System.Drawing.Size(260, 26);
            this.manageBillingToolStripMenuItem1.Text = "Manage Billing";
            this.manageBillingToolStripMenuItem1.Click += new System.EventHandler(this.manageBillingToolStripMenuItem1_Click);
            // 
            // viewDoctorsToolStripMenuItem1
            // 
            this.viewDoctorsToolStripMenuItem1.Name = "viewDoctorsToolStripMenuItem1";
            this.viewDoctorsToolStripMenuItem1.Size = new System.Drawing.Size(260, 26);
            this.viewDoctorsToolStripMenuItem1.Text = "View Doctors";
            this.viewDoctorsToolStripMenuItem1.Click += new System.EventHandler(this.viewDoctorsToolStripMenuItem1_Click);
            // 
            // viewAuditToolStripMenuItem1
            // 
            this.viewAuditToolStripMenuItem1.Name = "viewAuditToolStripMenuItem1";
            this.viewAuditToolStripMenuItem1.Size = new System.Drawing.Size(260, 26);
            this.viewAuditToolStripMenuItem1.Text = "View Audit";
            this.viewAuditToolStripMenuItem1.Click += new System.EventHandler(this.viewAuditToolStripMenuItem1_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDoctorsToolStripMenuItem,
            this.viewMedicalRecordsToolStripMenuItem,
            this.manageBillsToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // viewDoctorsToolStripMenuItem
            // 
            this.viewDoctorsToolStripMenuItem.Name = "viewDoctorsToolStripMenuItem";
            this.viewDoctorsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.viewDoctorsToolStripMenuItem.Text = "View Doctors";
            this.viewDoctorsToolStripMenuItem.Click += new System.EventHandler(this.viewDoctorsToolStripMenuItem_Click);
            // 
            // viewMedicalRecordsToolStripMenuItem
            // 
            this.viewMedicalRecordsToolStripMenuItem.Name = "viewMedicalRecordsToolStripMenuItem";
            this.viewMedicalRecordsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.viewMedicalRecordsToolStripMenuItem.Text = "View Medical Records";
            this.viewMedicalRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewMedicalRecordsToolStripMenuItem_Click);
            // 
            // manageBillsToolStripMenuItem
            // 
            this.manageBillsToolStripMenuItem.Name = "manageBillsToolStripMenuItem";
            this.manageBillsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.manageBillsToolStripMenuItem.Text = "Manage Bills";
            this.manageBillsToolStripMenuItem.Click += new System.EventHandler(this.manageBillsToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.userIdDisplay_txt,
            this.toolStripStatusLabel6,
            this.categoryIdDisplay_txt,
            this.toolStripStatusLabel1,
            this.usernameDisplay_txt,
            this.toolStripStatusLabel3,
            this.roleDisplay_txt,
            this.toolStripStatusLabel2,
            this.dateDisplay_txt,
            this.toolStripStatusLabel5,
            this.timerDisplay_txt,
            this.toolStripStatusLabel7,
            this.categoryNameDisplay_txt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1070, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 20);
            this.toolStripStatusLabel1.Text = "Username";
            // 
            // usernameDisplay_txt
            // 
            this.usernameDisplay_txt.Name = "usernameDisplay_txt";
            this.usernameDisplay_txt.Size = new System.Drawing.Size(15, 20);
            this.usernameDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(40, 20);
            this.toolStripStatusLabel3.Text = "Role";
            // 
            // roleDisplay_txt
            // 
            this.roleDisplay_txt.Name = "roleDisplay_txt";
            this.roleDisplay_txt.Size = new System.Drawing.Size(15, 20);
            this.roleDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 20);
            this.toolStripStatusLabel2.Text = "Date";
            // 
            // dateDisplay_txt
            // 
            this.dateDisplay_txt.Name = "dateDisplay_txt";
            this.dateDisplay_txt.Size = new System.Drawing.Size(15, 20);
            this.dateDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusLabel5.Text = "Timeout";
            // 
            // timerDisplay_txt
            // 
            this.timerDisplay_txt.Name = "timerDisplay_txt";
            this.timerDisplay_txt.Size = new System.Drawing.Size(15, 20);
            this.timerDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel4.Text = "UserID";
            // 
            // userIdDisplay_txt
            // 
            this.userIdDisplay_txt.Name = "userIdDisplay_txt";
            this.userIdDisplay_txt.Size = new System.Drawing.Size(15, 20);
            this.userIdDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(89, 20);
            this.toolStripStatusLabel6.Text = "CategoryID";
            // 
            // categoryIdDisplay_txt
            // 
            this.categoryIdDisplay_txt.Name = "categoryIdDisplay_txt";
            this.categoryIdDisplay_txt.Size = new System.Drawing.Size(15, 20);
            this.categoryIdDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(112, 20);
            this.toolStripStatusLabel7.Text = "Categoryname";
            // 
            // categoryNameDisplay_txt
            // 
            this.categoryNameDisplay_txt.Name = "categoryNameDisplay_txt";
            this.categoryNameDisplay_txt.Size = new System.Drawing.Size(15, 20);
            this.categoryNameDisplay_txt.Text = "-";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 543);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIN";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBillingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageMedicalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAuditToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewMedicalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDoctorsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel usernameDisplay_txt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel roleDisplay_txt;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel dateDisplay_txt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel timerDisplay_txt;
        private System.Windows.Forms.ToolStripMenuItem activateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMedicalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePatientsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDoctorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel userIdDisplay_txt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel categoryIdDisplay_txt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel categoryNameDisplay_txt;
    }
}