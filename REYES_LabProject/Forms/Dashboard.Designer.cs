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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.userIdDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.usernameDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.roleDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.categoryIdDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.categoryNameDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDisplay_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.patientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.profileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.profileToolStripMenuItem.Text = "Settings";
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.userInfoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.userInfoToolStripMenuItem.Text = "Edit Info";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
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
            this.manageUsersToolStripMenuItem,
            this.manageMedicalRecordsToolStripMenuItem,
            this.manageBillingToolStripMenuItem,
            this.auditLogToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.adminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // activateUserToolStripMenuItem
            // 
            this.activateUserToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.activateUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.activateUserToolStripMenuItem.Name = "activateUserToolStripMenuItem";
            this.activateUserToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.activateUserToolStripMenuItem.Text = "User Activation";
            this.activateUserToolStripMenuItem.Click += new System.EventHandler(this.activateUserToolStripMenuItem_Click);
            // 
            // manageDoctorsToolStripMenuItem
            // 
            this.manageDoctorsToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.manageDoctorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.manageDoctorsToolStripMenuItem.Name = "manageDoctorsToolStripMenuItem";
            this.manageDoctorsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageDoctorsToolStripMenuItem.Text = "Manage Doctors";
            this.manageDoctorsToolStripMenuItem.Click += new System.EventHandler(this.manageDoctorsToolStripMenuItem_Click);
            // 
            // managePatientsToolStripMenuItem
            // 
            this.managePatientsToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.managePatientsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.managePatientsToolStripMenuItem.Name = "managePatientsToolStripMenuItem";
            this.managePatientsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.managePatientsToolStripMenuItem.Text = "Manage Patients";
            this.managePatientsToolStripMenuItem.Click += new System.EventHandler(this.managePatientsToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.manageUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageMedicalRecordsToolStripMenuItem
            // 
            this.manageMedicalRecordsToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.manageMedicalRecordsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.manageMedicalRecordsToolStripMenuItem.Name = "manageMedicalRecordsToolStripMenuItem";
            this.manageMedicalRecordsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageMedicalRecordsToolStripMenuItem.Text = "Manage Medical Records";
            this.manageMedicalRecordsToolStripMenuItem.Click += new System.EventHandler(this.manageMedicalRecordsToolStripMenuItem_Click);
            // 
            // manageBillingToolStripMenuItem
            // 
            this.manageBillingToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.manageBillingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.manageBillingToolStripMenuItem.Name = "manageBillingToolStripMenuItem";
            this.manageBillingToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageBillingToolStripMenuItem.Text = "Manage Billing";
            this.manageBillingToolStripMenuItem.Click += new System.EventHandler(this.manageBillingToolStripMenuItem_Click);
            // 
            // auditLogToolStripMenuItem
            // 
            this.auditLogToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.auditLogToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.auditLogToolStripMenuItem.Name = "auditLogToolStripMenuItem";
            this.auditLogToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.auditLogToolStripMenuItem.Text = "Audit Log";
            this.auditLogToolStripMenuItem.Click += new System.EventHandler(this.auditLogToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.backupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.restoreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
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
            this.doctorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // managePatientsListToolStripMenuItem
            // 
            this.managePatientsListToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.managePatientsListToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.managePatientsListToolStripMenuItem.Name = "managePatientsListToolStripMenuItem";
            this.managePatientsListToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.managePatientsListToolStripMenuItem.Text = "Manage Patients";
            this.managePatientsListToolStripMenuItem.Click += new System.EventHandler(this.managePatientsListToolStripMenuItem_Click);
            // 
            // manageMedicalRecordToolStripMenuItem
            // 
            this.manageMedicalRecordToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.manageMedicalRecordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.manageMedicalRecordToolStripMenuItem.Name = "manageMedicalRecordToolStripMenuItem";
            this.manageMedicalRecordToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.manageMedicalRecordToolStripMenuItem.Text = "Manage Medical Records";
            this.manageMedicalRecordToolStripMenuItem.Click += new System.EventHandler(this.manageMedicalRecordToolStripMenuItem_Click);
            // 
            // manageBillingToolStripMenuItem1
            // 
            this.manageBillingToolStripMenuItem1.BackColor = System.Drawing.Color.DarkCyan;
            this.manageBillingToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.manageBillingToolStripMenuItem1.Name = "manageBillingToolStripMenuItem1";
            this.manageBillingToolStripMenuItem1.Size = new System.Drawing.Size(260, 26);
            this.manageBillingToolStripMenuItem1.Text = "Manage Billing";
            this.manageBillingToolStripMenuItem1.Click += new System.EventHandler(this.manageBillingToolStripMenuItem1_Click);
            // 
            // viewDoctorsToolStripMenuItem1
            // 
            this.viewDoctorsToolStripMenuItem1.BackColor = System.Drawing.Color.DarkCyan;
            this.viewDoctorsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.viewDoctorsToolStripMenuItem1.Name = "viewDoctorsToolStripMenuItem1";
            this.viewDoctorsToolStripMenuItem1.Size = new System.Drawing.Size(260, 26);
            this.viewDoctorsToolStripMenuItem1.Text = "View Doctors";
            this.viewDoctorsToolStripMenuItem1.Click += new System.EventHandler(this.viewDoctorsToolStripMenuItem1_Click);
            // 
            // viewAuditToolStripMenuItem1
            // 
            this.viewAuditToolStripMenuItem1.BackColor = System.Drawing.Color.DarkCyan;
            this.viewAuditToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
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
            this.patientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // viewDoctorsToolStripMenuItem
            // 
            this.viewDoctorsToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.viewDoctorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.viewDoctorsToolStripMenuItem.Name = "viewDoctorsToolStripMenuItem";
            this.viewDoctorsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.viewDoctorsToolStripMenuItem.Text = "View Doctors";
            this.viewDoctorsToolStripMenuItem.Click += new System.EventHandler(this.viewDoctorsToolStripMenuItem_Click);
            // 
            // viewMedicalRecordsToolStripMenuItem
            // 
            this.viewMedicalRecordsToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.viewMedicalRecordsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.viewMedicalRecordsToolStripMenuItem.Name = "viewMedicalRecordsToolStripMenuItem";
            this.viewMedicalRecordsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.viewMedicalRecordsToolStripMenuItem.Text = "View Medical Records";
            this.viewMedicalRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewMedicalRecordsToolStripMenuItem_Click);
            // 
            // manageBillsToolStripMenuItem
            // 
            this.manageBillsToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.manageBillsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
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
            this.statusStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.userIdDisplay_txt,
            this.toolStripStatusLabel1,
            this.usernameDisplay_txt,
            this.toolStripStatusLabel3,
            this.roleDisplay_txt,
            this.toolStripStatusLabel6,
            this.categoryIdDisplay_txt,
            this.toolStripStatusLabel7,
            this.categoryNameDisplay_txt,
            this.toolStripStatusLabel2,
            this.dateDisplay_txt,
            this.toolStripStatusLabel5,
            this.timerDisplay_txt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(998, 34);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(69, 28);
            this.toolStripStatusLabel4.Text = "UserID";
            // 
            // userIdDisplay_txt
            // 
            this.userIdDisplay_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdDisplay_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.userIdDisplay_txt.Name = "userIdDisplay_txt";
            this.userIdDisplay_txt.Size = new System.Drawing.Size(15, 28);
            this.userIdDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 28);
            this.toolStripStatusLabel1.Text = "Username";
            // 
            // usernameDisplay_txt
            // 
            this.usernameDisplay_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameDisplay_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameDisplay_txt.Name = "usernameDisplay_txt";
            this.usernameDisplay_txt.Size = new System.Drawing.Size(19, 28);
            this.usernameDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(40, 28);
            this.toolStripStatusLabel3.Text = "Role";
            // 
            // roleDisplay_txt
            // 
            this.roleDisplay_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleDisplay_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.roleDisplay_txt.Name = "roleDisplay_txt";
            this.roleDisplay_txt.Size = new System.Drawing.Size(19, 28);
            this.roleDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(69, 28);
            this.toolStripStatusLabel6.Text = "RoleID";
            // 
            // categoryIdDisplay_txt
            // 
            this.categoryIdDisplay_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIdDisplay_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.categoryIdDisplay_txt.Name = "categoryIdDisplay_txt";
            this.categoryIdDisplay_txt.Size = new System.Drawing.Size(19, 28);
            this.categoryIdDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel7.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(97, 28);
            this.toolStripStatusLabel7.Text = "Rolename";
            // 
            // categoryNameDisplay_txt
            // 
            this.categoryNameDisplay_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameDisplay_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.categoryNameDisplay_txt.Name = "categoryNameDisplay_txt";
            this.categoryNameDisplay_txt.Size = new System.Drawing.Size(19, 28);
            this.categoryNameDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(52, 28);
            this.toolStripStatusLabel2.Text = "Date";
            // 
            // dateDisplay_txt
            // 
            this.dateDisplay_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplay_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.dateDisplay_txt.Name = "dateDisplay_txt";
            this.dateDisplay_txt.Size = new System.Drawing.Size(20, 28);
            this.dateDisplay_txt.Text = "-";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(83, 28);
            this.toolStripStatusLabel5.Text = "Timeout";
            // 
            // timerDisplay_txt
            // 
            this.timerDisplay_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerDisplay_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.timerDisplay_txt.Name = "timerDisplay_txt";
            this.timerDisplay_txt.Size = new System.Drawing.Size(19, 28);
            this.timerDisplay_txt.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(215, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "paSEANte care is here for you!";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
    }
}