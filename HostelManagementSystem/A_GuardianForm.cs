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
    public partial class A_GuardianForm : UserControl
    {
        private string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        public A_GuardianForm()
        {
            InitializeComponent();
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_GuardianForm_Load(object sender, EventArgs e)
        {
            LoadGuardianData();
        }


        // =========================================
        // LOAD ALL GUARDIAN DATA
        // =========================================
        private void LoadGuardianData()
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
                    ORDER BY GuardianID ASC";


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


                dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.MultiSelect = false;

                dataGridView1.ReadOnly = true;

                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load Guardian data.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // ADD GUARDIAN
        // =========================================
        private void btnAddGuardian_Click(object sender, EventArgs e)
        {
            A_GuardianRegistrationForm form =
                new A_GuardianRegistrationForm();

            form.ShowDialog();

            LoadGuardianData();
        }


        // =========================================
        // SEARCH GUARDIAN
        // =========================================
        private void btnapplysearch_Click(object sender, EventArgs e)
        {
            SearchGuardian();
        }


        private void SearchGuardian()
        {
            try
            {
                string searchText =
                    txtGuardianSearch.Text.Trim();


                // Empty search
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadGuardianData();

                    MessageBox.Show(
                        "Please enter something to search.",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }


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
                    WHERE
                        CAST(GuardianID AS VARCHAR) LIKE @Search
                        OR CAST(StudentID AS VARCHAR) LIKE @Search
                        OR StudentName LIKE @Search
                        OR GuardianName LIKE @Search
                        OR Relation LIKE @Search
                        OR Phone LIKE @Search
                        OR Email LIKE @Search
                        OR Occupation LIKE @Search
                        OR Address LIKE @Search
                    ORDER BY
                        CASE
                            WHEN CAST(GuardianID AS VARCHAR) = @ExactSearch THEN 0
                            WHEN CAST(StudentID AS VARCHAR) = @ExactSearch THEN 1
                            WHEN GuardianName = @ExactSearch THEN 2
                            WHEN StudentName = @ExactSearch THEN 3
                            WHEN Phone = @ExactSearch THEN 4
                            ELSE 5
                        END,
                        GuardianID ASC";


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
        // EDIT GUARDIAN
        // =========================================
        private void btnEditGuardian_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Guardian first.",
                    "Edit Guardian",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // Get GuardianID from selected row
                object idValue =
                    dataGridView1.SelectedRows[0]
                    .Cells["GuardianID"]
                    .Value;


                if (idValue == null ||
                    idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Guardian ID could not be found.",
                        "Edit Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int guardianID =
                    Convert.ToInt32(idValue);


                // IMPORTANT:
                // Selected GuardianID is sent to registration form.
                // It will NOT generate a new GuardianID.
                A_GuardianRegistrationForm form =
                    new A_GuardianRegistrationForm(guardianID);


                form.ShowDialog();


                // Reload updated database data
                LoadGuardianData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Guardian for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Edit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // DELETE GUARDIAN
        // =========================================
        private void btnDeleteGuardian_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Guardian first.",
                    "Delete Guardian",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                int guardianID =
                    Convert.ToInt32(
                        dataGridView1.SelectedRows[0]
                        .Cells["GuardianID"]
                        .Value);


                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete Guardian ID "
                        + guardianID + "?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);


                if (result != DialogResult.Yes)
                {
                    return;
                }


                string query = @"
                    DELETE FROM GuardianForm
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

                        int rows =
                            command.ExecuteNonQuery();


                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Guardian deleted successfully.",
                                "Delete Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadGuardianData();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Guardian was not found.",
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
                    "Guardian deletion failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SEARCH TEXTBOX
        // =========================================
        private void txtGuardianSearch_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // OTHER DESIGNER EVENTS
        // =========================================

        private void pnlGuardianSearch_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void txtPhone_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void txtStudentID_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void lblStudentID_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblGaurdianPhone_Click(
            object sender,
            EventArgs e)
        {
        }

        private void txtGaurdianName_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void lblGaurdianName_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblSearchGaurdian_Click(
            object sender,
            EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}