using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class Staff_Profile : UserControl
    {
        private readonly string connectionString =
            "Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public Staff_Profile()
        {
            InitializeComponent();
        }

        private int loggedInStaffID;

        public Staff_Profile(int staffID)
        {
            InitializeComponent();
            loggedInStaffID = staffID;
        }

        private void Staff_Profile_Load(object sender, EventArgs e)
        {
            LoadStaffProfile();
        }

        private void LoadStaffProfile()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
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
    WHERE StaffID = @StaffID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", loggedInStaffID);
                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblstid.Text = reader["StaffID"].ToString();
                                lblstname.Text = reader["StaffName"].ToString();
                                lblstaffposition.Text = reader["StaffPosition"].ToString();
                                lblstphone.Text = reader["Phone"].ToString();
                                lblstemail.Text = reader["Email"].ToString();
                                lblsaddress.Text = reader["HomeAddress"].ToString();
                            }
                            else
                            {
                                lblstid.Text = "N/A";
                                lblstname.Text = "N/A";
                                lblstaffposition.Text = "N/A";
                                lblstphone.Text = "N/A";
                                lblstemail.Text = "N/A";
                                lblsaddress.Text = "N/A";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Staff profile load failed.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lblsaddress_Click(object sender, EventArgs e)
        {
        }

        private void lblStaffID_Click(object sender, EventArgs e)
        {
        }

        private void lblstid_Click(object sender, EventArgs e)
        {
        }

        private void lblstaffname_Click(object sender, EventArgs e)
        {
        }

        private void lblstname_Click(object sender, EventArgs e)
        {
        }

        private void lblposition_Click(object sender, EventArgs e)
        {
        }

        private void lblstaffposition_Click(object sender, EventArgs e)
        {
        }

        private void lblphone_Click(object sender, EventArgs e)
        {
        }

        private void lblstphone_Click(object sender, EventArgs e)
        {
        }

        private void lblemail_Click(object sender, EventArgs e)
        {
        }

        private void lblstemail_Click(object sender, EventArgs e)
        {
        }

        private void lblstaffaddress_Click(object sender, EventArgs e)
        {
        }

        private void pnlStaffOverview_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}