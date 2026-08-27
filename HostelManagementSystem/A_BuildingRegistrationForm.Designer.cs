namespace HostelManagementSystem
{
    partial class A_BuildingRegistrationForm
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
            cmbstatus = new ComboBox();
            txtStudentName = new TextBox();
            lblStatus = new Label();
            StudentIDlbl = new Label();
            lblStudentName = new Label();
            lblStudentID = new Label();
            txtStudentid = new TextBox();
            lblRoomID = new Label();
            cmbRoomID = new ComboBox();
            cmbFloorID = new ComboBox();
            lblFloorNumber = new Label();
            cmbBedNumber = new ComboBox();
            cmbRoomType = new ComboBox();
            lblRoomType = new Label();
            cmbBedType = new ComboBox();
            BedType = new Label();
            btnClear = new Button();
            btnRegisterStudentbed = new Button();
            lblbedregistration = new Label();
            SuspendLayout();
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "Available", "Reserved", "Maintanace" });
            cmbstatus.Location = new Point(111, 232);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(169, 23);
            cmbstatus.TabIndex = 28;
            cmbstatus.SelectedIndexChanged += cmbstatus_SelectedIndexChanged;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(473, 164);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(163, 23);
            txtStudentName.TabIndex = 26;
            txtStudentName.TextChanged += txtStudentName_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(33, 240);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 25;
            lblStatus.Text = "Status";
            lblStatus.Click += lblStatus_Click;
            // 
            // StudentIDlbl
            // 
            StudentIDlbl.AutoSize = true;
            StudentIDlbl.Location = new Point(362, 223);
            StudentIDlbl.Name = "StudentIDlbl";
            StudentIDlbl.Size = new Size(62, 15);
            StudentIDlbl.TabIndex = 24;
            StudentIDlbl.Text = "Student ID";
            StudentIDlbl.Click += StudentIDlbl_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(369, 167);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(83, 15);
            lblStudentName.TabIndex = 23;
            lblStudentName.Text = "Student Name";
            lblStudentName.Click += lblStudentName_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(387, 78);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(74, 15);
            lblStudentID.TabIndex = 22;
            lblStudentID.Text = "Bed Number";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // txtStudentid
            // 
            txtStudentid.Location = new Point(497, 223);
            txtStudentid.Name = "txtStudentid";
            txtStudentid.Size = new Size(163, 23);
            txtStudentid.TabIndex = 21;
            txtStudentid.TextChanged += txtStudentid_TextChanged;
            // 
            // lblRoomID
            // 
            lblRoomID.AutoSize = true;
            lblRoomID.Location = new Point(33, 117);
            lblRoomID.Name = "lblRoomID";
            lblRoomID.Size = new Size(86, 15);
            lblRoomID.TabIndex = 19;
            lblRoomID.Text = "Room Number";
            lblRoomID.Click += lblRoomID_Click;
            // 
            // cmbRoomID
            // 
            cmbRoomID.FormattingEnabled = true;
            cmbRoomID.Items.AddRange(new object[] { "101", "102", "103", "104", "201", "202", "203", "204", "301", "302", "303", "304", "401", "402", "403", "404", "501", "502", "503", "504", "601", "602", "603", "604", "701", "702", "703", "704", "801", "802", "803", "804", "901", "902", "903", "904" });
            cmbRoomID.Location = new Point(148, 109);
            cmbRoomID.Name = "cmbRoomID";
            cmbRoomID.Size = new Size(169, 23);
            cmbRoomID.TabIndex = 29;
            cmbRoomID.SelectedIndexChanged += cmbRoomID_SelectedIndexChanged;
            // 
            // cmbFloorID
            // 
            cmbFloorID.FormattingEnabled = true;
            cmbFloorID.Items.AddRange(new object[] { "Floor-01", "Floor-02", "Floor-03", "Floor-04", "Floor-05", "Floor-06", "Floor-07", "Floor-08", "Floor-09" });
            cmbFloorID.Location = new Point(158, 75);
            cmbFloorID.Name = "cmbFloorID";
            cmbFloorID.Size = new Size(169, 23);
            cmbFloorID.TabIndex = 30;
            cmbFloorID.SelectedIndexChanged += cmbFloorID_SelectedIndexChanged;
            // 
            // lblFloorNumber
            // 
            lblFloorNumber.AutoSize = true;
            lblFloorNumber.Location = new Point(45, 78);
            lblFloorNumber.Name = "lblFloorNumber";
            lblFloorNumber.Size = new Size(81, 15);
            lblFloorNumber.TabIndex = 31;
            lblFloorNumber.Text = "Floor Number";
            lblFloorNumber.Click += lblFloorNumber_Click;
            // 
            // cmbBedNumber
            // 
            cmbBedNumber.FormattingEnabled = true;
            cmbBedNumber.Items.AddRange(new object[] { "01", "02" });
            cmbBedNumber.Location = new Point(473, 70);
            cmbBedNumber.Name = "cmbBedNumber";
            cmbBedNumber.Size = new Size(169, 23);
            cmbBedNumber.TabIndex = 32;
            cmbBedNumber.SelectedIndexChanged += cmbBedNumber_SelectedIndexChanged;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Single", "Double Person" });
            cmbRoomType.Location = new Point(135, 164);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(169, 23);
            cmbRoomType.TabIndex = 33;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(45, 172);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(67, 15);
            lblRoomType.TabIndex = 34;
            lblRoomType.Text = "Room Type";
            lblRoomType.Click += lblRoomType_Click;
            // 
            // cmbBedType
            // 
            cmbBedType.FormattingEnabled = true;
            cmbBedType.Items.AddRange(new object[] { "Single", "King Size" });
            cmbBedType.Location = new Point(467, 109);
            cmbBedType.Name = "cmbBedType";
            cmbBedType.Size = new Size(169, 23);
            cmbBedType.TabIndex = 35;
            cmbBedType.SelectedIndexChanged += cmbBedType_SelectedIndexChanged;
            // 
            // BedType
            // 
            BedType.AutoSize = true;
            BedType.Location = new Point(387, 112);
            BedType.Name = "BedType";
            BedType.Size = new Size(55, 15);
            BedType.TabIndex = 36;
            BedType.Text = "Bed Type";
            BedType.Click += BedType_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(381, 309);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 44);
            btnClear.TabIndex = 38;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRegisterStudentbed
            // 
            btnRegisterStudentbed.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterStudentbed.Location = new Point(204, 308);
            btnRegisterStudentbed.Name = "btnRegisterStudentbed";
            btnRegisterStudentbed.Size = new Size(132, 45);
            btnRegisterStudentbed.TabIndex = 37;
            btnRegisterStudentbed.Text = "Register Bed";
            btnRegisterStudentbed.UseVisualStyleBackColor = true;
            btnRegisterStudentbed.Click += btnRegisterStudentbed_Click;
            // 
            // lblbedregistration
            // 
            lblbedregistration.AutoSize = true;
            lblbedregistration.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbedregistration.Location = new Point(184, 15);
            lblbedregistration.Name = "lblbedregistration";
            lblbedregistration.Size = new Size(267, 37);
            lblbedregistration.TabIndex = 39;
            lblbedregistration.Text = "BED REGISTRATION";
            lblbedregistration.Click += lblbedregistration_Click;
            // 
            // A_BuildingRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(lblbedregistration);
            Controls.Add(btnClear);
            Controls.Add(btnRegisterStudentbed);
            Controls.Add(BedType);
            Controls.Add(cmbBedType);
            Controls.Add(lblRoomType);
            Controls.Add(cmbRoomType);
            Controls.Add(cmbBedNumber);
            Controls.Add(lblFloorNumber);
            Controls.Add(cmbFloorID);
            Controls.Add(cmbRoomID);
            Controls.Add(cmbstatus);
            Controls.Add(txtStudentName);
            Controls.Add(lblStatus);
            Controls.Add(StudentIDlbl);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentID);
            Controls.Add(txtStudentid);
            Controls.Add(lblRoomID);
            Name = "A_BuildingRegistrationForm";
            Text = "A_BuildingRegistrationForm";
            Load += A_BuildingRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRelation;
        private TextBox txtGaurdianName;
        private TextBox txtStudentName;
        private Label lblStatus;
        private Label StudentIDlbl;
        private Label lblStudentName;
        private Label lblStudentID;
        private TextBox txtStudentid;
        private Label lblRoomID;
        private ComboBox cmbRoomID;
        private ComboBox cmbFloorID;
        private Label lblFloorNumber;
        private ComboBox cmbBedNumber;
        private ComboBox cmbRoomType;
        private Label lblRoomType;
        private ComboBox cmbBedType;
        private Label BedType;
        private Button btnClear;
        private Button btnRegisterStudentbed;
        private Label lblbedregistration;
        private ComboBox cmbstatus;
    }
}