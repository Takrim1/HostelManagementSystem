using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void adminpnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Visitor_Click(object sender, EventArgs e)
        {
            A_VisitorForm visitorForm = new A_VisitorForm();

            visitorForm.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Clear();

            DashBoardpnlContent.Controls.Add(visitorForm);
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            A_StaffForm staffForm = new A_StaffForm();

            staffForm.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Clear();

            DashBoardpnlContent.Controls.Add(staffForm);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlStudentOverview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlTotalRevenue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_Dashboard dashboard = new A_Dashboard();

            dashboard.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(dashboard);
        }

        private void DashBoardpnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Studentbtn_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_StudentForm studentForm = new A_StudentForm();

            studentForm.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(studentForm);
        }

        private void btnGaurdian_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_GuardianForm form = new A_GuardianForm();

            form.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(form);
        }

        private void btnStaffAttendance_Click(object sender, EventArgs e)
        {
            A_StaffAttendanceForm attendanceForm = new A_StaffAttendanceForm();

            attendanceForm.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Clear();

            DashBoardpnlContent.Controls.Add(attendanceForm);

            attendanceForm.BringToFront();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_PaymentForm paymentForm = new A_PaymentForm();

            paymentForm.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(paymentForm);
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_BuildingFloorForm buildingFloorForm =
                new A_BuildingFloorForm();

            buildingFloorForm.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(buildingFloorForm);

            buildingFloorForm.BringToFront();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_MealForm mealForm = new A_MealForm();

            mealForm.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(mealForm);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            ALL_login login = new ALL_login();

            login.Show();

            this.Hide();
        }

        private void btnnotice_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_Notice notice = new A_Notice();

            notice.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(notice);

        }

        private void btnComplaint_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_ComplaintForm complaint = new A_ComplaintForm();

            complaint.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(complaint);
        }

        private void btnrestoredata_Click(object sender, EventArgs e)
        {
            DashBoardpnlContent.Controls.Clear();

            A_RetoreData restoreData = new A_RetoreData();

            restoreData.Dock = DockStyle.Fill;

            DashBoardpnlContent.Controls.Add(restoreData);
        }
    }
}
