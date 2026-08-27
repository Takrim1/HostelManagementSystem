using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class A_VisitorRegistrationForm : Form
    {
        // =========================================
        // SQL SERVER CONNECTION
        // =========================================
        private readonly string connectionString =
            @"Server=DESKTOP-HJPSA8K;Database=SmartHostelDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // =========================================
        // EDIT VISITOR ID
        // 0 = ADD MODE
        // > 0 = EDIT MODE
        // =========================================
        private int editVisitorID = 0;


        // =========================================
        // NORMAL CONSTRUCTOR - ADD NEW VISITOR
        // =========================================
        public A_VisitorRegistrationForm()
        {
            InitializeComponent();
        }


        // =========================================
        // EDIT CONSTRUCTOR
        // =========================================
        public A_VisitorRegistrationForm(int visitorID)
        {
            InitializeComponent();

            editVisitorID = visitorID;
        }


        // =========================================
        // FORM LOAD
        // =========================================
        private void A_VisitorRegistrationForm_Load(
            object sender,
            EventArgs e)
        {
            LoadGender();
            LoadHostel();

            // =========================================
            // EDIT MODE
            // =========================================
            if (editVisitorID > 0)
            {
                LoadVisitorDataForEdit(editVisitorID);
            }
            else
            {
                // =========================================
                // ADD MODE
                // =========================================
                ShowNextVisitorID();

                dtVisit.Value = DateTime.Now;
            }
        }


        // =========================================
        // SHOW NEXT VISITOR ID
        // =========================================
        private void ShowNextVisitorID()
        {
            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    con.Open();

                    string query =
                        "SELECT ISNULL(MAX(VisitorID), 0) + 1 FROM Visitor";

                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        int nextID =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        txtVisitorID.Text =
                            nextID.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Visitor ID load করতে সমস্যা হয়েছে.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // LOAD GENDER
        // =========================================
        private void LoadGender()
        {
            cmbGender.Items.Clear();

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            cmbGender.SelectedIndex = -1;
        }


        // =========================================
        // LOAD HOSTEL
        // =========================================
        private void LoadHostel()
        {
            cmbhostel.Items.Clear();

            cmbhostel.Items.Add("Male Hostel A");
            cmbhostel.Items.Add("Male Hostel B");
            cmbhostel.Items.Add("Female Hostel A");
            cmbhostel.Items.Add("Female Hostel B");
            cmbhostel.SelectedIndex = -1;
        }


        // =========================================
        // LOAD VISITOR DATA FOR EDIT
        // =========================================
        private void LoadVisitorDataForEdit(int visitorID)
        {
            try
            {
                string query = @"
                    SELECT
                        VisitorID,
                        StudentID,
                        VisitorName,
                        Gender,
                        VisitDate,
                        Phone,
                        Relation,
                        Hostel
                    FROM Visitor
                    WHERE VisitorID = @VisitorID";


                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@VisitorID",
                            visitorID);

                        con.Open();

                        using (SqlDataReader reader =
                               cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // =========================================
                                // VISITOR ID
                                // =========================================
                                txtVisitorID.Text =
                                    reader["VisitorID"].ToString();


                                // =========================================
                                // STUDENT ID
                                // =========================================
                                txtStudentID.Text =
                                    reader["StudentID"].ToString();


                                // =========================================
                                // VISITOR NAME
                                // =========================================
                                txtVisitorName.Text =
                                    reader["VisitorName"].ToString();


                                // =========================================
                                // GENDER
                                // =========================================
                                if (reader["Gender"] != DBNull.Value)
                                {
                                    cmbGender.Text =
                                        reader["Gender"].ToString();
                                }
                                else
                                {
                                    cmbGender.SelectedIndex = -1;
                                }


                                // =========================================
                                // VISIT DATE
                                // =========================================
                                if (reader["VisitDate"] != DBNull.Value)
                                {
                                    dtVisit.Value =
                                        Convert.ToDateTime(
                                            reader["VisitDate"]);
                                }


                                // =========================================
                                // PHONE
                                // =========================================
                                if (reader["Phone"] != DBNull.Value)
                                {
                                    txtPhone.Text =
                                        reader["Phone"].ToString();
                                }
                                else
                                {
                                    txtPhone.Clear();
                                }


                                // =========================================
                                // RELATION
                                // =========================================
                                if (reader["Relation"] != DBNull.Value)
                                {
                                    txtrelation.Text =
                                        reader["Relation"].ToString();
                                }
                                else
                                {
                                    txtrelation.Clear();
                                }


                                // =========================================
                                // HOSTEL
                                // =========================================
                                if (reader["Hostel"] != DBNull.Value)
                                {
                                    cmbhostel.Text =
                                        reader["Hostel"].ToString();
                                }
                                else
                                {
                                    cmbhostel.SelectedIndex = -1;
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Visitor ID " +
                                    visitorID +
                                    " এর কোনো data পাওয়া যায়নি.",
                                    "Visitor Not Found",
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
                    "Visitor data load করতে সমস্যা হয়েছে.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // SAVE / ADD VISITOR
        // =========================================
        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            // =========================================
            // VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show(
                    "Student ID দিন.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentID.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtVisitorName.Text))
            {
                MessageBox.Show(
                    "Visitor Name দিন.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtVisitorName.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show(
                    "Phone Number দিন.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhone.Focus();
                return;
            }


            // =========================================
            // STUDENT ID NUMBER CHECK
            // =========================================
            if (!int.TryParse(
                    txtStudentID.Text.Trim(),
                    out int studentID))
            {
                MessageBox.Show(
                    "Student ID অবশ্যই number হতে হবে.",
                    "Invalid Student ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentID.Focus();
                return;
            }


            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        INSERT INTO Visitor
                        (
                            StudentID,
                            VisitorName,
                            Gender,
                            VisitDate,
                            Phone,
                            Relation,
                            Hostel
                        )
                        VALUES
                        (
                            @StudentID,
                            @VisitorName,
                            @Gender,
                            @VisitDate,
                            @Phone,
                            @Relation,
                            @Hostel
                        )";


                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@StudentID",
                            studentID);

                        cmd.Parameters.AddWithValue(
                            "@VisitorName",
                            txtVisitorName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Gender",
                            string.IsNullOrWhiteSpace(cmbGender.Text)
                                ? (object)DBNull.Value
                                : cmbGender.Text);

                        cmd.Parameters.AddWithValue(
                            "@VisitDate",
                            dtVisit.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@Phone",
                            string.IsNullOrWhiteSpace(txtPhone.Text)
                                ? (object)DBNull.Value
                                : txtPhone.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Relation",
                            string.IsNullOrWhiteSpace(txtrelation.Text)
                                ? (object)DBNull.Value
                                : txtrelation.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Hostel",
                            string.IsNullOrWhiteSpace(cmbhostel.Text)
                                ? (object)DBNull.Value
                                : cmbhostel.Text);


                        cmd.ExecuteNonQuery();
                    }
                }


                MessageBox.Show(
                    "Visitor information saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                ClearFields();

                ShowNextVisitorID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Visitor information save করতে সমস্যা হয়েছে.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // UPDATE VISITOR
        // =========================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // =========================================
            // VISITOR ID VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtVisitorID.Text))
            {
                MessageBox.Show(
                    "Visitor ID পাওয়া যায়নি.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            // =========================================
            // STUDENT ID VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show(
                    "Student ID দিন.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentID.Focus();
                return;
            }


            // =========================================
            // VISITOR NAME VALIDATION
            // =========================================
            if (string.IsNullOrWhiteSpace(txtVisitorName.Text))
            {
                MessageBox.Show(
                    "Visitor Name দিন.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtVisitorName.Focus();
                return;
            }


            // =========================================
            // ID NUMBER CHECK
            // =========================================
            if (!int.TryParse(
                    txtVisitorID.Text.Trim(),
                    out int visitorID))
            {
                MessageBox.Show(
                    "Visitor ID অবশ্যই number হতে হবে.",
                    "Invalid Visitor ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            if (!int.TryParse(
                    txtStudentID.Text.Trim(),
                    out int studentID))
            {
                MessageBox.Show(
                    "Student ID অবশ্যই number হতে হবে.",
                    "Invalid Student ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentID.Focus();
                return;
            }


            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    con.Open();


                    string query = @"
                        UPDATE Visitor
                        SET
                            StudentID = @StudentID,
                            VisitorName = @VisitorName,
                            Gender = @Gender,
                            VisitDate = @VisitDate,
                            Phone = @Phone,
                            Relation = @Relation,
                            Hostel = @Hostel
                        WHERE VisitorID = @VisitorID";


                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@VisitorID",
                            visitorID);

                        cmd.Parameters.AddWithValue(
                            "@StudentID",
                            studentID);

                        cmd.Parameters.AddWithValue(
                            "@VisitorName",
                            txtVisitorName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Gender",
                            string.IsNullOrWhiteSpace(cmbGender.Text)
                                ? (object)DBNull.Value
                                : cmbGender.Text);

                        cmd.Parameters.AddWithValue(
                            "@VisitDate",
                            dtVisit.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@Phone",
                            string.IsNullOrWhiteSpace(txtPhone.Text)
                                ? (object)DBNull.Value
                                : txtPhone.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Relation",
                            string.IsNullOrWhiteSpace(txtrelation.Text)
                                ? (object)DBNull.Value
                                : txtrelation.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Hostel",
                            string.IsNullOrWhiteSpace(cmbhostel.Text)
                                ? (object)DBNull.Value
                                : cmbhostel.Text);


                        int rows =
                            cmd.ExecuteNonQuery();


                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Visitor information updated successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            LoadVisitorDataForEdit(editVisitorID);
                        }
                        else
                        {
                            MessageBox.Show(
                                "এই Visitor ID-এর কোনো data পাওয়া যায়নি.",
                                "Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Visitor information update করতে সমস্যা হয়েছে.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // DELETE VISITOR
        // =========================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVisitorID.Text))
            {
                MessageBox.Show(
                    "Visitor ID পাওয়া যায়নি.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            if (!int.TryParse(
                    txtVisitorID.Text.Trim(),
                    out int visitorID))
            {
                MessageBox.Show(
                    "Visitor ID অবশ্যই number হতে হবে.",
                    "Invalid Visitor ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            DialogResult result =
                MessageBox.Show(
                    "আপনি কি Visitor ID " +
                    visitorID +
                    " delete করতে চান?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


            if (result != DialogResult.Yes)
            {
                return;
            }


            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    con.Open();


                    string query = @"
                        DELETE FROM Visitor
                        WHERE VisitorID = @VisitorID";


                    using (SqlCommand cmd =
                           new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@VisitorID",
                            visitorID);


                        int rows =
                            cmd.ExecuteNonQuery();


                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Visitor information deleted successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                            ClearFields();

                            ShowNextVisitorID();
                        }
                        else
                        {
                            MessageBox.Show(
                                "এই Visitor ID-এর কোনো data পাওয়া যায়নি.",
                                "Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Visitor information delete করতে সমস্যা হয়েছে.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================
        // CLEAR BUTTON
        // =========================================
        private void btnClear_Click_1(
            object sender,
            EventArgs e)
        {
            ClearFields();

            ShowNextVisitorID();
        }


        // =========================================
        // CLEAR ALL FIELDS
        // =========================================
        private void ClearFields()
        {
            txtStudentID.Clear();

            txtVisitorName.Clear();

            txtPhone.Clear();

            txtrelation.Clear();


            cmbGender.SelectedIndex = -1;

            cmbhostel.SelectedIndex = -1;


            dtVisit.Value = DateTime.Now;


            txtStudentID.Focus();
        }


        // =========================================
        // EXISTING EVENTS
        // =========================================

        private void lblGender_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblvisitorTitle_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblVisitorID_Click(
            object sender,
            EventArgs e)
        {
        }


        private void txtVisitorID_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        private void lblStudentID_Click(
            object sender,
            EventArgs e)
        {
        }


        private void txtStudentID_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        private void lblVisitorName_Click(
            object sender,
            EventArgs e)
        {
        }


        private void txtVisitorName_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        private void cmbGender_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        private void lblDOB_Click(
            object sender,
            EventArgs e)
        {
        }


        private void dtVisit_ValueChanged(
            object sender,
            EventArgs e)
        {
        }


        private void lblPhone_Click(
            object sender,
            EventArgs e)
        {
        }


        private void txtPhone_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        private void lblRelation_Click(
            object sender,
            EventArgs e)
        {
        }


        private void txtrelation_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        private void A_VisitorRegistrationForm_Load_1(
            object sender,
            EventArgs e)
        {
        }


        private void lblhostel_Click(
            object sender,
            EventArgs e)
        {
        }


        private void cmbhostel_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


   
    }
}