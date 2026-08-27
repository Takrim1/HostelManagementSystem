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
    public partial class A_StaffForm : UserControl
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // CONSTRUCTOR
        // =========================================
        public A_StaffForm()
        {
            InitializeComponent();
        }




        // =========================================
        // FORM LOAD
        // =========================================
        private void A_StaffForm_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }


        // =========================================
        // LOAD ALL STAFF DATA
        // =========================================
        private void LoadStaffData()
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
                        HomeAddress
                    FROM StaffForm
                    ORDER BY StaffID ASC";


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
                    "Could not load Staff data.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // REGISTER / ADD STAFF
        // =========================================
        private void btnregisterstaff_Click(object sender, EventArgs e)
        {
            A_StaffRegistrationForm form =
                new A_StaffRegistrationForm();

            form.ShowDialog();

            // Reload database data
            LoadStaffData();
        }


        // =========================================
        // SEARCH STAFF
        // =========================================
        private void btnapplysearch_Click(object sender, EventArgs e)
        {
            SearchStaff();
        }


        private void SearchStaff()
        {
            try
            {
                string searchText =
                    txtStaffSearch.Text.Trim();


                // =========================================
                // EMPTY SEARCH
                // =========================================
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadStaffData();

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
                        StaffID,
                        StaffName,
                        StaffPosition,
                        Phone,
                        Email,
                        HomeAddress
                    FROM StaffForm
                    WHERE
                        CAST(StaffID AS VARCHAR) LIKE @Search
                        OR StaffName LIKE @Search
                        OR StaffPosition LIKE @Search
                        OR Phone LIKE @Search
                        OR Email LIKE @Search
                        OR HomeAddress LIKE @Search
                    ORDER BY
                        CASE
                            WHEN CAST(StaffID AS VARCHAR) = @ExactSearch THEN 0
                            WHEN StaffName = @ExactSearch THEN 1
                            WHEN StaffPosition = @ExactSearch THEN 2
                            WHEN Phone = @ExactSearch THEN 3
                            WHEN Email = @ExactSearch THEN 4
                            ELSE 5
                        END,
                        StaffID ASC";


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
        // EDIT STAFF
        // =========================================
        private void btneditstaff_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Staff first.",
                    "Edit Staff",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET SELECTED STAFF ID
                // =========================================
                object idValue =
                    dataGridView1.SelectedRows[0]
                    .Cells["StaffID"]
                    .Value;


                if (idValue == null ||
                    idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Staff ID could not be found.",
                        "Edit Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int staffID =
                    Convert.ToInt32(idValue);


                // =========================================
                // OPEN EDIT MODE
                // =========================================
                A_StaffRegistrationForm form =
                    new A_StaffRegistrationForm(staffID);


                form.ShowDialog();


                // =========================================
                // RELOAD UPDATED DATA
                // =========================================
                LoadStaffData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Staff for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Edit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // DELETE STAFF
        // =========================================
        private void btndeletestaff_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Staff first.",
                    "Delete Staff",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET SELECTED STAFF ID
                // =========================================
                int staffID =
                    Convert.ToInt32(
                        dataGridView1.SelectedRows[0]
                        .Cells["StaffID"]
                        .Value);


                // =========================================
                // CONFIRM DELETE
                // =========================================
                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete Staff ID "
                        + staffID + "?",
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
                    DELETE FROM StaffForm
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

                        int rows =
                            command.ExecuteNonQuery();


                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Staff deleted successfully.",
                                "Delete Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadStaffData();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Staff was not found.",
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
                    "Staff deletion failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // DESIGNER EVENTS
        // =========================================

        private void lblStaffTitle_Click(object sender, EventArgs e)
        {
        }


        private void lblSearchStaff_Click(object sender, EventArgs e)
        {
        }


        private void txtStaffSearch_TextChanged(object sender, EventArgs e)
        {
        }


        private void lblStaffName_Click(object sender, EventArgs e)
        {
        }


        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {
        }


        private void lblStaffID_Click(object sender, EventArgs e)
        {
        }


        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
        }


        private void lblStaffPhone_Click(object sender, EventArgs e)
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
    }
}