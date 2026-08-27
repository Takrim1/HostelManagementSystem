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
    public partial class A_StaffRegistrationForm : Form
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // CONSTRUCTOR
        // =========================================
        private int editStaffID = 0;

        public A_StaffRegistrationForm()
        {
            InitializeComponent();
        }

        public A_StaffRegistrationForm(int staffID)
        {
            InitializeComponent();

            editStaffID = staffID;
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_StaffRegistrationForm_Load(object sender, EventArgs e)
        {
            txtStaffID.ReadOnly = true;

            if (editStaffID > 0)
            {
                // EDIT MODE
                txtStaffID.Text = editStaffID.ToString();

                LoadStaffDataForEdit(editStaffID);
            }
            else
            {
                // ADD MODE
                ShowNextStaffID();
            }
        }


        // =========================================
        // SHOW NEXT STAFF ID
        // =========================================
        private void ShowNextStaffID()
        {
            try
            {
                string query =
                    "SELECT ISNULL(MAX(StaffID), 0) + 1 FROM StaffForm";


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

                        txtStaffID.Text =
                            nextID.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                txtStaffID.Text = "1";

                MessageBox.Show(
                    "Could not generate Staff ID.\n\n" +
                    ex.Message,
                    "Staff ID Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // LOAD STAFF DATA FOR EDIT
        // =========================================
        private void LoadStaffDataForEdit(int staffID)
        {
            try
            {
                string query = @"
            SELECT
                StaffID,
                StaffName,
                StaffPosition,
                Phone,
                Email,
                HomeAddress,
                Password
            FROM StaffForm
            WHERE StaffID = @StaffID";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StaffID",
                            staffID);


                        connection.Open();


                        using (SqlDataReader reader =
                               command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtStaffID.Text =
                                    reader["StaffID"].ToString();

                                txtStaffName.Text =
                                    reader["StaffName"].ToString();

                                cmbstaffposition.Text =
                                    reader["StaffPosition"].ToString();

                                txtPhone.Text =
                                    reader["Phone"].ToString();

                                txtEmail.Text =
                                    reader["Email"] == DBNull.Value
                                        ? ""
                                        : reader["Email"].ToString();

                                txtHomeAddress.Text =
                                    reader["HomeAddress"] == DBNull.Value
                                        ? ""
                                        : reader["HomeAddress"].ToString();

                                txtpassword.Text =
                                    reader["Password"] == DBNull.Value
                                        ? ""
                                        : reader["Password"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Staff data not found.",
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
                    "Could not load Staff data for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SAVE / UPDATE STAFF
        // =========================================
        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            // =========================================
            // STAFF NAME VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtStaffName.Text))
            {
                MessageBox.Show(
                    "Please enter Staff Name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStaffName.Focus();
                return;
            }


            // =========================================
            // STAFF POSITION VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(cmbstaffposition.Text))
            {
                MessageBox.Show(
                    "Please select Staff Position.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbstaffposition.Focus();
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
            // PASSWORD VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show(
                    "Please enter Password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtpassword.Focus();
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
                    if (editStaffID > 0)
                    {
                        string updateQuery = @"
                    UPDATE StaffForm
                    SET
                        StaffName = @StaffName,
                        StaffPosition = @StaffPosition,
                        Phone = @Phone,
                        Email = @Email,
                        HomeAddress = @HomeAddress,
                        Password = @Password
                    WHERE StaffID = @StaffID";


                        using (SqlCommand command =
                               new SqlCommand(updateQuery, connection))
                        {
                            // =========================================
                            // SELECTED STAFF ID
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@StaffID",
                                editStaffID);


                            // =========================================
                            // STAFF NAME
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@StaffName",
                                txtStaffName.Text.Trim());


                            // =========================================
                            // STAFF POSITION
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@StaffPosition",
                                cmbstaffposition.Text.Trim());


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
                            // HOME ADDRESS
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@HomeAddress",
                                string.IsNullOrWhiteSpace(txtHomeAddress.Text)
                                    ? (object)DBNull.Value
                                    : txtHomeAddress.Text.Trim());


                            // =========================================
                            // PASSWORD
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@Password",
                                txtpassword.Text.Trim());


                            // =========================================
                            // EXECUTE UPDATE
                            // =========================================
                            int rows =
                                command.ExecuteNonQuery();


                            if (rows > 0)
                            {
                                MessageBox.Show(
                                    "Staff information updated successfully!\n\n" +
                                    "Staff ID: " + editStaffID +
                                    "\nStaff Name: " +
                                    txtStaffName.Text.Trim(),
                                    "Update Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                // Close edit form
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Staff was not found.",
                                    "Update Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }


                        // IMPORTANT:
                        // Edit mode এখানেই শেষ।
                        // নিচের INSERT code চলবে না।
                        return;
                    }


                    // =========================================
                    // ADD MODE - INSERT NEW STAFF
                    // =========================================
                    string insertQuery = @"
                INSERT INTO StaffForm
                (
                    StaffName,
                    StaffPosition,
                    Phone,
                    Email,
                    HomeAddress,
                    Password
                )
                OUTPUT INSERTED.StaffID
                VALUES
                (
                    @StaffName,
                    @StaffPosition,
                    @Phone,
                    @Email,
                    @HomeAddress,
                    @Password
                )";


                    using (SqlCommand command =
                           new SqlCommand(insertQuery, connection))
                    {
                        // =========================================
                        // STAFF NAME
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@StaffName",
                            txtStaffName.Text.Trim());


                        // =========================================
                        // STAFF POSITION
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@StaffPosition",
                            cmbstaffposition.Text.Trim());


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
                        // HOME ADDRESS
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@HomeAddress",
                            string.IsNullOrWhiteSpace(txtHomeAddress.Text)
                                ? (object)DBNull.Value
                                : txtHomeAddress.Text.Trim());


                        // =========================================
                        // PASSWORD
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Password",
                            txtpassword.Text.Trim());


                        // =========================================
                        // INSERT
                        // =========================================
                        int generatedStaffID =
                            Convert.ToInt32(
                                command.ExecuteScalar());


                        // =========================================
                        // SHOW GENERATED STAFF ID
                        // =========================================
                        txtStaffID.Text =
                            generatedStaffID.ToString();


                        MessageBox.Show(
                            "Staff registered successfully!\n\n" +
                            "Staff ID: " + generatedStaffID +
                            "\nStaff Name: " +
                            txtStaffName.Text.Trim(),
                            "Registration Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }


                // =========================================
                // CLEAR ONLY AFTER ADD
                // =========================================
                ClearStaffInformation();

                ShowNextStaffID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Staff save operation failed.\n\n" +
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
            ClearStaffInformation();

            ShowNextStaffID();
        }


        // =========================================
        // CLEAR STAFF INFORMATION
        // =========================================
        private void ClearStaffInformation()
        {
            txtStaffName.Clear();

            cmbstaffposition.SelectedIndex = -1;

            txtPhone.Clear();

            txtEmail.Clear();

            txtHomeAddress.Clear();

            txtpassword.Clear();

            txtStaffName.Focus();
        }


        // =========================================
        // DESIGNER EVENTS
        // =========================================

        private void lblStaffTitle_Click(object sender, EventArgs e)
        {
        }


        private void lblStaffID_Click(object sender, EventArgs e)
        {
        }


        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
        }


        private void lblStaffName_Click(object sender, EventArgs e)
        {
        }


        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {
        }


        private void lblstaffposition_Click(object sender, EventArgs e)
        {
        }


        private void cmbstaffposition_SelectedIndexChanged(object sender, EventArgs e)
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


        private void lblHomeAddress_Click(object sender, EventArgs e)
        {
        }


        private void txtHomeAddress_TextChanged(object sender, EventArgs e)
        {
        }


        private void btnSaveStaff_Click_old(object sender, EventArgs e)
        {
        }


        private void btnClear_Click_old(object sender, EventArgs e)
        {
        }


        private void lblpassword_Click(object sender, EventArgs e)
        {
        }


        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}