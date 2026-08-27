namespace HostelManagementSystem
{
    partial class AdminDashboardForm
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
            adminpnlSidebar = new Panel();
            btnnotice = new Button();
            btnlogout = new Button();
            btnGaurdian = new Button();
            btnComplaint = new Button();
            btnVisitor = new Button();
            btnMeal = new Button();
            btnStaffAttendance = new Button();
            btnPayment = new Button();
            btnRoom = new Button();
            btnStaff = new Button();
            Studentbtn = new Button();
            dashboardbtn = new Button();
            DashBoardpnlContent = new Panel();
            adminpnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // adminpnlSidebar
            // 
            adminpnlSidebar.BackColor = SystemColors.InactiveCaption;
            adminpnlSidebar.Controls.Add(btnnotice);
            adminpnlSidebar.Controls.Add(btnlogout);
            adminpnlSidebar.Controls.Add(btnGaurdian);
            adminpnlSidebar.Controls.Add(btnComplaint);
            adminpnlSidebar.Controls.Add(btnVisitor);
            adminpnlSidebar.Controls.Add(btnMeal);
            adminpnlSidebar.Controls.Add(btnStaffAttendance);
            adminpnlSidebar.Controls.Add(btnPayment);
            adminpnlSidebar.Controls.Add(btnRoom);
            adminpnlSidebar.Controls.Add(btnStaff);
            adminpnlSidebar.Controls.Add(Studentbtn);
            adminpnlSidebar.Controls.Add(dashboardbtn);
            adminpnlSidebar.Dock = DockStyle.Left;
            adminpnlSidebar.Location = new Point(0, 0);
            adminpnlSidebar.Name = "adminpnlSidebar";
            adminpnlSidebar.Size = new Size(200, 680);
            adminpnlSidebar.TabIndex = 0;
            adminpnlSidebar.Paint += adminpnlSidebar_Paint;
            // 
            // btnnotice
            // 
            btnnotice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnotice.Location = new Point(12, 451);
            btnnotice.Name = "btnnotice";
            btnnotice.Size = new Size(163, 33);
            btnnotice.TabIndex = 16;
            btnnotice.Text = "Notice";
            btnnotice.UseVisualStyleBackColor = true;
            btnnotice.Click += btnnotice_Click;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(12, 525);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(163, 38);
            btnlogout.TabIndex = 15;
            btnlogout.Text = "Log out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnGaurdian
            // 
            btnGaurdian.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGaurdian.Location = new Point(12, 83);
            btnGaurdian.Name = "btnGaurdian";
            btnGaurdian.Size = new Size(163, 39);
            btnGaurdian.TabIndex = 14;
            btnGaurdian.Text = "Gaurdian info";
            btnGaurdian.UseVisualStyleBackColor = true;
            btnGaurdian.Click += btnGaurdian_Click;
            // 
            // btnComplaint
            // 
            btnComplaint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComplaint.Location = new Point(12, 396);
            btnComplaint.Name = "btnComplaint";
            btnComplaint.Size = new Size(163, 33);
            btnComplaint.TabIndex = 11;
            btnComplaint.Text = "Complaint";
            btnComplaint.UseVisualStyleBackColor = true;
            btnComplaint.Click += btnComplaint_Click;
            // 
            // btnVisitor
            // 
            btnVisitor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVisitor.Location = new Point(12, 301);
            btnVisitor.Name = "btnVisitor";
            btnVisitor.Size = new Size(163, 31);
            btnVisitor.TabIndex = 10;
            btnVisitor.Text = "Visitor";
            btnVisitor.UseVisualStyleBackColor = true;
            btnVisitor.Click += Visitor_Click;
            // 
            // btnMeal
            // 
            btnMeal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMeal.Location = new Point(12, 352);
            btnMeal.Name = "btnMeal";
            btnMeal.Size = new Size(163, 38);
            btnMeal.TabIndex = 9;
            btnMeal.Text = "Meal";
            btnMeal.UseVisualStyleBackColor = true;
            btnMeal.Click += btnMeal_Click;
            // 
            // btnStaffAttendance
            // 
            btnStaffAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffAttendance.Location = new Point(12, 173);
            btnStaffAttendance.Name = "btnStaffAttendance";
            btnStaffAttendance.Size = new Size(163, 37);
            btnStaffAttendance.TabIndex = 8;
            btnStaffAttendance.Text = "Staff Attendance";
            btnStaffAttendance.UseVisualStyleBackColor = true;
            btnStaffAttendance.Click += btnStaffAttendance_Click;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(12, 260);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(163, 35);
            btnPayment.TabIndex = 7;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnRoom
            // 
            btnRoom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoom.Location = new Point(12, 217);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(163, 37);
            btnRoom.TabIndex = 4;
            btnRoom.Text = "Room Allocation";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnroom_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaff.Location = new Point(12, 128);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(163, 39);
            btnStaff.TabIndex = 2;
            btnStaff.Text = "Staff ";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // Studentbtn
            // 
            Studentbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Studentbtn.Location = new Point(12, 42);
            Studentbtn.Name = "Studentbtn";
            Studentbtn.Size = new Size(163, 35);
            Studentbtn.TabIndex = 1;
            Studentbtn.Text = "Student Info";
            Studentbtn.UseVisualStyleBackColor = true;
            Studentbtn.Click += Studentbtn_Click;
            // 
            // dashboardbtn
            // 
            dashboardbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardbtn.Location = new Point(12, 3);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(163, 33);
            dashboardbtn.TabIndex = 0;
            dashboardbtn.Text = "DashBoard";
            dashboardbtn.UseVisualStyleBackColor = true;
            dashboardbtn.Click += dashboardbtn_Click;
            // 
            // DashBoardpnlContent
            // 
            DashBoardpnlContent.Dock = DockStyle.Fill;
            DashBoardpnlContent.Location = new Point(200, 0);
            DashBoardpnlContent.Name = "DashBoardpnlContent";
            DashBoardpnlContent.Size = new Size(600, 680);
            DashBoardpnlContent.TabIndex = 1;
            DashBoardpnlContent.Paint += DashBoardpnlContent_Paint;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 680);
            Controls.Add(DashBoardpnlContent);
            Controls.Add(adminpnlSidebar);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Smart Hostel Management";
            WindowState = FormWindowState.Maximized;
            adminpnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel adminpnlSidebar;
        private Panel DashBoardpnlContent;
        private Button btnMeal;
        private Button btnStaffAttendance;
        private Button btnPayment;
        private Button btnRoom;
        private Button btnStaff;
        private Button Studentbtn;
        private Button dashboardbtn;
        private Button btnVisitor;
        private Button btnComplaint;
        private Button btnGaurdian;
        private Button btnlogout;
        private Button btnnotice;
    }
}