namespace HostelManagementSystem
{
    partial class A_BuildingFloorForm
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
            buildingsearchpnl = new Panel();
            dataGridView2 = new DataGridView();
            Serialnumber = new DataGridViewTextBoxColumn();
            FloorNumber = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            BedNumber = new DataGridViewTextBoxColumn();
            BedType = new DataGridViewTextBoxColumn();
            NameStudent = new DataGridViewTextBoxColumn();
            idstudent = new DataGridViewTextBoxColumn();
            btnsearch = new Button();
            txtidstudent = new TextBox();
            txtbednumber = new TextBox();
            lblbednumber = new Label();
            lblidstudent = new Label();
            lblroomnumber = new Label();
            txtroomid = new TextBox();
            btnDeleteroom = new Button();
            btnEditroom = new Button();
            btnregisterroom = new Button();
            lblGuardianTitle = new Label();
            buildingsearchpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // buildingsearchpnl
            // 
            buildingsearchpnl.Controls.Add(dataGridView2);
            buildingsearchpnl.Controls.Add(btnsearch);
            buildingsearchpnl.Controls.Add(txtidstudent);
            buildingsearchpnl.Controls.Add(txtbednumber);
            buildingsearchpnl.Controls.Add(lblbednumber);
            buildingsearchpnl.Controls.Add(lblidstudent);
            buildingsearchpnl.Controls.Add(lblroomnumber);
            buildingsearchpnl.Controls.Add(txtroomid);
            buildingsearchpnl.Location = new Point(3, 190);
            buildingsearchpnl.Name = "buildingsearchpnl";
            buildingsearchpnl.Size = new Size(933, 305);
            buildingsearchpnl.TabIndex = 4;
            buildingsearchpnl.Paint += buildingsearchpnl_Paint;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Serialnumber, FloorNumber, RoomNumber, RoomType, Status, BedNumber, BedType, NameStudent, idstudent });
            dataGridView2.Location = new Point(0, 98);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(930, 380);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Serialnumber
            // 
            Serialnumber.DataPropertyName = "Serialnumber";
            Serialnumber.HeaderText = "Serial Number";
            Serialnumber.Name = "Serialnumber";
            // 
            // FloorNumber
            // 
            FloorNumber.DataPropertyName = "FloorNumber";
            FloorNumber.HeaderText = "Floor Number";
            FloorNumber.Name = "FloorNumber";
            // 
            // RoomNumber
            // 
            RoomNumber.DataPropertyName = "RoomNumber";
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.Name = "RoomNumber";
            // 
            // RoomType
            // 
            RoomType.DataPropertyName = "RoomType";
            RoomType.HeaderText = "Room Type";
            RoomType.Name = "RoomType";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // BedNumber
            // 
            BedNumber.DataPropertyName = "BedNumber";
            BedNumber.HeaderText = "Bed Number";
            BedNumber.Name = "BedNumber";
            // 
            // BedType
            // 
            BedType.DataPropertyName = "BedType";
            BedType.HeaderText = "Bed Type";
            BedType.Name = "BedType";
            // 
            // NameStudent
            // 
            NameStudent.DataPropertyName = "NameStudent";
            NameStudent.HeaderText = "Name Student";
            NameStudent.Name = "NameStudent";
            // 
            // idstudent
            // 
            idstudent.DataPropertyName = "idstudent";
            idstudent.HeaderText = "Student ID";
            idstudent.Name = "idstudent";
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.Gainsboro;
            btnsearch.Location = new Point(769, 29);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(106, 53);
            btnsearch.TabIndex = 8;
            btnsearch.Text = "Apply Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtidstudent
            // 
            txtidstudent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtidstudent.Location = new Point(505, 15);
            txtidstudent.Name = "txtidstudent";
            txtidstudent.Size = new Size(164, 27);
            txtidstudent.TabIndex = 6;
            txtidstudent.TextChanged += txtidstudent_TextChanged;
            // 
            // txtbednumber
            // 
            txtbednumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbednumber.Location = new Point(143, 60);
            txtbednumber.Name = "txtbednumber";
            txtbednumber.Size = new Size(164, 27);
            txtbednumber.TabIndex = 5;
            txtbednumber.TextChanged += txtbednumber_TextChanged;
            // 
            // lblbednumber
            // 
            lblbednumber.AutoSize = true;
            lblbednumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbednumber.Location = new Point(12, 65);
            lblbednumber.Name = "lblbednumber";
            lblbednumber.Size = new Size(85, 17);
            lblbednumber.TabIndex = 3;
            lblbednumber.Text = "Bed Number";
            lblbednumber.Click += lblbednumber_Click;
            // 
            // lblidstudent
            // 
            lblidstudent.AutoSize = true;
            lblidstudent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblidstudent.Location = new Point(400, 19);
            lblidstudent.Name = "lblidstudent";
            lblidstudent.Size = new Size(72, 17);
            lblidstudent.TabIndex = 2;
            lblidstudent.Text = "Student Id";
            lblidstudent.Click += lblidstudent_Click;
            // 
            // lblroomnumber
            // 
            lblroomnumber.AutoSize = true;
            lblroomnumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblroomnumber.Location = new Point(12, 21);
            lblroomnumber.Name = "lblroomnumber";
            lblroomnumber.Size = new Size(137, 15);
            lblroomnumber.TabIndex = 1;
            lblroomnumber.Text = "Search Rooom Number";
            lblroomnumber.Click += lblroomnumber_Click;
            // 
            // txtroomid
            // 
            txtroomid.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtroomid.Location = new Point(155, 15);
            txtroomid.Name = "txtroomid";
            txtroomid.Size = new Size(164, 27);
            txtroomid.TabIndex = 0;
            txtroomid.TextChanged += txtroomid_TextChanged;
            // 
            // btnDeleteroom
            // 
            btnDeleteroom.BackColor = SystemColors.GradientActiveCaption;
            btnDeleteroom.Location = new Point(356, 112);
            btnDeleteroom.Name = "btnDeleteroom";
            btnDeleteroom.Size = new Size(143, 51);
            btnDeleteroom.TabIndex = 11;
            btnDeleteroom.Text = "Delete Room";
            btnDeleteroom.UseVisualStyleBackColor = false;
            btnDeleteroom.Click += btnDeleteroom_Click;
            // 
            // btnEditroom
            // 
            btnEditroom.BackColor = SystemColors.GradientActiveCaption;
            btnEditroom.Location = new Point(610, 99);
            btnEditroom.Name = "btnEditroom";
            btnEditroom.Size = new Size(129, 55);
            btnEditroom.TabIndex = 10;
            btnEditroom.Text = "Edit Room";
            btnEditroom.UseVisualStyleBackColor = false;
            btnEditroom.Click += btnEditroom_Click;
            // 
            // btnregisterroom
            // 
            btnregisterroom.BackColor = SystemColors.GradientActiveCaption;
            btnregisterroom.Location = new Point(78, 109);
            btnregisterroom.Name = "btnregisterroom";
            btnregisterroom.Size = new Size(119, 57);
            btnregisterroom.TabIndex = 9;
            btnregisterroom.Text = "Register Room";
            btnregisterroom.UseVisualStyleBackColor = false;
            btnregisterroom.Click += btnregisterroom_Click;
            // 
            // lblGuardianTitle
            // 
            lblGuardianTitle.AutoSize = true;
            lblGuardianTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGuardianTitle.Location = new Point(342, 16);
            lblGuardianTitle.Name = "lblGuardianTitle";
            lblGuardianTitle.Size = new Size(147, 30);
            lblGuardianTitle.TabIndex = 15;
            lblGuardianTitle.Text = "Building Floor";
            lblGuardianTitle.Click += lblGuardianTitle_Click;
            // 
            // A_BuildingFloorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblGuardianTitle);
            Controls.Add(btnDeleteroom);
            Controls.Add(btnEditroom);
            Controls.Add(btnregisterroom);
            Controls.Add(buildingsearchpnl);
            Name = "A_BuildingFloorForm";
            Size = new Size(972, 999);
            Load += A_BuildingFloorForm_Load;
            buildingsearchpnl.ResumeLayout(false);
            buildingsearchpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel buildingsearchpnl;
        private Button btnsearch;
        private TextBox txtidstudent;
        private TextBox txtbednumber;
        private Label lblbednumber;
        private Label lblidstudent;
        private Label lblroomnumber;
        private TextBox txtroomid;
        private Button btnDeleteroom;
        private Button btnEditroom;
        private Button btnregisterroom;
        private Label lblGuardianTitle;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Serialnumber;
        private DataGridViewTextBoxColumn FloorNumber;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn BedNumber;
        private DataGridViewTextBoxColumn BedType;
        private DataGridViewTextBoxColumn NameStudent;
        private DataGridViewTextBoxColumn idstudent;
    }
}
