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
    public partial class A_GuardianRegistrationForm : Form
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // EDIT MODE
        // =========================================
        private int editGuardianID = 0;


        // =========================================
        // NORMAL CONSTRUCTOR - ADD NEW GUARDIAN
        // =========================================
        public A_GuardianRegistrationForm()
        {
            InitializeComponent();
        }


        // =========================================
        // EDIT CONSTRUCTOR
        // =========================================
        public A_GuardianRegistrationForm(int guardianID)
        {
            InitializeComponent();

            editGuardianID = guardianID;
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_GuardianRegistrationForm_Load(object sender, EventArgs e)
        {
            // Guardian ID cannot be manually changed
            txtGuardianID.ReadOnly = true;

            // Student Name comes from StudentForm
            txtStudentName.ReadOnly = true;


            // =========================================
            // RELATION COMBOBOX
            // =========================================
            cmbRelation.Items.Clear();

            cmbRelation.Items.Add("Father");
            cmbRelation.Items.Add("Mother");
            cmbRelation.Items.Add("Brother");
            cmbRelation.Items.Add("Sister");
            cmbRelation.Items.Add("Uncle");
            cmbRelation.Items.Add("Aunt");
            cmbRelation.Items.Add("Guardian");
            cmbRelation.Items.Add("Other");


            // =========================================
            // ADD MODE / EDIT MODE
            // =========================================
            if (editGuardianID > 0)
            {
                // EDIT MODE
                // Selected GuardianID will remain the same
                txtGuardianID.Text = editGuardianID.ToString();

                // Load selected Guardian's existing data
                LoadGuardianDataForEdit(editGuardianID);
            }
            else
            {
                // ADD MODE
                // Only here generate next ID
                ShowNextGuardianID();
            }
        }


        // =========================================
        // SHOW NEXT GUARDIAN ID
        // =========================================
        private void ShowNextGuardianID()
        {
            try
            {
                string query =
                    "SELECT ISNULL(MAX(GuardianID), 0) + 1 FROM GuardianForm";

                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        connection.Open();

                        int nextID =
                            Convert.ToInt32(command.ExecuteScalar());

                        txtGuardianID.Text = nextID.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                txtGuardianID.Text = "1";

                MessageBox.Show(
                    "Could not generate Guardian ID.\n\n" +
                    ex.Message,
                    "Guardian ID Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // LOAD SELECTED GUARDIAN DATA FOR EDIT
        // =========================================
        private void LoadGuardianDataForEdit(int guardianID)
        {
            try
            {
                string query = @"
                SELECT
                    GuardianID,
                    StudentID,
                    StudentName,
                    GuardianName,
                    Relation,
                    Phone,
                    Email,
                    Occupation,
                    Address
                FROM GuardianForm
                WHERE GuardianID = @GuardianID";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@GuardianID",
                            guardianID);

                        connection.Open();

                        using (SqlDataReader reader =
                               command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Guardian ID
                                txtGuardianID.Text =
                                    reader["GuardianID"].ToString();


                                // Student ID
                                txtstudentid.Text =
                                    reader["StudentID"].ToString();


                                // Student Name
                                txtStudentName.Text =
                                    reader["StudentName"].ToString();


                                // Guardian Name
                                gaurdiannametxt.Text =
                                    reader["GuardianName"].ToString();


                                // Relation
                                cmbRelation.Text =
                                    reader["Relation"].ToString();


                                // Phone
                                txtPhone.Text =
                                    reader["Phone"].ToString();


                                // Email
                                txtEmail.Text =
                                    reader["Email"] == DBNull.Value
                                        ? ""
                                        : reader["Email"].ToString();


                                // Occupation
                                txtOccupation.Text =
                                    reader["Occupation"] == DBNull.Value
                                        ? ""
                                        : reader["Occupation"].ToString();


                                // Address
                                txtAddress.Text =
                                    reader["Address"] == DBNull.Value
                                        ? ""
                                        : reader["Address"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Guardian data not found.",
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
                    "Could not load Guardian data for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SAVE GUARDIAN
        // =========================================
        private void btnSaveGuardian_Click(object sender, EventArgs e)
        {
            // =========================================
            // STUDENT ID VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtstudentid.Text))
            {
                MessageBox.Show(
                    "Please enter Student ID.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtstudentid.Focus();
                return;
            }

            int studentID;

            if (!int.TryParse(txtstudentid.Text.Trim(), out studentID))
            {
                MessageBox.Show(
                    "Student ID must be a valid number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtstudentid.Focus();
                return;
            }


            // =========================================
            // GUARDIAN NAME VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(gaurdiannametxt.Text))
            {
                MessageBox.Show(
                    "Please enter Guardian Name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                gaurdiannametxt.Focus();
                return;
            }


            // =========================================
            // RELATION VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(cmbRelation.Text))
            {
                MessageBox.Show(
                    "Please select Guardian Relation.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbRelation.Focus();
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


            try
            {
                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    connection.Open();


                    // =========================================
                    // GET STUDENT NAME
                    // =========================================
                    string studentQuery = @"
                SELECT StudentName
                FROM StudentForm
                WHERE StudentID = @StudentID";


                    string studentName = "";


                    using (SqlCommand studentCommand =
                           new SqlCommand(studentQuery, connection))
                    {
                        studentCommand.Parameters.AddWithValue(
                            "@StudentID",
                            studentID);


                        object result =
                            studentCommand.ExecuteScalar();


                        if (result == null ||
                            result == DBNull.Value)
                        {
                            MessageBox.Show(
                                "Student ID " + studentID +
                                " does not exist in StudentForm.\n\n" +
                                "Please enter a valid Student ID.",
                                "Invalid Student ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtstudentid.Focus();
                            return;
                        }


                        studentName = result.ToString();

                        txtStudentName.Text = studentName;
                    }


                    // =====================================================
                    // EDIT MODE
                    // =====================================================
                    if (editGuardianID > 0)
                    {
                        string updateQuery = @"
                    UPDATE GuardianForm
                    SET
                        StudentID = @StudentID,
                        StudentName = @StudentName,
                        GuardianName = @GuardianName,
                        Relation = @Relation,
                        Phone = @Phone,
                        Email = @Email,
                        Occupation = @Occupation,
                        Address = @Address
                    WHERE GuardianID = @GuardianID";


                        using (SqlCommand command =
                               new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue(
                                "@GuardianID",
                                editGuardianID);

                            command.Parameters.AddWithValue(
                                "@StudentID",
                                studentID);

                            command.Parameters.AddWithValue(
                                "@StudentName",
                                studentName);

                            command.Parameters.AddWithValue(
                                "@GuardianName",
                                gaurdiannametxt.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Relation",
                                cmbRelation.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Phone",
                                txtPhone.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Email",
                                string.IsNullOrWhiteSpace(txtEmail.Text)
                                    ? (object)DBNull.Value
                                    : txtEmail.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Occupation",
                                string.IsNullOrWhiteSpace(txtOccupation.Text)
                                    ? (object)DBNull.Value
                                    : txtOccupation.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Address",
                                string.IsNullOrWhiteSpace(txtAddress.Text)
                                    ? (object)DBNull.Value
                                    : txtAddress.Text.Trim());


                            int rows =
                                command.ExecuteNonQuery();


                            if (rows > 0)
                            {
                                // Keep the SAME GuardianID
                                txtGuardianID.Text =
                                    editGuardianID.ToString();


                                MessageBox.Show(
                                    "Guardian information updated successfully!\n\n" +
                                    "Guardian ID: " + editGuardianID +
                                    "\n" +
                                    "Student ID: " + studentID +
                                    "\n" +
                                    "Student Name: " + studentName,
                                    "Update Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);


                                // Close edit form
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Guardian data could not be updated.",
                                    "Update Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                    }


                    // =====================================================
                    // ADD MODE
                    // =====================================================
                    else
                    {
                        string insertQuery = @"
                    INSERT INTO GuardianForm
                    (
                        StudentID,
                        StudentName,
                        GuardianName,
                        Relation,
                        Phone,
                        Email,
                        Occupation,
                        Address
                    )
                    OUTPUT INSERTED.GuardianID
                    VALUES
                    (
                        @StudentID,
                        @StudentName,
                        @GuardianName,
                        @Relation,
                        @Phone,
                        @Email,
                        @Occupation,
                        @Address
                    )";


                        using (SqlCommand command =
                               new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue(
                                "@StudentID",
                                studentID);

                            command.Parameters.AddWithValue(
                                "@StudentName",
                                studentName);

                            command.Parameters.AddWithValue(
                                "@GuardianName",
                                gaurdiannametxt.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Relation",
                                cmbRelation.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Phone",
                                txtPhone.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Email",
                                string.IsNullOrWhiteSpace(txtEmail.Text)
                                    ? (object)DBNull.Value
                                    : txtEmail.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Occupation",
                                string.IsNullOrWhiteSpace(txtOccupation.Text)
                                    ? (object)DBNull.Value
                                    : txtOccupation.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Address",
                                string.IsNullOrWhiteSpace(txtAddress.Text)
                                    ? (object)DBNull.Value
                                    : txtAddress.Text.Trim());


                            int generatedGuardianID =
                                Convert.ToInt32(
                                    command.ExecuteScalar());


                            txtGuardianID.Text =
                                generatedGuardianID.ToString();


                            MessageBox.Show(
                                "Guardian registered successfully!\n\n" +
                                "Guardian ID: " + generatedGuardianID +
                                "\n" +
                                "Student ID: " + studentID +
                                "\n" +
                                "Student Name: " + studentName,
                                "Registration Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }


                        // Clear only after NEW registration
                        ClearGuardianInformation();

                        // Generate next ID only for NEW registration
                        ShowNextGuardianID();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Guardian operation failed.\n\n" +
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
            ClearGuardianInformation();

            ShowNextGuardianID();
        }


        // =========================================
        // CLEAR GUARDIAN INFORMATION
        // =========================================
        private void ClearGuardianInformation()
        {
            txtstudentid.Clear();

            txtStudentName.Clear();

            gaurdiannametxt.Clear();

            cmbRelation.SelectedIndex = -1;

            txtPhone.Clear();

            txtEmail.Clear();

            txtOccupation.Clear();

            txtAddress.Clear();

            txtstudentid.Focus();
        }


        // =========================================
        // EMPTY DESIGNER EVENTS
        // =========================================

        private void Gaurdianregisterformlbl_Click(object sender, EventArgs e)
        {
        }

        private void lblGuardianID_Click(object sender, EventArgs e)
        {
        }

        private void txtGuardianID_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {
        }

        private void lblGaurdianName_Click(object sender, EventArgs e)
        {
        }

        private void gaurdiannametxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblRelation_Click(object sender, EventArgs e)
        {
        }

        private void cmbRelation_SelectedIndexChanged(object sender, EventArgs e)
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

        private void lblOccupation_Click(object sender, EventArgs e)
        {
        }

        private void txtOccupation_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblstudentid_Click(object sender, EventArgs e)
        {
        }

        private void txtstudentid_TextChanged(object sender, EventArgs e)
        {
        }
    }
}