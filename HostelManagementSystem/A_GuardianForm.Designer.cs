namespace HostelManagementSystem
{
    partial class A_GuardianForm
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
            lblGuardianTitle = new Label();
            pnlGuardianSearch = new Panel();
            dataGridView1 = new DataGridView();
            btnapplysearch = new Button();
            txtPhone = new TextBox();
            txtStudentID = new TextBox();
            txtGaurdianName = new TextBox();
            lblGaurdianPhone = new Label();
            lblGaurdianName = new Label();
            lblStudentID = new Label();
            lblSearchGaurdian = new Label();
            txtGuardianSearch = new TextBox();
            btnAddGuardian = new Button();
            btnEditGuardian = new Button();
            btnDeleteGuardian = new Button();
            pnlGuardianSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblGuardianTitle
            // 
            lblGuardianTitle.AutoSize = true;
            lblGuardianTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGuardianTitle.Location = new Point(379, 0);
            lblGuardianTitle.Name = "lblGuardianTitle";
            lblGuardianTitle.Size = new Size(272, 30);
            lblGuardianTitle.TabIndex = 0;
            lblGuardianTitle.Text = "GUARDIAN MANAGEMENT";
            // 
            // pnlGuardianSearch
            // 
            pnlGuardianSearch.Controls.Add(dataGridView1);
            pnlGuardianSearch.Controls.Add(btnapplysearch);
            pnlGuardianSearch.Controls.Add(txtPhone);
            pnlGuardianSearch.Controls.Add(txtStudentID);
            pnlGuardianSearch.Controls.Add(txtGaurdianName);
            pnlGuardianSearch.Controls.Add(lblGaurdianPhone);
            pnlGuardianSearch.Controls.Add(lblGaurdianName);
            pnlGuardianSearch.Controls.Add(lblStudentID);
            pnlGuardianSearch.Controls.Add(lblSearchGaurdian);
            pnlGuardianSearch.Controls.Add(txtGuardianSearch);
            pnlGuardianSearch.Location = new Point(0, 155);
            pnlGuardianSearch.Name = "pnlGuardianSearch";
            pnlGuardianSearch.Size = new Size(933, 593);
            pnlGuardianSearch.TabIndex = 1;
            pnlGuardianSearch.Paint += pnlGuardianSearch_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(553, 21);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(164, 27);
            txtStudentID.TabIndex = 6;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // txtGaurdianName
            // 
            txtGaurdianName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGaurdianName.Location = new Point(143, 60);
            txtGaurdianName.Name = "txtGaurdianName";
            txtGaurdianName.Size = new Size(164, 27);
            txtGaurdianName.TabIndex = 5;
            txtGaurdianName.TextChanged += txtGaurdianName_TextChanged;
            // 
            // lblGaurdianPhone
            // 
            lblGaurdianPhone.AutoSize = true;
            lblGaurdianPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGaurdianPhone.Location = new Point(386, 70);
            lblGaurdianPhone.Name = "lblGaurdianPhone";
            lblGaurdianPhone.Size = new Size(161, 17);
            lblGaurdianPhone.TabIndex = 4;
            lblGaurdianPhone.Text = "Gaurdian Phone Number";
            lblGaurdianPhone.Click += lblGaurdianPhone_Click;
            // 
            // lblGaurdianName
            // 
            lblGaurdianName.AutoSize = true;
            lblGaurdianName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGaurdianName.Location = new Point(12, 65);
            lblGaurdianName.Name = "lblGaurdianName";
            lblGaurdianName.Size = new Size(104, 17);
            lblGaurdianName.TabIndex = 3;
            lblGaurdianName.Text = "Guardian Name";
            lblGaurdianName.Click += lblGaurdianName_Click;
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
            lblSearchGaurdian.Size = new Size(129, 15);
            lblSearchGaurdian.TabIndex = 1;
            lblSearchGaurdian.Text = "Search Guardian By Id";
            lblSearchGaurdian.Click += lblSearchGaurdian_Click;
            // 
            // txtGuardianSearch
            // 
            txtGuardianSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuardianSearch.Location = new Point(143, 15);
            txtGuardianSearch.Name = "txtGuardianSearch";
            txtGuardianSearch.Size = new Size(164, 27);
            txtGuardianSearch.TabIndex = 0;
            txtGuardianSearch.TextChanged += txtGuardianSearch_TextChanged;
            // 
            // btnAddGuardian
            // 
            btnAddGuardian.BackColor = SystemColors.GradientActiveCaption;
            btnAddGuardian.Location = new Point(40, 62);
            btnAddGuardian.Name = "btnAddGuardian";
            btnAddGuardian.Size = new Size(119, 57);
            btnAddGuardian.TabIndex = 2;
            btnAddGuardian.Text = "Register  Gaurdian";
            btnAddGuardian.UseVisualStyleBackColor = false;
            btnAddGuardian.Click += btnAddGuardian_Click;
            // 
            // btnEditGuardian
            // 
            btnEditGuardian.BackColor = SystemColors.GradientActiveCaption;
            btnEditGuardian.Location = new Point(265, 64);
            btnEditGuardian.Name = "btnEditGuardian";
            btnEditGuardian.Size = new Size(129, 55);
            btnEditGuardian.TabIndex = 3;
            btnEditGuardian.Text = "Edit Gaurdian";
            btnEditGuardian.UseVisualStyleBackColor = false;
            btnEditGuardian.Click += btnEditGuardian_Click;
            // 
            // btnDeleteGuardian
            // 
            btnDeleteGuardian.BackColor = SystemColors.GradientActiveCaption;
            btnDeleteGuardian.Location = new Point(488, 68);
            btnDeleteGuardian.Name = "btnDeleteGuardian";
            btnDeleteGuardian.Size = new Size(143, 51);
            btnDeleteGuardian.TabIndex = 4;
            btnDeleteGuardian.Text = "Delete Gaurdian";
            btnDeleteGuardian.UseVisualStyleBackColor = false;
            btnDeleteGuardian.Click += btnDeleteGuardian_Click;
            // 
            // A_GuardianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeleteGuardian);
            Controls.Add(btnEditGuardian);
            Controls.Add(btnAddGuardian);
            Controls.Add(pnlGuardianSearch);
            Controls.Add(lblGuardianTitle);
            Name = "A_GuardianForm";
            Size = new Size(921, 660);
            Load += A_GuardianForm_Load;
            pnlGuardianSearch.ResumeLayout(false);
            pnlGuardianSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGuardianTitle;
        private Panel pnlGuardianSearch;
        private Button btnapplysearch;
        private TextBox txtPhone;
        private TextBox txtStudentID;
        private TextBox txtGaurdianName;
        private Label lblGaurdianPhone;
        private Label lblGaurdianName;
        private Label lblStudentID;
        private Label lblSearchGaurdian;
        private TextBox txtGuardianSearch;
        private DataGridView dataGridView1;
        private Button btnAddGuardian;
        private Button btnEditGuardian;
        private Button btnDeleteGuardian;
    }
}
