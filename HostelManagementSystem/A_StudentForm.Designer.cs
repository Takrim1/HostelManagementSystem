namespace HostelManagementSystem
{
    partial class A_StudentForm
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
            lblStudentTitle = new Label();
            pnlSearch = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            searchapplybtn = new Button();
            dataGridViewStudents = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            homeaddress = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            AdmissionDate = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            cmbhostelstd = new ComboBox();
            cmbdepartmentstd = new ComboBox();
            cmbHostel = new Label();
            cmbDepartment = new Label();
            lblSearchStudentID = new Label();
            txtSearchStudentID = new TextBox();
            btnRegister = new Button();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // lblStudentTitle
            // 
            lblStudentTitle.AutoSize = true;
            lblStudentTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStudentTitle.Location = new Point(266, 0);
            lblStudentTitle.Name = "lblStudentTitle";
            lblStudentTitle.Size = new Size(328, 37);
            lblStudentTitle.TabIndex = 0;
            lblStudentTitle.Text = "STUDENT MANAGEMENT";
            lblStudentTitle.Click += lblStudentTitle_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(btnDelete);
            pnlSearch.Controls.Add(btnEdit);
            pnlSearch.Controls.Add(searchapplybtn);
            pnlSearch.Controls.Add(dataGridViewStudents);
            pnlSearch.Controls.Add(cmbhostelstd);
            pnlSearch.Controls.Add(cmbdepartmentstd);
            pnlSearch.Controls.Add(cmbHostel);
            pnlSearch.Controls.Add(cmbDepartment);
            pnlSearch.Controls.Add(lblSearchStudentID);
            pnlSearch.Controls.Add(txtSearchStudentID);
            pnlSearch.Location = new Point(0, 163);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1210, 374);
            pnlSearch.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(637, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 42);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(480, 9);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 42);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // searchapplybtn
            // 
            searchapplybtn.BackColor = SystemColors.ActiveCaption;
            searchapplybtn.Location = new Point(800, 6);
            searchapplybtn.Name = "searchapplybtn";
            searchapplybtn.Size = new Size(124, 42);
            searchapplybtn.TabIndex = 7;
            searchapplybtn.Text = "Apply Search";
            searchapplybtn.UseVisualStyleBackColor = false;
            searchapplybtn.Click += searchapplybtn_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { StudentID, homeaddress, StudentName, Gender, Department, Phone, Email, AdmissionDate, password, dob });
            dataGridViewStudents.Location = new Point(0, 91);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(1150, 420);
            dataGridViewStudents.TabIndex = 6;
            dataGridViewStudents.CellContentClick += dataGridViewStudents_CellContentClick;
            // 
            // StudentID
            // 
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "Student ID";
            StudentID.Name = "StudentID";
            // 
            // homeaddress
            // 
            homeaddress.DataPropertyName = "HomeAddress";
            homeaddress.HeaderText = "Home Address";
            homeaddress.Name = "homeaddress";
            // 
            // StudentName
            // 
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "Student Name";
            StudentName.Name = "StudentName";
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            // 
            // Department
            // 
            Department.DataPropertyName = "Department";
            Department.HeaderText = "Department";
            Department.Name = "Department";
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
            // AdmissionDate
            // 
            AdmissionDate.DataPropertyName = "AdmissionDate";
            AdmissionDate.HeaderText = "Admission Date";
            AdmissionDate.Name = "AdmissionDate";
            // 
            // password
            // 
            password.DataPropertyName = "Password";
            password.HeaderText = "Password";
            password.Name = "password";
            // 
            // dob
            // 
            dob.DataPropertyName = "DOB";
            dob.HeaderText = "DOB";
            dob.Name = "dob";
            // 
            // cmbhostelstd
            // 
            cmbhostelstd.FormattingEnabled = true;
            cmbhostelstd.Items.AddRange(new object[] { "Male Hostel", "Female Hostel" });
            cmbhostelstd.Location = new Point(427, 67);
            cmbhostelstd.Name = "cmbhostelstd";
            cmbhostelstd.Size = new Size(121, 23);
            cmbhostelstd.TabIndex = 5;
            cmbhostelstd.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cmbdepartmentstd
            // 
            cmbdepartmentstd.FormattingEnabled = true;
            cmbdepartmentstd.Items.AddRange(new object[] { "🎓 Faculty of Science & Technology (FST) ", "🎓 Faculty of Arts & Social Sciences (FASS)", "🎓 Faculty of Business Administration (FBA) ", "🎓 Faculty of Law ", "🎓 Faculty of Pharmacy & Health Sciences", "\U0001fa7a Faculty of Medicine & Clinical Sciences", " 🌾 Faculty of Agriculture & Life Sciences ", "🎨 Faculty of Fine Arts (FFA) ", "🛡️ Faculty of Security & Strategic Studies (FSSS)", "# Other" });
            cmbdepartmentstd.Location = new Point(145, 62);
            cmbdepartmentstd.Name = "cmbdepartmentstd";
            cmbdepartmentstd.Size = new Size(121, 23);
            cmbdepartmentstd.TabIndex = 4;
            cmbdepartmentstd.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbHostel
            // 
            cmbHostel.AutoSize = true;
            cmbHostel.Location = new Point(333, 70);
            cmbHostel.Name = "cmbHostel";
            cmbHostel.Size = new Size(41, 15);
            cmbHostel.TabIndex = 3;
            cmbHostel.Text = "Hostel";
            cmbHostel.Click += cmbHostel_Click;
            // 
            // cmbDepartment
            // 
            cmbDepartment.AutoSize = true;
            cmbDepartment.Location = new Point(46, 62);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(70, 15);
            cmbDepartment.TabIndex = 2;
            cmbDepartment.Text = "Department";
            cmbDepartment.Click += cmbDepartment_Click;
            // 
            // lblSearchStudentID
            // 
            lblSearchStudentID.AutoSize = true;
            lblSearchStudentID.Location = new Point(23, 18);
            lblSearchStudentID.Name = "lblSearchStudentID";
            lblSearchStudentID.Size = new Size(116, 15);
            lblSearchStudentID.TabIndex = 1;
            lblSearchStudentID.Text = "Search Student by ID";
            lblSearchStudentID.TextAlign = ContentAlignment.TopCenter;
            lblSearchStudentID.Click += lblSearchStudentID_Click;
            // 
            // txtSearchStudentID
            // 
            txtSearchStudentID.Location = new Point(145, 15);
            txtSearchStudentID.Name = "txtSearchStudentID";
            txtSearchStudentID.Size = new Size(207, 23);
            txtSearchStudentID.TabIndex = 0;
            txtSearchStudentID.TextChanged += txtSearchStudentID_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.InactiveBorder;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(14, 57);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(215, 54);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register New Student";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // A_StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRegister);
            Controls.Add(pnlSearch);
            Controls.Add(lblStudentTitle);
            Name = "A_StudentForm";
            Size = new Size(1213, 671);
            Load += StudentForm_Load;
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentTitle;
        private Panel pnlSearch;
        private ComboBox cmbdepartmentstd;
        private Label cmbHostel;
        private Label cmbDepartment;
        private Label lblSearchStudentID;
        private TextBox txtSearchStudentID;
        private ComboBox cmbhostelstd;
        private DataGridView dataGridViewStudents;
        private Button btnRegister;
        private Button searchapplybtn;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn homeaddress;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn AdmissionDate;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn dob;
    }
}
