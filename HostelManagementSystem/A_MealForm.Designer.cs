namespace HostelManagementSystem
{
    partial class A_MealForm
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
            btnDeleteMealBooking = new Button();
            btneditmealbooking = new Button();
            btnmealbooking = new Button();
            pnlMealSearch = new Panel();
            dataGridView1 = new DataGridView();
            btnapplysearch = new Button();
            txtStaffID = new TextBox();
            lblStaffID = new Label();
            lblSearchStudentid = new Label();
            txtStudentMealSearch = new TextBox();
            lblMealbookingTitle = new Label();
            pnlMealSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteMealBooking
            // 
            btnDeleteMealBooking.BackColor = SystemColors.GradientActiveCaption;
            btnDeleteMealBooking.Location = new Point(713, 114);
            btnDeleteMealBooking.Name = "btnDeleteMealBooking";
            btnDeleteMealBooking.Size = new Size(143, 51);
            btnDeleteMealBooking.TabIndex = 8;
            btnDeleteMealBooking.Text = "Delete Meal Booking";
            btnDeleteMealBooking.UseVisualStyleBackColor = false;
            btnDeleteMealBooking.Click += btnDeleteMealBooking_Click;
            // 
            // btneditmealbooking
            // 
            btneditmealbooking.BackColor = SystemColors.GradientActiveCaption;
            btneditmealbooking.Location = new Point(529, 114);
            btneditmealbooking.Name = "btneditmealbooking";
            btneditmealbooking.Size = new Size(129, 55);
            btneditmealbooking.TabIndex = 7;
            btneditmealbooking.Text = "Edit Meal Booking";
            btneditmealbooking.UseVisualStyleBackColor = false;
            btneditmealbooking.Click += btneditmealbooking_Click;
            // 
            // btnmealbooking
            // 
            btnmealbooking.BackColor = SystemColors.GradientActiveCaption;
            btnmealbooking.Location = new Point(325, 114);
            btnmealbooking.Name = "btnmealbooking";
            btnmealbooking.Size = new Size(119, 57);
            btnmealbooking.TabIndex = 6;
            btnmealbooking.Text = "Meal Booking";
            btnmealbooking.UseVisualStyleBackColor = false;
            btnmealbooking.Click += btnmealbooking_Click;
            // 
            // pnlMealSearch
            // 
            pnlMealSearch.Controls.Add(dataGridView1);
            pnlMealSearch.Controls.Add(btnapplysearch);
            pnlMealSearch.Controls.Add(txtStaffID);
            pnlMealSearch.Controls.Add(lblStaffID);
            pnlMealSearch.Controls.Add(lblSearchStudentid);
            pnlMealSearch.Controls.Add(txtStudentMealSearch);
            pnlMealSearch.Location = new Point(12, 198);
            pnlMealSearch.Name = "pnlMealSearch";
            pnlMealSearch.Size = new Size(933, 503);
            pnlMealSearch.TabIndex = 5;
            pnlMealSearch.Paint += pnlMealSearch_Paint;
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
            // txtStaffID
            // 
            txtStaffID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffID.Location = new Point(507, 11);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(164, 27);
            txtStaffID.TabIndex = 6;
            txtStaffID.TextChanged += txtStaffID_TextChanged;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffID.Location = new Point(386, 21);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(55, 17);
            lblStaffID.TabIndex = 2;
            lblStaffID.Text = "Staff ID";
            lblStaffID.Click += lblStaffID_Click;
            // 
            // lblSearchStudentid
            // 
            lblSearchStudentid.AutoSize = true;
            lblSearchStudentid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchStudentid.Location = new Point(12, 21);
            lblSearchStudentid.Name = "lblSearchStudentid";
            lblSearchStudentid.Size = new Size(157, 15);
            lblSearchStudentid.TabIndex = 1;
            lblSearchStudentid.Text = "Search Student Meal  By Id";
            lblSearchStudentid.Click += lblSearchStudentid_Click;
            // 
            // txtStudentMealSearch
            // 
            txtStudentMealSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentMealSearch.Location = new Point(175, 15);
            txtStudentMealSearch.Name = "txtStudentMealSearch";
            txtStudentMealSearch.Size = new Size(164, 27);
            txtStudentMealSearch.TabIndex = 0;
            txtStudentMealSearch.TextChanged += txtStudentMealSearch_TextChanged;
            // 
            // lblMealbookingTitle
            // 
            lblMealbookingTitle.AutoSize = true;
            lblMealbookingTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMealbookingTitle.Location = new Point(348, 25);
            lblMealbookingTitle.Name = "lblMealbookingTitle";
            lblMealbookingTitle.Size = new Size(144, 30);
            lblMealbookingTitle.TabIndex = 9;
            lblMealbookingTitle.Text = "Meal Booking";
            lblMealbookingTitle.Click += lblMealbookingTitle_Click;
            // 
            // A_MealForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMealbookingTitle);
            Controls.Add(btnDeleteMealBooking);
            Controls.Add(btneditmealbooking);
            Controls.Add(btnmealbooking);
            Controls.Add(pnlMealSearch);
            Name = "A_MealForm";
            Size = new Size(1068, 661);
            Load += A_MealForm_Load;
            pnlMealSearch.ResumeLayout(false);
            pnlMealSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteMealBooking;
        private Button btneditmealbooking;
        private Button btnmealbooking;
        private Panel pnlMealSearch;
        private DataGridView dataGridView1;
        private Button btnapplysearch;
        private TextBox txtStaffID;
        private Label lblStaffID;
        private Label lblSearchStudentid;
        private TextBox txtStudentMealSearch;
        private Label lblMealbookingTitle;
    }
}
