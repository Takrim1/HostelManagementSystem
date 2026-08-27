namespace HostelManagementSystem
{
    partial class A_VisitorRegistrationForm
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
            txtrelation = new TextBox();
            txtPhone = new TextBox();
            dtVisit = new DateTimePicker();
            cmbGender = new ComboBox();
            txtVisitorName = new TextBox();
            txtVisitorID = new TextBox();
            lblRelation = new Label();
            lblPhone = new Label();
            lblDOB = new Label();
            lblGender = new Label();
            lblVisitorName = new Label();
            lblVisitorID = new Label();
            lblvisitorTitle = new Label();
            lblStudentID = new Label();
            txtStudentID = new TextBox();
            lblhostel = new Label();
            cmbhostel = new ComboBox();
            btnClear = new Button();
            btnRegisterStudent = new Button();
            SuspendLayout();
            // 
            // txtrelation
            // 
            txtrelation.Location = new Point(359, 313);
            txtrelation.Name = "txtrelation";
            txtrelation.Size = new Size(212, 23);
            txtrelation.TabIndex = 32;
            txtrelation.TextChanged += txtrelation_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(350, 265);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(207, 23);
            txtPhone.TabIndex = 31;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // dtVisit
            // 
            dtVisit.Location = new Point(339, 357);
            dtVisit.Name = "dtVisit";
            dtVisit.Size = new Size(232, 23);
            dtVisit.TabIndex = 30;
            dtVisit.ValueChanged += dtVisit_ValueChanged;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(350, 226);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(203, 23);
            cmbGender.TabIndex = 29;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // txtVisitorName
            // 
            txtVisitorName.Location = new Point(339, 191);
            txtVisitorName.Name = "txtVisitorName";
            txtVisitorName.Size = new Size(208, 23);
            txtVisitorName.TabIndex = 28;
            txtVisitorName.TextChanged += txtVisitorName_TextChanged;
            // 
            // txtVisitorID
            // 
            txtVisitorID.Location = new Point(174, 119);
            txtVisitorID.Name = "txtVisitorID";
            txtVisitorID.Size = new Size(208, 23);
            txtVisitorID.TabIndex = 27;
            txtVisitorID.TextChanged += txtVisitorID_TextChanged;
            // 
            // lblRelation
            // 
            lblRelation.AutoSize = true;
            lblRelation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRelation.Location = new Point(122, 313);
            lblRelation.Name = "lblRelation";
            lblRelation.Size = new Size(148, 25);
            lblRelation.TabIndex = 26;
            lblRelation.Text = "Visitor Relation";
            lblRelation.Click += lblRelation_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(122, 276);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(132, 25);
            lblPhone.TabIndex = 25;
            lblPhone.Text = "Visitor Phone";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(142, 355);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(96, 25);
            lblDOB.TabIndex = 24;
            lblDOB.Text = "Visit Date";
            lblDOB.Click += lblDOB_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(113, 226);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(141, 25);
            lblGender.TabIndex = 23;
            lblGender.Text = "Visitor Gender";
            lblGender.Click += lblGender_Click;
            // 
            // lblVisitorName
            // 
            lblVisitorName.AutoSize = true;
            lblVisitorName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisitorName.Location = new Point(113, 191);
            lblVisitorName.Name = "lblVisitorName";
            lblVisitorName.Size = new Size(127, 25);
            lblVisitorName.TabIndex = 22;
            lblVisitorName.Text = "Visitor Name";
            lblVisitorName.Click += lblVisitorName_Click;
            // 
            // lblVisitorID
            // 
            lblVisitorID.AutoSize = true;
            lblVisitorID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisitorID.Location = new Point(50, 119);
            lblVisitorID.Name = "lblVisitorID";
            lblVisitorID.Size = new Size(95, 25);
            lblVisitorID.TabIndex = 21;
            lblVisitorID.Text = "Visitor ID";
            lblVisitorID.Click += lblVisitorID_Click;
            // 
            // lblvisitorTitle
            // 
            lblvisitorTitle.AutoSize = true;
            lblvisitorTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblvisitorTitle.Location = new Point(225, 31);
            lblvisitorTitle.Name = "lblvisitorTitle";
            lblvisitorTitle.Size = new Size(248, 37);
            lblvisitorTitle.TabIndex = 33;
            lblvisitorTitle.Text = "Visitor Registration";
            lblvisitorTitle.Click += lblvisitorTitle_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentID.Location = new Point(122, 152);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(108, 25);
            lblStudentID.TabIndex = 34;
            lblStudentID.Text = "Student ID";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(324, 152);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(208, 23);
            txtStudentID.TabIndex = 35;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // lblhostel
            // 
            lblhostel.AutoSize = true;
            lblhostel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhostel.Location = new Point(478, 109);
            lblhostel.Name = "lblhostel";
            lblhostel.Size = new Size(69, 25);
            lblhostel.TabIndex = 36;
            lblhostel.Text = "Hostel";
            lblhostel.Click += lblhostel_Click;
            // 
            // cmbhostel
            // 
            cmbhostel.FormattingEnabled = true;
            cmbhostel.Items.AddRange(new object[] { "Male A", "Male B", "Female A", "Female B" });
            cmbhostel.Location = new Point(562, 114);
            cmbhostel.Name = "cmbhostel";
            cmbhostel.Size = new Size(203, 23);
            cmbhostel.TabIndex = 37;
            cmbhostel.SelectedIndexChanged += cmbhostel_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(427, 419);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 44);
            btnClear.TabIndex = 39;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnRegisterStudent
            // 
            btnRegisterStudent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterStudent.Location = new Point(250, 418);
            btnRegisterStudent.Name = "btnRegisterStudent";
            btnRegisterStudent.Size = new Size(132, 45);
            btnRegisterStudent.TabIndex = 38;
            btnRegisterStudent.Text = "Register";
            btnRegisterStudent.UseVisualStyleBackColor = true;
            btnRegisterStudent.Click += btnRegisterStudent_Click;
            // 
            // A_VisitorRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 577);
            Controls.Add(btnClear);
            Controls.Add(btnRegisterStudent);
            Controls.Add(cmbhostel);
            Controls.Add(lblhostel);
            Controls.Add(txtStudentID);
            Controls.Add(lblStudentID);
            Controls.Add(lblvisitorTitle);
            Controls.Add(txtrelation);
            Controls.Add(txtPhone);
            Controls.Add(dtVisit);
            Controls.Add(cmbGender);
            Controls.Add(txtVisitorName);
            Controls.Add(txtVisitorID);
            Controls.Add(lblRelation);
            Controls.Add(lblPhone);
            Controls.Add(lblDOB);
            Controls.Add(lblGender);
            Controls.Add(lblVisitorName);
            Controls.Add(lblVisitorID);
            Name = "A_VisitorRegistrationForm";
            Text = "A_VisitorRegistrationForm";
            Load += A_VisitorRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtrelation;
        private TextBox txtPhone;
        private DateTimePicker dtVisit;
        private ComboBox cmbGender;
        private TextBox txtVisitorName;
        private TextBox txtVisitorID;
        private Label lblRelation;
        private Label lblPhone;
        private Label lblDOB;
        private Label lblGender;
        private Label lblVisitorName;
        private Label lblVisitorID;
        private Label lblvisitorTitle;
        private Label lblStudentID;
        private TextBox txtStudentID;
        private Label lblhostel;
        private ComboBox cmbhostel;
        private Button btnClear;
        private Button btnRegisterStudent;
    }
}