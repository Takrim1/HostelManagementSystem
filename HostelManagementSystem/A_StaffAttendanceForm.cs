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
    public partial class A_StaffAttendanceForm : UserControl
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // EDIT MODE
        // 0 = ADD MODE
        // > 0 = EDIT MODE
        // =========================================
        private int editAttendanceID = 0;


        // =========================================
        // CONSTRUCTOR
        // =========================================
        public A_StaffAttendanceForm()
        {
            InitializeComponent();
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_StaffAttendanceForm_Load(object sender, EventArgs e)
        {
            // Staff ID can be entered
            txtStaffID.ReadOnly = false;

            // Staff Name will come automatically
            txtStaffNamel.ReadOnly = true;

            // Load attendance data
            LoadAttendanceData();

            // Default date
            dateTimePicker1.Value = DateTime.Today;

            // Clear edit mode
            editAttendanceID = 0;

            // Default button text
            btnAttendance.Text = "Attendance";
        }


        // =========================================
        // LOAD ALL ATTENDANCE DATA
        // =========================================
        private void LoadAttendanceData()
        {
            try
            {
                string query = @"
                    SELECT
                        AttendanceID,
                        StaffID,
                        StaffName,
                        Status,
                        Date
                    FROM StaffAttendance
                    ORDER BY Date DESC, AttendanceID DESC";


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


                // =========================================
                // HIDE ATTENDANCE ID
                // =========================================
                if (dataGridView1.Columns.Contains("AttendanceID"))
                {
                    dataGridView1.Columns["AttendanceID"].Visible = false;
                }


                // =========================================
                // COLUMN HEADERS
                // =========================================
                if (dataGridView1.Columns.Contains("StaffID"))
                {
                    dataGridView1.Columns["StaffID"].HeaderText =
                        "Staff ID";
                }

                if (dataGridView1.Columns.Contains("StaffName"))
                {
                    dataGridView1.Columns["StaffName"].HeaderText =
                        "Staff Name";
                }

                if (dataGridView1.Columns.Contains("Status"))
                {
                    dataGridView1.Columns["Status"].HeaderText =
                        "Status";
                }

                if (dataGridView1.Columns.Contains("Date"))
                {
                    dataGridView1.Columns["Date"].HeaderText =
                        "Date";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load Staff Attendance data.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // GET STAFF NAME BY STAFF ID
        // =========================================
        private bool LoadStaffName()
        {
            try
            {
                string staffIDText =
                    txtStaffID.Text.Trim();


                if (string.IsNullOrWhiteSpace(staffIDText))
                {
                    txtStaffNamel.Clear();
                    return false;
                }


                int staffID;

                if (!int.TryParse(staffIDText, out staffID))
                {
                    txtStaffNamel.Clear();

                    MessageBox.Show(
                        "Please enter a valid Staff ID.",
                        "Staff ID Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtStaffID.Focus();
                    return false;
                }


                string query = @"
                    SELECT StaffName
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


                        object result =
                            command.ExecuteScalar();


                        if (result == null ||
                            result == DBNull.Value)
                        {
                            txtStaffNamel.Clear();

                            MessageBox.Show(
                                "Staff ID " + staffID +
                                " was not found.",
                                "Staff Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtStaffID.Focus();

                            return false;
                        }


                        txtStaffNamel.Text =
                            result.ToString();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not find Staff.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }


        // =========================================
        // STAFF ID TEXT CHANGED
        // =========================================
        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            // Do not automatically show MessageBox while typing.
            // Staff name will be loaded when Attendance button is clicked.
        }


        // =========================================
        // SAVE / UPDATE ATTENDANCE
        // =========================================
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            // =========================================
            // STAFF ID VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtStaffID.Text))
            {
                MessageBox.Show(
                    "Please enter Staff ID.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStaffID.Focus();
                return;
            }


            int staffID;

            if (!int.TryParse(
                    txtStaffID.Text.Trim(),
                    out staffID))
            {
                MessageBox.Show(
                    "Please enter a valid Staff ID.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStaffID.Focus();
                return;
            }


            // =========================================
            // STATUS VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show(
                    "Please select Attendance Status.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboBox1.Focus();
                return;
            }


            // =========================================
            // GET STAFF NAME
            // =========================================
            if (!LoadStaffName())
            {
                return;
            }


            string staffName =
                txtStaffNamel.Text.Trim();

            string status =
                comboBox1.Text.Trim();

            DateTime attendanceDate =
                dateTimePicker1.Value.Date;


            try
            {
                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    connection.Open();


                    // =========================================
                    // EDIT MODE
                    // =========================================
                    if (editAttendanceID > 0)
                    {
                        string updateQuery = @"
                            UPDATE StaffAttendance
                            SET
                                StaffID = @StaffID,
                                StaffName = @StaffName,
                                Status = @Status,
                                Date = @Date
                            WHERE AttendanceID = @AttendanceID";


                        using (SqlCommand command =
                               new SqlCommand(
                                   updateQuery,
                                   connection))
                        {
                            command.Parameters.AddWithValue(
                                "@AttendanceID",
                                editAttendanceID);

                            command.Parameters.AddWithValue(
                                "@StaffID",
                                staffID);

                            command.Parameters.AddWithValue(
                                "@StaffName",
                                staffName);

                            command.Parameters.AddWithValue(
                                "@Status",
                                status);

                            command.Parameters.AddWithValue(
                                "@Date",
                                attendanceDate);


                            int rows =
                                command.ExecuteNonQuery();


                            if (rows > 0)
                            {
                                MessageBox.Show(
                                    "Staff attendance updated successfully!\n\n" +
                                    "Staff ID: " + staffID +
                                    "\nStaff Name: " + staffName +
                                    "\nStatus: " + status +
                                    "\nDate: " +
                                    attendanceDate.ToString("dd-MM-yyyy"),
                                    "Update Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);


                                // Reset edit mode
                                editAttendanceID = 0;

                                btnAttendance.Text =
                                    "Attendance";


                                // Clear form
                                ClearAttendanceInformation();


                                // Reload GridView
                                LoadAttendanceData();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Attendance record was not found.",
                                    "Update Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }


                        // IMPORTANT:
                        // Edit mode ends here.
                        // INSERT will NOT execute.
                        return;
                    }


                    // =========================================
                    // ADD MODE
                    // =========================================

                    // Check duplicate attendance
                    // for same Staff + same Date
                    string checkQuery = @"
                        SELECT COUNT(*)
                        FROM StaffAttendance
                        WHERE StaffID = @StaffID
                        AND Date = @Date";


                    using (SqlCommand checkCommand =
                           new SqlCommand(
                               checkQuery,
                               connection))
                    {
                        checkCommand.Parameters.AddWithValue(
                            "@StaffID",
                            staffID);

                        checkCommand.Parameters.AddWithValue(
                            "@Date",
                            attendanceDate);


                        int existingCount =
                            Convert.ToInt32(
                                checkCommand.ExecuteScalar());


                        if (existingCount > 0)
                        {
                            MessageBox.Show(
                                "Attendance for this Staff on this Date already exists.",
                                "Duplicate Attendance",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }


                    // =========================================
                    // INSERT NEW ATTENDANCE
                    // =========================================
                    string insertQuery = @"
                        INSERT INTO StaffAttendance
                        (
                            StaffID,
                            StaffName,
                            Status,
                            Date
                        )
                        VALUES
                        (
                            @StaffID,
                            @StaffName,
                            @Status,
                            @Date
                        )";


                    using (SqlCommand command =
                           new SqlCommand(
                               insertQuery,
                               connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StaffID",
                            staffID);

                        command.Parameters.AddWithValue(
                            "@StaffName",
                            staffName);

                        command.Parameters.AddWithValue(
                            "@Status",
                            status);

                        command.Parameters.AddWithValue(
                            "@Date",
                            attendanceDate);


                        command.ExecuteNonQuery();


                        MessageBox.Show(
                            "Staff attendance saved successfully!\n\n" +
                            "Staff ID: " + staffID +
                            "\nStaff Name: " + staffName +
                            "\nStatus: " + status +
                            "\nDate: " +
                            attendanceDate.ToString("dd-MM-yyyy"),
                            "Attendance Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }


                // =========================================
                // CLEAR AFTER NEW ATTENDANCE
                // =========================================
                ClearAttendanceInformation();

                // =========================================
                // RELOAD GRID
                // =========================================
                LoadAttendanceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Attendance operation failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // EDIT ATTENDANCE
        // =========================================
        private void btneditattendance_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select an Attendance record first.",
                    "Edit Attendance",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                object idValue =
                    dataGridView1.SelectedRows[0]
                    .Cells["AttendanceID"]
                    .Value;

                if (idValue == null || idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Attendance ID could not be found.",
                        "Edit Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                editAttendanceID = Convert.ToInt32(idValue);

                txtStaffID.Text =
                    dataGridView1.SelectedRows[0]
                    .Cells["StaffID"]
                    .Value.ToString();

                txtStaffNamel.Text =
                    dataGridView1.SelectedRows[0]
                    .Cells["StaffName"]
                    .Value.ToString();

                comboBox1.Text =
                    dataGridView1.SelectedRows[0]
                    .Cells["Status"]
                    .Value.ToString();

                dateTimePicker1.Value =
                    Convert.ToDateTime(
                        dataGridView1.SelectedRows[0]
                        .Cells["Date"]
                        .Value);

                btnAttendance.Text = "Update Attendance";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load Attendance for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Edit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SEARCH STAFF ATTENDANCE
        // =========================================
        private void txtStaffIdSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            SearchAttendance();
        }


        private void SearchAttendance()
        {
            try
            {
                string searchText =
                    txtStaffIdSearch.Text.Trim();


                // =========================================
                // EMPTY SEARCH
                // =========================================
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadAttendanceData();
                    return;
                }


                string query = @"
                    SELECT
                        AttendanceID,
                        StaffID,
                        StaffName,
                        Status,
                        Date
                    FROM StaffAttendance
                    WHERE
                        CAST(StaffID AS VARCHAR) LIKE @Search
                        OR StaffName LIKE @Search
                        OR Status LIKE @Search
                    ORDER BY
                        Date DESC,
                        AttendanceID DESC";


                DataTable table =
                    new DataTable();


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(
                               query,
                               connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Search",
                            "%" + searchText + "%");


                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }


                dataGridView1.DataSource =
                    table;


                // =========================================
                // DATAGRIDVIEW SETTINGS
                // =========================================
                dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.MultiSelect = false;

                dataGridView1.ReadOnly = true;

                dataGridView1.AllowUserToAddRows = false;


                // =========================================
                // HIDE ATTENDANCE ID
                // =========================================
                if (dataGridView1.Columns.Contains(
                    "AttendanceID"))
                {
                    dataGridView1.Columns[
                        "AttendanceID"].Visible = false;
                }


                // =========================================
                // NO DATA
                // =========================================
                if (table.Rows.Count == 0)
                {
                    dataGridView1.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Attendance search failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // CLEAR ATTENDANCE INFORMATION
        // =========================================
        private void ClearAttendanceInformation()
        {
            txtStaffID.Clear();

            txtStaffNamel.Clear();

            comboBox1.SelectedIndex = -1;

            dateTimePicker1.Value =
                DateTime.Today;

            editAttendanceID = 0;

            btnAttendance.Text =
                "Attendance";

            txtStaffID.Focus();
        }


        // =========================================
        // STAFF ID LABEL
        // =========================================
        private void lblStaffId_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // STAFF NAME TEXT CHANGED
        // =========================================
        private void txtStaffNamel_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // STAFF NAME LABEL
        // =========================================
        private void lblaStaffName_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // STATUS LABEL
        // =========================================
        private void lblstatus_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // STATUS COMBOBOX
        // =========================================
        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // DATE LABEL
        // =========================================
        private void lbldate_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // DATE PICKER
        // =========================================
        private void dateTimePicker1_ValueChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================
        // SEARCH PANEL
        // =========================================
        private void pnlStaffSearch_Paint(
            object sender,
            PaintEventArgs e)
        {
        }


        // =========================================
        // SEARCH LABEL
        // =========================================
        private void lblSearchSatffID_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}