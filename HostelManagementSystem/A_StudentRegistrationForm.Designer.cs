namespace HostelManagementSystem
{
    partial class A_StudentRegistrationForm
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
            Studentregisterformlbl = new Label();
            lblStudentID = new Label();
            lblStudentName = new Label();
            lblGender = new Label();
            lblDOB = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblDepartment = new Label();
            lblHomeAddress = new Label();
            lblHostel = new Label();
            lblRoom = new Label();
            lblBed = new Label();
            lblAdmissionDate = new Label();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            cmbGender = new ComboBox();
            dtpDOB = new DateTimePicker();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            cmbdepartment = new ComboBox();
            txtHomeAddress = new TextBox();
            dtpAdmissionDate = new DateTimePicker();
            btnRegisterStudent = new Button();
            btnClear = new Button();
            txtpass = new TextBox();
            lblpass = new Label();
            SuspendLayout();
            // 
            // Studentregisterformlbl
            // 
            Studentregisterformlbl.AutoSize = true;
            Studentregisterformlbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Studentregisterformlbl.Location = new Point(283, 9);
            Studentregisterformlbl.Name = "Studentregisterformlbl";
            Studentregisterformlbl.Size = new Size(338, 37);
            Studentregisterformlbl.TabIndex = 0;
            Studentregisterformlbl.Text = "STUDENT REGISTRATION";
            Studentregisterformlbl.Click += Studentregisterformlbl_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentID.Location = new Point(83, 89);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(108, 25);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(51, 129);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(140, 25);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Student Name";
            lblStudentName.Click += lblStudentName_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(91, 164);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(78, 25);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            lblGender.Click += lblGender_Click;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(79, 198);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(126, 25);
            lblDOB.TabIndex = 4;
            lblDOB.Text = "Date of Birth";
            lblDOB.Click += lblDOB_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(91, 234);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(69, 25);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(90, 279);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 25);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartment.Location = new Point(91, 337);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(120, 25);
            lblDepartment.TabIndex = 7;
            lblDepartment.Text = "Department";
            lblDepartment.Click += lblDepartment_Click;
            // 
            // lblHomeAddress
            // 
            lblHomeAddress.AutoSize = true;
            lblHomeAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHomeAddress.Location = new Point(91, 394);
            lblHomeAddress.Name = "lblHomeAddress";
            lblHomeAddress.Size = new Size(142, 25);
            lblHomeAddress.TabIndex = 8;
            lblHomeAddress.Text = "Home Address";
            lblHomeAddress.Click += lblHomeAddress_Click;
            // 
            // lblHostel
            // 
            lblHostel.Location = new Point(0, 0);
            lblHostel.Name = "lblHostel";
            lblHostel.Size = new Size(100, 23);
            lblHostel.TabIndex = 36;
            // 
            // lblRoom
            // 
            lblRoom.Location = new Point(0, 0);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(100, 23);
            lblRoom.TabIndex = 35;
            // 
            // lblBed
            // 
            lblBed.Location = new Point(0, 0);
            lblBed.Name = "lblBed";
            lblBed.Size = new Size(100, 23);
            lblBed.TabIndex = 34;
            // 
            // lblAdmissionDate
            // 
            lblAdmissionDate.AutoSize = true;
            lblAdmissionDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmissionDate.Location = new Point(61, 467);
            lblAdmissionDate.Name = "lblAdmissionDate";
            lblAdmissionDate.Size = new Size(150, 25);
            lblAdmissionDate.TabIndex = 12;
            lblAdmissionDate.Text = "Admission Date";
            lblAdmissionDate.Click += lblAdmissionDate_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(252, 91);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(208, 23);
            txtStudentID.TabIndex = 15;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(252, 131);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(208, 23);
            txtStudentName.TabIndex = 16;
            txtStudentName.TextChanged += txtStudentName_TextChanged;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(257, 165);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(203, 23);
            cmbGender.TabIndex = 17;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(250, 204);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(232, 23);
            dtpDOB.TabIndex = 18;
            dtpDOB.ValueChanged += dtpDOB_ValueChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(253, 241);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(207, 23);
            txtPhone.TabIndex = 19;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(248, 284);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 23);
            txtEmail.TabIndex = 20;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // cmbdepartment
            // 
            cmbdepartment.FormattingEnabled = true;
            cmbdepartment.Items.AddRange(new object[] { "CSE", "EEE", "BBA", "Architecture", "English", "Other" });
            cmbdepartment.Location = new Point(251, 336);
            cmbdepartment.Name = "cmbdepartment";
            cmbdepartment.Size = new Size(231, 23);
            cmbdepartment.TabIndex = 21;
            cmbdepartment.SelectedIndexChanged += cmbdepartment_SelectedIndexChanged;
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.Location = new Point(251, 391);
            txtHomeAddress.Multiline = true;
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.Size = new Size(269, 23);
            txtHomeAddress.TabIndex = 22;
            txtHomeAddress.TextChanged += txtHomeAddress_TextChanged;
            // 
            // dtpAdmissionDate
            // 
            dtpAdmissionDate.Location = new Point(283, 467);
            dtpAdmissionDate.Name = "dtpAdmissionDate";
            dtpAdmissionDate.Size = new Size(200, 23);
            dtpAdmissionDate.TabIndex = 26;
            dtpAdmissionDate.ValueChanged += dtpAdmissionDate_ValueChanged;
            // 
            // btnRegisterStudent
            // 
            btnRegisterStudent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterStudent.Location = new Point(539, 545);
            btnRegisterStudent.Name = "btnRegisterStudent";
            btnRegisterStudent.Size = new Size(132, 45);
            btnRegisterStudent.TabIndex = 27;
            btnRegisterStudent.Text = "Register";
            btnRegisterStudent.UseVisualStyleBackColor = true;
            btnRegisterStudent.Click += btnRegisterStudent_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(716, 546);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 44);
            btnClear.TabIndex = 28;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(636, 89);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(208, 23);
            txtpass.TabIndex = 29;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpass.Location = new Point(513, 91);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(97, 25);
            lblpass.TabIndex = 30;
            lblpass.Text = "Password";
            lblpass.Click += lblpass_Click;
            // 
            // A_StudentRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 688);
            Controls.Add(lblpass);
            Controls.Add(txtpass);
            Controls.Add(btnClear);
            Controls.Add(btnRegisterStudent);
            Controls.Add(dtpAdmissionDate);
            Controls.Add(txtHomeAddress);
            Controls.Add(cmbdepartment);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(dtpDOB);
            Controls.Add(cmbGender);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(lblAdmissionDate);
            Controls.Add(lblBed);
            Controls.Add(lblRoom);
            Controls.Add(lblHostel);
            Controls.Add(lblHomeAddress);
            Controls.Add(lblDepartment);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblDOB);
            Controls.Add(lblGender);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentID);
            Controls.Add(Studentregisterformlbl);
            Name = "A_StudentRegistrationForm";
            Text = "StudentRegistrationForm";
            Load += StudentRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Studentregisterformlbl;
        private Label lblStudentID;
        private Label lblStudentName;
        private Label lblGender;
        private Label lblDOB;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblDepartment;
        private Label lblHomeAddress;
        private Label lblHostel;
        private Label lblRoom;
        private Label lblBed;
        private Label lblAdmissionDate;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private ComboBox cmbGender;
        private DateTimePicker dtpDOB;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private ComboBox cmbdepartment;
        private TextBox txtHomeAddress;
        private DateTimePicker dtpAdmissionDate;
        private Button btnRegisterStudent;
        private Button btnClear;
        private TextBox txtpass;
        private Label lblpass;
    }
}