namespace HostelManagementSystem
{
    partial class A_PaymentForm
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDeletePayment = new Button();
            lblGuardianTitle = new Label();
            pnlPaymentSearch = new Panel();
            txtEmail = new TextBox();
            dataGridView1 = new DataGridView();
            PaymentID = new DataGridViewTextBoxColumn();
            StudentID = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            PaidAmount = new DataGridViewTextBoxColumn();
            PaymentType = new DataGridViewTextBoxColumn();
            DueAmount = new DataGridViewTextBoxColumn();
            btnapplysearch = new Button();
            txtPhone = new TextBox();
            txtStudentID = new TextBox();
            lblGaurdianPhone = new Label();
            lblStudentID = new Label();
            lblSearchGaurdian = new Label();
            txtpaymentSearch = new TextBox();
            btnEditPayment = new Button();
            btnPayment = new Button();
            lblStatus = new Label();
            lblPaidAmount = new Label();
            lblPaymentType = new Label();
            lblDueAmount = new Label();
            cmbStatus = new ComboBox();
            cmbpaidAmount = new ComboBox();
            cmbpatmenttype = new ComboBox();
            cmbdueamount = new ComboBox();
            lblemail = new Label();
            pnlPaymentSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDeletePayment
            // 
            btnDeletePayment.BackColor = SystemColors.GradientActiveCaption;
            btnDeletePayment.Location = new Point(136, 103);
            btnDeletePayment.Name = "btnDeletePayment";
            btnDeletePayment.Size = new Size(143, 51);
            btnDeletePayment.TabIndex = 13;
            btnDeletePayment.Text = "Delete Payment";
            btnDeletePayment.UseVisualStyleBackColor = false;
            btnDeletePayment.Click += btnDeletePayment_Click;
            // 
            // lblGuardianTitle
            // 
            lblGuardianTitle.AutoSize = true;
            lblGuardianTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGuardianTitle.Location = new Point(315, -39);
            lblGuardianTitle.Name = "lblGuardianTitle";
            lblGuardianTitle.Size = new Size(208, 30);
            lblGuardianTitle.TabIndex = 10;
            lblGuardianTitle.Text = "Staff MANAGEMENT";
            // 
            // pnlPaymentSearch
            // 
            pnlPaymentSearch.Controls.Add(lblemail);
            pnlPaymentSearch.Controls.Add(txtEmail);
            pnlPaymentSearch.Controls.Add(dataGridView1);
            pnlPaymentSearch.Controls.Add(btnapplysearch);
            pnlPaymentSearch.Controls.Add(txtPhone);
            pnlPaymentSearch.Controls.Add(txtStudentID);
            pnlPaymentSearch.Controls.Add(lblGaurdianPhone);
            pnlPaymentSearch.Controls.Add(lblStudentID);
            pnlPaymentSearch.Controls.Add(lblSearchGaurdian);
            pnlPaymentSearch.Controls.Add(txtpaymentSearch);
            pnlPaymentSearch.Location = new Point(11, 255);
            pnlPaymentSearch.Name = "pnlPaymentSearch";
            pnlPaymentSearch.Size = new Size(933, 444);
            pnlPaymentSearch.TabIndex = 9;
            pnlPaymentSearch.Paint += pnlPaymentSearch_Paint;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(553, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 27);
            txtEmail.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PaymentID, StudentID, Phone, Email, Status, PaidAmount, PaymentType, DueAmount });
            dataGridView1.Location = new Point(12, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(887, 380);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PaymentID
            // 
            PaymentID.DataPropertyName = "PaymentID";
            PaymentID.HeaderText = "Payment ID";
            PaymentID.Name = "PaymentID";
            // 
            // StudentID
            // 
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "Student ID";
            StudentID.Name = "StudentID";
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // PaidAmount
            // 
            PaidAmount.DataPropertyName = "PaidAmount";
            PaidAmount.HeaderText = "Paid Amount";
            PaidAmount.Name = "PaidAmount";
            // 
            // PaymentType
            // 
            PaymentType.DataPropertyName = "PaymentType";
            PaymentType.HeaderText = "Payment Type";
            PaymentType.Name = "PaymentType";
            // 
            // DueAmount
            // 
            DueAmount.DataPropertyName = "DueAmount";
            DueAmount.HeaderText = "DueAmount";
            DueAmount.Name = "DueAmount";
            // 
            // btnapplysearch
            // 
            btnapplysearch.BackColor = Color.Gainsboro;
            btnapplysearch.Location = new Point(769, 29);
            btnapplysearch.Name = "btnapplysearch";
            btnapplysearch.Size = new Size(106, 53);
            btnapplysearch.TabIndex = 8;
            btnapplysearch.Text = "Apply Search";
            btnapplysearch.UseVisualStyleBackColor = false;
            btnapplysearch.Click += btnapplysearch_Click;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(179, 65);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 27);
            txtPhone.TabIndex = 7;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(553, 21);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(164, 27);
            txtStudentID.TabIndex = 6;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // lblGaurdianPhone
            // 
            lblGaurdianPhone.AutoSize = true;
            lblGaurdianPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGaurdianPhone.Location = new Point(12, 65);
            lblGaurdianPhone.Name = "lblGaurdianPhone";
            lblGaurdianPhone.Size = new Size(101, 17);
            lblGaurdianPhone.TabIndex = 4;
            lblGaurdianPhone.Text = "Phone Number";
            lblGaurdianPhone.Click += lblGaurdianPhone_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentID.Location = new Point(424, 25);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(72, 17);
            lblStudentID.TabIndex = 2;
            lblStudentID.Text = "Student Id";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // lblSearchGaurdian
            // 
            lblSearchGaurdian.AutoSize = true;
            lblSearchGaurdian.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchGaurdian.Location = new Point(12, 21);
            lblSearchGaurdian.Name = "lblSearchGaurdian";
            lblSearchGaurdian.Size = new Size(128, 15);
            lblSearchGaurdian.TabIndex = 1;
            lblSearchGaurdian.Text = "Search Payment By Id";
            lblSearchGaurdian.Click += lblSearchGaurdian_Click;
            // 
            // txtpaymentSearch
            // 
            txtpaymentSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpaymentSearch.Location = new Point(143, 15);
            txtpaymentSearch.Name = "txtpaymentSearch";
            txtpaymentSearch.Size = new Size(164, 27);
            txtpaymentSearch.TabIndex = 0;
            txtpaymentSearch.TextChanged += txtpaymentSearch_TextChanged;
            // 
            // btnEditPayment
            // 
            btnEditPayment.BackColor = SystemColors.GradientActiveCaption;
            btnEditPayment.Location = new Point(547, 108);
            btnEditPayment.Name = "btnEditPayment";
            btnEditPayment.Size = new Size(129, 55);
            btnEditPayment.TabIndex = 12;
            btnEditPayment.Text = "Edit Payment";
            btnEditPayment.UseVisualStyleBackColor = false;
            btnEditPayment.Click += btnEditPayment_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = SystemColors.GradientActiveCaption;
            btnPayment.Location = new Point(375, 113);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(119, 57);
            btnPayment.TabIndex = 11;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(815, 46);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(46, 17);
            lblStatus.TabIndex = 18;
            lblStatus.Text = "Status";
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.AutoSize = true;
            lblPaidAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaidAmount.Location = new Point(806, 88);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(89, 17);
            lblPaidAmount.TabIndex = 20;
            lblPaidAmount.Text = "Paid Amount";
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            lblPaymentType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentType.Location = new Point(791, 131);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(95, 17);
            lblPaymentType.TabIndex = 22;
            lblPaymentType.Text = "Payment Type";
            // 
            // lblDueAmount
            // 
            lblDueAmount.AutoSize = true;
            lblDueAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDueAmount.Location = new Point(791, 169);
            lblDueAmount.Name = "lblDueAmount";
            lblDueAmount.Size = new Size(87, 17);
            lblDueAmount.TabIndex = 24;
            lblDueAmount.Text = "Due Amount";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Paid", "Pending", "Partial" });
            cmbStatus.Location = new Point(901, 40);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(130, 23);
            cmbStatus.TabIndex = 19;
            // 
            // cmbpaidAmount
            // 
            cmbpaidAmount.Location = new Point(911, 87);
            cmbpaidAmount.Name = "cmbpaidAmount";
            cmbpaidAmount.Size = new Size(130, 23);
            cmbpaidAmount.TabIndex = 21;
            // 
            // cmbpatmenttype
            // 
            cmbpatmenttype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpatmenttype.Items.AddRange(new object[] { "Cash", "Bkash", "Nagad", "Bank" });
            cmbpatmenttype.Location = new Point(911, 131);
            cmbpatmenttype.Name = "cmbpatmenttype";
            cmbpatmenttype.Size = new Size(120, 23);
            cmbpatmenttype.TabIndex = 23;
            // 
            // cmbdueamount
            // 
            cmbdueamount.Location = new Point(911, 168);
            cmbdueamount.Name = "cmbdueamount";
            cmbdueamount.Size = new Size(120, 23);
            cmbdueamount.TabIndex = 25;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblemail.Location = new Point(424, 75);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(42, 17);
            lblemail.TabIndex = 27;
            lblemail.Text = "Email";
            // 
            // A_PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDueAmount);
            Controls.Add(cmbdueamount);
            Controls.Add(btnDeletePayment);
            Controls.Add(lblGuardianTitle);
            Controls.Add(cmbpatmenttype);
            Controls.Add(pnlPaymentSearch);
            Controls.Add(lblPaymentType);
            Controls.Add(btnEditPayment);
            Controls.Add(cmbpaidAmount);
            Controls.Add(btnPayment);
            Controls.Add(lblPaidAmount);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Name = "A_PaymentForm";
            Size = new Size(1103, 751);
            Load += A_PaymentForm_Load;
            pnlPaymentSearch.ResumeLayout(false);
            pnlPaymentSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeletePayment;
        private Label lblGuardianTitle;
        private Panel pnlPaymentSearch;
        private DataGridView dataGridView1;
        private Button btnapplysearch;
        private TextBox txtPhone;
        private TextBox txtStudentID;
        private Label lblGaurdianPhone;
        private Label lblStudentID;
        private Label lblSearchGaurdian;
        private TextBox txtpaymentSearch;
        private Button btnEditPayment;
        private Button btnPayment;

        private Label lblStatus;
        private Label lblPaidAmount;
        private Label lblPaymentType;
        private Label lblDueAmount;

        private ComboBox cmbStatus;
        private ComboBox cmbpaidAmount;
        private ComboBox cmbpatmenttype;
        private ComboBox cmbdueamount;

        private DataGridViewTextBoxColumn PaymentID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn PaidAmount;
        private DataGridViewTextBoxColumn PaymentType;
        private DataGridViewTextBoxColumn DueAmount;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private Label lblemail;
    }
}