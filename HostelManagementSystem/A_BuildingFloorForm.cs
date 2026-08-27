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
    public partial class A_BuildingFloorForm : UserControl
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // CONSTRUCTOR
        // =========================================
        public A_BuildingFloorForm()
        {
            InitializeComponent();
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_BuildingFloorForm_Load(object sender, EventArgs e)
        {
            LoadBuildingData();
        }


        // =========================================
        // LOAD ALL BUILDING / ROOM / BED DATA
        // =========================================
        private void LoadBuildingData()
        {
            try
            {
                dataGridView2.AutoGenerateColumns = true;

                string query = @"
    SELECT
        SerialNumber,
        FloorNumber,
        RoomNumber,
        RoomType,
        Status,
        BedNumber,
        BedType,
        StudentName AS NameStudent,
        StudentID AS idstudent
    FROM BuildingForm
    ORDER BY SerialNumber ASC";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dataGridView2.AutoGenerateColumns = true;
                        dataGridView2.DataSource = table;
                    }
                }


                // =========================================
                // DATAGRIDVIEW SETTINGS
                // =========================================
                dataGridView2.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridView2.MultiSelect = false;

                dataGridView2.ReadOnly = true;

                dataGridView2.AllowUserToAddRows = false;

                dataGridView2.AutoGenerateColumns = true;


                // =========================================
                // CHANGE HEADER TEXT
                // =========================================
                if (dataGridView2.Columns.Contains("SerialNumber"))
                {
                    dataGridView2.Columns["SerialNumber"].HeaderText =
                        "Serial Number";
                }

                if (dataGridView2.Columns.Contains("FloorNumber"))
                {
                    dataGridView2.Columns["FloorNumber"].HeaderText =
                        "Floor Number";
                }

                if (dataGridView2.Columns.Contains("RoomNumber"))
                {
                    dataGridView2.Columns["RoomNumber"].HeaderText =
                        "Room Number";
                }

                if (dataGridView2.Columns.Contains("RoomType"))
                {
                    dataGridView2.Columns["RoomType"].HeaderText =
                        "Room Type";
                }

                if (dataGridView2.Columns.Contains("Status"))
                {
                    dataGridView2.Columns["Status"].HeaderText =
                        "Status";
                }

                if (dataGridView2.Columns.Contains("BedNumber"))
                {
                    dataGridView2.Columns["BedNumber"].HeaderText =
                        "Bed Number";
                }

                if (dataGridView2.Columns.Contains("BedType"))
                {
                    dataGridView2.Columns["BedType"].HeaderText =
                        "Bed Type";
                }

                if (dataGridView2.Columns.Contains("StudentName"))
                {
                    dataGridView2.Columns["StudentName"].HeaderText =
                        "Name Student";
                }

                if (dataGridView2.Columns.Contains("StudentID"))
                {
                    dataGridView2.Columns["StudentID"].HeaderText =
                        "Student ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load Building data.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // REGISTER ROOM / BED
        // =========================================
        private void btnregisterroom_Click(object sender, EventArgs e)
        {
            A_BuildingRegistrationForm form =
                new A_BuildingRegistrationForm();

            form.ShowDialog();

            // Reload database data
            LoadBuildingData();
        }


        // =========================================
        // DELETE ROOM / BED
        // =========================================
        private void btnDeleteroom_Click(object sender, EventArgs e)
        {
            // =========================================
            // CHECK ROW SELECTION
            // =========================================
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a room or bed first.",
                    "Delete Room",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET SERIAL NUMBER
                // =========================================
                object serialValue =
                    dataGridView2.SelectedRows[0]
                    .Cells["SerialNumber"]
                    .Value;


                // =========================================
                // CHECK SERIAL NUMBER
                // =========================================
                if (serialValue == null ||
                    serialValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Serial Number could not be found.",
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int serialNumber =
                    Convert.ToInt32(serialValue);


                // =========================================
                // CONFIRM DELETE
                // =========================================
                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete Serial Number "
                        + serialNumber + "?",
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
                    DELETE FROM BuildingForm
                    WHERE SerialNumber = @SerialNumber";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@SerialNumber",
                            serialNumber);


                        connection.Open();


                        int rows =
                            command.ExecuteNonQuery();


                        // =========================================
                        // DELETE SUCCESS
                        // =========================================
                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Room / Bed information deleted successfully.",
                                "Delete Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                            // Reload database data
                            LoadBuildingData();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Room / Bed information was not found.",
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
                    "Room / Bed deletion failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // EDIT ROOM / BED
        // =========================================
        private void btnEditroom_Click(object sender, EventArgs e)
        {
            // =========================================
            // CHECK ROW SELECTION
            // =========================================
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a room or bed first.",
                    "Edit Room",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // =========================================
                // GET SERIAL NUMBER
                // =========================================
                object serialValue =
                    dataGridView2.SelectedRows[0]
                    .Cells["SerialNumber"]
                    .Value;

                // =========================================
                // CHECK SERIAL NUMBER
                // =========================================
                if (serialValue == null ||
                    serialValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Serial Number could not be found.",
                        "Edit Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                int serialNumber =
                    Convert.ToInt32(serialValue);

                // =========================================
                // OPEN EDIT FORM
                // =========================================
                A_BuildingRegistrationForm form =
                    new A_BuildingRegistrationForm(serialNumber);

                form.ShowDialog();

                // =========================================
                // RELOAD GRID AFTER EDIT
                // =========================================
                LoadBuildingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open room for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Edit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SEARCH ROOM / BED
        // =========================================
        private void btnsearch_Click(object sender, EventArgs e)
        {
            SearchBuilding();
        }


        // =========================================
        // SEARCH BUILDING DATA
        // =========================================
        private void SearchBuilding()
        {
            try
            {
                string roomSearch =
                    txtroomid.Text.Trim();

                string bedSearch =
                    txtbednumber.Text.Trim();

                string studentSearch =
                    txtidstudent.Text.Trim();


                // =========================================
                // EMPTY SEARCH
                // =========================================
                if (string.IsNullOrWhiteSpace(roomSearch) &&
                    string.IsNullOrWhiteSpace(bedSearch) &&
                    string.IsNullOrWhiteSpace(studentSearch))
                {
                    LoadBuildingData();

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
        SerialNumber,
        FloorNumber,
        RoomNumber,
        RoomType,
        Status,
        BedNumber,
        BedType,
        StudentName AS NameStudent,
        StudentID AS idstudent
                    FROM BuildingForm
                    WHERE
                        (@RoomSearch = '' OR RoomNumber LIKE @Room)
                        AND
                        (@BedSearch = '' OR BedNumber LIKE @Bed)
                        AND
                        (@StudentSearch = '' OR
                         CAST(StudentID AS VARCHAR) LIKE @Student)
                    ORDER BY SerialNumber ASC";


                DataTable table =
                    new DataTable();


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@RoomSearch",
                            roomSearch);

                        command.Parameters.AddWithValue(
                            "@Room",
                            "%" + roomSearch + "%");


                        command.Parameters.AddWithValue(
                            "@BedSearch",
                            bedSearch);

                        command.Parameters.AddWithValue(
                            "@Bed",
                            "%" + bedSearch + "%");


                        command.Parameters.AddWithValue(
                            "@StudentSearch",
                            studentSearch);

                        command.Parameters.AddWithValue(
                            "@Student",
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
                    dataGridView2.DataSource = null;

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
                dataGridView2.AutoGenerateColumns = true;

                dataGridView2.DataSource = table;

                dataGridView2.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridView2.MultiSelect = false;

                dataGridView2.ReadOnly = true;

                dataGridView2.AllowUserToAddRows = false;


                // =========================================
                // HEADER TEXT
                // =========================================
                if (dataGridView2.Columns.Contains("SerialNumber"))
                {
                    dataGridView2.Columns["SerialNumber"].HeaderText =
                        "Serial Number";
                }

                if (dataGridView2.Columns.Contains("FloorNumber"))
                {
                    dataGridView2.Columns["FloorNumber"].HeaderText =
                        "Floor Number";
                }

                if (dataGridView2.Columns.Contains("RoomNumber"))
                {
                    dataGridView2.Columns["RoomNumber"].HeaderText =
                        "Room Number";
                }

                if (dataGridView2.Columns.Contains("RoomType"))
                {
                    dataGridView2.Columns["RoomType"].HeaderText =
                        "Room Type";
                }

                if (dataGridView2.Columns.Contains("Status"))
                {
                    dataGridView2.Columns["Status"].HeaderText =
                        "Status";
                }

                if (dataGridView2.Columns.Contains("BedNumber"))
                {
                    dataGridView2.Columns["BedNumber"].HeaderText =
                        "Bed Number";
                }

                if (dataGridView2.Columns.Contains("BedType"))
                {
                    dataGridView2.Columns["BedType"].HeaderText =
                        "Bed Type";
                }

                if (dataGridView2.Columns.Contains("StudentName"))
                {
                    dataGridView2.Columns["StudentName"].HeaderText =
                        "Name Student";
                }

                if (dataGridView2.Columns.Contains("StudentID"))
                {
                    dataGridView2.Columns["StudentID"].HeaderText =
                        "Student ID";
                }


                // =========================================
                // SELECT FIRST SEARCH RESULT
                // =========================================
                dataGridView2.ClearSelection();

                if (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.Rows[0].Selected = true;

                    dataGridView2.CurrentCell =
                        dataGridView2.Rows[0].Cells[0];

                    dataGridView2.FirstDisplayedScrollingRowIndex = 0;
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
        // ROOM NUMBER LABEL
        // =========================================
        private void lblroomnumber_Click(object sender, EventArgs e)
        {
        }


        // =========================================
        // ROOM NUMBER SEARCH TEXTBOX
        // =========================================
        private void txtroomid_TextChanged(object sender, EventArgs e)
        {
        }


        // =========================================
        // BED NUMBER LABEL
        // =========================================
        private void lblbednumber_Click(object sender, EventArgs e)
        {
        }


        // =========================================
        // BED NUMBER SEARCH TEXTBOX
        // =========================================
        private void txtbednumber_TextChanged(object sender, EventArgs e)
        {
        }


        // =========================================
        // STUDENT ID LABEL
        // =========================================
        private void lblidstudent_Click(object sender, EventArgs e)
        {
        }


        // =========================================
        // STUDENT ID SEARCH TEXTBOX
        // =========================================
        private void txtidstudent_TextChanged(object sender, EventArgs e)
        {
        }


        // =========================================
        // PANEL PAINT
        // =========================================
        private void buildingsearchpnl_Paint(
            object sender,
            PaintEventArgs e)
        {
        }


        // =========================================
        // DATAGRIDVIEW CELL CLICK
        // =========================================
        private void dataGridView2_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }


        // =========================================
        // TITLE
        // =========================================
        private void lblGuardianTitle_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}