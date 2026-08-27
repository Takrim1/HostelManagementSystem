namespace HostelManagementSystem
{
    partial class A_Dashboard
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
            pnlTotalRevenue = new Panel();
            lblTotalRevenue = new Label();
            lblTotalRevenuetitle = new Label();
            pnlPendingFees = new Panel();
            lblPendingFees = new Label();
            lblPendingFeestitle = new Label();
            pnlTotalStaff = new Panel();
            lblTotalStaff = new Label();
            lblTotalStafftitle = new Label();
            pnlTotalStudents = new Panel();
            lblTotalStudents = new Label();
            lblTotalStudentsTitle = new Label();
            pnlTotalRevenue.SuspendLayout();
            pnlPendingFees.SuspendLayout();
            pnlTotalStaff.SuspendLayout();
            pnlTotalStudents.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTotalRevenue
            // 
            pnlTotalRevenue.Controls.Add(lblTotalRevenue);
            pnlTotalRevenue.Controls.Add(lblTotalRevenuetitle);
            pnlTotalRevenue.Location = new Point(462, 258);
            pnlTotalRevenue.Name = "pnlTotalRevenue";
            pnlTotalRevenue.Size = new Size(171, 74);
            pnlTotalRevenue.TabIndex = 9;
            pnlTotalRevenue.Paint += pnlTotalRevenue_Paint;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(23, 44);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(10, 15);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = ":";
            lblTotalRevenue.Click += lblTotalRevenue_Click;
            // 
            // lblTotalRevenuetitle
            // 
            lblTotalRevenuetitle.AutoSize = true;
            lblTotalRevenuetitle.Location = new Point(23, 7);
            lblTotalRevenuetitle.Name = "lblTotalRevenuetitle";
            lblTotalRevenuetitle.Size = new Size(93, 15);
            lblTotalRevenuetitle.TabIndex = 0;
            lblTotalRevenuetitle.Text = "TOTAL REVENUE";
            lblTotalRevenuetitle.Click += lblTotalRevenuetitle_Click;
            // 
            // pnlPendingFees
            // 
            pnlPendingFees.Controls.Add(lblPendingFees);
            pnlPendingFees.Controls.Add(lblPendingFeestitle);
            pnlPendingFees.Location = new Point(225, 258);
            pnlPendingFees.Name = "pnlPendingFees";
            pnlPendingFees.Size = new Size(171, 74);
            pnlPendingFees.TabIndex = 8;
            pnlPendingFees.Paint += pnlPendingFees_Paint;
            // 
            // lblPendingFees
            // 
            lblPendingFees.AutoSize = true;
            lblPendingFees.Location = new Point(23, 44);
            lblPendingFees.Name = "lblPendingFees";
            lblPendingFees.Size = new Size(10, 15);
            lblPendingFees.TabIndex = 1;
            lblPendingFees.Text = ":";
            lblPendingFees.Click += lblPendingFees_Click;
            // 
            // lblPendingFeestitle
            // 
            lblPendingFeestitle.AutoSize = true;
            lblPendingFeestitle.Location = new Point(23, 7);
            lblPendingFeestitle.Name = "lblPendingFeestitle";
            lblPendingFeestitle.Size = new Size(84, 15);
            lblPendingFeestitle.TabIndex = 0;
            lblPendingFeestitle.Text = "PENDING FEES";
            lblPendingFeestitle.Click += lblPendingFeestitle_Click;
            // 
            // pnlTotalStaff
            // 
            pnlTotalStaff.Controls.Add(lblTotalStaff);
            pnlTotalStaff.Controls.Add(lblTotalStafftitle);
            pnlTotalStaff.Location = new Point(462, 37);
            pnlTotalStaff.Name = "pnlTotalStaff";
            pnlTotalStaff.Size = new Size(171, 74);
            pnlTotalStaff.TabIndex = 7;
            pnlTotalStaff.Paint += pnlTotalStaff_Paint;
            // 
            // lblTotalStaff
            // 
            lblTotalStaff.AutoSize = true;
            lblTotalStaff.Location = new Point(23, 44);
            lblTotalStaff.Name = "lblTotalStaff";
            lblTotalStaff.Size = new Size(10, 15);
            lblTotalStaff.TabIndex = 1;
            lblTotalStaff.Text = ":";
            lblTotalStaff.Click += lblTotalStaff_Click;
            // 
            // lblTotalStafftitle
            // 
            lblTotalStafftitle.AutoSize = true;
            lblTotalStafftitle.Location = new Point(23, 7);
            lblTotalStafftitle.Name = "lblTotalStafftitle";
            lblTotalStafftitle.Size = new Size(76, 15);
            lblTotalStafftitle.TabIndex = 0;
            lblTotalStafftitle.Text = "TOTAL STAFF";
            lblTotalStafftitle.Click += lblTotalStafftitle_Click;
            // 
            // pnlTotalStudents
            // 
            pnlTotalStudents.Controls.Add(lblTotalStudents);
            pnlTotalStudents.Controls.Add(lblTotalStudentsTitle);
            pnlTotalStudents.Location = new Point(204, 37);
            pnlTotalStudents.Name = "pnlTotalStudents";
            pnlTotalStudents.Size = new Size(159, 74);
            pnlTotalStudents.TabIndex = 6;
            pnlTotalStudents.Paint += pnlTotalStudents_Paint;
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Location = new Point(12, 41);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(10, 15);
            lblTotalStudents.TabIndex = 1;
            lblTotalStudents.Text = ":";
            lblTotalStudents.Click += lblTotalStudents_Click;
            // 
            // lblTotalStudentsTitle
            // 
            lblTotalStudentsTitle.AutoSize = true;
            lblTotalStudentsTitle.Location = new Point(12, 18);
            lblTotalStudentsTitle.Name = "lblTotalStudentsTitle";
            lblTotalStudentsTitle.Size = new Size(101, 15);
            lblTotalStudentsTitle.TabIndex = 0;
            lblTotalStudentsTitle.Text = "TOTAL STUDENTS";
            lblTotalStudentsTitle.Click += lblTotalStudentsTitle_Click;
            // 
            // A_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlTotalRevenue);
            Controls.Add(pnlPendingFees);
            Controls.Add(pnlTotalStaff);
            Controls.Add(pnlTotalStudents);
            Name = "A_Dashboard";
            Size = new Size(861, 520);
            Load += A_Dashboard_Load;
            pnlTotalRevenue.ResumeLayout(false);
            pnlTotalRevenue.PerformLayout();
            pnlPendingFees.ResumeLayout(false);
            pnlPendingFees.PerformLayout();
            pnlTotalStaff.ResumeLayout(false);
            pnlTotalStaff.PerformLayout();
            pnlTotalStudents.ResumeLayout(false);
            pnlTotalStudents.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTotalRevenue;
        private Label lblTotalRevenue;
        private Label lblTotalRevenuetitle;
        private Panel pnlPendingFees;
        private Label lblPendingFees;
        private Label lblPendingFeestitle;
        private Panel pnlTotalStaff;
        private Label lblTotalStaff;
        private Label lblTotalStafftitle;
        private Panel pnlTotalStudents;
        private Label lblTotalStudents;
        private Label lblTotalStudentsTitle;
    }
}
