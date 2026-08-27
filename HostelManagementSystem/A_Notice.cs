using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class A_Notice : UserControl
    {
        private readonly string connectionString =
            "Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public A_Notice()
        {
            InitializeComponent();
        }

        // =========================================
        // FORM LOAD
        // =========================================
        private void A_Notice_Load(object sender, EventArgs e)
        {
            LoadNotices();

            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            // =========================================
            // NOTICE TEXT FULLY SHOW
            // =========================================

            // Long text will go to next line
            dataGridView1.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            // Row height will automatically increase
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;

            // Keep column width fixed
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.None;

            // Make Notice column large
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

                // Change GridView column headers

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
                    "Notice data could not be loaded.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================
        // SAVE NOTICE
        // =========================================
        private void btnsavenotice_Click(object sender, EventArgs e)
        {
            try
            {
                string noticeText =
                    txtrtnotice.Text.Trim();

                // Check empty notice
                if (string.IsNullOrWhiteSpace(noticeText))
                {
                    MessageBox.Show(
                        "Please write a notice first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtrtnotice.Focus();

                    return;
                }

                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    string query = @"
                        INSERT INTO NoticeForm
                        (
                            NoticeText
                        )
                        VALUES
                        (
                            @NoticeText
                        )";

                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@NoticeText",
                            SqlDbType.NVarChar).Value =
                            noticeText;

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Notice saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear textbox
                txtrtnotice.Clear();

                // Reload GridView
                LoadNotices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Notice could not be saved.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================
        // DELETE NOTICE
        // =========================================
        private void btndeletenotice_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a notice from the table.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int noticeID = Convert.ToInt32(
                    dataGridView1
                    .SelectedRows[0]
                    .Cells["NoticeID"]
                    .Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this notice?",
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
                        DELETE FROM NoticeForm
                        WHERE NoticeID = @NoticeID";

                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@NoticeID",
                            SqlDbType.Int).Value =
                            noticeID;

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Notice deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear textbox
                txtrtnotice.Clear();

                // Reload GridView
                LoadNotices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Notice could not be deleted.\n\n" +
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

            try
            {
                if (dataGridView1.Rows[e.RowIndex]
                    .Cells["NoticeText"].Value != null)
                {
                    txtrtnotice.Text =
                        dataGridView1.Rows[e.RowIndex]
                        .Cells["NoticeText"]
                        .Value
                        .ToString();
                }
            }
            catch
            {
                // Prevent unnecessary GridView error
            }
        }

        // =========================================
        // LABEL
        // =========================================
        private void lblwritenotice_Click(
            object sender,
            EventArgs e)
        {
        }

        // =========================================
        // TEXTBOX
        // =========================================
        private void txtrtnotice_TextChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}