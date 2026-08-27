namespace HostelManagementSystem
{
    partial class A_MealRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed, otherwise false.</param>
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
            cmbmealtype = new ComboBox();
            lblprice = new Label();
            lblmealbookdate = new Label();
            lblmenu = new Label();
            lblmealtype = new Label();
            lblStudentID = new Label();
            txtStudentID = new TextBox();
            txtStaffID = new TextBox();
            lblStaffID = new Label();
            cmbmenu = new ComboBox();
            dtpmealbook = new DateTimePicker();
            txtPrice = new TextBox();
            lblmealbookingTitle = new Label();
            btnClear = new Button();
            btnSavemeal = new Button();
            SuspendLayout();
            // 
            // cmbmealtype
            // 
            cmbmealtype.FormattingEnabled = true;
            cmbmealtype.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner" });
            cmbmealtype.Location = new Point(355, 155);
            cmbmealtype.Name = "cmbmealtype";
            cmbmealtype.Size = new Size(169, 23);
            cmbmealtype.TabIndex = 1;
            cmbmealtype.SelectedIndexChanged += cmbmealtype_SelectedIndexChanged;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Location = new Point(237, 283);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(33, 15);
            lblprice.TabIndex = 8;
            lblprice.Text = "Price";
            lblprice.Click += lblprice_Click;
            // 
            // lblmealbookdate
            // 
            lblmealbookdate.AutoSize = true;
            lblmealbookdate.Location = new Point(219, 245);
            lblmealbookdate.Name = "lblmealbookdate";
            lblmealbookdate.Size = new Size(107, 15);
            lblmealbookdate.TabIndex = 6;
            lblmealbookdate.Text = "Meal Booking Date";
            lblmealbookdate.Click += lblmealbookdate_Click;
            // 
            // lblmenu
            // 
            lblmenu.AutoSize = true;
            lblmenu.Location = new Point(245, 201);
            lblmenu.Name = "lblmenu";
            lblmenu.Size = new Size(38, 15);
            lblmenu.TabIndex = 4;
            lblmenu.Text = "Menu";
            lblmenu.Click += lblmenu_Click;
            // 
            // lblmealtype
            // 
            lblmealtype.AutoSize = true;
            lblmealtype.Location = new Point(245, 155);
            lblmealtype.Name = "lblmealtype";
            lblmealtype.Size = new Size(61, 15);
            lblmealtype.TabIndex = 2;
            lblmealtype.Text = "Meal Type";
            lblmealtype.Click += lblmealtype_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(272, 111);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(62, 15);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(380, 107);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(163, 23);
            txtStudentID.TabIndex = 0;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(374, 65);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(169, 23);
            txtStaffID.TabIndex = 0;
            txtStaffID.TextChanged += txtStaffID_TextChanged;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Location = new Point(272, 73);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(44, 15);
            lblStaffID.TabIndex = 0;
            lblStaffID.Text = "Staff Id";
            lblStaffID.Click += lblStaffID_Click;
            // 
            // cmbmenu
            // 
            cmbmenu.FormattingEnabled = true;
            cmbmenu.Items.AddRange(new object[] { "Regular Meal", "Special Meal", "Vegetarian Meal" });
            cmbmenu.Location = new Point(355, 193);
            cmbmenu.Name = "cmbmenu";
            cmbmenu.Size = new Size(169, 23);
            cmbmenu.TabIndex = 3;
            cmbmenu.SelectedIndexChanged += cmbmenu_SelectedIndexChanged;
            // 
            // dtpmealbook
            // 
            dtpmealbook.Location = new Point(364, 240);
            dtpmealbook.Name = "dtpmealbook";
            dtpmealbook.Size = new Size(200, 23);
            dtpmealbook.TabIndex = 5;
            dtpmealbook.ValueChanged += dtpmealbook_ValueChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(355, 280);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(169, 23);
            txtPrice.TabIndex = 7;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // lblmealbookingTitle
            // 
            lblmealbookingTitle.AutoSize = true;
            lblmealbookingTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblmealbookingTitle.Location = new Point(263, 9);
            lblmealbookingTitle.Name = "lblmealbookingTitle";
            lblmealbookingTitle.Size = new Size(144, 30);
            lblmealbookingTitle.TabIndex = 52;
            lblmealbookingTitle.Text = "Meal Booking";
            lblmealbookingTitle.Click += lblmealbookingTitle_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(400, 354);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 43);
            btnClear.TabIndex = 55;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSavemeal
            // 
            btnSavemeal.Location = new Point(219, 354);
            btnSavemeal.Name = "btnSavemeal";
            btnSavemeal.Size = new Size(153, 45);
            btnSavemeal.TabIndex = 54;
            btnSavemeal.Text = "Save Meal";
            btnSavemeal.UseVisualStyleBackColor = true;
            btnSavemeal.Click += btnSavemeal_Click;
            // 
            // A_MealRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "A_MealRegistrationForm";
            Text = "A_MealRegistrationForm";
            Load += A_MealRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmealtype;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblmealbookdate;
        private System.Windows.Forms.Label lblmenu;
        private System.Windows.Forms.Label lblmealtype;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.ComboBox cmbmenu;
        private System.Windows.Forms.DateTimePicker dtpmealbook;
        private System.Windows.Forms.TextBox txtPrice;
        private Label lblmealbookingTitle;
        private Button btnClear;
        private Button btnSavemeal;
    }
}