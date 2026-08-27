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
    public partial class A_PaymentRegistrationForm : Form
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
        private int editPaymentID = 0;


        // =========================================
        // NORMAL CONSTRUCTOR
        // ADD NEW PAYMENT
        // =========================================
        public A_PaymentRegistrationForm()
        {
            InitializeComponent();
        }


        // =========================================
        // EDIT CONSTRUCTOR
        // =========================================
        public A_PaymentRegistrationForm(int paymentID)
        {
            InitializeComponent();

            editPaymentID = paymentID;
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_PaymentRegistrationForm_Load(object sender, EventArgs e)
        {
            txtPaymentID.ReadOnly = true;

            if (editPaymentID > 0)
            {
                // =========================================
                // EDIT MODE
                // =========================================

                txtPaymentID.Text =
                    editPaymentID.ToString();

                LoadPaymentDataForEdit(editPaymentID);
            }
            else
            {
                // =========================================
                // ADD MODE
                // =========================================

                ShowNextPaymentID();
            }
        }


        // =========================================
        // SHOW NEXT PAYMENT ID
        // =========================================
        private void ShowNextPaymentID()
        {
            try
            {
                string query =
                    "SELECT ISNULL(MAX(PaymentID), 0) + 1 FROM PaymentForm";


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

                        txtPaymentID.Text =
                            nextID.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                txtPaymentID.Text = "1";

                MessageBox.Show(
                    "Could not generate Payment ID.\n\n" +
                    ex.Message,
                    "Payment ID Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // LOAD PAYMENT DATA FOR EDIT
        // =========================================
        private void LoadPaymentDataForEdit(int paymentID)
        {
            try
            {
                string query = @"
                    SELECT
                        PaymentID,
                        StudentID,
                        Phone,
                        Email,
                        Status,
                        PaidAmount,
                        PaymentType,
                        DueAmount
                    FROM PaymentForm
                    WHERE PaymentID = @PaymentID";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@PaymentID",
                            paymentID);

                        connection.Open();

                        using (SqlDataReader reader =
                               command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // =========================================
                                // PAYMENT ID
                                // =========================================
                                txtPaymentID.Text =
                                    reader["PaymentID"].ToString();


                                // =========================================
                                // STUDENT ID
                                // =========================================
                                txtStudentID.Text =
                                    reader["StudentID"].ToString();


                                // =========================================
                                // PHONE
                                // =========================================
                                txtPhone.Text =
                                    reader["Phone"] == DBNull.Value
                                        ? ""
                                        : reader["Phone"].ToString();


                                // =========================================
                                // EMAIL
                                // =========================================
                                txtEmail.Text =
                                    reader["Email"] == DBNull.Value
                                        ? ""
                                        : reader["Email"].ToString();


                                // =========================================
                                // STATUS
                                // =========================================
                                cmbStatus.Text =
                                    reader["Status"].ToString();


                                // =========================================
                                // PAID AMOUNT
                                // =========================================
                                cmbpaidAmount.Text =
                                    reader["PaidAmount"].ToString();


                                // =========================================
                                // PAYMENT TYPE
                                // =========================================
                                cmbpatmenttype.Text =
                                    reader["PaymentType"].ToString();


                                // =========================================
                                // DUE AMOUNT
                                // =========================================
                                cmbdueamount.Text =
                                    reader["DueAmount"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Payment data not found.",
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
                    "Could not load Payment data for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SAVE / UPDATE PAYMENT
        // =========================================
        private void btnSavepayment_Click(object sender, EventArgs e)
        {
            // =========================================
            // STUDENT ID VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show(
                    "Please enter Student ID.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentID.Focus();
                return;
            }


            // =========================================
            // STATUS VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show(
                    "Please select Payment Status.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbStatus.Focus();
                return;
            }


            // =========================================
            // PAID AMOUNT VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(cmbpaidAmount.Text))
            {
                MessageBox.Show(
                    "Please enter Paid Amount.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbpaidAmount.Focus();
                return;
            }


            // =========================================
            // PAYMENT TYPE VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(cmbpatmenttype.Text))
            {
                MessageBox.Show(
                    "Please select Payment Type.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbpatmenttype.Focus();
                return;
            }


            // =========================================
            // DUE AMOUNT VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(cmbdueamount.Text))
            {
                MessageBox.Show(
                    "Please enter Due Amount.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbdueamount.Focus();
                return;
            }


            // =========================================
            // CONVERT STUDENT ID
            // =========================================
            int studentID;

            if (!int.TryParse(
                txtStudentID.Text.Trim(),
                out studentID))
            {
                MessageBox.Show(
                    "Student ID must be a valid number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentID.Focus();
                return;
            }


            // =========================================
            // CONVERT PAID AMOUNT
            // =========================================
            decimal paidAmount;

            if (!decimal.TryParse(
                cmbpaidAmount.Text.Trim(),
                out paidAmount))
            {
                MessageBox.Show(
                    "Paid Amount must be a valid number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbpaidAmount.Focus();
                return;
            }


            // =========================================
            // CONVERT DUE AMOUNT
            // =========================================
            decimal dueAmount;

            if (!decimal.TryParse(
                cmbdueamount.Text.Trim(),
                out dueAmount))
            {
                MessageBox.Show(
                    "Due Amount must be a valid number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbdueamount.Focus();
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
                    if (editPaymentID > 0)
                    {
                        string updateQuery = @"
                            UPDATE PaymentForm
                            SET
                                StudentID = @StudentID,
                                Phone = @Phone,
                                Email = @Email,
                                Status = @Status,
                                PaidAmount = @PaidAmount,
                                PaymentType = @PaymentType,
                                DueAmount = @DueAmount
                            WHERE PaymentID = @PaymentID";


                        using (SqlCommand command =
                               new SqlCommand(
                                   updateQuery,
                                   connection))
                        {
                            command.Parameters.AddWithValue(
                                "@PaymentID",
                                editPaymentID);

                            command.Parameters.AddWithValue(
                                "@StudentID",
                                studentID);

                            command.Parameters.AddWithValue(
                                "@Phone",
                                string.IsNullOrWhiteSpace(txtPhone.Text)
                                    ? (object)DBNull.Value
                                    : txtPhone.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Email",
                                string.IsNullOrWhiteSpace(txtEmail.Text)
                                    ? (object)DBNull.Value
                                    : txtEmail.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@Status",
                                cmbStatus.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@PaidAmount",
                                paidAmount);

                            command.Parameters.AddWithValue(
                                "@PaymentType",
                                cmbpatmenttype.Text.Trim());

                            command.Parameters.AddWithValue(
                                "@DueAmount",
                                dueAmount);


                            int rows =
                                command.ExecuteNonQuery();


                            if (rows > 0)
                            {
                                MessageBox.Show(
                                    "Payment information updated successfully!\n\n" +
                                    "Payment ID: " +
                                    editPaymentID,
                                    "Update Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Payment record was not found.",
                                    "Update Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }

                        return;
                    }


                    // =========================================
                    // ADD MODE - INSERT NEW PAYMENT
                    // =========================================
                    string insertQuery = @"
                        INSERT INTO PaymentForm
                        (
                            StudentID,
                            Phone,
                            Email,
                            Status,
                            PaidAmount,
                            PaymentType,
                            DueAmount
                        )
                        OUTPUT INSERTED.PaymentID
                        VALUES
                        (
                            @StudentID,
                            @Phone,
                            @Email,
                            @Status,
                            @PaidAmount,
                            @PaymentType,
                            @DueAmount
                        )";


                    using (SqlCommand command =
                           new SqlCommand(
                               insertQuery,
                               connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StudentID",
                            studentID);

                        command.Parameters.AddWithValue(
                            "@Phone",
                            string.IsNullOrWhiteSpace(txtPhone.Text)
                                ? (object)DBNull.Value
                                : txtPhone.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@Email",
                            string.IsNullOrWhiteSpace(txtEmail.Text)
                                ? (object)DBNull.Value
                                : txtEmail.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@Status",
                            cmbStatus.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@PaidAmount",
                            paidAmount);

                        command.Parameters.AddWithValue(
                            "@PaymentType",
                            cmbpatmenttype.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@DueAmount",
                            dueAmount);


                        int generatedPaymentID =
                            Convert.ToInt32(
                                command.ExecuteScalar());


                        txtPaymentID.Text =
                            generatedPaymentID.ToString();


                        MessageBox.Show(
                            "Payment registered successfully!\n\n" +
                            "Payment ID: " +
                            generatedPaymentID,
                            "Registration Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }


                // =========================================
                // CLEAR AFTER NEW PAYMENT
                // =========================================
                ClearPaymentInformation();

                ShowNextPaymentID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Payment registration failed.\n\n" +
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
            ClearPaymentInformation();

            ShowNextPaymentID();
        }


        // =========================================
        // CLEAR PAYMENT INFORMATION
        // =========================================
        private void ClearPaymentInformation()
        {
            txtStudentID.Clear();

            txtPhone.Clear();

            txtEmail.Clear();

            cmbStatus.SelectedIndex = -1;

            cmbpaidAmount.SelectedIndex = -1;
            cmbpaidAmount.Text = "";

            cmbpatmenttype.SelectedIndex = -1;

            cmbdueamount.SelectedIndex = -1;
            cmbdueamount.Text = "";

            txtStudentID.Focus();
        }


        // =========================================
        // DESIGNER EVENTS
        // =========================================

        private void lblRelation_Click(object sender, EventArgs e)
        {
        }

        private void lblpaymentregiTitle_Click(object sender, EventArgs e)
        {
        }

        private void lblPaymentID_Click(object sender, EventArgs e)
        {
        }

        private void txtPaymentID_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
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

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblPaidAmount_Click(object sender, EventArgs e)
        {
        }

        private void cmbpaidAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblPaymenttype_Click(object sender, EventArgs e)
        {
        }

        private void cmbpatmenttype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblDueamount_Click(object sender, EventArgs e)
        {
        }

        private void cmbdueamount_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
 

    
    }
}
