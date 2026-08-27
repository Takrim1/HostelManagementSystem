using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class A_StudentRegistrationForm : Form
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // EDIT MODE
        // 0  = ADD MODE
        // >0 = EDIT MODE
        // =========================================
        private int editStudentID = 0;


        // =========================================
        // NORMAL CONSTRUCTOR - ADD NEW STUDENT
        // =========================================
        public A_StudentRegistrationForm()
        {
            InitializeComponent();
        }


        // =========================================
        // EDIT CONSTRUCTOR
        // =========================================
        public A_StudentRegistrationForm(int studentID)
        {
            InitializeComponent();

            editStudentID = studentID;
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            // Student ID cannot be manually changed
            txtStudentID.ReadOnly = true;

            // Password field
            txtpass.UseSystemPasswordChar = true;


            // =========================================
            // ADD MODE / EDIT MODE
            // =========================================
            if (editStudentID > 0)
            {
                // =========================================
                // EDIT MODE
                // =========================================

                // Keep selected Student ID
                txtStudentID.Text =
                    editStudentID.ToString();

                // Load existing student information
                LoadStudentDataForEdit(editStudentID);
            }
            else
            {
                // =========================================
                // ADD MODE
                // =========================================

                // Generate next ID only for display
                ShowNextStudentID();
            }
        }


        // =========================================
        // SHOW NEXT STUDENT ID
        // =========================================
        private void ShowNextStudentID()
        {
            try
            {
                string query =
                    "SELECT ISNULL(MAX(StudentID), 0) + 1 FROM StudentForm";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        connection.Open();

                        int nextID =
                            Convert.ToInt32(
                                command.ExecuteScalar());

                        txtStudentID.Text =
                            nextID.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                txtStudentID.Text = "1";

                MessageBox.Show(
                    "Could not generate Student ID.\n\n" +
                    ex.Message,
                    "Student ID Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // LOAD SELECTED STUDENT DATA FOR EDIT
        // =========================================
        private void LoadStudentDataForEdit(int studentID)
        {
            try
            {
                string query = @"
                    SELECT
                        StudentID,
                        StudentName,
                        Password,
                        Gender,
                        DOB,
                        Phone,
                        Email,
                        Department,
                        HomeAddress,
                        AdmissionDate
                    FROM StudentForm
                    WHERE StudentID = @StudentID";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StudentID",
                            studentID);


                        connection.Open();


                        using (SqlDataReader reader =
                               command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // =========================================
                                // STUDENT ID
                                // =========================================
                                txtStudentID.Text =
                                    reader["StudentID"].ToString();


                                // =========================================
                                // STUDENT NAME
                                // =========================================
                                txtStudentName.Text =
                                    reader["StudentName"].ToString();


                                // =========================================
                                // PASSWORD
                                // =========================================
                                txtpass.Text =
                                    reader["Password"].ToString();


                                // =========================================
                                // GENDER
                                // =========================================
                                cmbGender.Text =
                                    reader["Gender"].ToString();


                                // =========================================
                                // DATE OF BIRTH
                                // =========================================
                                if (reader["DOB"] != DBNull.Value)
                                {
                                    dtpDOB.Value =
                                        Convert.ToDateTime(
                                            reader["DOB"]);
                                }


                                // =========================================
                                // PHONE
                                // =========================================
                                txtPhone.Text =
                                    reader["Phone"].ToString();


                                // =========================================
                                // EMAIL
                                // =========================================
                                txtEmail.Text =
                                    reader["Email"] == DBNull.Value
                                        ? ""
                                        : reader["Email"].ToString();


                                // =========================================
                                // DEPARTMENT
                                // =========================================
                                cmbdepartment.Text =
                                    reader["Department"].ToString();


                                // =========================================
                                // HOME ADDRESS
                                // =========================================
                                txtHomeAddress.Text =
                                    reader["HomeAddress"] == DBNull.Value
                                        ? ""
                                        : reader["HomeAddress"].ToString();


                                // =========================================
                                // ADMISSION DATE
                                // =========================================
                                if (reader["AdmissionDate"] != DBNull.Value)
                                {
                                    dtpAdmissionDate.Value =
                                        Convert.ToDateTime(
                                            reader["AdmissionDate"]);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Student data not found.",
                                    "Edit Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load Student data for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // REGISTER / UPDATE STUDENT
        // =========================================
        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            // =========================================
            // STUDENT NAME VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show(
                    "Please enter Student Name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentName.Focus();
                return;
            }


            // =========================================
            // GENDER VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show(
                    "Please select Gender.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbGender.Focus();
                return;
            }


            // =========================================
            // PHONE VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show(
                    "Please enter Phone Number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhone.Focus();
                return;
            }


            // =========================================
            // DEPARTMENT VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(cmbdepartment.Text))
            {
                MessageBox.Show(
                    "Please select Department.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbdepartment.Focus();
                return;
            }


            // =========================================
            // PASSWORD VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show(
                    "Please enter Password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtpass.Focus();
                return;
            }


            try
            {
                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    connection.Open();


                    // =========================================
                    // EDIT MODE
                    // =========================================
                    if (editStudentID > 0)
                    {
                        string updateQuery = @"
                            UPDATE StudentForm
                            SET
                                StudentName = @StudentName,
                                Password = @Password,
                                Gender = @Gender,
                                DOB = @DOB,
                                Phone = @Phone,
                                Email = @Email,
                                Department = @Department,
                                HomeAddress = @HomeAddress,
                                AdmissionDate = @AdmissionDate
                            WHERE StudentID = @StudentID";


                        using (SqlCommand command =
                               new SqlCommand(updateQuery, connection))
                        {
                            // =========================================
                            // IMPORTANT
                            // Existing StudentID
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@StudentID",
                                editStudentID);


                            command.Parameters.AddWithValue(
                                "@StudentName",
                                txtStudentName.Text.Trim());


                            command.Parameters.AddWithValue(
                                "@Password",
                                txtpass.Text);


                            command.Parameters.AddWithValue(
                                "@Gender",
                                cmbGender.Text.Trim());


                            command.Parameters.AddWithValue(
                                "@DOB",
                                dtpDOB.Value.Date);


                            command.Parameters.AddWithValue(
                                "@Phone",
                                txtPhone.Text.Trim());


                            command.Parameters.AddWithValue(
                                "@Email",
                                string.IsNullOrWhiteSpace(txtEmail.Text)
                                    ? (object)DBNull.Value
                                    : txtEmail.Text.Trim());


                            command.Parameters.AddWithValue(
                                "@Department",
                                cmbdepartment.Text.Trim());


                            command.Parameters.AddWithValue(
                                "@HomeAddress",
                                string.IsNullOrWhiteSpace(txtHomeAddress.Text)
                                    ? (object)DBNull.Value
                                    : txtHomeAddress.Text.Trim());


                            command.Parameters.AddWithValue(
                                "@AdmissionDate",
                                dtpAdmissionDate.Value.Date);


                            // =========================================
                            // EXECUTE UPDATE
                            // =========================================
                            int rows =
                                command.ExecuteNonQuery();


                            if (rows > 0)
                            {
                                MessageBox.Show(
                                    "Student information updated successfully!\n\n" +
                                    "Student ID: " + editStudentID,
                                    "Update Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                // Close edit form
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Student was not found.",
                                    "Update Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }


                        // IMPORTANT:
                        // Do NOT execute INSERT after EDIT
                        return;
                    }


                    // =========================================
                    // ADD MODE - INSERT NEW STUDENT
                    // =========================================
                    string insertQuery = @"
                        INSERT INTO StudentForm
                        (
                            StudentName,
                            Password,
                            Gender,
                            DOB,
                            Phone,
                            Email,
                            Department,
                            HomeAddress,
                            AdmissionDate
                        )
                        OUTPUT INSERTED.StudentID
                        VALUES
                        (
                            @StudentName,
                            @Password,
                            @Gender,
                            @DOB,
                            @Phone,
                            @Email,
                            @Department,
                            @HomeAddress,
                            @AdmissionDate
                        )";


                    using (SqlCommand command =
                           new SqlCommand(insertQuery, connection))
                    {
                        // =========================================
                        // STUDENT NAME
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@StudentName",
                            txtStudentName.Text.Trim());


                        // =========================================
                        // PASSWORD
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Password",
                            txtpass.Text);


                        // =========================================
                        // GENDER
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Gender",
                            cmbGender.Text.Trim());


                        // =========================================
                        // DOB
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@DOB",
                            dtpDOB.Value.Date);


                        // =========================================
                        // PHONE
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Phone",
                            txtPhone.Text.Trim());


                        // =========================================
                        // EMAIL
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Email",
                            string.IsNullOrWhiteSpace(txtEmail.Text)
                                ? (object)DBNull.Value
                                : txtEmail.Text.Trim());


                        // =========================================
                        // DEPARTMENT
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Department",
                            cmbdepartment.Text.Trim());


                        // =========================================
                        // HOME ADDRESS
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@HomeAddress",
                            string.IsNullOrWhiteSpace(txtHomeAddress.Text)
                                ? (object)DBNull.Value
                                : txtHomeAddress.Text.Trim());


                        // =========================================
                        // ADMISSION DATE
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@AdmissionDate",
                            dtpAdmissionDate.Value.Date);


                        // =========================================
                        // INSERT NEW STUDENT
                        // SQL SERVER GENERATES StudentID
                        // =========================================
                        int generatedStudentID =
                            Convert.ToInt32(
                                command.ExecuteScalar());


                        // Show actual generated ID
                        txtStudentID.Text =
                            generatedStudentID.ToString();


                        MessageBox.Show(
                            "Student registered successfully!\n\n" +
                            "Student ID: " + generatedStudentID +
                            "\n\nThis Student ID can be used for Student Login.",
                            "Registration Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }


                // =========================================
                // CLEAR AFTER NEW REGISTRATION
                // =========================================
                ClearStudentInformation();

                // Show next available ID
                ShowNextStudentID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Student registration failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // CLEAR BUTTON
        // =========================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearStudentInformation();

            ShowNextStudentID();
        }


        // =========================================
        // CLEAR STUDENT INFORMATION
        // =========================================
        private void ClearStudentInformation()
        {
            txtStudentName.Clear();

            txtPhone.Clear();

            txtEmail.Clear();

            txtHomeAddress.Clear();

            txtpass.Clear();

            cmbGender.SelectedIndex = -1;

            cmbdepartment.SelectedIndex = -1;

            dtpDOB.Value = DateTime.Today;

            dtpAdmissionDate.Value = DateTime.Today;

            txtStudentName.Focus();
        }


        // =========================================
        // DESIGNER EVENTS
        // =========================================

        private void lblStudentID_Click(object sender, EventArgs e)
        {
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblGender_Click(object sender, EventArgs e)
        {
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblDOB_Click(object sender, EventArgs e)
        {
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {
        }

        private void cmbdepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblHomeAddress_Click(object sender, EventArgs e)
        {
        }

        private void txtHomeAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblAdmissionDate_Click(object sender, EventArgs e)
        {
        }

        private void dtpAdmissionDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblpass_Click(object sender, EventArgs e)
        {
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
        }

        private void Studentregisterformlbl_Click(object sender, EventArgs e)
        {
        }
    }
}