namespace REYES_LabProject
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signin_txt = new System.Windows.Forms.Label();
            this.capslock_indicator = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.passwordEye_ptb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.confirmPasswordEye_ptb = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmPassword_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.capslockConfirm_indicator = new System.Windows.Forms.Label();
            this.role_cmb = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye_ptb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordEye_ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Already a user?";
            // 
            // signin_txt
            // 
            this.signin_txt.AutoSize = true;
            this.signin_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_txt.Location = new System.Drawing.Point(213, 414);
            this.signin_txt.Name = "signin_txt";
            this.signin_txt.Size = new System.Drawing.Size(67, 25);
            this.signin_txt.TabIndex = 6;
            this.signin_txt.Text = "Signin";
            this.signin_txt.Click += new System.EventHandler(this.signin_txt_Click);
            // 
            // capslock_indicator
            // 
            this.capslock_indicator.AutoSize = true;
            this.capslock_indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capslock_indicator.ForeColor = System.Drawing.Color.Red;
            this.capslock_indicator.Location = new System.Drawing.Point(301, 148);
            this.capslock_indicator.Name = "capslock_indicator";
            this.capslock_indicator.Size = new System.Drawing.Size(107, 18);
            this.capslock_indicator.TabIndex = 17;
            this.capslock_indicator.Text = "Capslock is on";
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(62, 462);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(97, 38);
            this.register_btn.TabIndex = 5;
            this.register_btn.Text = "Create";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // passwordEye_ptb
            // 
            this.passwordEye_ptb.Image = global::REYES_LabProject.Properties.Resources.closedEye;
            this.passwordEye_ptb.Location = new System.Drawing.Point(415, 169);
            this.passwordEye_ptb.Name = "passwordEye_ptb";
            this.passwordEye_ptb.Size = new System.Drawing.Size(30, 30);
            this.passwordEye_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordEye_ptb.TabIndex = 14;
            this.passwordEye_ptb.TabStop = false;
            this.passwordEye_ptb.Click += new System.EventHandler(this.passwordEye_ptb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(62, 169);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(346, 30);
            this.password_txt.TabIndex = 2;
            this.password_txt.Enter += new System.EventHandler(this.password_txt_Enter);
            this.password_txt.Leave += new System.EventHandler(this.password_txt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Username";
            // 
            // username_txt
            // 
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(62, 81);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(346, 30);
            this.username_txt.TabIndex = 1;
            // 
            // confirmPasswordEye_ptb
            // 
            this.confirmPasswordEye_ptb.Image = global::REYES_LabProject.Properties.Resources.closedEye;
            this.confirmPasswordEye_ptb.Location = new System.Drawing.Point(415, 255);
            this.confirmPasswordEye_ptb.Name = "confirmPasswordEye_ptb";
            this.confirmPasswordEye_ptb.Size = new System.Drawing.Size(30, 30);
            this.confirmPasswordEye_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.confirmPasswordEye_ptb.TabIndex = 23;
            this.confirmPasswordEye_ptb.TabStop = false;
            this.confirmPasswordEye_ptb.Click += new System.EventHandler(this.passwordConfirmEye_ptb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Confirm Password";
            // 
            // confirmPassword_txt
            // 
            this.confirmPassword_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword_txt.Location = new System.Drawing.Point(62, 255);
            this.confirmPassword_txt.Name = "confirmPassword_txt";
            this.confirmPassword_txt.PasswordChar = '*';
            this.confirmPassword_txt.Size = new System.Drawing.Size(346, 30);
            this.confirmPassword_txt.TabIndex = 3;
            this.confirmPassword_txt.Enter += new System.EventHandler(this.confirmPassword_txt_Enter);
            this.confirmPassword_txt.Leave += new System.EventHandler(this.confirmPassword_txt_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Role";
            // 
            // capslockConfirm_indicator
            // 
            this.capslockConfirm_indicator.AutoSize = true;
            this.capslockConfirm_indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capslockConfirm_indicator.ForeColor = System.Drawing.Color.Red;
            this.capslockConfirm_indicator.Location = new System.Drawing.Point(301, 234);
            this.capslockConfirm_indicator.Name = "capslockConfirm_indicator";
            this.capslockConfirm_indicator.Size = new System.Drawing.Size(107, 18);
            this.capslockConfirm_indicator.TabIndex = 26;
            this.capslockConfirm_indicator.Text = "Capslock is on";
            // 
            // role_cmb
            // 
            this.role_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_cmb.FormattingEnabled = true;
            this.role_cmb.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Patient"});
            this.role_cmb.Location = new System.Drawing.Point(62, 337);
            this.role_cmb.Name = "role_cmb";
            this.role_cmb.Size = new System.Drawing.Size(346, 33);
            this.role_cmb.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "closedEye.png");
            this.imageList1.Images.SetKeyName(1, "openEye.png");
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 533);
            this.Controls.Add(this.role_cmb);
            this.Controls.Add(this.capslockConfirm_indicator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.confirmPasswordEye_ptb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmPassword_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signin_txt);
            this.Controls.Add(this.capslock_indicator);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.passwordEye_ptb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Register_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye_ptb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordEye_ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label signin_txt;
        private System.Windows.Forms.Label capslock_indicator;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.PictureBox passwordEye_ptb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.PictureBox confirmPasswordEye_ptb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirmPassword_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label capslockConfirm_indicator;
        private System.Windows.Forms.ComboBox role_cmb;
        private System.Windows.Forms.ImageList imageList1;
    }
}