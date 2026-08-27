using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class Stud_Notice : UserControl
    {
        private readonly string connectionString =
            "Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public Stud_Notice()
        {
            InitializeComponent();
        }

        // =========================================
        // FORM LOAD
        // =========================================
        private void Stud_Notice_Load(object sender, EventArgs e)
        {
            // Student can only view notices
            btndelete.Enabled = false;

            LoadNotices();

            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            // =========================================
            // SHOW FULL NOTICE TEXT
            // =========================================

            // Long notice text will move to next line
            dataGridView1.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            // Row height will increase automatically
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;

            // Keep column width fixed
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.None;

            // Make Notice column bigger
            if (dataGridView1.Columns.Contains("NoticeText"))
            {
                dataGridView1.Columns["NoticeText"].Width = 500;
            }
        }
        // =========================================
        // LOAD NOTICE FROM DATABASE
        // =========================================
        private void LoadNotices()
        {
            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT
                            NoticeID,
                            NoticeText,
                            NoticeDate
                        FROM NoticeForm
                        ORDER BY NoticeID DESC";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }

                // GridView Header Names

                if (dataGridView1.Columns.Contains("NoticeID"))
                {
                    dataGridView1.Columns["NoticeID"].HeaderText =
                        "Notice ID";
                }

                if (dataGridView1.Columns.Contains("NoticeText"))
                {
                    dataGridView1.Columns["NoticeText"].HeaderText =
                        "Notice";
                }

                if (dataGridView1.Columns.Contains("NoticeDate"))
                {
                    dataGridView1.Columns["NoticeDate"].HeaderText =
                        "Date";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Notice could not be loaded.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================
        // DELETE BUTTON
        // =========================================
        private void btndelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Students are not allowed to delete notices.",
                "Access Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
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
        // NOTICE LABEL
        // =========================================
        private void lblnotice_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}