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
    public partial class A_BuildingRegistrationForm : Form
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

        private int editSerialNumber = 0;


        // =========================================
        // ADD MODE CONSTRUCTOR
        // =========================================

        public A_BuildingRegistrationForm()
        {
            InitializeComponent();
        }


        // =========================================
        // EDIT MODE CONSTRUCTOR
        // =========================================

        public A_BuildingRegistrationForm(int serialNumber)
        {
            InitializeComponent();

            editSerialNumber = serialNumber;
        }


        // =========================================
        // FORM LOAD
        // =========================================

        private void A_BuildingRegistrationForm_Load(object sender, EventArgs e)
        {
            // EDITABLE CONTROLS
            // =========================================

            cmbFloorID.Enabled = true;
            cmbRoomID.Enabled = true;
            cmbRoomType.Enabled = true;
            cmbstatus.Enabled = true;
            cmbBedNumber.Enabled = true;
            cmbBedType.Enabled = true;

            txtStudentName.ReadOnly = false;
            txtStudentid.ReadOnly = false;

            // =========================================
            // EDIT MODE
            // =========================================

            if (editSerialNumber > 0)
            {
                LoadBuildingDataForEdit(editSerialNumber);
            }
            else
            {
                // =========================================
                // ADD MODE
                // =========================================

                ClearBuildingInformation();
            }
        }


        // =========================================
        // LOAD SELECTED RECORD FOR EDIT
        // =========================================

        private void LoadBuildingDataForEdit(int serialNumber)
        {
            try
            {
                string query = @"
                    SELECT
                        SerialNumber,
                        FloorNumber,
                        RoomNumber,
                        RoomType,
                        Status,
                        BedNumber,
                        BedType,
                        StudentName,
                        StudentID
                    FROM BuildingForm
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


                        using (SqlDataReader reader =
                               command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // =========================================
                                // FLOOR NUMBER
                                // =========================================

                                cmbFloorID.Text =
                                    reader["FloorNumber"] == DBNull.Value
                                        ? ""
                                        : reader["FloorNumber"].ToString();


                                // =========================================
                                // ROOM NUMBER
                                // =========================================

                                cmbRoomID.Text =
                                    reader["RoomNumber"] == DBNull.Value
                                        ? ""
                                        : reader["RoomNumber"].ToString();


                                // =========================================
                                // ROOM TYPE
                                // =========================================

                                cmbRoomType.Text =
                                    reader["RoomType"] == DBNull.Value
                                        ? ""
                                        : reader["RoomType"].ToString();


                                // =========================================
                                // STATUS
                                // =========================================

                                cmbstatus.Text =
                                    reader["Status"] == DBNull.Value
                                        ? ""
                                        : reader["Status"].ToString();


                                // =========================================
                                // BED NUMBER
                                // =========================================

                                cmbBedNumber.Text =
                                    reader["BedNumber"] == DBNull.Value
                                        ? ""
                                        : reader["BedNumber"].ToString();


                                // =========================================
                                // BED TYPE
                                // =========================================

                                cmbBedType.Text =
                                    reader["BedType"] == DBNull.Value
                                        ? ""
                                        : reader["BedType"].ToString();


                                // =========================================
                                // STUDENT NAME
                                // =========================================

                                txtStudentName.Text =
                                    reader["StudentName"] == DBNull.Value
                                        ? ""
                                        : reader["StudentName"].ToString();


                                // =========================================
                                // STUDENT ID
                                // =========================================

                                txtStudentid.Text =
                                    reader["StudentID"] == DBNull.Value
                                        ? ""
                                        : reader["StudentID"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Building/Bed data not found.",
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
                    "Could not load Building/Bed data for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // REGISTER / UPDATE
        // =========================================

        private void btnRegisterStudentbed_Click(object sender, EventArgs e)
        {
            // =========================================
            // FLOOR VALIDATION
            // =========================================

            if (string.IsNullOrWhiteSpace(cmbFloorID.Text))
            {
                MessageBox.Show(
                    "Please select Floor Number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbFloorID.Focus();
                return;
            }


            // =========================================
            // ROOM NUMBER VALIDATION
            // =========================================

            if (string.IsNullOrWhiteSpace(cmbRoomID.Text))
            {
                MessageBox.Show(
                    "Please select Room Number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbRoomID.Focus();
                return;
            }


            // =========================================
            // ROOM TYPE VALIDATION
            // =========================================

            if (string.IsNullOrWhiteSpace(cmbRoomType.Text))
            {
                MessageBox.Show(
                    "Please select Room Type.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbRoomType.Focus();
                return;
            }


            // =========================================
            // STATUS VALIDATION
            // =========================================

            if (string.IsNullOrWhiteSpace(cmbstatus.Text))
            {
                MessageBox.Show(
                    "Please select Status.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbstatus.Focus();
                return;
            }


            // =========================================
            // BED NUMBER VALIDATION
            // =========================================

            if (string.IsNullOrWhiteSpace(cmbBedNumber.Text))
            {
                MessageBox.Show(
                    "Please select Bed Number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbBedNumber.Focus();
                return;
            }


            // =========================================
            // BED TYPE VALIDATION
            // =========================================

            if (string.IsNullOrWhiteSpace(cmbBedType.Text))
            {
                MessageBox.Show(
                    "Please select Bed Type.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbBedType.Focus();
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

                    if (editSerialNumber > 0)
                    {
                        string updateQuery = @"
                            UPDATE BuildingForm
                            SET
                                FloorNumber = @FloorNumber,
                                RoomNumber = @RoomNumber,
                                RoomType = @RoomType,
                                Status = @Status,
                                BedNumber = @BedNumber,
                                BedType = @BedType,
                                StudentName = @StudentName,
                                StudentID = @StudentID
                            WHERE SerialNumber = @SerialNumber";


                        using (SqlCommand command =
                               new SqlCommand(updateQuery, connection))
                        {
                            // =========================================
                            // SERIAL NUMBER
                            // =========================================

                            command.Parameters.AddWithValue(
                                "@SerialNumber",
                                editSerialNumber);


                            // =========================================
                            // FLOOR NUMBER
                            // =========================================

                            command.Parameters.AddWithValue(
                                "@FloorNumber",
                                cmbFloorID.Text.Trim());


                            // =========================================
                            // ROOM NUMBER
                            // =========================================

                            command.Parameters.AddWithValue(
                                "@RoomNumber",
                                cmbRoomID.Text.Trim());


                            // =========================================
                            // ROOM TYPE
                            // =========================================

                            command.Parameters.AddWithValue(
                                "@RoomType",
                                cmbRoomType.Text.Trim());


                            // =========================================
                            // STATUS
                            // =========================================

                            command.Parameters.AddWithValue(
                                "@Status",
                                cmbstatus.Text.Trim());


                            // =========================================
                            // BED NUMBER
                            // =========================================

                            command.Parameters.AddWithValue(
                                "@BedNumber",
                                cmbBedNumber.Text.Trim());


                            // =========================================
                            // BED TYPE
                            // =========================================

                            command.Parameters.AddWithValue(
                                "@BedType",
                                cmbBedType.Text.Trim());


                            // =========================================
                            // STUDENT NAME
                            // =========================================

                            command.Parameters.AddWithValue(
                                "@StudentName",
                                string.IsNullOrWhiteSpace(txtStudentName.Text)
                                    ? (object)DBNull.Value
                                    : txtStudentName.Text.Trim());


                            // =========================================
                            // STUDENT ID
                            // =========================================

                            command.Parameters.AddWithValue(
                                "@StudentID",
                                string.IsNullOrWhiteSpace(txtStudentid.Text)
                                    ? (object)DBNull.Value
                                    : txtStudentid.Text.Trim());


                            // =========================================
                            // EXECUTE UPDATE
                            // =========================================

                            int rows =
                                command.ExecuteNonQuery();


                            if (rows > 0)
                            {
                                MessageBox.Show(
                                    "Room/Bed information updated successfully!\n\n" +
                                    "Serial Number: " + editSerialNumber,
                                    "Update Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Room/Bed record was not found.",
                                    "Update Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }


                        // =========================================
                        // DO NOT INSERT AFTER EDIT
                        // =========================================

                        return;
                    }


                    // =========================================
                    // ADD MODE - INSERT NEW RECORD
                    // =========================================

                    string insertQuery = @"
                        INSERT INTO BuildingForm
                        (
                            FloorNumber,
                            RoomNumber,
                            RoomType,
                            Status,
                            BedNumber,
                            BedType,
                            StudentName,
                            StudentID
                        )
                        OUTPUT INSERTED.SerialNumber
                        VALUES
                        (
                            @FloorNumber,
                            @RoomNumber,
                            @RoomType,
                            @Status,
                            @BedNumber,
                            @BedType,
                            @StudentName,
                            @StudentID
                        )";


                    using (SqlCommand command =
                           new SqlCommand(insertQuery, connection))
                    {
                        // =========================================
                        // FLOOR NUMBER
                        // =========================================

                        command.Parameters.AddWithValue(
                            "@FloorNumber",
                            cmbFloorID.Text.Trim());


                        // =========================================
                        // ROOM NUMBER
                        // =========================================

                        command.Parameters.AddWithValue(
                            "@RoomNumber",
                            cmbRoomID.Text.Trim());


                        // =========================================
                        // ROOM TYPE
                        // =========================================

                        command.Parameters.AddWithValue(
                            "@RoomType",
                            cmbRoomType.Text.Trim());


                        // =========================================
                        // STATUS
                        // =========================================

                        command.Parameters.AddWithValue(
                            "@Status",
                            cmbstatus.Text.Trim());


                        // =========================================
                        // BED NUMBER
                        // =========================================

                        command.Parameters.AddWithValue(
                            "@BedNumber",
                            cmbBedNumber.Text.Trim());


                        // =========================================
                        // BED TYPE
                        // =========================================

                        command.Parameters.AddWithValue(
                            "@BedType",
                            cmbBedType.Text.Trim());


                        // =========================================
                        // STUDENT NAME
                        // =========================================

                        command.Parameters.AddWithValue(
                            "@StudentName",
                            string.IsNullOrWhiteSpace(txtStudentName.Text)
                                ? (object)DBNull.Value
                                : txtStudentName.Text.Trim());


                        // =========================================
                        // STUDENT ID
                        // =========================================

                        command.Parameters.AddWithValue(
                            "@StudentID",
                            string.IsNullOrWhiteSpace(txtStudentid.Text)
                                ? (object)DBNull.Value
                                : txtStudentid.Text.Trim());


                        // =========================================
                        // INSERT
                        // SQL SERVER GENERATES SerialNumber
                        // =========================================

                        int generatedSerialNumber =
                            Convert.ToInt32(
                                command.ExecuteScalar());


                        MessageBox.Show(
                            "Room/Bed registered successfully!\n\n" +
                            "Serial Number: " + generatedSerialNumber,
                            "Registration Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }


                // =========================================
                // CLEAR AFTER REGISTRATION
                // =========================================

                ClearBuildingInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Room/Bed registration failed.\n\n" +
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
            ClearBuildingInformation();
        }


        // =========================================
        // CLEAR ALL INFORMATION
        // =========================================

        private void ClearBuildingInformation()
        {
            cmbFloorID.SelectedIndex = -1;

            cmbRoomID.SelectedIndex = -1;

            cmbRoomType.SelectedIndex = -1;

            cmbstatus.SelectedIndex = -1;

            cmbBedNumber.SelectedIndex = -1;

            cmbBedType.SelectedIndex = -1;

            txtStudentName.Clear();

            txtStudentid.Clear();

            cmbFloorID.Focus();
        }


        // =========================================
        // DESIGNER EVENTS
        // =========================================

        private void lblbedregistration_Click(object sender, EventArgs e)
        {
        }

        private void lblFloorNumber_Click(object sender, EventArgs e)
        {
        }

        private void cmbFloorID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblRoomID_Click(object sender, EventArgs e)
        {
        }

        private void cmbRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblRoomType_Click(object sender, EventArgs e)
        {
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {
        }

        private void cmbBedNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BedType_Click(object sender, EventArgs e)
        {
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
        }

        private void StudentIDlbl_Click(object sender, EventArgs e)
        {
        }

        private void txtStudentid_TextChanged(object sender, EventArgs e)
        {
        }
    }
}