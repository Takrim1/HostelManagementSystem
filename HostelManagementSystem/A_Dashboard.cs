using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class A_Dashboard : UserControl
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================

        private readonly string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // CONSTRUCTOR
        // =========================================

        public A_Dashboard()
        {
            InitializeComponent();
        }


        // =========================================
        // DASHBOARD LOAD
        // =========================================

        private void A_Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }


        // =========================================
        // LOAD DASHBOARD DATA
        // =========================================

        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    con.Open();


                    // =========================================
                    // TOTAL STUDENTS
                    // =========================================

                    string studentQuery = @"
                        SELECT COUNT(*)
                        FROM StudentForm";


                    using (SqlCommand cmd =
                           new SqlCommand(studentQuery, con))
                    {
                        object result = cmd.ExecuteScalar();

                        int totalStudents = 0;

                        if (result != null &&
                            result != DBNull.Value)
                        {
                            totalStudents =
                                Convert.ToInt32(result);
                        }

                        lblTotalStudents.Text =
                            totalStudents.ToString();
                    }


                    // =========================================
                    // TOTAL STAFF
                    // =========================================

                    string staffQuery = @"
                        SELECT COUNT(*)
                        FROM StaffForm";


                    using (SqlCommand cmd =
                           new SqlCommand(staffQuery, con))
                    {
                        object result = cmd.ExecuteScalar();

                        int totalStaff = 0;

                        if (result != null &&
                            result != DBNull.Value)
                        {
                            totalStaff =
                                Convert.ToInt32(result);
                        }

                        lblTotalStaff.Text =
                            totalStaff.ToString();
                    }


                    // =========================================
                    // PENDING FEES
                    // =========================================
                    // Total DueAmount where Status = Pending
                    // =========================================

                    string pendingFeesQuery = @"
                        SELECT ISNULL(SUM(DueAmount), 0)
                        FROM PaymentForm
                        WHERE Status = 'Pending'";


                    using (SqlCommand cmd =
                           new SqlCommand(
                               pendingFeesQuery,
                               con))
                    {
                        object result =
                            cmd.ExecuteScalar();

                        decimal pendingFees = 0;

                        if (result != null &&
                            result != DBNull.Value)
                        {
                            pendingFees =
                                Convert.ToDecimal(result);
                        }

                        lblPendingFees.Text =
                            pendingFees.ToString("N2") + " Tk";
                    }


                    // =========================================
                    // TOTAL REVENUE
                    // =========================================
                    // Total PaidAmount
                    // =========================================

                    string revenueQuery = @"
                        SELECT ISNULL(SUM(PaidAmount), 0)
                        FROM PaymentForm";


                    using (SqlCommand cmd =
                           new SqlCommand(
                               revenueQuery,
                               con))
                    {
                        object result =
                            cmd.ExecuteScalar();

                        decimal totalRevenue = 0;

                        if (result != null &&
                            result != DBNull.Value)
                        {
                            totalRevenue =
                                Convert.ToDecimal(result);
                        }

                        lblTotalRevenue.Text =
                            totalRevenue.ToString("N2") + " Tk";
                    }
                }
            }
            catch (Exception ex)
            {
                // =========================================
                // DEFAULT VALUES
                // =========================================

                lblTotalStudents.Text = "0";
                lblTotalStaff.Text = "0";
                lblPendingFees.Text = "0.00 Tk";
                lblTotalRevenue.Text = "0.00 Tk";


                MessageBox.Show(
                    "Dashboard data could not be loaded.\n\n" +
                    "Error: " + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // TOTAL STUDENTS EVENTS
        // =========================================

        private void lblTotalStudentsTitle_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblTotalStudents_Click(
            object sender,
            EventArgs e)
        {
        }


        private void pnlTotalStudents_Paint(
            object sender,
            PaintEventArgs e)
        {
        }


        // =========================================
        // TOTAL STAFF EVENTS
        // =========================================

        private void lblTotalStafftitle_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblTotalStaff_Click(
            object sender,
            EventArgs e)
        {
        }


        private void pnlTotalStaff_Paint(
            object sender,
            PaintEventArgs e)
        {
        }


        // =========================================
        // PENDING FEES EVENTS
        // =========================================

        private void lblPendingFeestitle_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblPendingFees_Click(
            object sender,
            EventArgs e)
        {
        }


        private void pnlPendingFees_Paint(
            object sender,
            PaintEventArgs e)
        {
        }


        // =========================================
        // TOTAL REVENUE EVENTS
        // =========================================

        private void lblTotalRevenuetitle_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblTotalRevenue_Click(
            object sender,
            EventArgs e)
        {
        }


        private void pnlTotalRevenue_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}