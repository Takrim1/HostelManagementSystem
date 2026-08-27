namespace HostelManagementSystem
{
    partial class A_PaymentRegistrationForm
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
            cmbStatus = new ComboBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lblEmail = new Label();
            lblPhone = new Label();
            lblStatus = new Label();
            lblPaidAmount = new Label();
            lblPaymenttype = new Label();
            lblStudentID = new Label();
            txtStudentID = new TextBox();
            txtPaymentID = new TextBox();
            lblPaymentID = new Label();
            cmbpatmenttype = new ComboBox();
            cmbpaidAmount = new ComboBox();
            cmbdueamount = new ComboBox();
            lblDueamount = new Label();
            lblpaymentregiTitle = new Label();
            btnClear = new Button();
            btnSavepayment = new Button();
            SuspendLayout();
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Pending" });
            cmbStatus.Location = new Point(369, 242);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(169, 23);
            cmbStatus.TabIndex = 46;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(375, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 45;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(369, 171);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(163, 23);
            txtPhone.TabIndex = 44;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(267, 208);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 41;
            lblEmail.Text = "Email";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(261, 174);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 40;
            lblPhone.Text = "Phone";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(252, 245);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 39;
            lblStatus.Text = "Status";
            lblStatus.Click += lblRelation_Click;
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.AutoSize = true;
            lblPaidAmount.Location = new Point(248, 283);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(77, 15);
            lblPaidAmount.TabIndex = 38;
            lblPaidAmount.Text = "Paid Amount";
            lblPaidAmount.Click += lblPaidAmount_Click;
            // 
            // lblPaymenttype
            // 
            lblPaymenttype.AutoSize = true;
            lblPaymenttype.Location = new Point(248, 324);
            lblPaymenttype.Name = "lblPaymenttype";
            lblPaymenttype.Size = new Size(82, 15);
            lblPaymenttype.TabIndex = 37;
            lblPaymenttype.Text = "Payment Type";
            lblPaymenttype.Click += lblPaymenttype_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(267, 134);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(62, 15);
            lblStudentID.TabIndex = 36;
            lblStudentID.Text = "Student ID";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(375, 130);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(163, 23);
            txtStudentID.TabIndex = 35;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // txtPaymentID
            // 
            txtPaymentID.Location = new Point(369, 88);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.Size = new Size(169, 23);
            txtPaymentID.TabIndex = 34;
            txtPaymentID.TextChanged += txtPaymentID_TextChanged;
            // 
            // lblPaymentID
            // 
            lblPaymentID.AutoSize = true;
            lblPaymentID.Location = new Point(263, 87);
            lblPaymentID.Name = "lblPaymentID";
            lblPaymentID.Size = new Size(67, 15);
            lblPaymentID.TabIndex = 33;
            lblPaymentID.Text = "Payment Id";
            lblPaymentID.Click += lblPaymentID_Click;
            // 
            // cmbpatmenttype
            // 
            cmbpatmenttype.FormattingEnabled = true;
            cmbpatmenttype.Items.AddRange(new object[] { "Cash", "Online" });
            cmbpatmenttype.Location = new Point(363, 316);
            cmbpatmenttype.Name = "cmbpatmenttype";
            cmbpatmenttype.Size = new Size(169, 23);
            cmbpatmenttype.TabIndex = 47;
            cmbpatmenttype.SelectedIndexChanged += cmbpatmenttype_SelectedIndexChanged;
            // 
            // cmbpaidAmount
            // 
            cmbpaidAmount.FormattingEnabled = true;
            cmbpaidAmount.Items.AddRange(new object[] { "10000", "20000", "30000", "40000", "50000" });
            cmbpaidAmount.Location = new Point(363, 280);
            cmbpaidAmount.Name = "cmbpaidAmount";
            cmbpaidAmount.Size = new Size(169, 23);
            cmbpaidAmount.TabIndex = 48;
            cmbpaidAmount.SelectedIndexChanged += cmbpaidAmount_SelectedIndexChanged;
            // 
            // cmbdueamount
            // 
            cmbdueamount.FormattingEnabled = true;
            cmbdueamount.Items.AddRange(new object[] { "10000", "20000", "30000", "40000", "50000" });
            cmbdueamount.Location = new Point(363, 357);
            cmbdueamount.Name = "cmbdueamount";
            cmbdueamount.Size = new Size(169, 23);
            cmbdueamount.TabIndex = 50;
            cmbdueamount.SelectedIndexChanged += cmbdueamount_SelectedIndexChanged;
            // 
            // lblDueamount
            // 
            lblDueamount.AutoSize = true;
            lblDueamount.Location = new Point(242, 360);
            lblDueamount.Name = "lblDueamount";
            lblDueamount.Size = new Size(75, 15);
            lblDueamount.TabIndex = 49;
            lblDueamount.Text = "Due Amount";
            lblDueamount.Click += lblDueamount_Click;
            // 
            // lblpaymentregiTitle
            // 
            lblpaymentregiTitle.AutoSize = true;
            lblpaymentregiTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblpaymentregiTitle.Location = new Point(267, 26);
            lblpaymentregiTitle.Name = "lblpaymentregiTitle";
            lblpaymentregiTitle.Size = new Size(219, 30);
            lblpaymentregiTitle.TabIndex = 51;
            lblpaymentregiTitle.Text = "Payment Registration";
            lblpaymentregiTitle.Click += lblpaymentregiTitle_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(435, 418);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 43);
            btnClear.TabIndex = 53;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSavepayment
            // 
            btnSavepayment.Location = new Point(242, 416);
            btnSavepayment.Name = "btnSavepayment";
            btnSavepayment.Size = new Size(153, 45);
            btnSavepayment.TabIndex = 52;
            btnSavepayment.Text = "Save Payment";
            btnSavepayment.UseVisualStyleBackColor = true;
            btnSavepayment.Click += btnSavepayment_Click;
            // 
            // A_PaymentRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 541);
            Controls.Add(btnClear);
            Controls.Add(btnSavepayment);
            Controls.Add(lblpaymentregiTitle);
            Controls.Add(cmbdueamount);
            Controls.Add(lblDueamount);
            Controls.Add(cmbpaidAmount);
            Controls.Add(cmbpatmenttype);
            Controls.Add(cmbStatus);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblStatus);
            Controls.Add(lblPaidAmount);
            Controls.Add(lblPaymenttype);
            Controls.Add(lblStudentID);
            Controls.Add(txtStudentID);
            Controls.Add(txtPaymentID);
            Controls.Add(lblPaymentID);
            Name = "A_PaymentRegistrationForm";
            Text = "A_PaymentRegistrationForm";
            Load += A_PaymentRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStatus;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblStatus;
        private Label lblPaidAmount;
        private Label lblPaymenttype;
        private Label lblStudentID;
        private TextBox txtStudentID;
        private TextBox txtPaymentID;
        private Label lblPaymentID;
        private ComboBox cmbpatmenttype;
        private ComboBox cmbpaidAmount;
        private ComboBox cmbdueamount;
        private Label lblDueamount;
        private Label lblpaymentregiTitle;
        private Button btnClear;
        private Button btnSavepayment;
    }
}