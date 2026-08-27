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
    public partial class A_StudentForm : UserControl
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // CONSTRUCTOR
        // =========================================


        public A_StudentForm()
        {
            InitializeComponent();
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }


        // =========================================
        // LOAD ALL STUDENT DATA
        // =========================================
        private void LoadStudentData()
        {
            try
            {
                dataGridViewStudents.AutoGenerateColumns = true;

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
                    ORDER BY StudentID ASC";


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
               // dataGridViewStudents.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load Student data.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // ADD STUDENT
        // =========================================
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            A_StudentRegistrationForm form =
                new A_StudentRegistrationForm();

            form.ShowDialog();

            // Reload database data
            LoadStudentData();
        }


        // =========================================
        // REGISTER STUDENT
        // =========================================
        private void btnRegister_Click(object sender, EventArgs e)
        {
            A_StudentRegistrationForm form =
                new A_StudentRegistrationForm();

            form.ShowDialog();

            // Reload database data
            LoadStudentData();
        }


        // =========================================
        // SEARCH STUDENT
        // =========================================
        private void searchapplybtn_Click(object sender, EventArgs e)
        {
            SearchStudent();
        }


        // =========================================
        // SEARCH STUDENT DATA
        // =========================================
        private void SearchStudent()
        {
            try
            {
                string searchText =
                    txtSearchStudentID.Text.Trim();


                // =========================================
                // EMPTY SEARCH
                // =========================================
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadStudentData();

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
                    WHERE
                        CAST(StudentID AS VARCHAR) LIKE @Search
                        OR StudentName LIKE @Search
                        OR Gender LIKE @Search
                        OR Phone LIKE @Search
                        OR Email LIKE @Search
                        OR Department LIKE @Search
                        OR HomeAddress LIKE @Search
                    ORDER BY
                        CASE
                            WHEN CAST(StudentID AS VARCHAR) = @ExactSearch THEN 0
                            WHEN StudentName = @ExactSearch THEN 1
                            WHEN Phone = @ExactSearch THEN 2
                            WHEN Email = @ExactSearch THEN 3
                            WHEN Department = @ExactSearch THEN 4
                            ELSE 5
                        END,
                        StudentID ASC";


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
                dataGridViewStudents.AutoGenerateColumns = true;
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
        // EDIT STUDENT
        // =========================================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // =========================================
            // CHECK ROW SELECTION
            // =========================================
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Student first.",
                    "Edit Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET STUDENT ID FROM SELECTED ROW
                // =========================================
                object idValue =
                    dataGridViewStudents.SelectedRows[0]
                    .Cells["StudentID"]
                    .Value;


                // =========================================
                // CHECK STUDENT ID
                // =========================================
                if (idValue == null ||
                    idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Student ID could not be found.",
                        "Edit Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int studentID =
                    Convert.ToInt32(idValue);


                // =========================================
                // OPEN REGISTRATION FORM IN EDIT MODE
                // =========================================
                A_StudentRegistrationForm form =
                    new A_StudentRegistrationForm(studentID);


                form.ShowDialog();


                // =========================================
                // RELOAD UPDATED DATABASE DATA
                // =========================================
                LoadStudentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Student for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Edit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // DELETE STUDENT
        // =========================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // =========================================
            // CHECK ROW SELECTION
            // =========================================
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Student first.",
                    "Delete Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET STUDENT ID
                // =========================================
                object idValue =
                    dataGridViewStudents.SelectedRows[0]
                    .Cells["StudentID"]
                    .Value;


                if (idValue == null ||
                    idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Student ID could not be found.",
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int studentID =
                    Convert.ToInt32(idValue);


                // =========================================
                // CONFIRM DELETE
                // =========================================
                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete Student ID "
                        + studentID + "?",
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
                    DELETE FROM StudentForm
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


                        int rows =
                            command.ExecuteNonQuery();


                        // =========================================
                        // DELETE SUCCESS
                        // =========================================
                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Student deleted successfully.",
                                "Delete Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                            // Reload database data
                            LoadStudentData();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Student was not found.",
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
                    "Student deletion failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // DATAGRIDVIEW CELL CLICK
        // =========================================
        private void dataGridViewStudents_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }


        // =========================================
        // STUDENT TITLE
        // =========================================
        private void lblStudentTitle_Click(
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
        // SEARCH TEXTBOX
        // =========================================
        private void txtSearchStudentID_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // DEPARTMENT CLICK
        // =========================================
        private void cmbDepartment_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // DEPARTMENT COMBOBOX
        // =========================================
        private void comboBox1_SelectedIndexChanged(
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
    }
}