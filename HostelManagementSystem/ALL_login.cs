using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class ALL_login : Form
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private readonly string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // CONSTRUCTOR
        // =========================================
        public ALL_login()
        {
            InitializeComponent();
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void ALL_login_Load(object sender, EventArgs e)
        {
            // Make password hidden
            txtPassword.UseSystemPasswordChar = true;
        }


        // =========================================
        // LOGIN BUTTON
        // =========================================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = comboBox1.Text.Trim();
            string id = txtId.Text.Trim();
            string password = txtPassword.Text.Trim();


            // =========================================
            // ROLE VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show(
                    "Please select Admin, Staff or Student.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboBox1.Focus();
                return;
            }


            // =========================================
            // ID VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show(
                    "Please enter your ID.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtId.Focus();
                return;
            }


            // =========================================
            // PASSWORD VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }


            // =========================================
            // ADMIN LOGIN
            // =========================================
            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                if (id.Equals("admin", StringComparison.OrdinalIgnoreCase)
                    && password == "1234")
                {
                   

                    AdminDashboardForm adminForm =
                        new AdminDashboardForm();

                    adminForm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Invalid Admin ID or Password!",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtPassword.Clear();
                    txtPassword.Focus();
                }

                return;
            }


            // =========================================
            // STAFF LOGIN
            // =========================================
            if (role.Equals("Staff", StringComparison.OrdinalIgnoreCase))
            {
                StaffLogin(id, password);
                return;
            }


            // =========================================
            // STUDENT LOGIN
            // =========================================
            if (role.Equals("Student", StringComparison.OrdinalIgnoreCase))
            {
                StudentLogin(id, password);
                return;
            }


            // =========================================
            // INVALID ROLE
            // =========================================
            MessageBox.Show(
                "Please select Admin, Staff or Student.",
                "Login Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }


        // =========================================
        // STAFF LOGIN
        // =========================================
        private void StaffLogin(string staffID, string password)
        {
            try
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM StaffForm
                    WHERE StaffID = @StaffID
                    AND Password = @Password";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        // Staff ID is INT in database
                        int staffIdNumber;

                        if (!int.TryParse(staffID, out staffIdNumber))
                        {
                            MessageBox.Show(
                                "Staff ID must be a valid number.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtId.Focus();
                            return;
                        }


                        command.Parameters.Add(
                            "@StaffID",
                            SqlDbType.Int).Value =
                            staffIdNumber;


                        command.Parameters.Add(
                            "@Password",
                            SqlDbType.NVarChar).Value =
                            password;


                        connection.Open();


                        int result =
                            Convert.ToInt32(
                                command.ExecuteScalar());


                        if (result > 0)
                        {
                           

                            StaffDashboardForm staffForm =
                                new StaffDashboardForm();

                            staffForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid Staff ID or Password!",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Staff login failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // STUDENT LOGIN
        // =========================================
        private void StudentLogin(string studentID, string password)
        {
            try
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM StudentForm
                    WHERE StudentID = @StudentID
                    AND Password = @Password";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        // Student ID is INT in database
                        int studentIdNumber;

                        if (!int.TryParse(studentID, out studentIdNumber))
                        {
                            MessageBox.Show(
                                "Student ID must be a valid number.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtId.Focus();
                            return;
                        }


                        command.Parameters.Add(
                            "@StudentID",
                            SqlDbType.Int).Value =
                            studentIdNumber;


                        command.Parameters.Add(
                            "@Password",
                            SqlDbType.NVarChar).Value =
                            password;


                        connection.Open();


                        int result =
                            Convert.ToInt32(
                                command.ExecuteScalar());


                        if (result > 0)
                        {
                           
                            StudentDashboardForm studentForm =
                                new StudentDashboardForm();

                            studentForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid Student ID or Password!",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Student login failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // ADMIN LABEL
        // =========================================
        private void adminlabellogin_Click(object sender, EventArgs e)
        {
        }


        // =========================================
        // LOGIN AS LABEL
        // =========================================
        private void LogAs_Click(object sender, EventArgs e)
        {
        }


        // =========================================
        // COMBOBOX
        // =========================================
        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // ID LABEL
        // =========================================
        private void lblId_Click(object sender, EventArgs e)
        {
        }


        // =========================================
        // ID TEXTBOX
        // =========================================
        private void txtId_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // PASSWORD LABEL
        // =========================================
        private void lblpassword_Click(object sender, EventArgs e)
        {
        }


        // =========================================
        // PASSWORD TEXTBOX
        // =========================================
        private void txtPassword_TextChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}