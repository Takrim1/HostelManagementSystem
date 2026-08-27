namespace HostelManagementSystem
{
    partial class A_StaffForm
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
            pnlGuardianSearch = new Panel();
            dataGridView1 = new DataGridView();
            btnapplysearch = new Button();
            txtPhone = new TextBox();
            txtStaffID = new TextBox();
            txtStaffName = new TextBox();
            lblStaffPhone = new Label();
            lblStaffName = new Label();
            lblStaffID = new Label();
            lblSearchStaff = new Label();
            txtStaffSearch = new TextBox();
            btndeletestaff = new Button();
            btneditstaff = new Button();
            btnregisterstaff = new Button();
            lblStaffTitle = new Label();
            Staffid = new DataGridViewTextBoxColumn();
            Staffname = new DataGridViewTextBoxColumn();
            StaffPosition = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            HomeAddress = new DataGridViewTextBoxColumn();
            pnlGuardianSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlGuardianSearch
            // 
            pnlGuardianSearch.Controls.Add(dataGridView1);
            pnlGuardianSearch.Controls.Add(btnapplysearch);
            pnlGuardianSearch.Controls.Add(txtPhone);
            pnlGuardianSearch.Controls.Add(txtStaffID);
            pnlGuardianSearch.Controls.Add(txtStaffName);
            pnlGuardianSearch.Controls.Add(lblStaffPhone);
            pnlGuardianSearch.Controls.Add(lblStaffName);
            pnlGuardianSearch.Controls.Add(lblStaffID);
            pnlGuardianSearch.Controls.Add(lblSearchStaff);
            pnlGuardianSearch.Controls.Add(txtStaffSearch);
            pnlGuardianSearch.Location = new Point(3, 145);
            pnlGuardianSearch.Name = "pnlGuardianSearch";
            pnlGuardianSearch.Size = new Size(933, 593);
            pnlGuardianSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Staffid, Staffname, StaffPosition, phone, Email, HomeAddress });
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(887, 380);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            txtPhone.Location = new Point(553, 65);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 27);
            txtPhone.TabIndex = 7;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtStaffID
            // 
            txtStaffID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffID.Location = new Point(553, 21);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(164, 27);
            txtStaffID.TabIndex = 6;
            txtStaffID.TextChanged += txtStaffID_TextChanged;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffName.Location = new Point(143, 60);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(164, 27);
            txtStaffName.TabIndex = 5;
            txtStaffName.TextChanged += txtStaffName_TextChanged;
            // 
            // lblStaffPhone
            // 
            lblStaffPhone.AutoSize = true;
            lblStaffPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffPhone.Location = new Point(386, 70);
            lblStaffPhone.Name = "lblStaffPhone";
            lblStaffPhone.Size = new Size(134, 17);
            lblStaffPhone.TabIndex = 4;
            lblStaffPhone.Text = "Staff Phone Number";
            lblStaffPhone.Click += lblStaffPhone_Click;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffName.Location = new Point(12, 65);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(77, 17);
            lblStaffName.TabIndex = 3;
            lblStaffName.Text = "Staff Name";
            lblStaffName.Click += lblStaffName_Click;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffID.Location = new Point(424, 25);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(53, 17);
            lblStaffID.TabIndex = 2;
            lblStaffID.Text = "Staff Id";
            lblStaffID.Click += lblStaffID_Click;
            // 
            // lblSearchStaff
            // 
            lblSearchStaff.AutoSize = true;
            lblSearchStaff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchStaff.Location = new Point(12, 21);
            lblSearchStaff.Name = "lblSearchStaff";
            lblSearchStaff.Size = new Size(107, 15);
            lblSearchStaff.TabIndex = 1;
            lblSearchStaff.Text = "Search Staff By Id";
            lblSearchStaff.Click += lblSearchStaff_Click;
            // 
            // txtStaffSearch
            // 
            txtStaffSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffSearch.Location = new Point(143, 15);
            txtStaffSearch.Name = "txtStaffSearch";
            txtStaffSearch.Size = new Size(164, 27);
            txtStaffSearch.TabIndex = 0;
            txtStaffSearch.TextChanged += txtStaffSearch_TextChanged;
            // 
            // btndeletestaff
            // 
            btndeletestaff.BackColor = SystemColors.GradientActiveCaption;
            btndeletestaff.Location = new Point(356, 50);
            btndeletestaff.Name = "btndeletestaff";
            btndeletestaff.Size = new Size(143, 51);
            btndeletestaff.TabIndex = 8;
            btndeletestaff.Text = "Delete Staff";
            btndeletestaff.UseVisualStyleBackColor = false;
            btndeletestaff.Click += btndeletestaff_Click;
            // 
            // btneditstaff
            // 
            btneditstaff.BackColor = SystemColors.GradientActiveCaption;
            btneditstaff.Location = new Point(573, 52);
            btneditstaff.Name = "btneditstaff";
            btneditstaff.Size = new Size(129, 55);
            btneditstaff.TabIndex = 7;
            btneditstaff.Text = "Edit Staff";
            btneditstaff.UseVisualStyleBackColor = false;
            btneditstaff.Click += btneditstaff_Click;
            // 
            // btnregisterstaff
            // 
            btnregisterstaff.BackColor = SystemColors.GradientActiveCaption;
            btnregisterstaff.Location = new Point(82, 50);
            btnregisterstaff.Name = "btnregisterstaff";
            btnregisterstaff.Size = new Size(119, 57);
            btnregisterstaff.TabIndex = 6;
            btnregisterstaff.Text = "Register Staff";
            btnregisterstaff.UseVisualStyleBackColor = false;
            btnregisterstaff.Click += btnregisterstaff_Click;
            // 
            // lblStaffTitle
            // 
            lblStaffTitle.AutoSize = true;
            lblStaffTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStaffTitle.Location = new Point(307, 0);
            lblStaffTitle.Name = "lblStaffTitle";
            lblStaffTitle.Size = new Size(208, 30);
            lblStaffTitle.TabIndex = 5;
            lblStaffTitle.Text = "Staff MANAGEMENT";
            lblStaffTitle.Click += lblStaffTitle_Click;
            // 
            // Staffid
            // 
            Staffid.DataPropertyName = "Staffid";
            Staffid.HeaderText = "Staff ID";
            Staffid.Name = "Staffid";
            // 
            // Staffname
            // 
            Staffname.DataPropertyName = "Staffname";
            Staffname.HeaderText = "Staff Name";
            Staffname.Name = "Staffname";
            // 
            // StaffPosition
            // 
            StaffPosition.DataPropertyName = "StaffPosition";
            StaffPosition.HeaderText = "Staff Position";
            StaffPosition.Name = "StaffPosition";
            // 
            // phone
            // 
            phone.DataPropertyName = "phone";
            phone.HeaderText = "Phone";
            phone.Name = "phone";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // HomeAddress
            // 
            HomeAddress.DataPropertyName = "HomeAddress";
            HomeAddress.HeaderText = "Home Address";
            HomeAddress.Name = "HomeAddress";
            // 
            // A_StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btndeletestaff);
            Controls.Add(lblStaffTitle);
            Controls.Add(pnlGuardianSearch);
            Controls.Add(btneditstaff);
            Controls.Add(btnregisterstaff);
            Name = "A_StaffForm";
            Size = new Size(1014, 661);
            Load += A_StaffForm_Load;
            pnlGuardianSearch.ResumeLayout(false);
            pnlGuardianSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlGuardianSearch;
        private DataGridView dataGridView1;
        private Button btnapplysearch;
        private TextBox txtPhone;
        private TextBox txtStaffID;
        private TextBox txtStaffName;
        private Label lblStaffPhone;
        private Label lblStaffName;
        private Label lblStaffID;
        private Label lblSearchStaff;
        private TextBox txtStaffSearch;
        private Button btndeletestaff;
        private Button btneditstaff;
        private Button btnregisterstaff;
        private Label lblStaffTitle;
        private DataGridViewTextBoxColumn Staffid;
        private DataGridViewTextBoxColumn Staffname;
        private DataGridViewTextBoxColumn StaffPosition;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn HomeAddress;
    }
}
