namespace HostelManagementSystem
{
    partial class A_GuardianRegistrationForm
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
            lblGuardianID = new Label();
            txtGuardianID = new TextBox();
            lblStudentName = new Label();
            lblGaurdianName = new Label();
            lblRelation = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblOccupation = new Label();
            lblAddress = new Label();
            gaurdiannametxt = new TextBox();
            txtStudentName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtOccupation = new TextBox();
            cmbRelation = new ComboBox();
            btnSaveGuardian = new Button();
            btnClear = new Button();
            Gaurdianregisterformlbl = new Label();
            txtstudentid = new TextBox();
            lblstudentid = new Label();
            SuspendLayout();
            // 
            // lblGuardianID
            // 
            lblGuardianID.AutoSize = true;
            lblGuardianID.Location = new Point(73, 52);
            lblGuardianID.Name = "lblGuardianID";
            lblGuardianID.Size = new Size(68, 15);
            lblGuardianID.TabIndex = 0;
            lblGuardianID.Text = "Gaurdian Id";
            lblGuardianID.Click += lblGuardianID_Click;
            // 
            // txtGuardianID
            // 
            txtGuardianID.Location = new Point(185, 49);
            txtGuardianID.Name = "txtGuardianID";
            txtGuardianID.Size = new Size(169, 23);
            txtGuardianID.TabIndex = 1;
            txtGuardianID.TextChanged += txtGuardianID_TextChanged;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(62, 182);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(83, 15);
            lblStudentName.TabIndex = 4;
            lblStudentName.Text = "Student Name";
            lblStudentName.Click += lblStudentName_Click;
            // 
            // lblGaurdianName
            // 
            lblGaurdianName.AutoSize = true;
            lblGaurdianName.Location = new Point(62, 133);
            lblGaurdianName.Name = "lblGaurdianName";
            lblGaurdianName.Size = new Size(90, 15);
            lblGaurdianName.TabIndex = 5;
            lblGaurdianName.Text = "Gaurdian Name";
            lblGaurdianName.Click += lblGaurdianName_Click;
            // 
            // lblRelation
            // 
            lblRelation.AutoSize = true;
            lblRelation.Location = new Point(77, 218);
            lblRelation.Name = "lblRelation";
            lblRelation.Size = new Size(50, 15);
            lblRelation.TabIndex = 6;
            lblRelation.Text = "Relation";
            lblRelation.Click += lblRelation_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(73, 263);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(77, 306);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Location = new Point(62, 348);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new Size(69, 15);
            lblOccupation.TabIndex = 9;
            lblOccupation.Text = "Occupation";
            lblOccupation.Click += lblOccupation_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(73, 392);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address";
            lblAddress.Click += lblAddress_Click;
            // 
            // gaurdiannametxt
            // 
            gaurdiannametxt.Location = new Point(185, 130);
            gaurdiannametxt.Name = "gaurdiannametxt";
            gaurdiannametxt.Size = new Size(163, 23);
            gaurdiannametxt.TabIndex = 12;
            gaurdiannametxt.TextChanged += gaurdiannametxt_TextChanged;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(185, 182);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(163, 23);
            txtStudentName.TabIndex = 13;
            txtStudentName.TextChanged += txtStudentName_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(179, 260);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(163, 23);
            txtPhone.TabIndex = 14;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(179, 392);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(163, 23);
            txtAddress.TabIndex = 15;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(179, 303);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 16;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtOccupation
            // 
            txtOccupation.Location = new Point(179, 348);
            txtOccupation.Name = "txtOccupation";
            txtOccupation.Size = new Size(163, 23);
            txtOccupation.TabIndex = 17;
            txtOccupation.TextChanged += txtOccupation_TextChanged;
            // 
            // cmbRelation
            // 
            cmbRelation.FormattingEnabled = true;
            cmbRelation.Items.AddRange(new object[] { "Father", "Mother", "Brother", "Sister", "Uncle", "Aunt", "Other" });
            cmbRelation.Location = new Point(179, 218);
            cmbRelation.Name = "cmbRelation";
            cmbRelation.Size = new Size(169, 23);
            cmbRelation.TabIndex = 18;
            cmbRelation.SelectedIndexChanged += cmbRelation_SelectedIndexChanged;
            // 
            // btnSaveGuardian
            // 
            btnSaveGuardian.Location = new Point(140, 446);
            btnSaveGuardian.Name = "btnSaveGuardian";
            btnSaveGuardian.Size = new Size(153, 45);
            btnSaveGuardian.TabIndex = 19;
            btnSaveGuardian.Text = "Save Gaurdian";
            btnSaveGuardian.UseVisualStyleBackColor = true;
            btnSaveGuardian.Click += btnSaveGuardian_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(333, 448);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 43);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Gaurdianregisterformlbl
            // 
            Gaurdianregisterformlbl.AutoSize = true;
            Gaurdianregisterformlbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gaurdianregisterformlbl.Location = new Point(236, 9);
            Gaurdianregisterformlbl.Name = "Gaurdianregisterformlbl";
            Gaurdianregisterformlbl.Size = new Size(361, 37);
            Gaurdianregisterformlbl.TabIndex = 21;
            Gaurdianregisterformlbl.Text = "GAURDIAN REGISTRATION";
            Gaurdianregisterformlbl.Click += Gaurdianregisterformlbl_Click;
            // 
            // txtstudentid
            // 
            txtstudentid.Location = new Point(185, 90);
            txtstudentid.Name = "txtstudentid";
            txtstudentid.Size = new Size(169, 23);
            txtstudentid.TabIndex = 22;
            txtstudentid.TextChanged += txtstudentid_TextChanged;
            // 
            // lblstudentid
            // 
            lblstudentid.AutoSize = true;
            lblstudentid.Location = new Point(63, 90);
            lblstudentid.Name = "lblstudentid";
            lblstudentid.Size = new Size(61, 15);
            lblstudentid.TabIndex = 23;
            lblstudentid.Text = "Student Id";
            lblstudentid.Click += lblstudentid_Click;
            // 
            // A_GuardianRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(lblstudentid);
            Controls.Add(txtstudentid);
            Controls.Add(Gaurdianregisterformlbl);
            Controls.Add(btnClear);
            Controls.Add(btnSaveGuardian);
            Controls.Add(cmbRelation);
            Controls.Add(txtOccupation);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtStudentName);
            Controls.Add(gaurdiannametxt);
            Controls.Add(lblAddress);
            Controls.Add(lblOccupation);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblRelation);
            Controls.Add(lblGaurdianName);
            Controls.Add(lblStudentName);
            Controls.Add(txtGuardianID);
            Controls.Add(lblGuardianID);
            Name = "A_GuardianRegistrationForm";
            Text = "GuardianRegistrationForm";
            Load += A_GuardianRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGuardianID;
        private TextBox txtGuardianID;
        private Label lblStudentName;
        private Label lblGaurdianName;
        private Label lblRelation;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblOccupation;
        private Label lblAddress;
        private TextBox gaurdiannametxt;
        private TextBox txtStudentName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtOccupation;
        private ComboBox cmbRelation;
        private Button btnSaveGuardian;
        private Button btnClear;
        private Label Gaurdianregisterformlbl;
        private TextBox txtstudentid;
        private Label lblstudentid;
    }
}