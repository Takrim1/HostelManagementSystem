using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class StudentDashboardForm : Form
    {
        public StudentDashboardForm()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            ALL_login login = new ALL_login();

            login.Show();

            this.Hide();
        }

        private void DashBoardpnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnotice_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            Stud_Notice notice = new Stud_Notice();

            notice.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(notice);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            Stud_Profile profile = new Stud_Profile();

            profile.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(profile);
        }

        private void btnroombed_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            Stud_Room_Bed roomBed = new Stud_Room_Bed();

            roomBed.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(roomBed);
        }

        private void btncomplaint_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            Stud_Complaint complaint = new Stud_Complaint();

            complaint.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(complaint);
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_VisitorForm visitor = new A_VisitorForm();

            visitor.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(visitor);
        }
    }
}
