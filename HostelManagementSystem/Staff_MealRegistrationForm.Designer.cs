namespace HostelManagementSystem
{
    partial class Staff_MealRegistrationForm
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
            btnClear = new Button();
            btnSavemeal = new Button();
            lblmealbookingTitle = new Label();
            txtPrice = new TextBox();
            dtpmealbook = new DateTimePicker();
            cmbmenu = new ComboBox();
            cmbmealtype = new ComboBox();
            lblprice = new Label();
            lblmealbookdate = new Label();
            lblmenu = new Label();
            lblmealtype = new Label();
            lblStudentID = new Label();
            txtStudentID = new TextBox();
            txtStaffID = new TextBox();
            lblStaffID = new Label();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(439, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 43);
            btnClear.TabIndex = 70;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSavemeal
            // 
            btnSavemeal.Location = new Point(258, 375);
            btnSavemeal.Name = "btnSavemeal";
            btnSavemeal.Size = new Size(153, 45);
            btnSavemeal.TabIndex = 69;
            btnSavemeal.Text = "Save Meal";
            btnSavemeal.UseVisualStyleBackColor = true;
            // 
            // lblmealbookingTitle
            // 
            lblmealbookingTitle.AutoSize = true;
            lblmealbookingTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblmealbookingTitle.Location = new Point(302, 30);
            lblmealbookingTitle.Name = "lblmealbookingTitle";
            lblmealbookingTitle.Size = new Size(144, 30);
            lblmealbookingTitle.TabIndex = 68;
            lblmealbookingTitle.Text = "Meal Booking";
            lblmealbookingTitle.Click += lblmealbookingTitle_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(394, 301);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(169, 23);
            txtPrice.TabIndex = 66;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // dtpmealbook
            // 
            dtpmealbook.Location = new Point(403, 261);
            dtpmealbook.Name = "dtpmealbook";
            dtpmealbook.Size = new Size(200, 23);
            dtpmealbook.TabIndex = 64;
            dtpmealbook.ValueChanged += dtpmealbook_ValueChanged;
            // 
            // cmbmenu
            // 
            cmbmenu.FormattingEnabled = true;
            cmbmenu.Items.AddRange(new object[] { "Regular Meal", "Special Meal", "Vegetarian Meal" });
            cmbmenu.Location = new Point(394, 214);
            cmbmenu.Name = "cmbmenu";
            cmbmenu.Size = new Size(169, 23);
            cmbmenu.TabIndex = 62;
            cmbmenu.SelectedIndexChanged += cmbmenu_SelectedIndexChanged;
            // 
            // cmbmealtype
            // 
            cmbmealtype.FormattingEnabled = true;
            cmbmealtype.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner" });
            cmbmealtype.Location = new Point(394, 176);
            cmbmealtype.Name = "cmbmealtype";
            cmbmealtype.Size = new Size(169, 23);
            cmbmealtype.TabIndex = 60;
            cmbmealtype.SelectedIndexChanged += cmbmealtype_SelectedIndexChanged;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Location = new Point(276, 304);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(33, 15);
            lblprice.TabIndex = 67;
            lblprice.Text = "Price";
            lblprice.Click += lblprice_Click;
            // 
            // lblmealbookdate
            // 
            lblmealbookdate.AutoSize = true;
            lblmealbookdate.Location = new Point(258, 266);
            lblmealbookdate.Name = "lblmealbookdate";
            lblmealbookdate.Size = new Size(107, 15);
            lblmealbookdate.TabIndex = 65;
            lblmealbookdate.Text = "Meal Booking Date";
            lblmealbookdate.Click += lblmealbookdate_Click;
            // 
            // lblmenu
            // 
            lblmenu.AutoSize = true;
            lblmenu.Location = new Point(284, 222);
            lblmenu.Name = "lblmenu";
            lblmenu.Size = new Size(38, 15);
            lblmenu.TabIndex = 63;
            lblmenu.Text = "Menu";
            lblmenu.Click += lblmenu_Click;
            // 
            // lblmealtype
            // 
            lblmealtype.AutoSize = true;
            lblmealtype.Location = new Point(284, 176);
            lblmealtype.Name = "lblmealtype";
            lblmealtype.Size = new Size(61, 15);
            lblmealtype.TabIndex = 61;
            lblmealtype.Text = "Meal Type";
            lblmealtype.Click += lblmealtype_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(311, 132);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(62, 15);
            lblStudentID.TabIndex = 56;
            lblStudentID.Text = "Student ID";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(419, 128);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(163, 23);
            txtStudentID.TabIndex = 57;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(413, 86);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(169, 23);
            txtStaffID.TabIndex = 58;
            txtStaffID.TextChanged += txtStaffID_TextChanged;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Location = new Point(311, 94);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(44, 15);
            lblStaffID.TabIndex = 59;
            lblStaffID.Text = "Staff Id";
            lblStaffID.Click += lblStaffID_Click;
            // 
            // Staff_MealRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 450);
            Controls.Add(btnClear);
            Controls.Add(btnSavemeal);
            Controls.Add(lblmealbookingTitle);
            Controls.Add(txtPrice);
            Controls.Add(dtpmealbook);
            Controls.Add(cmbmenu);
            Controls.Add(cmbmealtype);
            Controls.Add(lblprice);
            Controls.Add(lblmealbookdate);
            Controls.Add(lblmenu);
            Controls.Add(lblmealtype);
            Controls.Add(lblStudentID);
            Controls.Add(txtStudentID);
            Controls.Add(txtStaffID);
            Controls.Add(lblStaffID);
            Name = "Staff_MealRegistrationForm";
            Text = "Staff_MealRegistrationForm";
            Load += Staff_MealRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnSavemeal;
        private Label lblmealbookingTitle;
        private TextBox txtPrice;
        private DateTimePicker dtpmealbook;
        private ComboBox cmbmenu;
        private ComboBox cmbmealtype;
        private Label lblprice;
        private Label lblmealbookdate;
        private Label lblmenu;
        private Label lblmealtype;
        private Label lblStudentID;
        private TextBox txtStudentID;
        private TextBox txtStaffID;
        private Label lblStaffID;
    }
}