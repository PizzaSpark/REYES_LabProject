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
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAssignedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMedicalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBillingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editMedicalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAssignedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAuditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMedicalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.manageDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(704, 28);
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
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.userInfoToolStripMenuItem.Text = "Edit My Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateUserToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.auditLogToolStripMenuItem,
            this.manageRoomsToolStripMenuItem,
            this.manageAssignedToolStripMenuItem,
            this.manageMedicalRecordsToolStripMenuItem,
            this.manageBillingToolStripMenuItem,
            this.manageDoctorsToolStripMenuItem,
            this.managePatientsToolStripMenuItem,
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
            this.activateUserToolStripMenuItem.Text = "Activate User";
            this.activateUserToolStripMenuItem.Click += new System.EventHandler(this.activateUserToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.addUserToolStripMenuItem.Text = "Manage Users";
            // 
            // auditLogToolStripMenuItem
            // 
            this.auditLogToolStripMenuItem.Name = "auditLogToolStripMenuItem";
            this.auditLogToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.auditLogToolStripMenuItem.Text = "Audit Log";
            this.auditLogToolStripMenuItem.Click += new System.EventHandler(this.auditLogToolStripMenuItem_Click);
            // 
            // manageRoomsToolStripMenuItem
            // 
            this.manageRoomsToolStripMenuItem.Name = "manageRoomsToolStripMenuItem";
            this.manageRoomsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageRoomsToolStripMenuItem.Text = "Manage Rooms";
            // 
            // manageAssignedToolStripMenuItem
            // 
            this.manageAssignedToolStripMenuItem.Name = "manageAssignedToolStripMenuItem";
            this.manageAssignedToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageAssignedToolStripMenuItem.Text = "Manage Assigned";
            // 
            // manageMedicalRecordsToolStripMenuItem
            // 
            this.manageMedicalRecordsToolStripMenuItem.Name = "manageMedicalRecordsToolStripMenuItem";
            this.manageMedicalRecordsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageMedicalRecordsToolStripMenuItem.Text = "Manage Medical Records";
            // 
            // manageBillingToolStripMenuItem
            // 
            this.manageBillingToolStripMenuItem.Name = "manageBillingToolStripMenuItem";
            this.manageBillingToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageBillingToolStripMenuItem.Text = "Manage Billing";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBillingToolStripMenuItem1,
            this.editMedicalRecordToolStripMenuItem,
            this.editAssignedToolStripMenuItem1,
            this.viewAuditToolStripMenuItem1,
            this.patientsListToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // editBillingToolStripMenuItem1
            // 
            this.editBillingToolStripMenuItem1.Name = "editBillingToolStripMenuItem1";
            this.editBillingToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.editBillingToolStripMenuItem1.Text = "Edit Billing";
            // 
            // editMedicalRecordToolStripMenuItem
            // 
            this.editMedicalRecordToolStripMenuItem.Name = "editMedicalRecordToolStripMenuItem";
            this.editMedicalRecordToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.editMedicalRecordToolStripMenuItem.Text = "Patient Medical Records";
            // 
            // editAssignedToolStripMenuItem1
            // 
            this.editAssignedToolStripMenuItem1.Name = "editAssignedToolStripMenuItem1";
            this.editAssignedToolStripMenuItem1.Size = new System.Drawing.Size(251, 26);
            this.editAssignedToolStripMenuItem1.Text = "Assign Patients";
            // 
            // viewAuditToolStripMenuItem1
            // 
            this.viewAuditToolStripMenuItem1.Name = "viewAuditToolStripMenuItem1";
            this.viewAuditToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.viewAuditToolStripMenuItem1.Text = "View Audit";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMedicalRecordsToolStripMenuItem,
            this.viewBillingToolStripMenuItem,
            this.viewDoctorsToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // viewMedicalRecordsToolStripMenuItem
            // 
            this.viewMedicalRecordsToolStripMenuItem.Name = "viewMedicalRecordsToolStripMenuItem";
            this.viewMedicalRecordsToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.viewMedicalRecordsToolStripMenuItem.Text = "My Medical Records";
            // 
            // viewBillingToolStripMenuItem
            // 
            this.viewBillingToolStripMenuItem.Name = "viewBillingToolStripMenuItem";
            this.viewBillingToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.viewBillingToolStripMenuItem.Text = "Pay Bills";
            // 
            // viewDoctorsToolStripMenuItem
            // 
            this.viewDoctorsToolStripMenuItem.Name = "viewDoctorsToolStripMenuItem";
            this.viewDoctorsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.viewDoctorsToolStripMenuItem.Text = "View Doctors";
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
            this.toolStripStatusLabel1,
            this.usernameDisplay_txt,
            this.toolStripStatusLabel3,
            this.roleDisplay_txt,
            this.toolStripStatusLabel2,
            this.dateDisplay_txt,
            this.toolStripStatusLabel5,
            this.timerDisplay_txt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 26);
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
            // manageDoctorsToolStripMenuItem
            // 
            this.manageDoctorsToolStripMenuItem.Name = "manageDoctorsToolStripMenuItem";
            this.manageDoctorsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageDoctorsToolStripMenuItem.Text = "Manage Doctors";
            // 
            // managePatientsToolStripMenuItem
            // 
            this.managePatientsToolStripMenuItem.Name = "managePatientsToolStripMenuItem";
            this.managePatientsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.managePatientsToolStripMenuItem.Text = "Manage Patients";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // patientsListToolStripMenuItem
            // 
            this.patientsListToolStripMenuItem.Name = "patientsListToolStripMenuItem";
            this.patientsListToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.patientsListToolStripMenuItem.Text = "Patients List";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 543);
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
        private System.Windows.Forms.ToolStripMenuItem editBillingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editMedicalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAssignedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAuditToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewMedicalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBillingToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAssignedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMedicalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsListToolStripMenuItem;
    }
}