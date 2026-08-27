using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class A_ComplaintForm : UserControl
    {
        private readonly string connectionString =
            "Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public A_ComplaintForm()
        {
            InitializeComponent();
        }

        // =========================================
        // FORM LOAD
        // =========================================
        private void A_ComplaintForm_Load(object sender, EventArgs e)
        {
            LoadComplaints();

            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            // =========================================
            // SHOW FULL COMPLAINT TEXT
            // =========================================

            // Long complaint text will move to next line
            dataGridView1.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            // Row height will increase automatically
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;

            // Keep column width fixed
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.None;

            // Make Complaint column bigger
            if (dataGridView1.Columns.Contains("ComplaintText"))
            {
                dataGridView1.Columns["ComplaintText"].Width = 500;
            }
        }

        // =========================================
        // LOAD COMPLAINTS
        // =========================================
        private void LoadComplaints()
        {
            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT
                            ComplaintID,
                            ComplaintText,
                            ComplaintDate,
                            Status
                        FROM ComplaintForm
                        ORDER BY ComplaintID DESC";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }

                // Change GridView headers

                if (dataGridView1.Columns.Contains("ComplaintID"))
                {
                    dataGridView1.Columns["ComplaintID"].HeaderText =
                        "Complaint ID";
                }

                if (dataGridView1.Columns.Contains("ComplaintText"))
                {
                    dataGridView1.Columns["ComplaintText"].HeaderText =
                        "Complaint";
                }

                if (dataGridView1.Columns.Contains("ComplaintDate"))
                {
                    dataGridView1.Columns["ComplaintDate"].HeaderText =
                        "Date";
                }

                if (dataGridView1.Columns.Contains("Status"))
                {
                    dataGridView1.Columns["Status"].HeaderText =
                        "Status";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Complaint data could not be loaded.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================
        // DELETE COMPLAINT
        // =========================================
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a complaint first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int complaintID = Convert.ToInt32(
                    dataGridView1
                    .SelectedRows[0]
                    .Cells["ComplaintID"]
                    .Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this complaint?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    string query = @"
                        DELETE FROM ComplaintForm
                        WHERE ComplaintID = @ComplaintID";

                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@ComplaintID",
                            SqlDbType.Int).Value =
                            complaintID;

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Complaint deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadComplaints();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Complaint could not be deleted.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================
        // GRIDVIEW CLICK
        // =========================================
        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
        }

        // =========================================
        // LABEL
        // =========================================
        private void lblcomplain_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}