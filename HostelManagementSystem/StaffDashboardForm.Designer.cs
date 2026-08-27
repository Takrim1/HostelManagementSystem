namespace HostelManagementSystem
{
    partial class StaffDashboardForm
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
            DashBoardpnlContent = new Panel();
            staffpnlsidebar = new Panel();
            btnnotice = new Button();
            btnMeal = new Button();
            btnlogout = new Button();
            btnComplaint = new Button();
            btnProfile = new Button();
            btnVisitor = new Button();
            staffpnlsidebar.SuspendLayout();
            SuspendLayout();
            // 
            // DashBoardpnlContent
            // 
            DashBoardpnlContent.Dock = DockStyle.Fill;
            DashBoardpnlContent.Location = new Point(200, 0);
            DashBoardpnlContent.Name = "DashBoardpnlContent";
            DashBoardpnlContent.Size = new Size(670, 450);
            DashBoardpnlContent.TabIndex = 3;
            DashBoardpnlContent.Paint += DashBoardpnlContent_Paint;
            // 
            // staffpnlsidebar
            // 
            staffpnlsidebar.BackColor = SystemColors.InactiveCaption;
            staffpnlsidebar.Controls.Add(btnVisitor);
            staffpnlsidebar.Controls.Add(btnnotice);
            staffpnlsidebar.Controls.Add(btnMeal);
            staffpnlsidebar.Controls.Add(btnlogout);
            staffpnlsidebar.Controls.Add(btnComplaint);
            staffpnlsidebar.Controls.Add(btnProfile);
            staffpnlsidebar.Dock = DockStyle.Left;
            staffpnlsidebar.Location = new Point(0, 0);
            staffpnlsidebar.Name = "staffpnlsidebar";
            staffpnlsidebar.Size = new Size(200, 450);
            staffpnlsidebar.TabIndex = 2;
            staffpnlsidebar.Paint += staffpnlsidebar_Paint;
            // 
            // btnnotice
            // 
            btnnotice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnotice.Location = new Point(16, 209);
            btnnotice.Name = "btnnotice";
            btnnotice.Size = new Size(163, 38);
            btnnotice.TabIndex = 21;
            btnnotice.Text = "Notice";
            btnnotice.UseVisualStyleBackColor = true;
            btnnotice.Click += btnnotice_Click;
            // 
            // btnMeal
            // 
            btnMeal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMeal.Location = new Point(16, 97);
            btnMeal.Name = "btnMeal";
            btnMeal.Size = new Size(163, 38);
            btnMeal.TabIndex = 20;
            btnMeal.Text = "Meal";
            btnMeal.UseVisualStyleBackColor = true;
            btnMeal.Click += btnMeal_Click_1;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(16, 301);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(163, 38);
            btnlogout.TabIndex = 19;
            btnlogout.Text = "Log out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnComplaint
            // 
            btnComplaint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComplaint.Location = new Point(16, 152);
            btnComplaint.Name = "btnComplaint";
            btnComplaint.Size = new Size(163, 38);
            btnComplaint.TabIndex = 17;
            btnComplaint.Text = "Complaint";
            btnComplaint.UseVisualStyleBackColor = true;
            btnComplaint.Click += btnComplaint_Click;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(16, 42);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(163, 38);
            btnProfile.TabIndex = 15;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnVisitor
            // 
            btnVisitor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVisitor.Location = new Point(16, 253);
            btnVisitor.Name = "btnVisitor";
            btnVisitor.Size = new Size(163, 38);
            btnVisitor.TabIndex = 22;
            btnVisitor.Text = "Visitor";
            btnVisitor.UseVisualStyleBackColor = true;
            btnVisitor.Click += btnVisitor_Click;
            // 
            // StaffDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 450);
            Controls.Add(DashBoardpnlContent);
            Controls.Add(staffpnlsidebar);
            Name = "StaffDashboardForm";
            Text = "StaffDashboardForm";
            staffpnlsidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel DashBoardpnlContent;
        private Panel staffpnlsidebar;
        private Button btnMeal;
        private Button button5;
        private Button btnlogout;
        private Button btnComplaint;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnProfile;
        private Button btnnotice;
        private Button btnVisitor;
    }
}