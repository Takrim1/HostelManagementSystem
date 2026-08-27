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
    public partial class A_VisitorForm : UserControl
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // CONSTRUCTOR
        // =========================================
        public A_VisitorForm()
        {
            InitializeComponent();
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_VisitorForm_Load(object sender, EventArgs e)
        {
            LoadVisitorData();
        }


        // =========================================
        // LOAD ALL VISITOR DATA
        // =========================================
        private void LoadVisitorData()
        {
            try
            {
                dataGridViewStudents.AutoGenerateColumns = false;

                string query = @"
                    SELECT
                        VisitorID,
                        StudentID,
                        VisitorName,
                        Gender,
                        VisitDate,
                        Phone,
                        Relation,
                        Hostel
                    FROM Visitor
                    ORDER BY VisitorID ASC";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dataGridViewStudents.AutoGenerateColumns = true;
                        dataGridViewStudents.DataSource = table;
                    }
                }


                // =========================================
                // DATAGRIDVIEW SETTINGS
                // =========================================
                dataGridViewStudents.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridViewStudents.MultiSelect = false;

                dataGridViewStudents.ReadOnly = true;

                dataGridViewStudents.AllowUserToAddRows = false;

                dataGridViewStudents.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load Visitor data.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // REGISTER VISITOR
        // =========================================
        private void btnRegisterVisitor_Click(object sender, EventArgs e)
        {
            A_VisitorRegistrationForm form =
                new A_VisitorRegistrationForm();

            form.ShowDialog();

            // Reload database data
            LoadVisitorData();
        }


        // =========================================
        // SEARCH VISITOR
        // =========================================
        private void searchapplybtn_Click(object sender, EventArgs e)
        {
            SearchVisitor();
        }


        // =========================================
        // SEARCH VISITOR DATA
        // =========================================
        private void SearchVisitor()
        {
            try
            {
                string visitorSearch =
                    txtSearchVisitorID.Text.Trim();

                string studentSearch =
                    txtSearchStudentID.Text.Trim();


                // =========================================
                // EMPTY SEARCH
                // =========================================
                if (string.IsNullOrWhiteSpace(visitorSearch) &&
                    string.IsNullOrWhiteSpace(studentSearch))
                {
                    LoadVisitorData();

                    MessageBox.Show(
                        "Please enter Visitor ID or Student ID.",
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
                        VisitorID,
                        StudentID,
                        VisitorName,
                        Gender,
                        VisitDate,
                        Phone,
                        Relation,
                        Hostel
                    FROM Visitor
                    WHERE
                        (
                            @VisitorSearch = ''
                            OR CAST(VisitorID AS VARCHAR) LIKE @VisitorSearchLike
                            OR VisitorName LIKE @VisitorSearchLike
                            OR Gender LIKE @VisitorSearchLike
                            OR Phone LIKE @VisitorSearchLike
                            OR Relation LIKE @VisitorSearchLike
                            OR Hostel LIKE @VisitorSearchLike
                        )
                        AND
                        (
                            @StudentSearch = ''
                            OR CAST(StudentID AS VARCHAR) LIKE @StudentSearchLike
                        )
                    ORDER BY
                        VisitorID ASC";


                DataTable table = new DataTable();


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@VisitorSearch",
                            visitorSearch);

                        command.Parameters.AddWithValue(
                            "@VisitorSearchLike",
                            "%" + visitorSearch + "%");

                        command.Parameters.AddWithValue(
                            "@StudentSearch",
                            studentSearch);

                        command.Parameters.AddWithValue(
                            "@StudentSearchLike",
                            "%" + studentSearch + "%");


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
                    dataGridViewStudents.DataSource = null;

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
                dataGridViewStudents.AutoGenerateColumns = false;

                dataGridViewStudents.DataSource = table;

                dataGridViewStudents.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridViewStudents.MultiSelect = false;

                dataGridViewStudents.ReadOnly = true;

                dataGridViewStudents.AllowUserToAddRows = false;


                // =========================================
                // SELECT FIRST SEARCH RESULT
                // =========================================
                dataGridViewStudents.ClearSelection();

                if (dataGridViewStudents.Rows.Count > 0)
                {
                    dataGridViewStudents.Rows[0].Selected = true;

                    dataGridViewStudents.CurrentCell =
                        dataGridViewStudents.Rows[0].Cells[0];

                    dataGridViewStudents.FirstDisplayedScrollingRowIndex = 0;
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
        // EDIT VISITOR
        // =========================================
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            // =========================================
            // CHECK ROW SELECTION
            // =========================================
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Visitor first.",
                    "Edit Visitor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET VISITOR ID FROM SELECTED ROW
                // =========================================
                object idValue =
                    dataGridViewStudents.SelectedRows[0]
                    .Cells["VisitorID"]
                    .Value;


                // =========================================
                // CHECK VISITOR ID
                // =========================================
                if (idValue == null ||
                    idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Visitor ID could not be found.",
                        "Edit Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int visitorID =
                    Convert.ToInt32(idValue);


                // =========================================
                // OPEN REGISTRATION FORM IN EDIT MODE
                // =========================================
                A_VisitorRegistrationForm form =
                    new A_VisitorRegistrationForm(visitorID);


                form.ShowDialog();


                // =========================================
                // RELOAD UPDATED DATABASE DATA
                // =========================================
                LoadVisitorData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Visitor for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Edit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // DELETE VISITOR
        // =========================================
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // =========================================
            // CHECK ROW SELECTION
            // =========================================
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Visitor first.",
                    "Delete Visitor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET VISITOR ID
                // =========================================
                object idValue =
                    dataGridViewStudents.SelectedRows[0]
                    .Cells["VisitorID"]
                    .Value;


                if (idValue == null ||
                    idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Visitor ID could not be found.",
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int visitorID =
                    Convert.ToInt32(idValue);


                // =========================================
                // CONFIRM DELETE
                // =========================================
                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete Visitor ID "
                        + visitorID + "?",
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
                    DELETE FROM Visitor
                    WHERE VisitorID = @VisitorID";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@VisitorID",
                            visitorID);


                        connection.Open();


                        int rows =
                            command.ExecuteNonQuery();


                        // =========================================
                        // DELETE SUCCESS
                        // =========================================
                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Visitor deleted successfully.",
                                "Delete Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                            // Reload database data
                            LoadVisitorData();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Visitor was not found.",
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
                    "Visitor deletion failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // VISITOR TITLE
        // =========================================
        private void lblVisitorTitle_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // SEARCH VISITOR ID LABEL
        // =========================================
        private void lblSearchVisitorID_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // SEARCH VISITOR ID TEXTBOX
        // =========================================
        private void txtSearchVisitorID_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // SEARCH STUDENT ID LABEL
        // =========================================
        private void lblSearchStudentID_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // SEARCH STUDENT ID TEXTBOX
        // =========================================
        private void txtSearchStudentID_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // HOSTEL CLICK
        // =========================================
        private void cmbHostel_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // HOSTEL COMBOBOX
        // =========================================
        private void comboBox2_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // SEARCH PANEL PAINT
        // =========================================
        private void pnlVisitorSearch_Paint(
            object sender,
            PaintEventArgs e)
        {
        }


        // =========================================
        // DATAGRIDVIEW CELL CLICK
        // =========================================
        private void dataGridViewStudents_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

       

        
    }
}