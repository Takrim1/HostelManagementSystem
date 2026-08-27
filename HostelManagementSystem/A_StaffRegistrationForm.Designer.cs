namespace HostelManagementSystem
{
    partial class A_StaffRegistrationForm
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
            btnClear = new Button();
            btnSaveStaff = new Button();
            cmbstaffposition = new ComboBox();
            txtEmail = new TextBox();
            txtHomeAddress = new TextBox();
            txtPhone = new TextBox();
            txtStaffName = new TextBox();
            lblHomeAddress = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblstaffposition = new Label();
            lblStaffName = new Label();
            txtStaffID = new TextBox();
            lblStaffID = new Label();
            lblStaffTitle = new Label();
            lblpassword = new Label();
            txtpassword = new TextBox();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(454, 403);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 43);
            btnClear.TabIndex = 40;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveStaff
            // 
            btnSaveStaff.Location = new Point(261, 401);
            btnSaveStaff.Name = "btnSaveStaff";
            btnSaveStaff.Size = new Size(153, 45);
            btnSaveStaff.TabIndex = 39;
            btnSaveStaff.Text = "Save Staff";
            btnSaveStaff.UseVisualStyleBackColor = true;
            btnSaveStaff.Click += btnSaveStaff_Click;
            // 
            // cmbstaffposition
            // 
            cmbstaffposition.FormattingEnabled = true;
            cmbstaffposition.Items.AddRange(new object[] { "Cleaner", "Security Gaurd", "Waiter", "Chef", "Manager", "Clerk" });
            cmbstaffposition.Location = new Point(300, 173);
            cmbstaffposition.Name = "cmbstaffposition";
            cmbstaffposition.Size = new Size(169, 23);
            cmbstaffposition.TabIndex = 38;
            cmbstaffposition.SelectedIndexChanged += cmbstaffposition_SelectedIndexChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(300, 258);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 36;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.Location = new Point(300, 347);
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.Size = new Size(163, 23);
            txtHomeAddress.TabIndex = 35;
            txtHomeAddress.TextChanged += txtHomeAddress_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(300, 215);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(163, 23);
            txtPhone.TabIndex = 34;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(300, 123);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(163, 23);
            txtStaffName.TabIndex = 32;
            txtStaffName.TextChanged += txtStaffName_TextChanged;
            // 
            // lblHomeAddress
            // 
            lblHomeAddress.AutoSize = true;
            lblHomeAddress.Location = new Point(194, 347);
            lblHomeAddress.Name = "lblHomeAddress";
            lblHomeAddress.Size = new Size(85, 15);
            lblHomeAddress.TabIndex = 31;
            lblHomeAddress.Text = "Home Address";
            lblHomeAddress.Click += lblHomeAddress_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(198, 261);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 29;
            lblEmail.Text = "Email";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(194, 218);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 28;
            lblPhone.Text = "Phone";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblstaffposition
            // 
            lblstaffposition.AutoSize = true;
            lblstaffposition.Location = new Point(198, 173);
            lblstaffposition.Name = "lblstaffposition";
            lblstaffposition.Size = new Size(77, 15);
            lblstaffposition.TabIndex = 27;
            lblstaffposition.Text = "Staff Position";
            lblstaffposition.Click += lblstaffposition_Click;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Location = new Point(194, 126);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(66, 15);
            lblStaffName.TabIndex = 25;
            lblStaffName.Text = "Staff Name";
            lblStaffName.Click += lblStaffName_Click;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(300, 83);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(169, 23);
            txtStaffID.TabIndex = 22;
            txtStaffID.TextChanged += txtStaffID_TextChanged;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Location = new Point(191, 86);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(44, 15);
            lblStaffID.TabIndex = 21;
            lblStaffID.Text = "Staff Id";
            lblStaffID.Click += lblStaffID_Click;
            // 
            // lblStaffTitle
            // 
            lblStaffTitle.AutoSize = true;
            lblStaffTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStaffTitle.Location = new Point(261, 9);
            lblStaffTitle.Name = "lblStaffTitle";
            lblStaffTitle.Size = new Size(283, 37);
            lblStaffTitle.TabIndex = 41;
            lblStaffTitle.Text = "STAFF REGISTRATION";
            lblStaffTitle.Click += lblStaffTitle_Click;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(171, 302);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(84, 15);
            lblpassword.TabIndex = 42;
            lblpassword.Text = "Staff Password";
            lblpassword.Click += lblpassword_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(300, 302);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(169, 23);
            txtpassword.TabIndex = 43;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // A_StaffRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 511);
            Controls.Add(txtpassword);
            Controls.Add(lblpassword);
            Controls.Add(lblStaffTitle);
            Controls.Add(btnClear);
            Controls.Add(btnSaveStaff);
            Controls.Add(cmbstaffposition);
            Controls.Add(txtEmail);
            Controls.Add(txtHomeAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtStaffName);
            Controls.Add(lblHomeAddress);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblstaffposition);
            Controls.Add(lblStaffName);
            Controls.Add(txtStaffID);
            Controls.Add(lblStaffID);
            Name = "A_StaffRegistrationForm";
            Text = "A_StaffRegistrationForm";
            Load += A_StaffRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnSaveStaff;
        private ComboBox cmbstaffposition;
        private ComboBox cmbRelation;
        private TextBox txtEmail;
        private TextBox txtHomeAddress;
        private TextBox txtPhone;
        private TextBox txtGaurdianName;
        private TextBox txtStaffName;
        private Label lblHomeAddress;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblstaffposition;
        private Label lblName;
        private Label lblStaffName;
        private TextBox txtStaffID;
        private Label lblStaffID;
        private Label lblStaffTitle;
        private Label lblpassword;
        private TextBox txtpassword;
    }
}