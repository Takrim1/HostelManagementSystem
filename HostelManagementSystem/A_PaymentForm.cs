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
    public partial class A_PaymentForm : UserControl
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
        // CONSTRUCTOR
        // =========================================
        public A_PaymentForm()
        {
            InitializeComponent();
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_PaymentForm_Load(object sender, EventArgs e)
        {
            LoadPaymentData();

            // Normal mode
            editPaymentID = 0;

            btnPayment.Text = "Payment";
        }


        // =========================================
        // LOAD ALL PAYMENT DATA
        // =========================================
        private void LoadPaymentData()
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
                    ORDER BY PaymentID ASC";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dataGridView1.DataSource = table;
                    }
                }


                // =========================================
                // DATAGRIDVIEW SETTINGS
                // =========================================
                dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.MultiSelect = false;

                dataGridView1.ReadOnly = true;

                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load Payment data.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // PAYMENT BUTTON
        // ADD NEW / UPDATE EXISTING
        // =========================================
        private void btnPayment_Click(object sender, EventArgs e)
        {
            // =========================================
            // EDIT MODE
            // =========================================
            if (editPaymentID > 0)
            {
                UpdatePayment();
                return;
            }


            // =========================================
            // ADD MODE
            // =========================================
            try
            {
                A_PaymentRegistrationForm form =
                    new A_PaymentRegistrationForm();

                form.ShowDialog();

                // Reload after new registration
                LoadPaymentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Payment Registration Form.\n\n" +
                    "Error: " + ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SEARCH PAYMENT
        // =========================================
        private void btnapplysearch_Click(object sender, EventArgs e)
        {
            SearchPayment();
        }


        private void SearchPayment()
        {
            try
            {
                string searchText =
                    txtpaymentSearch.Text.Trim();


                // =========================================
                // EMPTY SEARCH
                // =========================================
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadPaymentData();

                    MessageBox.Show(
                        "Please enter something to search.",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }


                // =========================================
                // SEARCH QUERY
                // =========================================
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
                    WHERE
                        CAST(PaymentID AS VARCHAR) LIKE @Search
                        OR CAST(StudentID AS VARCHAR) LIKE @Search
                        OR Phone LIKE @Search
                        OR Email LIKE @Search
                        OR Status LIKE @Search
                        OR CAST(PaidAmount AS VARCHAR) LIKE @Search
                        OR PaymentType LIKE @Search
                        OR CAST(DueAmount AS VARCHAR) LIKE @Search
                    ORDER BY
                        CASE
                            WHEN CAST(PaymentID AS VARCHAR) = @ExactSearch THEN 0
                            WHEN CAST(StudentID AS VARCHAR) = @ExactSearch THEN 1
                            WHEN Phone = @ExactSearch THEN 2
                            WHEN Email = @ExactSearch THEN 3
                            WHEN Status = @ExactSearch THEN 4
                            ELSE 5
                        END,
                        PaymentID ASC";


                DataTable table = new DataTable();


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Search",
                            "%" + searchText + "%");

                        command.Parameters.AddWithValue(
                            "@ExactSearch",
                            searchText);


                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }


                // =========================================
                // NO DATA FOUND
                // =========================================
                if (table.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;

                    MessageBox.Show(
                        "No Data Found.",
                        "Search Result",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }


                // =========================================
                // SHOW SEARCH RESULT
                // =========================================
                dataGridView1.DataSource = table;

                dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.MultiSelect = false;

                dataGridView1.ReadOnly = true;

                dataGridView1.AllowUserToAddRows = false;


                // =========================================
                // SELECT FIRST RESULT
                // =========================================
                dataGridView1.ClearSelection();

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;

                    dataGridView1.CurrentCell =
                        dataGridView1.Rows[0].Cells[0];

                    dataGridView1.FirstDisplayedScrollingRowIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // EDIT PAYMENT
        // =========================================
        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            // =========================================
            // CHECK ROW SELECTION
            // =========================================
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Payment record first.",
                    "Edit Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET PAYMENT ID FROM SELECTED ROW
                // =========================================
                object idValue =
                    dataGridView1.SelectedRows[0]
                    .Cells["PaymentID"]
                    .Value;


                // =========================================
                // CHECK PAYMENT ID
                // =========================================
                if (idValue == null ||
                    idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Payment ID could not be found.",
                        "Edit Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int paymentID =
                    Convert.ToInt32(idValue);


                // =========================================
                // SET EDIT MODE
                // =========================================
                editPaymentID = paymentID;


                // =========================================
                // LOAD STUDENT ID
                // =========================================
                txtStudentID.Text =
                    dataGridView1.SelectedRows[0]
                    .Cells["StudentID"]
                    .Value == DBNull.Value
                        ? ""
                        : dataGridView1.SelectedRows[0]
                        .Cells["StudentID"]
                        .Value.ToString();


                // =========================================
                // LOAD PHONE
                // =========================================
                txtPhone.Text =
                    dataGridView1.SelectedRows[0]
                    .Cells["Phone"]
                    .Value == DBNull.Value
                        ? ""
                        : dataGridView1.SelectedRows[0]
                        .Cells["Phone"]
                        .Value.ToString();


                // =========================================
                // LOAD EMAIL
                // =========================================
                txtEmail.Text =
                    dataGridView1.SelectedRows[0]
                    .Cells["Email"]
                    .Value == DBNull.Value
                        ? ""
                        : dataGridView1.SelectedRows[0]
                        .Cells["Email"]
                        .Value.ToString();


                // =========================================
                // LOAD STATUS
                // =========================================
                cmbStatus.Text =
                    dataGridView1.SelectedRows[0]
                    .Cells["Status"]
                    .Value == DBNull.Value
                        ? ""
                        : dataGridView1.SelectedRows[0]
                        .Cells["Status"]
                        .Value.ToString();


                // =========================================
                // LOAD PAID AMOUNT
                // =========================================
                cmbpaidAmount.Text =
                    dataGridView1.SelectedRows[0]
                    .Cells["PaidAmount"]
                    .Value == DBNull.Value
                        ? ""
                        : dataGridView1.SelectedRows[0]
                        .Cells["PaidAmount"]
                        .Value.ToString();


                // =========================================
                // LOAD PAYMENT TYPE
                // =========================================
                cmbpatmenttype.Text =
                    dataGridView1.SelectedRows[0]
                    .Cells["PaymentType"]
                    .Value == DBNull.Value
                        ? ""
                        : dataGridView1.SelectedRows[0]
                        .Cells["PaymentType"]
                        .Value.ToString();


                // =========================================
                // LOAD DUE AMOUNT
                // =========================================
                cmbdueamount.Text =
                    dataGridView1.SelectedRows[0]
                    .Cells["DueAmount"]
                    .Value == DBNull.Value
                        ? ""
                        : dataGridView1.SelectedRows[0]
                        .Cells["DueAmount"]
                        .Value.ToString();


                // =========================================
                // CHANGE BUTTON TO UPDATE MODE
                // =========================================
                btnPayment.Text =
                    "Update Payment";


                MessageBox.Show(
                    "Payment data loaded for editing.\n\n" +
                    "Change the information and click " +
                    "\"Update Payment\".",
                    "Edit Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load Payment for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Edit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // UPDATE EXISTING PAYMENT
        // =========================================
        private void UpdatePayment()
        {
            // =========================================
            // CHECK EDIT MODE
            // =========================================
            if (editPaymentID <= 0)
            {
                MessageBox.Show(
                    "No Payment record is selected for editing.",
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            // =========================================
            // VALIDATION
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


            try
            {
                // =========================================
                // UPDATE QUERY
                // =========================================
                string query = @"
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


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        // =========================================
                        // PAYMENT ID
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@PaymentID",
                            editPaymentID);


                        // =========================================
                        // STUDENT ID
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@StudentID",
                            txtStudentID.Text.Trim());


                        // =========================================
                        // PHONE
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Phone",
                            string.IsNullOrWhiteSpace(txtPhone.Text)
                                ? (object)DBNull.Value
                                : txtPhone.Text.Trim());


                        // =========================================
                        // EMAIL
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Email",
                            string.IsNullOrWhiteSpace(txtEmail.Text)
                                ? (object)DBNull.Value
                                : txtEmail.Text.Trim());


                        // =========================================
                        // STATUS
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Status",
                            string.IsNullOrWhiteSpace(cmbStatus.Text)
                                ? (object)DBNull.Value
                                : cmbStatus.Text.Trim());


                        // =========================================
                        // PAID AMOUNT
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@PaidAmount",
                            string.IsNullOrWhiteSpace(cmbpaidAmount.Text)
                                ? (object)DBNull.Value
                                : cmbpaidAmount.Text.Trim());


                        // =========================================
                        // PAYMENT TYPE
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@PaymentType",
                            string.IsNullOrWhiteSpace(cmbpatmenttype.Text)
                                ? (object)DBNull.Value
                                : cmbpatmenttype.Text.Trim());


                        // =========================================
                        // DUE AMOUNT
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@DueAmount",
                            string.IsNullOrWhiteSpace(cmbdueamount.Text)
                                ? (object)DBNull.Value
                                : cmbdueamount.Text.Trim());


                        // =========================================
                        // OPEN CONNECTION
                        // =========================================
                        connection.Open();


                        // =========================================
                        // UPDATE DATABASE
                        // =========================================
                        int rows =
                            command.ExecuteNonQuery();


                        // =========================================
                        // UPDATE SUCCESS
                        // =========================================
                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Payment updated successfully.",
                                "Update Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                            // =========================================
                            // EXIT EDIT MODE
                            // =========================================
                            editPaymentID = 0;


                            // =========================================
                            // CHANGE BUTTON BACK
                            // =========================================
                            btnPayment.Text =
                                "Payment";


                            // =========================================
                            // CLEAR INPUT FIELDS
                            // =========================================
                            ClearPaymentFields();


                            // =========================================
                            // RELOAD GRID
                            // =========================================
                            LoadPaymentData();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Payment update failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // DELETE PAYMENT
        // =========================================
        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            // =========================================
            // CHECK ROW SELECTION
            // =========================================
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Payment record first.",
                    "Delete Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET PAYMENT ID
                // =========================================
                object idValue =
                    dataGridView1.SelectedRows[0]
                    .Cells["PaymentID"]
                    .Value;


                if (idValue == null ||
                    idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Payment ID could not be found.",
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int paymentID =
                    Convert.ToInt32(idValue);


                // =========================================
                // CONFIRM DELETE
                // =========================================
                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete Payment ID "
                        + paymentID + "?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);


                if (result != DialogResult.Yes)
                {
                    return;
                }


                // =========================================
                // DELETE QUERY
                // =========================================
                string query = @"
                    DELETE FROM PaymentForm
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

                        int rows =
                            command.ExecuteNonQuery();


                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Payment deleted successfully.",
                                "Delete Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                            // Exit edit mode
                            editPaymentID = 0;

                            btnPayment.Text = "Payment";

                            ClearPaymentFields();

                            LoadPaymentData();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Payment was not found.",
                                "Delete Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Payment deletion failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // CLEAR PAYMENT FIELDS
        // =========================================
        private void ClearPaymentFields()
        {
            txtStudentID.Clear();

            txtPhone.Clear();

            txtEmail.Clear();

            cmbStatus.SelectedIndex = -1;
            cmbStatus.Text = "";

            cmbpaidAmount.SelectedIndex = -1;
            cmbpaidAmount.Text = "";

            cmbpatmenttype.SelectedIndex = -1;
            cmbpatmenttype.Text = "";

            cmbdueamount.SelectedIndex = -1;
            cmbdueamount.Text = "";
        }


        // =========================================
        // DESIGNER EVENTS
        // =========================================

        private void lblpaymentTitle_Click(object sender, EventArgs e)
        {
        }

        private void lblSearchGaurdian_Click(object sender, EventArgs e)
        {
        }

        private void txtpaymentSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblGaurdianPhone_Click(object sender, EventArgs e)
        {
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void pnlPaymentSearch_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}