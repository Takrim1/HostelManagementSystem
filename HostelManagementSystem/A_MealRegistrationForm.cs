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
    public partial class A_MealRegistrationForm : Form
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
        private int editMealID = 0;


        // =========================================
        // NORMAL CONSTRUCTOR
        // ADD NEW MEAL
        // =========================================
        public A_MealRegistrationForm()
        {
            InitializeComponent();
        }


        // =========================================
        // EDIT CONSTRUCTOR
        // =========================================
        public A_MealRegistrationForm(int mealID)
        {
            InitializeComponent();

            editMealID = mealID;
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_MealRegistrationForm_Load(object sender, EventArgs e)
        {
            // =========================================
            // MEAL ID / EDIT MODE
            // =========================================

            if (editMealID > 0)
            {
                // =========================================
                // EDIT MODE
                // =========================================

                LoadMealDataForEdit(editMealID);
            }
            else
            {
                // =========================================
                // ADD MODE
                // =========================================

                // Default booking date
                dtpmealbook.Value = DateTime.Today;
            }
        }


        // =========================================
        // LOAD SELECTED MEAL DATA FOR EDIT
        // =========================================
        private void LoadMealDataForEdit(int mealID)
        {
            try
            {
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
                    WHERE MealID = @MealID";


                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        // =========================================
                        // SELECTED MEAL ID
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@MealID",
                            mealID);


                        connection.Open();


                        using (SqlDataReader reader =
                               command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // =========================================
                                // STAFF ID
                                // =========================================
                                txtStaffID.Text =
                                    reader["StaffID"] == DBNull.Value
                                        ? ""
                                        : reader["StaffID"].ToString();


                                // =========================================
                                // STUDENT ID
                                // =========================================
                                txtStudentID.Text =
                                    reader["StudentID"] == DBNull.Value
                                        ? ""
                                        : reader["StudentID"].ToString();


                                // =========================================
                                // MEAL TYPE
                                // =========================================
                                cmbmealtype.Text =
                                    reader["MealType"] == DBNull.Value
                                        ? ""
                                        : reader["MealType"].ToString();


                                // =========================================
                                // MENU
                                // =========================================
                                cmbmenu.Text =
                                    reader["Menu"] == DBNull.Value
                                        ? ""
                                        : reader["Menu"].ToString();


                                // =========================================
                                // MEAL BOOKING DATE
                                // =========================================
                                if (reader["MealBookingDate"] != DBNull.Value)
                                {
                                    dtpmealbook.Value =
                                        Convert.ToDateTime(
                                            reader["MealBookingDate"]);
                                }


                                // =========================================
                                // PRICE
                                // =========================================
                                txtPrice.Text =
                                    reader["Price"] == DBNull.Value
                                        ? ""
                                        : reader["Price"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Meal data not found.",
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
                    "Could not load Meal data for editing.\n\n" +
                    "Error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SAVE / UPDATE MEAL
        // =========================================
        private void btnSavemeal_Click(object sender, EventArgs e)
        {
            // =========================================
            // STAFF ,Student ID VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtStaffID.Text) &&
        string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show(
                    "Please enter either Staff ID or Student ID.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!string.IsNullOrWhiteSpace(txtStaffID.Text) &&
                !string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show(
                    "Please enter either Staff ID or Student ID, not both.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // =========================================
            // MEAL TYPE VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(cmbmealtype.Text))
            {
                MessageBox.Show(
                    "Please select Meal Type.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbmealtype.Focus();
                return;
            }


            // =========================================
            // MENU VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(cmbmenu.Text))
            {
                MessageBox.Show(
                    "Please select Menu.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbmenu.Focus();
                return;
            }


            // =========================================
            // PRICE VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show(
                    "Please enter Price.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();
                return;
            }


            // =========================================
            // PRICE NUMBER VALIDATION
            // =========================================
            decimal price;

            if (!decimal.TryParse(txtPrice.Text.Trim(), out price))
            {
                MessageBox.Show(
                    "Please enter a valid Price.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();
                return;
            }


            // =========================================
            // PRICE MUST NOT BE NEGATIVE
            // =========================================
            if (price < 0)
            {
                MessageBox.Show(
                    "Price cannot be negative.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();
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
                    if (editMealID > 0)
                    {
                        string updateQuery = @"
                            UPDATE MealForm
                            SET
                                StaffID = @StaffID,
                                StudentID = @StudentID,
                                MealType = @MealType,
                                Menu = @Menu,
                                MealBookingDate = @MealBookingDate,
                                Price = @Price
                            WHERE MealID = @MealID";


                        using (SqlCommand command =
                               new SqlCommand(updateQuery, connection))
                        {
                            // =========================================
                            // SELECTED MEAL ID
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@MealID",
                                editMealID);


                            // =========================================
                            // STAFF ID
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@StaffID",
                                txtStaffID.Text.Trim());


                            // =========================================
                            // STUDENT ID
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@StudentID",
                                txtStudentID.Text.Trim());


                            // =========================================
                            // MEAL TYPE
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@MealType",
                                cmbmealtype.Text.Trim());


                            // =========================================
                            // MENU
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@Menu",
                                cmbmenu.Text.Trim());


                            // =========================================
                            // MEAL BOOKING DATE
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@MealBookingDate",
                                dtpmealbook.Value.Date);


                            // =========================================
                            // PRICE
                            // =========================================
                            command.Parameters.AddWithValue(
                                "@Price",
                                price);


                            // =========================================
                            // EXECUTE UPDATE
                            // =========================================
                            int rows =
                                command.ExecuteNonQuery();


                            if (rows > 0)
                            {
                                MessageBox.Show(
                                    "Meal information updated successfully!\n\n" +
                                    "Meal ID: " + editMealID +
                                    "\nStudent ID: " +
                                    txtStudentID.Text.Trim(),
                                    "Update Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                // Close edit form
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Meal was not found.",
                                    "Update Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }


                        // =========================================
                        // IMPORTANT:
                        // DO NOT EXECUTE INSERT AFTER EDIT
                        // =========================================
                        return;
                    }


                    // =========================================
                    // ADD MODE - INSERT NEW MEAL
                    // =========================================
                    string insertQuery = @"
                        INSERT INTO MealForm
                        (
                            StaffID,
                            StudentID,
                            MealType,
                            Menu,
                            MealBookingDate,
                            Price
                        )
                        OUTPUT INSERTED.MealID
                        VALUES
                        (
                            @StaffID,
                            @StudentID,
                            @MealType,
                            @Menu,
                            @MealBookingDate,
                            @Price
                        )";


                    using (SqlCommand command =
                           new SqlCommand(insertQuery, connection))
                    {
                        // =========================================
                        // STAFF ID
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@StaffID",
                            txtStaffID.Text.Trim());


                        // =========================================
                        // STUDENT ID
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@StudentID",
                            txtStudentID.Text.Trim());


                        // =========================================
                        // MEAL TYPE
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@MealType",
                            cmbmealtype.Text.Trim());


                        // =========================================
                        // MENU
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Menu",
                            cmbmenu.Text.Trim());


                        // =========================================
                        // MEAL BOOKING DATE
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@MealBookingDate",
                            dtpmealbook.Value.Date);


                        // =========================================
                        // PRICE
                        // =========================================
                        command.Parameters.AddWithValue(
                            "@Price",
                            price);


                        // =========================================
                        // INSERT NEW MEAL
                        // SQL SERVER GENERATES MealID
                        // =========================================
                        int generatedMealID =
                            Convert.ToInt32(
                                command.ExecuteScalar());


                        MessageBox.Show(
                            "Meal registered successfully!\n\n" +
                            "Meal ID: " + generatedMealID +
                            "\nStudent ID: " +
                            txtStudentID.Text.Trim(),
                            "Registration Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }


                // =========================================
                // CLEAR AFTER NEW REGISTRATION
                // =========================================
                ClearMealInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Meal registration failed.\n\n" +
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
            ClearMealInformation();
        }


        // =========================================
        // CLEAR MEAL INFORMATION
        // =========================================
        private void ClearMealInformation()
        {
            txtStaffID.Clear();

            txtStudentID.Clear();

            cmbmealtype.SelectedIndex = -1;

            cmbmenu.SelectedIndex = -1;

            dtpmealbook.Value = DateTime.Today;

            txtPrice.Clear();

            txtStaffID.Focus();
        }


        // =========================================
        // DESIGNER EVENTS
        // =========================================

        private void lblStaffID_Click(object sender, EventArgs e)
        {
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblmealtype_Click(object sender, EventArgs e)
        {
        }

        private void cmbmealtype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblmenu_Click(object sender, EventArgs e)
        {
        }

        private void cmbmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblmealbookdate_Click(object sender, EventArgs e)
        {
        }

        private void dtpmealbook_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblprice_Click(object sender, EventArgs e)
        {
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblmealbookingTitle_Click(object sender, EventArgs e)
        {
        }
    }
}