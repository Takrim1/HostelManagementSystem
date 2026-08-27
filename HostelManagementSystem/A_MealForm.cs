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
    public partial class A_MealForm : UserControl
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // CONSTRUCTOR
        // =========================================
        public A_MealForm()
        {
            InitializeComponent();
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_MealForm_Load(object sender, EventArgs e)
        {
            LoadMealData();
        }


        // =========================================
        // LOAD ALL MEAL DATA
        // =========================================
        private void LoadMealData()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true;

                string query = @"
                    SELECT
                        MealID,
                        StaffID,
                        StudentID,
                        MealType,
                        Menu,
                        MealBookingDate,
                        Price
                    FROM MealForm
                    ORDER BY MealID ASC";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dataGridView1.AutoGenerateColumns = true;
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

                dataGridView1.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load Meal data.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // MEAL BOOKING / ADD MEAL
        // =========================================
        private void btnmealbooking_Click(object sender, EventArgs e)
        {
            A_MealRegistrationForm mealForm =
                new A_MealRegistrationForm();

            mealForm.ShowDialog();

            // Reload database data
            LoadMealData();
        }


        // =========================================
        // EDIT MEAL BOOKING
        // =========================================
        private void btneditmealbooking_Click(object sender, EventArgs e)
        {
            // =========================================
            // CHECK ROW SELECTION
            // =========================================
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Meal Booking first.",
                    "Edit Meal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET MEAL ID FROM SELECTED ROW
                // =========================================
                object idValue =
                    dataGridView1.SelectedRows[0]
                    .Cells["MealID"]
                    .Value;


                // =========================================
                // CHECK MEAL ID
                // =========================================
                if (idValue == null ||
                    idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Meal ID could not be found.",
                        "Edit Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int mealID =
                    Convert.ToInt32(idValue);


                // =========================================
                // OPEN REGISTRATION FORM IN EDIT MODE
                // =========================================
                A_MealRegistrationForm form =
                    new A_MealRegistrationForm(mealID);


                form.ShowDialog();


                // =========================================
                // RELOAD UPDATED DATABASE DATA
                // =========================================
                LoadMealData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Meal for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Edit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // DELETE MEAL BOOKING
        // =========================================
        private void btnDeleteMealBooking_Click(object sender, EventArgs e)
        {
            // =========================================
            // CHECK ROW SELECTION
            // =========================================
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Meal Booking first.",
                    "Delete Meal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                // =========================================
                // GET MEAL ID
                // =========================================
                object idValue =
                    dataGridView1.SelectedRows[0]
                    .Cells["MealID"]
                    .Value;


                // =========================================
                // CHECK MEAL ID
                // =========================================
                if (idValue == null ||
                    idValue == DBNull.Value)
                {
                    MessageBox.Show(
                        "Meal ID could not be found.",
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                int mealID =
                    Convert.ToInt32(idValue);


                // =========================================
                // CONFIRM DELETE
                // =========================================
                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete Meal Booking ID "
                        + mealID + "?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);


                if (result != DialogResult.Yes)
                {
                    return;
                }


                // =========================================
                // DELETE QUERY
                // =========================================
                string query = @"
                    DELETE FROM MealForm
                    WHERE MealID = @MealID";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@MealID",
                            mealID);


                        connection.Open();


                        int rows =
                            command.ExecuteNonQuery();


                        // =========================================
                        // DELETE SUCCESS
                        // =========================================
                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Meal Booking deleted successfully.",
                                "Delete Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                            // Reload database data
                            LoadMealData();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Meal Booking was not found.",
                                "Delete Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Meal Booking deletion failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SEARCH MEAL BOOKING
        // =========================================
        private void btnapplysearch_Click(object sender, EventArgs e)
        {
            SearchMeal();
        }


        // =========================================
        // SEARCH MEAL DATA
        // =========================================
        private void SearchMeal()
        {
            try
            {
                string searchText =
                    txtStudentMealSearch.Text.Trim();


                // =========================================
                // EMPTY SEARCH
                // =========================================
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadMealData();

                    MessageBox.Show(
                        "Please enter something to search.",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }


                // =========================================
                // SEARCH QUERY
                // =========================================
                string query = @"
                    SELECT
                        MealID,
                        StaffID,
                        StudentID,
                        MealType,
                        Menu,
                        MealBookingDate,
                        Price
                    FROM MealForm
                    WHERE
                        CAST(MealID AS VARCHAR) LIKE @Search
                        OR CAST(StaffID AS VARCHAR) LIKE @Search
                        OR CAST(StudentID AS VARCHAR) LIKE @Search
                        OR MealType LIKE @Search
                        OR Menu LIKE @Search
                        OR CAST(Price AS VARCHAR) LIKE @Search
                        OR CONVERT(VARCHAR, MealBookingDate, 23) LIKE @Search
                    ORDER BY
                        CASE
                            WHEN CAST(MealID AS VARCHAR) = @ExactSearch THEN 0
                            WHEN CAST(StudentID AS VARCHAR) = @ExactSearch THEN 1
                            WHEN CAST(StaffID AS VARCHAR) = @ExactSearch THEN 2
                            WHEN MealType = @ExactSearch THEN 3
                            WHEN Menu = @ExactSearch THEN 4
                            ELSE 5
                        END,
                        MealID ASC";


                DataTable table =
                    new DataTable();


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Search",
                            "%" + searchText + "%");


                        command.Parameters.AddWithValue(
                            "@ExactSearch",
                            searchText);


                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }


                // =========================================
                // NO DATA FOUND
                // =========================================
                if (table.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;

                    MessageBox.Show(
                        "No Data Found.",
                        "Search Result",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }


                // =========================================
                // SHOW SEARCH RESULT
                // =========================================
                dataGridView1.AutoGenerateColumns = true;

                dataGridView1.DataSource =
                    table;

                dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.MultiSelect =
                    false;

                dataGridView1.ReadOnly =
                    true;

                dataGridView1.AllowUserToAddRows =
                    false;


                // =========================================
                // SELECT FIRST SEARCH RESULT
                // =========================================
                dataGridView1.ClearSelection();


                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;


                    dataGridView1.CurrentCell =
                        dataGridView1.Rows[0].Cells[0];


                    dataGridView1.FirstDisplayedScrollingRowIndex =
                        0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SEARCH STUDENT ID LABEL
        // =========================================
        private void lblSearchStudentid_Click(object sender, EventArgs e)
        {
        }


        // =========================================
        // SEARCH TEXTBOX
        // =========================================
        private void txtStudentMealSearch_TextChanged(object sender, EventArgs e)
        {
        }


        // =========================================
        // STAFF ID TEXTBOX
        // =========================================
        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
        }


        // =========================================
        // STAFF ID LABEL
        // =========================================
        private void lblStaffID_Click(object sender, EventArgs e)
        {
        }


        // =========================================
        // MEAL TITLE
        // =========================================
        private void lblMealbookingTitle_Click(object sender, EventArgs e)
        {
        }


        // =========================================
        // SEARCH PANEL
        // =========================================
        private void pnlMealSearch_Paint(object sender, PaintEventArgs e)
        {
        }


        // =========================================
        // DATAGRIDVIEW CELL CLICK
        // =========================================
        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}