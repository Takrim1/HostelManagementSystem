using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HostelManagementSystem
{
    public partial class A_RetoreData : UserControl
    {
        // =========================================================
        // DATABASE CONNECTION
        // =========================================================

        private readonly string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================================
        // CONTROLS
        // =========================================================

        private ComboBox cmbTable;
        private DataGridView dgvDeletedData;
        private Button btnRestore;
        private Button btnPermanentDelete;
        private Button btnRefresh;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public A_RetoreData()
        {
            InitializeComponent();

            CreateRestorePage();
        }


        // =========================================================
        // CREATE PAGE UI
        // =========================================================

        private void CreateRestorePage()
        {
            // -----------------------------------------------------
            // TABLE COMBOBOX
            // -----------------------------------------------------

            cmbTable = new ComboBox();

            cmbTable.Name = "cmbTable";
            cmbTable.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbTable.Items.Add("All Tables");
            cmbTable.Items.Add("BuildingForm");
            cmbTable.Items.Add("ComplaintForm");
            cmbTable.Items.Add("GuardianForm");
            cmbTable.Items.Add("MealForm");
            cmbTable.Items.Add("NoticeForm");
            cmbTable.Items.Add("PaymentForm");
            cmbTable.Items.Add("StaffAttendance");
            cmbTable.Items.Add("StaffForm");
            cmbTable.Items.Add("StudentForm");
            cmbTable.Items.Add("Visitor");

            cmbTable.SelectedIndex = 0;

            cmbTable.Location = new Point(20, 20);
            cmbTable.Width = 220;

            cmbTable.SelectedIndexChanged +=
                cmbTable_SelectedIndexChanged;


            // -----------------------------------------------------
            // REFRESH BUTTON
            // -----------------------------------------------------

            btnRefresh = new Button();

            btnRefresh.Name = "btnRefresh";
            btnRefresh.Text = "Refresh";

            btnRefresh.Width = 100;
            btnRefresh.Height = 35;

            btnRefresh.Location = new Point(260, 18);

            btnRefresh.Click +=
                btnRefresh_Click;


            // -----------------------------------------------------
            // RESTORE BUTTON
            // -----------------------------------------------------

            btnRestore = new Button();

            btnRestore.Name = "btnRestore";
            btnRestore.Text = "Restore Selected";

            btnRestore.Width = 150;
            btnRestore.Height = 35;

            btnRestore.Location = new Point(370, 18);

            btnRestore.Click +=
                btnRestore_Click;


            // -----------------------------------------------------
            // PERMANENT DELETE BUTTON
            // -----------------------------------------------------

            btnPermanentDelete = new Button();

            btnPermanentDelete.Name = "btnPermanentDelete";
            btnPermanentDelete.Text = "Delete Permanently";

            btnPermanentDelete.Width = 160;
            btnPermanentDelete.Height = 35;

            btnPermanentDelete.Location = new Point(530, 18);

            btnPermanentDelete.Click +=
                btnPermanentDelete_Click;


            // -----------------------------------------------------
            // DATAGRIDVIEW
            // -----------------------------------------------------

            dgvDeletedData = new DataGridView();

            dgvDeletedData.Name = "dgvDeletedData";

            dgvDeletedData.Location =
                new Point(20, 70);

            dgvDeletedData.Width =
                Math.Max(700, this.Width - 40);

            dgvDeletedData.Height =
                Math.Max(300, this.Height - 90);

            dgvDeletedData.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvDeletedData.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDeletedData.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDeletedData.MultiSelect = false;

            dgvDeletedData.ReadOnly = true;

            dgvDeletedData.AllowUserToAddRows = false;

            dgvDeletedData.AllowUserToDeleteRows = false;


            // -----------------------------------------------------
            // ADD CONTROLS
            // -----------------------------------------------------

            this.Controls.Add(cmbTable);
            this.Controls.Add(btnRefresh);
            this.Controls.Add(btnRestore);
            this.Controls.Add(btnPermanentDelete);
            this.Controls.Add(dgvDeletedData);
        }


        // =========================================================
        // LOAD
        // =========================================================

        private void A_RetoreData_Load(object sender, EventArgs e)
        {
            LoadDeletedData();
        }


        // =========================================================
        // TABLE CHANGED
        // =========================================================

        private void cmbTable_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            LoadDeletedData();
        }


        // =========================================================
        // REFRESH
        // =========================================================

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            LoadDeletedData();
        }


        // =========================================================
        // LOAD DELETED DATA
        // =========================================================

        private void LoadDeletedData()
        {
            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT
                            DeletedID,
                            TableName,
                            PrimaryKeyColumn,
                            PrimaryKeyValue,
                            DeletedData,
                            DeletedDate
                        FROM DeletedRecords
                    ";

                    if (cmbTable != null &&
                        cmbTable.SelectedIndex > 0)
                    {
                        query +=
                            " WHERE TableName = @TableName ";
                    }

                    query +=
                        " ORDER BY DeletedID DESC";


                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        if (cmbTable != null &&
                            cmbTable.SelectedIndex > 0)
                        {
                            cmd.Parameters.Add(
                                "@TableName",
                                SqlDbType.NVarChar,
                                100).Value =
                                cmbTable.SelectedItem.ToString();
                        }


                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(cmd))
                        {
                            DataTable dt =
                                new DataTable();

                            adapter.Fill(dt);

                            dgvDeletedData.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Deleted data load failed.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================================
        // RESTORE SELECTED DATA
        // =========================================================

        private void btnRestore_Click(
            object sender,
            EventArgs e)
        {
            if (dgvDeletedData.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a deleted record first.",
                    "Restore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            DataGridViewRow row =
                dgvDeletedData.SelectedRows[0];


            int deletedID =
                Convert.ToInt32(
                    row.Cells["DeletedID"].Value);


            string tableName =
                row.Cells["TableName"].Value.ToString();


            string primaryKeyColumn =
                row.Cells["PrimaryKeyColumn"].Value.ToString();


            string primaryKeyValue =
                row.Cells["PrimaryKeyValue"].Value.ToString();


            string deletedData =
                row.Cells["DeletedData"].Value.ToString();


            DialogResult result =
                MessageBox.Show(
                    "Restore this record?\n\n" +
                    "Table: " + tableName + "\n" +
                    primaryKeyColumn + ": " +
                    primaryKeyValue,
                    "Confirm Restore",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


            if (result != DialogResult.Yes)
            {
                return;
            }


            try
            {
                RestoreRecord(
                    deletedID,
                    tableName,
                    deletedData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Restore failed.\n\n" +
                    ex.Message,
                    "Restore Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================================
        // RESTORE RECORD
        // =========================================================

        private void RestoreRecord(
            int deletedID,
            string tableName,
            string jsonData)
        {
            using (SqlConnection con =
                   new SqlConnection(connectionString))
            {
                con.Open();

                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    // -------------------------------------------------
                    // CHECK TABLE NAME
                    // -------------------------------------------------

                    if (!IsAllowedTable(tableName))
                    {
                        throw new Exception(
                            "Invalid table selected.");
                    }


                    // -------------------------------------------------
                    // GET TABLE COLUMNS
                    // -------------------------------------------------

                    DataTable columns =
                        GetTableColumns(
                            con,
                            transaction,
                            tableName);


                    if (columns.Rows.Count == 0)
                    {
                        throw new Exception(
                            "Table columns could not be found.");
                    }


                    StringBuilder columnList =
                        new StringBuilder();

                    StringBuilder withList =
                        new StringBuilder();

                    StringBuilder selectList =
                        new StringBuilder();


                    foreach (DataRow column in columns.Rows)
                    {
                        string columnName =
                            column["ColumnName"].ToString();

                        string dataType =
                            column["DataType"].ToString();

                        string maxLength =
                            column["MaxLength"].ToString();


                        if (columnList.Length > 0)
                        {
                            columnList.Append(", ");
                            withList.Append(", ");
                            selectList.Append(", ");
                        }


                        columnList.Append(
                            "[" + columnName + "]");


                        string sqlType =
                            GetJsonSqlType(
                                dataType,
                                maxLength);


                        withList.Append(
                            "[" + columnName + "] " +
                            sqlType +
                            " '$." +
                            columnName +
                            "'");


                        selectList.Append(
                            "[" + columnName + "]");
                    }


                    // -------------------------------------------------
                    // CHECK IDENTITY COLUMN
                    // -------------------------------------------------

                    bool hasIdentity =
                        false;

                    foreach (DataRow column in columns.Rows)
                    {
                        if (Convert.ToBoolean(
                            column["IsIdentity"]))
                        {
                            hasIdentity = true;
                            break;
                        }
                    }


                    // -------------------------------------------------
                    // CHECK DUPLICATE
                    // -------------------------------------------------

                    string primaryKeyColumn =
                        GetPrimaryKeyColumn(
                            con,
                            transaction,
                            tableName);


                    if (!string.IsNullOrWhiteSpace(
                        primaryKeyColumn))
                    {
                        string checkQuery = @"
                            SELECT COUNT(*)
                            FROM [" + tableName + @"]
                            WHERE [" + primaryKeyColumn + @"]
                            = JSON_VALUE(
                                @JsonData,
                                '$." + primaryKeyColumn + @"'
                            )";


                        using (SqlCommand checkCommand =
                               new SqlCommand(
                                   checkQuery,
                                   con,
                                   transaction))
                        {
                            checkCommand.Parameters.Add(
                                "@JsonData",
                                SqlDbType.NVarChar,
                                -1).Value =
                                jsonData;


                            int exists =
                                Convert.ToInt32(
                                    checkCommand.ExecuteScalar());


                            if (exists > 0)
                            {
                                throw new Exception(
                                    "This record already exists in " +
                                    tableName +
                                    ".");
                            }
                        }
                    }


                    // -------------------------------------------------
                    // IDENTITY INSERT
                    // -------------------------------------------------

                    if (hasIdentity)
                    {
                        using (SqlCommand identityOn =
                               new SqlCommand(
                                   "SET IDENTITY_INSERT [" +
                                   tableName +
                                   "] ON",
                                   con,
                                   transaction))
                        {
                            identityOn.ExecuteNonQuery();
                        }
                    }


                    // -------------------------------------------------
                    // RESTORE QUERY
                    // -------------------------------------------------

                    string restoreQuery = @"
                        INSERT INTO [" + tableName + @"]
                        (" + columnList + @")
                        SELECT
                            " + selectList + @"
                        FROM OPENJSON(@JsonData)
                        WITH
                        (
                            " + withList + @"
                        );";


                    using (SqlCommand restoreCommand =
                           new SqlCommand(
                               restoreQuery,
                               con,
                               transaction))
                    {
                        restoreCommand.Parameters.Add(
                            "@JsonData",
                            SqlDbType.NVarChar,
                            -1).Value =
                            jsonData;


                        restoreCommand.ExecuteNonQuery();
                    }


                    // -------------------------------------------------
                    // IDENTITY INSERT OFF
                    // -------------------------------------------------

                    if (hasIdentity)
                    {
                        using (SqlCommand identityOff =
                               new SqlCommand(
                                   "SET IDENTITY_INSERT [" +
                                   tableName +
                                   "] OFF",
                                   con,
                                   transaction))
                        {
                            identityOff.ExecuteNonQuery();
                        }
                    }


                    // -------------------------------------------------
                    // REMOVE FROM RECYCLE BIN
                    // -------------------------------------------------

                    string deleteArchiveQuery = @"
                        DELETE FROM DeletedRecords
                        WHERE DeletedID = @DeletedID";


                    using (SqlCommand deleteArchive =
                           new SqlCommand(
                               deleteArchiveQuery,
                               con,
                               transaction))
                    {
                        deleteArchive.Parameters.Add(
                            "@DeletedID",
                            SqlDbType.Int).Value =
                            deletedID;

                        deleteArchive.ExecuteNonQuery();
                    }


                    transaction.Commit();


                    MessageBox.Show(
                        "Data restored successfully!\n\n" +
                        "Table: " + tableName,
                        "Restore Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    LoadDeletedData();
                }
                catch
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch
                    {
                    }

                    throw;
                }
            }
        }


        // =========================================================
        // PERMANENT DELETE
        // =========================================================

        private void btnPermanentDelete_Click(
            object sender,
            EventArgs e)
        {
            if (dgvDeletedData.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a deleted record first.",
                    "Permanent Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            DataGridViewRow row =
                dgvDeletedData.SelectedRows[0];


            int deletedID =
                Convert.ToInt32(
                    row.Cells["DeletedID"].Value);


            string tableName =
                row.Cells["TableName"].Value.ToString();


            string primaryKeyValue =
                row.Cells["PrimaryKeyValue"].Value.ToString();


            DialogResult result =
                MessageBox.Show(
                    "WARNING!\n\n" +
                    "This will permanently delete this record " +
                    "from the Restore page.\n\n" +
                    "Table: " + tableName + "\n" +
                    "ID: " + primaryKeyValue + "\n\n" +
                    "This action cannot be undone.",
                    "Permanent Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);


            if (result != DialogResult.Yes)
            {
                return;
            }


            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    string query = @"
                        DELETE FROM DeletedRecords
                        WHERE DeletedID = @DeletedID";


                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@DeletedID",
                            SqlDbType.Int).Value =
                            deletedID;


                        con.Open();

                        int rows =
                            cmd.ExecuteNonQuery();


                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Record permanently deleted.",
                                "Deleted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadDeletedData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Permanent delete failed.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================================
        // GET TABLE COLUMNS
        // =========================================================

        private DataTable GetTableColumns(
            SqlConnection con,
            SqlTransaction transaction,
            string tableName)
        {
            string query = @"
                SELECT
                    c.name AS ColumnName,
                    t.name AS DataType,
                    CASE
                        WHEN c.max_length = -1
                            THEN 'MAX'
                        ELSE CAST(c.max_length AS VARCHAR(20))
                    END AS MaxLength,
                    c.is_identity AS IsIdentity
                FROM sys.columns c
                INNER JOIN sys.types t
                    ON c.user_type_id = t.user_type_id
                WHERE c.object_id =
                    OBJECT_ID(@TableName)
                ORDER BY c.column_id";


            using (SqlCommand cmd =
                   new SqlCommand(
                       query,
                       con,
                       transaction))
            {
                cmd.Parameters.Add(
                    "@TableName",
                    SqlDbType.NVarChar,
                    100).Value =
                    tableName;


                DataTable dt =
                    new DataTable();


                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }


                return dt;
            }
        }


        // =========================================================
        // GET PRIMARY KEY COLUMN
        // =========================================================

        private string GetPrimaryKeyColumn(
            SqlConnection con,
            SqlTransaction transaction,
            string tableName)
        {
            string query = @"
                SELECT TOP 1
                    c.name
                FROM sys.indexes i
                INNER JOIN sys.index_columns ic
                    ON i.object_id = ic.object_id
                    AND i.index_id = ic.index_id
                INNER JOIN sys.columns c
                    ON ic.object_id = c.object_id
                    AND ic.column_id = c.column_id
                WHERE i.is_primary_key = 1
                    AND i.object_id =
                        OBJECT_ID(@TableName)
                ORDER BY ic.key_ordinal";


            using (SqlCommand cmd =
                   new SqlCommand(
                       query,
                       con,
                       transaction))
            {
                cmd.Parameters.Add(
                    "@TableName",
                    SqlDbType.NVarChar,
                    100).Value =
                    tableName;


                object result =
                    cmd.ExecuteScalar();


                return result == null ||
                       result == DBNull.Value
                    ? ""
                    : result.ToString();
            }
        }


        // =========================================================
        // ALLOWED TABLES
        // =========================================================

        private bool IsAllowedTable(string tableName)
        {
            switch (tableName)
            {
                case "BuildingForm":
                case "ComplaintForm":
                case "GuardianForm":
                case "MealForm":
                case "NoticeForm":
                case "PaymentForm":
                case "StaffAttendance":
                case "StaffForm":
                case "StudentForm":
                case "Visitor":
                    return true;

                default:
                    return false;
            }
        }


        // =========================================================
        // JSON SQL TYPE
        // =========================================================

        private string GetJsonSqlType(
            string dataType,
            string maxLength)
        {
            switch (dataType.ToLower())
            {
                case "int":
                    return "INT";

                case "bigint":
                    return "BIGINT";

                case "smallint":
                    return "SMALLINT";

                case "tinyint":
                    return "TINYINT";

                case "bit":
                    return "BIT";

                case "decimal":
                    return "DECIMAL(18,2)";

                case "numeric":
                    return "NUMERIC(18,2)";

                case "float":
                    return "FLOAT";

                case "real":
                    return "REAL";

                case "date":
                    return "DATE";

                case "datetime":
                    return "DATETIME";

                case "datetime2":
                    return "DATETIME2";

                case "smalldatetime":
                    return "SMALLDATETIME";

                case "time":
                    return "TIME";

                case "uniqueidentifier":
                    return "UNIQUEIDENTIFIER";

                case "nvarchar":
                    if (maxLength == "MAX")
                        return "NVARCHAR(MAX)";

                    return "NVARCHAR(4000)";

                case "varchar":
                    if (maxLength == "MAX")
                        return "VARCHAR(MAX)";

                    return "VARCHAR(8000)";

                case "nchar":
                    return "NVARCHAR(4000)";

                case "char":
                    return "VARCHAR(8000)";

                default:
                    return "NVARCHAR(MAX)";
            }
        }
    }
}
