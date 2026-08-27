namespace HostelManagementSystem
{
    partial class StudentDashboardForm
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
            studentpnlsidebar = new Panel();
            btnnotice = new Button();
            btnlogout = new Button();
            btnVisitor = new Button();
            btncomplaint = new Button();
            btnroombed = new Button();
            btnProfile = new Button();
            DashBoardpnlContent = new Panel();
            studentpnlsidebar.SuspendLayout();
            SuspendLayout();
            // 
            // studentpnlsidebar
            // 
            studentpnlsidebar.BackColor = SystemColors.InactiveCaption;
            studentpnlsidebar.Controls.Add(btnnotice);
            studentpnlsidebar.Controls.Add(btnlogout);
            studentpnlsidebar.Controls.Add(btnVisitor);
            studentpnlsidebar.Controls.Add(btncomplaint);
            studentpnlsidebar.Controls.Add(btnroombed);
            studentpnlsidebar.Controls.Add(btnProfile);
            studentpnlsidebar.Dock = DockStyle.Left;
            studentpnlsidebar.Location = new Point(0, 0);
            studentpnlsidebar.Name = "studentpnlsidebar";
            studentpnlsidebar.Size = new Size(200, 450);
            studentpnlsidebar.TabIndex = 0;
            // 
            // btnnotice
            // 
            btnnotice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnotice.Location = new Point(12, 247);
            btnnotice.Name = "btnnotice";
            btnnotice.Size = new Size(163, 38);
            btnnotice.TabIndex = 15;
            btnnotice.Text = "Notice";
            btnnotice.UseVisualStyleBackColor = true;
            btnnotice.Click += btnnotice_Click;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(12, 299);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(163, 38);
            btnlogout.TabIndex = 14;
            btnlogout.Text = "Log out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnVisitor
            // 
            btnVisitor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVisitor.Location = new Point(12, 203);
            btnVisitor.Name = "btnVisitor";
            btnVisitor.Size = new Size(163, 38);
            btnVisitor.TabIndex = 13;
            btnVisitor.Text = "Visitor";
            btnVisitor.UseVisualStyleBackColor = true;
            btnVisitor.Click += btnVisitor_Click;
            // 
            // btncomplaint
            // 
            btncomplaint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncomplaint.Location = new Point(12, 133);
            btncomplaint.Name = "btncomplaint";
            btncomplaint.Size = new Size(163, 38);
            btncomplaint.TabIndex = 12;
            btncomplaint.Text = "Complaint";
            btncomplaint.UseVisualStyleBackColor = true;
            btncomplaint.Click += btncomplaint_Click;
            // 
            // btnroombed
            // 
            btnroombed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnroombed.Location = new Point(0, 75);
            btnroombed.Name = "btnroombed";
            btnroombed.Size = new Size(163, 38);
            btnroombed.TabIndex = 11;
            btnroombed.Text = "Room-Bed";
            btnroombed.UseVisualStyleBackColor = true;
            btnroombed.Click += btnroombed_Click;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(3, 21);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(163, 38);
            btnProfile.TabIndex = 10;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // DashBoardpnlContent
            // 
            DashBoardpnlContent.Dock = DockStyle.Fill;
            DashBoardpnlContent.Location = new Point(200, 0);
            DashBoardpnlContent.Name = "DashBoardpnlContent";
            DashBoardpnlContent.Size = new Size(600, 450);
            DashBoardpnlContent.TabIndex = 1;
            DashBoardpnlContent.Paint += DashBoardpnlContent_Paint;
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(DashBoardpnlContent);
            Controls.Add(studentpnlsidebar);
            Name = "StudentDashboardForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StudentDashboard";
            WindowState = FormWindowState.Maximized;
            studentpnlsidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel studentpnlsidebar;
        private Panel DashBoardpnlContent;
        private Button btnProfile;
        private Button btnlogout;
        private Button btnVisitor;
        private Button btncomplaint;
        private Button btnroombed;
        private Button btnnotice;
    }
}