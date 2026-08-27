namespace HostelManagementSystem
{
    partial class A_VisitorForm
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
            btnRegisterVisitor = new Button();
            pnlVisitorSearch = new Panel();
            txtSearchStudentID = new TextBox();
            lblSearchStudentID = new Label();
            searchapplybtn = new Button();
            dataGridViewStudents = new DataGridView();
            comboBox2 = new ComboBox();
            cmbHostel = new Label();
            lblSearchVisitorID = new Label();
            txtSearchVisitorID = new TextBox();
            lblVisitorTitle = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            VisitorID = new DataGridViewTextBoxColumn();
            StudentID = new DataGridViewTextBoxColumn();
            VisitorName = new DataGridViewTextBoxColumn();
            VisitDate = new DataGridViewTextBoxColumn();
            Hostel = new DataGridViewTextBoxColumn();
            pnlVisitorSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // btnRegisterVisitor
            // 
            btnRegisterVisitor.BackColor = SystemColors.InactiveBorder;
            btnRegisterVisitor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterVisitor.Location = new Point(12, 118);
            btnRegisterVisitor.Name = "btnRegisterVisitor";
            btnRegisterVisitor.Size = new Size(215, 54);
            btnRegisterVisitor.TabIndex = 5;
            btnRegisterVisitor.Text = "Register New Visitor";
            btnRegisterVisitor.UseVisualStyleBackColor = false;
            btnRegisterVisitor.Click += btnRegisterVisitor_Click;
            // 
            // pnlVisitorSearch
            // 
            pnlVisitorSearch.Controls.Add(txtSearchStudentID);
            pnlVisitorSearch.Controls.Add(lblSearchStudentID);
            pnlVisitorSearch.Controls.Add(searchapplybtn);
            pnlVisitorSearch.Controls.Add(dataGridViewStudents);
            pnlVisitorSearch.Controls.Add(comboBox2);
            pnlVisitorSearch.Controls.Add(cmbHostel);
            pnlVisitorSearch.Controls.Add(lblSearchVisitorID);
            pnlVisitorSearch.Controls.Add(txtSearchVisitorID);
            pnlVisitorSearch.Location = new Point(-2, 225);
            pnlVisitorSearch.Name = "pnlVisitorSearch";
            pnlVisitorSearch.Size = new Size(972, 373);
            pnlVisitorSearch.TabIndex = 4;
            pnlVisitorSearch.Paint += pnlVisitorSearch_Paint;
            // 
            // txtSearchStudentID
            // 
            txtSearchStudentID.Location = new Point(145, 50);
            txtSearchStudentID.Name = "txtSearchStudentID";
            txtSearchStudentID.Size = new Size(207, 23);
            txtSearchStudentID.TabIndex = 9;
            txtSearchStudentID.TextChanged += txtSearchStudentID_TextChanged;
            // 
            // lblSearchStudentID
            // 
            lblSearchStudentID.AutoSize = true;
            lblSearchStudentID.Location = new Point(23, 53);
            lblSearchStudentID.Name = "lblSearchStudentID";
            lblSearchStudentID.Size = new Size(116, 15);
            lblSearchStudentID.TabIndex = 8;
            lblSearchStudentID.Text = "Search Student by ID";
            lblSearchStudentID.TextAlign = ContentAlignment.TopCenter;
            lblSearchStudentID.Click += lblSearchStudentID_Click;
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
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { VisitorID, StudentID, VisitorName, VisitDate, Hostel });
            dataGridViewStudents.Location = new Point(14, 99);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(848, 420);
            dataGridViewStudents.TabIndex = 6;
            dataGridViewStudents.CellContentClick += dataGridViewStudents_CellContentClick;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male Hostel A", "Male Hostel B", "Female Hostel A", "Female Hostel B" });
            comboBox2.Location = new Point(473, 15);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cmbHostel
            // 
            cmbHostel.AutoSize = true;
            cmbHostel.Location = new Point(404, 18);
            cmbHostel.Name = "cmbHostel";
            cmbHostel.Size = new Size(41, 15);
            cmbHostel.TabIndex = 3;
            cmbHostel.Text = "Hostel";
            cmbHostel.Click += cmbHostel_Click;
            // 
            // lblSearchVisitorID
            // 
            lblSearchVisitorID.AutoSize = true;
            lblSearchVisitorID.Location = new Point(23, 18);
            lblSearchVisitorID.Name = "lblSearchVisitorID";
            lblSearchVisitorID.Size = new Size(108, 15);
            lblSearchVisitorID.TabIndex = 1;
            lblSearchVisitorID.Text = "Search Visitor by ID";
            lblSearchVisitorID.TextAlign = ContentAlignment.TopCenter;
            lblSearchVisitorID.Click += lblSearchVisitorID_Click;
            // 
            // txtSearchVisitorID
            // 
            txtSearchVisitorID.Location = new Point(145, 15);
            txtSearchVisitorID.Name = "txtSearchVisitorID";
            txtSearchVisitorID.Size = new Size(207, 23);
            txtSearchVisitorID.TabIndex = 0;
            txtSearchVisitorID.TextChanged += txtSearchVisitorID_TextChanged;
            // 
            // lblVisitorTitle
            // 
            lblVisitorTitle.AutoSize = true;
            lblVisitorTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVisitorTitle.Location = new Point(278, 45);
            lblVisitorTitle.Name = "lblVisitorTitle";
            lblVisitorTitle.Size = new Size(308, 37);
            lblVisitorTitle.TabIndex = 3;
            lblVisitorTitle.Text = "VISITOR MANAGEMENT";
            lblVisitorTitle.Click += lblVisitorTitle_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(694, 126);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 42);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(501, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 42);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // VisitorID
            // 
            VisitorID.DataPropertyName = "VisitorID";
            VisitorID.HeaderText = "VisitorID";
            VisitorID.Name = "VisitorID";
            // 
            // StudentID
            // 
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "StudentID";
            StudentID.Name = "StudentID";
            // 
            // VisitorName
            // 
            VisitorName.DataPropertyName = "VisitorName";
            VisitorName.HeaderText = "Visitor Name";
            VisitorName.Name = "VisitorName";
            // 
            // VisitDate
            // 
            VisitDate.DataPropertyName = "VisitDate";
            VisitDate.HeaderText = "Visit Date";
            VisitDate.Name = "VisitDate";
            // 
            // Hostel
            // 
            Hostel.DataPropertyName = "Hostel";
            Hostel.HeaderText = "Hostel";
            Hostel.Name = "Hostel";
            // 
            // A_VisitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnRegisterVisitor);
            Controls.Add(pnlVisitorSearch);
            Controls.Add(lblVisitorTitle);
            Name = "A_VisitorForm";
            Size = new Size(968, 729);
            Load += A_VisitorForm_Load;
            pnlVisitorSearch.ResumeLayout(false);
            pnlVisitorSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisterVisitor;
        private Panel pnlVisitorSearch;
        private Button searchapplybtn;
        private DataGridView dataGridViewStudents;
        private ComboBox comboBox2;
        private Label cmbHostel;
        private Label lblSearchVisitorID;
        private TextBox txtSearchVisitorID;
        private Label lblVisitorTitle;
        private Label lblSearchStudentID;
        private TextBox txtSearchStudentID;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn VisitorID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn VisitorName;
        private DataGridViewTextBoxColumn VisitDate;
        private DataGridViewTextBoxColumn Hostel;
    }
}
