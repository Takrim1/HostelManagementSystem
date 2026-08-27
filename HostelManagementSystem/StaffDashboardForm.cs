using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class StaffDashboardForm : Form
    {
        public StaffDashboardForm()
        {
            InitializeComponent();
        }

        private int loggedInStaffID;

        public StaffDashboardForm(int staffID)
        {
            InitializeComponent();
            loggedInStaffID = staffID;
        }



        private void btnMeal_Click_1(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_MealForm mealForm = new A_MealForm();

            mealForm.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(mealForm);
        }



        private void DashBoardpnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void staffpnlsidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            Staff_Profile profile = new Staff_Profile(loggedInStaffID);

            profile.Dock = DockStyle.Fill;
            DashBoardpnlContent.Controls.Clear();

            DashBoardpnlContent.Controls.Add(profile);

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            ALL_login login = new ALL_login();

            login.Show();

            this.Hide();
        
        }

        private void btnComplaint_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            Staff_Complaint complaint = new Staff_Complaint();

            complaint.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(complaint);
        }

        private void btnnotice_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            Staff_Notice notice = new Staff_Notice();

            notice.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(notice);
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
