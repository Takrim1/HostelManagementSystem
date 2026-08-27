using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class Stud_Complaint : UserControl
    {
        private readonly string connectionString =
            "Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public Stud_Complaint()
        {
            InitializeComponent();
        }

        // =========================================
        // FORM LOAD
        // =========================================
        private void Stud_Complaint_Load(object sender, EventArgs e)
        {
            txtcomplaintbox.Clear();
        }

        // =========================================
        // SAVE COMPLAINT
        // =========================================
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string complaint =
                    txtcomplaintbox.Text.Trim();

                // Check empty complaint
                if (string.IsNullOrWhiteSpace(complaint))
                {
                    MessageBox.Show(
                        "Please write your complaint first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtcomplaintbox.Focus();

                    return;
                }

                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    string query = @"
                        INSERT INTO ComplaintForm
                        (
                            ComplaintText,
                            ComplaintDate,
                            Status
                        )
                        VALUES
                        (
                            @ComplaintText,
                            GETDATE(),
                            'Pending'
                        )";

                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@ComplaintText",
                            SqlDbType.NVarChar).Value =
                            complaint;

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Complaint submitted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear textbox after saving
                txtcomplaintbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Complaint could not be saved.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================
        // COMPLAINT TEXTBOX
        // =========================================
        private void txtcomplaintbox_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        // =========================================
        // LABEL
        // =========================================
        private void lblcomplaint_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}