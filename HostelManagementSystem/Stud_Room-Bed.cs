using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class Stud_Room_Bed : UserControl
    {
        private readonly string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // Logged-in Student ID
        private string studentID = "";

        // =========================================
        // DEFAULT CONSTRUCTOR
        // =========================================

        public Stud_Room_Bed()
        {
            InitializeComponent();
        }

        // =========================================
        // STUDENT ID CONSTRUCTOR
        // =========================================

        public Stud_Room_Bed(string loggedInStudentID)
        {
            InitializeComponent();

            studentID = loggedInStudentID;
        }

        // =========================================
        // LOAD
        // =========================================

        private void Stud_Room_Bed_Load(object sender, EventArgs e)
        {
            LoadRoomBedInfo();
        }

        // =========================================
        // LOAD ROOM BED INFO
        // =========================================

        private void LoadRoomBedInfo()
        {
            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    string query;

                    // =========================================
                    // IF STUDENT ID IS AVAILABLE
                    // =========================================

                    if (!string.IsNullOrWhiteSpace(studentID))
                    {
                        query = @"
                            SELECT TOP 1
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
                            WHERE CAST(StudentID AS VARCHAR(50)) = @StudentID
                            ORDER BY SerialNumber DESC";
                    }
                    else
                    {
                        // =========================================
                        // NO STUDENT ID PASSED
                        // SHOW LAST ASSIGNED STUDENT RECORD
                        // =========================================

                        query = @"
                            SELECT TOP 1
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
                            WHERE StudentID IS NOT NULL
                            ORDER BY SerialNumber DESC";
                    }

                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        if (!string.IsNullOrWhiteSpace(studentID))
                        {
                            cmd.Parameters.AddWithValue(
                                "@StudentID",
                                studentID.Trim());
                        }

                        con.Open();

                        using (SqlDataReader reader =
                               cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // =====================================
                                // FLOOR NUMBER
                                // =====================================

                                lblFloor.Text =
                                    reader["FloorNumber"] == DBNull.Value
                                    ? ""
                                    : reader["FloorNumber"].ToString();


                                // =====================================
                                // ROOM NUMBER
                                // =====================================

                                lblsroomnumber.Text =
                                    reader["RoomNumber"] == DBNull.Value
                                    ? ""
                                    : reader["RoomNumber"].ToString();

                                // =====================================
                                // ROOM TYPE
                                // =====================================

                                lblsroomtype.Text =
                                    reader["RoomType"] == DBNull.Value
                                    ? ""
                                    : reader["RoomType"].ToString();

                                // =====================================
                                // STATUS
                                // =====================================

                                lblsStatus.Text =
                                    reader["Status"] == DBNull.Value
                                    ? ""
                                    : reader["Status"].ToString();

                                // =====================================
                                // BED NUMBER
                                // =====================================

                                lblsbednumber.Text =
                                    reader["BedNumber"] == DBNull.Value
                                    ? ""
                                    : reader["BedNumber"].ToString();

                                // =====================================
                                // BED TYPE
                                // =====================================

                                lblsbedtype.Text =
                                    reader["BedType"] == DBNull.Value
                                    ? ""
                                    : reader["BedType"].ToString();

                                // =====================================
                                // STUDENT NAME
                                // =====================================

                                lblsStudentname.Text =
                                    reader["StudentName"] == DBNull.Value
                                    ? ""
                                    : reader["StudentName"].ToString();

                                // =====================================
                                // STUDENT ID
                                // =====================================

                                lblsstudentid.Text =
                                    reader["StudentID"] == DBNull.Value
                                    ? ""
                                    : reader["StudentID"].ToString();
                            }
                            else
                            {
                                ClearRoomBedLabels();

                                MessageBox.Show(
                                    "No Room/Bed information found for this student.",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClearRoomBedLabels();

                MessageBox.Show(
                    "Room/Bed information could not be loaded.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================
        // CLEAR LABELS
        // =========================================

        private void ClearRoomBedLabels()
        {
            lblsroomnumber.Text = "";
            lblsroomtype.Text = "";
            lblsStatus.Text = "";
            lblsbednumber.Text = "";
            lblsbedtype.Text = "";
            lblsStudentname.Text = "";
            lblsstudentid.Text = "";
        }

        // =========================================
        // DESIGNER EVENTS
        // =========================================

        private void lblFloorNumber_Click(object sender, EventArgs e)
        {
        }

        private void lblFloor_Click(object sender, EventArgs e)
        {
        }

        private void lblRoomID_Click(object sender, EventArgs e)
        {
        }

        private void lblsroomnumber_Click(object sender, EventArgs e)
        {
        }

        private void lblRoomType_Click(object sender, EventArgs e)
        {
        }

        private void lblsroomtype_Click(object sender, EventArgs e)
        {
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
        }

        private void lblsStatus_Click(object sender, EventArgs e)
        {
        }

        private void lblbednumber_Click(object sender, EventArgs e)
        {
        }

        private void lblsbednumber_Click(object sender, EventArgs e)
        {
        }

        private void BedType_Click(object sender, EventArgs e)
        {
        }

        private void lblsbedtype_Click(object sender, EventArgs e)
        {
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {
        }

        private void lblsStudentname_Click(object sender, EventArgs e)
        {
        }

        private void StudentIDlbl_Click(object sender, EventArgs e)
        {
        }

        private void lblsstudentid_Click(object sender, EventArgs e)
        {
        }
    }
}