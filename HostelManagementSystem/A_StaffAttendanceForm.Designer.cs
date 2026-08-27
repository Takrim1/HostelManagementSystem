namespace HostelManagementSystem
{
    partial class A_StaffAttendanceForm
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
            pnlStaffSearch = new Panel();
            dataGridView1 = new DataGridView();
            StaffID = new DataGridViewTextBoxColumn();
            StaffName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            btnapplysearch = new Button();
            txtStaffName = new TextBox();
            lblStaffName = new Label();
            lblSearchSatffID = new Label();
            txtStaffIdSearch = new TextBox();
            txtStaffID = new TextBox();
            lblstatus = new Label();
            lblStaffId = new Label();
            btnAttendance = new Button();
            comboBox1 = new ComboBox();
            lbldate = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblaStaffName = new Label();
            txtStaffNamel = new TextBox();
            btneditattendance = new Button();
            pnlStaffSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlStaffSearch
            // 
            pnlStaffSearch.Controls.Add(dataGridView1);
            pnlStaffSearch.Controls.Add(btnapplysearch);
            pnlStaffSearch.Controls.Add(txtStaffName);
            pnlStaffSearch.Controls.Add(lblStaffName);
            pnlStaffSearch.Controls.Add(lblSearchSatffID);
            pnlStaffSearch.Controls.Add(txtStaffIdSearch);
            pnlStaffSearch.Location = new Point(3, 169);
            pnlStaffSearch.Name = "pnlStaffSearch";
            pnlStaffSearch.Size = new Size(933, 495);
            pnlStaffSearch.TabIndex = 14;
            pnlStaffSearch.Paint += pnlStaffSearch_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StaffID, StaffName, Status, Date });
            dataGridView1.Location = new Point(12, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(887, 373);
            dataGridView1.TabIndex = 9;
            // 
            // StaffID
            // 
            StaffID.DataPropertyName = "StaffID";
            StaffID.HeaderText = "Staff ID";
            StaffID.Name = "StaffID";
            // 
            // StaffName
            // 
            StaffName.DataPropertyName = "StaffName";
            StaffName.HeaderText = "Staff Name";
            StaffName.Name = "StaffName";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // btnapplysearch
            // 
            btnapplysearch.BackColor = Color.Gainsboro;
            btnapplysearch.Location = new Point(718, 33);
            btnapplysearch.Name = "btnapplysearch";
            btnapplysearch.Size = new Size(106, 53);
            btnapplysearch.TabIndex = 8;
            btnapplysearch.Text = "Apply Search";
            btnapplysearch.UseVisualStyleBackColor = false;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffName.Location = new Point(498, 59);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(164, 27);
            txtStaffName.TabIndex = 5;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffName.Location = new Point(386, 64);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(77, 17);
            lblStaffName.TabIndex = 3;
            lblStaffName.Text = "Staff Name";
            // 
            // lblSearchSatffID
            // 
            lblSearchSatffID.AutoSize = true;
            lblSearchSatffID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchSatffID.Location = new Point(12, 66);
            lblSearchSatffID.Name = "lblSearchSatffID";
            lblSearchSatffID.Size = new Size(107, 15);
            lblSearchSatffID.TabIndex = 1;
            lblSearchSatffID.Text = "Search Staff By Id";
            lblSearchSatffID.Click += lblSearchSatffID_Click;
            // 
            // txtStaffIdSearch
            // 
            txtStaffIdSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffIdSearch.Location = new Point(161, 59);
            txtStaffIdSearch.Name = "txtStaffIdSearch";
            txtStaffIdSearch.Size = new Size(164, 27);
            txtStaffIdSearch.TabIndex = 0;
            txtStaffIdSearch.TextChanged += txtStaffIdSearch_TextChanged;
            // 
            // txtStaffID
            // 
            txtStaffID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffID.Location = new Point(164, 35);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(164, 27);
            txtStaffID.TabIndex = 6;
            txtStaffID.TextChanged += txtStaffID_TextChanged;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatus.Location = new Point(62, 97);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(46, 17);
            lblstatus.TabIndex = 4;
            lblstatus.Text = "Status";
            lblstatus.Click += lblstatus_Click;
            // 
            // lblStaffId
            // 
            lblStaffId.AutoSize = true;
            lblStaffId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffId.Location = new Point(62, 40);
            lblStaffId.Name = "lblStaffId";
            lblStaffId.Size = new Size(55, 17);
            lblStaffId.TabIndex = 2;
            lblStaffId.Text = "Staff ID";
            lblStaffId.Click += lblStaffId_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = SystemColors.GradientActiveCaption;
            btnAttendance.Location = new Point(709, 35);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(154, 57);
            btnAttendance.TabIndex = 15;
            btnAttendance.Text = "Add Staff Attendance";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Present", "Absent", "Reason Leave" });
            comboBox1.Location = new Point(157, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldate.Location = new Point(389, 103);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(37, 17);
            lbldate.TabIndex = 17;
            lbldate.Text = "Date";
            lbldate.Click += lbldate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(447, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblaStaffName
            // 
            lblaStaffName.AutoSize = true;
            lblaStaffName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblaStaffName.Location = new Point(381, 45);
            lblaStaffName.Name = "lblaStaffName";
            lblaStaffName.Size = new Size(77, 17);
            lblaStaffName.TabIndex = 19;
            lblaStaffName.Text = "Staff Name";
            lblaStaffName.Click += lblaStaffName_Click;
            // 
            // txtStaffNamel
            // 
            txtStaffNamel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffNamel.Location = new Point(483, 40);
            txtStaffNamel.Name = "txtStaffNamel";
            txtStaffNamel.Size = new Size(164, 27);
            txtStaffNamel.TabIndex = 20;
            txtStaffNamel.TextChanged += txtStaffNamel_TextChanged;
            // 
            // btneditattendance
            // 
            btneditattendance.BackColor = SystemColors.GradientActiveCaption;
            btneditattendance.Location = new Point(709, 106);
            btneditattendance.Name = "btneditattendance";
            btneditattendance.Size = new Size(154, 57);
            btneditattendance.TabIndex = 21;
            btneditattendance.Text = "Edit Attendance";
            btneditattendance.UseVisualStyleBackColor = false;
            btneditattendance.Click += btneditattendance_Click;
            // 
            // A_StaffAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btneditattendance);
            Controls.Add(lblaStaffName);
            Controls.Add(txtStaffNamel);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbldate);
            Controls.Add(comboBox1);
            Controls.Add(pnlStaffSearch);
            Controls.Add(btnAttendance);
            Controls.Add(lblStaffId);
            Controls.Add(txtStaffID);
            Controls.Add(lblstatus);
            Name = "A_StaffAttendanceForm";
            Size = new Size(1035, 755);
            Load += A_StaffAttendanceForm_Load;
            pnlStaffSearch.ResumeLayout(false);
            pnlStaffSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlStaffSearch;
        private DataGridView dataGridView1;
        private Button btnapplysearch;
        private TextBox txtStaffID;
        private TextBox txtStaffName;
        private Label lblstatus;
        private Label lblStaffName;
        private Label lblStaffId;
        private Label lblSearchSatffID;
        private TextBox txtStaffIdSearch;
        private Button btnAttendance;
        private ComboBox comboBox1;
        private Label lbldate;
        private DateTimePicker dateTimePicker1;
        private Label lblaStaffName;
        private TextBox txtStaffNamel;
        private DataGridViewTextBoxColumn StaffID;
        private DataGridViewTextBoxColumn StaffName;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Date;
        private Button btneditattendance;
    }
}
