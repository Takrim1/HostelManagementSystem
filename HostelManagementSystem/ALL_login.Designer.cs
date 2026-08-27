namespace HostelManagementSystem
{
    partial class ALL_login
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
            adminlabellogin = new Label();
            LogAs = new Label();
            comboBox1 = new ComboBox();
            lblId = new Label();
            txtId = new TextBox();
            lblpassword = new Label();
            txtPassword = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // adminlabellogin
            // 
            adminlabellogin.AutoSize = true;
            adminlabellogin.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            adminlabellogin.Location = new Point(400, 34);
            adminlabellogin.Margin = new Padding(4, 0, 4, 0);
            adminlabellogin.Name = "adminlabellogin";
            adminlabellogin.Size = new Size(162, 30);
            adminlabellogin.TabIndex = 0;
            adminlabellogin.Text = "SMART HOSTEL";
            adminlabellogin.TextAlign = ContentAlignment.TopCenter;
            adminlabellogin.Click += adminlabellogin_Click;
            // 
            // LogAs
            // 
            LogAs.AutoSize = true;
            LogAs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogAs.Location = new Point(139, 122);
            LogAs.Margin = new Padding(4, 0, 4, 0);
            LogAs.Name = "LogAs";
            LogAs.Size = new Size(60, 21);
            LogAs.TabIndex = 1;
            LogAs.Text = "Log As";
            LogAs.Click += LogAs_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Staff", "Student" });
            comboBox1.Location = new Point(261, 119);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 29);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(145, 179);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 21);
            lblId.TabIndex = 3;
            lblId.Text = "ID";
            lblId.Click += lblId_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(261, 171);
            txtId.Name = "txtId";
            txtId.Size = new Size(177, 29);
            txtId.TabIndex = 4;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.Location = new Point(117, 232);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(82, 21);
            lblpassword.TabIndex = 5;
            lblpassword.Text = "Password";
            lblpassword.Click += lblpassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(261, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 29);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(334, 317);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(218, 55);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // ALL_login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 417);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblpassword);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(comboBox1);
            Controls.Add(LogAs);
            Controls.Add(adminlabellogin);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ALL_login";
            Text = "LoginForm";
            Load += ALL_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminlabellogin;
        private Label LogAs;
        private ComboBox comboBox1;
        private Label lblId;
        private TextBox txtId;
        private Label lblpassword;
        private TextBox txtPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnLogin;
    }
}