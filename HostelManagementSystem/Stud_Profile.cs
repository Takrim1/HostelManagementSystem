using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class Stud_Profile : UserControl
    {
        private readonly string connectionString =
            "Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public Stud_Profile()
        {
            InitializeComponent();
        }

        private void Stud_Profile_Load(object sender, EventArgs e)
        {
            LoadStudentProfile();
        }

        private void LoadStudentProfile()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT TOP 1
                            StudentID,
                            StudentName,
                            Gender,
                            DOB,
                            Phone,
                            Email,
                            Department,
                            HomeAddress,
                            AdmissionDate
                        FROM StudentForm
                        ORDER BY StudentID DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Student ID
                                lblsid.Text = reader["StudentID"] == DBNull.Value
                                    ? "N/A"
                                    : reader["StudentID"].ToString();

                                // Student Name
                                lblsname.Text = reader["StudentName"] == DBNull.Value
                                    ? "N/A"
                                    : reader["StudentName"].ToString();

                                // Gender
                                lblstudentgender.Text = reader["Gender"] == DBNull.Value
                                    ? "N/A"
                                    : reader["Gender"].ToString();

                                // DOB
                                lblsdob.Text = reader["DOB"] == DBNull.Value
                                    ? "N/A"
                                    : Convert.ToDateTime(reader["DOB"]).ToString("dd-MM-yyyy");

                                // Phone
                                lblsphone.Text = reader["Phone"] == DBNull.Value
                                    ? "N/A"
                                    : reader["Phone"].ToString();

                                // Email
                                lblsemail.Text = reader["Email"] == DBNull.Value
                                    ? "N/A"
                                    : reader["Email"].ToString();

                                // Department
                                lblsdepartment.Text = reader["Department"] == DBNull.Value
                                    ? "N/A"
                                    : reader["Department"].ToString();

                                // Home Address
                                lblsaddress.Text = reader["HomeAddress"] == DBNull.Value
                                    ? "N/A"
                                    : reader["HomeAddress"].ToString();

                                // Admission Date
                                lblsadmission.Text = reader["AdmissionDate"] == DBNull.Value
                                    ? "N/A"
                                    : Convert.ToDateTime(reader["AdmissionDate"]).ToString("dd-MM-yyyy");
                            }
                            else
                            {
                                lblsid.Text = "N/A";
                                lblsname.Text = "N/A";
                                lblstudentgender.Text = "N/A";
                                lblsdob.Text = "N/A";
                                lblsphone.Text = "N/A";
                                lblsemail.Text = "N/A";
                                lblsdepartment.Text = "N/A";
                                lblsaddress.Text = "N/A";
                                lblsadmission.Text = "N/A";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Student profile load failed.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void pnlStudentOverview_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {
        }

        private void lblsid_Click(object sender, EventArgs e)
        {
        }

        private void lblstudentname_Click(object sender, EventArgs e)
        {
        }

        private void lblsname_Click(object sender, EventArgs e)
        {
        }

        private void lblgender_Click(object sender, EventArgs e)
        {
        }

        private void lblstudentgender_Click(object sender, EventArgs e)
        {
        }

        private void lblphone_Click(object sender, EventArgs e)
        {
        }

        private void lblsphone_Click(object sender, EventArgs e)
        {
        }

        private void lblemail_Click(object sender, EventArgs e)
        {
        }

        private void lblsemail_Click(object sender, EventArgs e)
        {
        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {
        }

        private void lblsdepartment_Click(object sender, EventArgs e)
        {
        }

        private void lblstudentaddress_Click(object sender, EventArgs e)
        {
        }

        private void lblsaddress_Click(object sender, EventArgs e)
        {
        }

        private void lbldob_Click(object sender, EventArgs e)
        {
        }

        private void lblsdob_Click(object sender, EventArgs e)
        {
        }

        private void lbladmission_Click(object sender, EventArgs e)
        {
        }

        private void lblsadmission_Click(object sender, EventArgs e)
        {
        }
    }
}