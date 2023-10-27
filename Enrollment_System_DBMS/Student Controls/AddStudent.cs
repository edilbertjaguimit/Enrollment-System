using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System_DBMS.Student_Controls
{
    public partial class AddStudent : UserControl
    {
        public string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        //public int ID { get; set; }
        public string StudentID { get; set; }
        public string Photo { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }
        public string BirthDate { get; set; }
        public string PlaceBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }

        public int ProgramID { get; set; }
        //string ProgramName { get; set; }
        public int CollegeID { get; set; }
        //string CollegeName { get; set; }

        public int YearLevelID { get; set; }

        public int AcademicID { get; set; }
        public int SubjectID { get; set; }

        EnrollmentDBDataContext db = new EnrollmentDBDataContext();

        public AddStudent()
        {
            InitializeComponent();
            YearLevelList();
            CollegeList();
            ProgramList();
        }

        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    Photo = dialog.FileName;
                    LblPhoto.ImageLocation = Photo;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (!isTextEmpty())
            {
                DateTime birthDate = DpBirthDate.Value;
                TimeSpan age = DateTime.Now - birthDate;
                int currentAge = (int)(age.TotalDays / 365.25);
                string email = TxtEmail.Text;
                string mobile = TxtMobile.Text;
                bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                bool isNumeber = Regex.IsMatch(mobile, @"^(09|\+639)\d{9}$");
                if (isNumeber)
                {
                    if (isEmail)
                    {
                        if(currentAge >= 18)
                        {
                            try
                            {
                                byte[] photoBytes = null;
                                if (!string.IsNullOrEmpty(Photo))
                                {
                                    try
                                    {
                                        photoBytes = File.ReadAllBytes(Photo);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Error reading the photo file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return; // Exit the method to prevent further execution
                                    }
                                }
                                db.SP_INSERT_STUDENT_INFORMATION(photoBytes, TxtFirstname.Text, TxtMiddlename.Text, TxtLastname.Text, currentAge.ToString(), birthDate, TxtPlaceBirth.Text, TxtAddress.Text, email, mobile, Gender, "Pending", DateTime.Now, DateTime.Now, CollegeID, ProgramID, YearLevelID);
                                ClearText();
                                MessageBox.Show("Successfully Added!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //btlViewData.DataSource = db.sp_view();
                                StudentRecords records = new StudentRecords();
                                records.DisplayStudentRecords();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student's age is not eligible for college. Please set the birth date correctly.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Mobile Number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Input Field Are Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gender = CbGender.Text;
            //if (!emptyGender)
            //{
            //}
            //else
            //    CbGender.Text = "";
        }

        // Year Level Combobox
        private void CbYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (CbYearLevel.Text)
            //{
            //    case "First Year":
            //        YearLevelID = 1;
            //        break;
            //    case "Second Year":
            //        YearLevelID = 2;
            //        break;
            //    case "Third Year":
            //        YearLevelID = 3;
            //        break;
            //    case "Fourth Year":
            //        YearLevelID = 4;
            //        break;
            //    case "Fifth Year":
            //        YearLevelID = 5;
            //        break;
            //}
            try
            {
                using (var dbYearLevel = new SqlConnection(_conn))
                {
                    dbYearLevel.Open();
                    using (var cmd = dbYearLevel.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.CommandText = "SELECT COLL_ID FROM COLLEGE WHERE COLL_NAME = '"+ CbCollege.Text + "'";
                        cmd.CommandText = "SP_YEAR_LEVEL_ID";
                        cmd.Parameters.AddWithValue("YEAR_NAME", CbYearLevel.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                YearLevelID = Convert.ToInt32(reader["YEAR_ID"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // College Combobox
        private void CbCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var dbCollege = new SqlConnection(_conn))
                {
                    dbCollege.Open();
                    using (var cmd = dbCollege.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.CommandText = "SELECT COLL_ID FROM COLLEGE WHERE COLL_NAME = '"+ CbCollege.Text + "'";
                        cmd.CommandText = "SP_COLLEGE_ID";
                        cmd.Parameters.AddWithValue("COLL_NAME", CbCollege.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                CollegeID = Convert.ToInt32(reader["COLL_ID"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Program Combobox
        private void CbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var dbProgram = new SqlConnection(_conn))
                {
                    dbProgram.Open();
                    using (var cmd = dbProgram.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.CommandText = "SELECT PROG_ID FROM PROGRAM WHERE PROG_NAME = '" + CbProgram.Text + "'";
                        cmd.CommandText = "SP_PROGRAM_ID";
                        cmd.Parameters.AddWithValue("PROG_NAME", CbProgram.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ProgramID = Convert.ToInt32(reader["PROG_ID"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Year Level Name Combobox
        public void YearLevelList()
        {
            try
            {
                using (var dbYearLevel = new SqlConnection(_conn))
                {
                    dbYearLevel.Open();
                    using (var cmd = dbYearLevel.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_YEAR_LEVEL";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string yearLevel = reader["YEAR_NAME"].ToString();
                                CbYearLevel.Items.Add(yearLevel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // College Name Combobox
        public void CollegeList()
        {
            try
            {
                using (var dbCollege = new SqlConnection(_conn))
                {
                    dbCollege.Open();
                    using (var cmd = dbCollege.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_COLLEGE";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string college = reader["COLL_NAME"].ToString();
                                CbCollege.Items.Add(college);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Program Name Combobox
        public void ProgramList()
        {
            try
            {
                using (var dbProgram = new SqlConnection(_conn))
                {
                    dbProgram.Open();
                    using (var cmd = dbProgram.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_PROGRAM";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string program = reader["PROG_NAME"].ToString();
                                CbProgram.Items.Add(program);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear Text
        private void ClearText()
        {
            TxtFirstname.Text = "";
            TxtMiddlename.Text = "";
            TxtLastname.Text = "";
            DpBirthDate.Value = DateTime.Now;
            TxtAddress.Text = "";
            TxtMobile.Text = "";
            TxtEmail.Text = "";
            TxtPlaceBirth.Text = "";
            //CbGender.Text = "";
            CbGender.SelectedIndex = -1;
            CbYearLevel.SelectedIndex = -1;
            CbProgram.SelectedIndex = -1;
            CbCollege.SelectedIndex = -1;
        }

        // Check the field if it is empty
        private bool isTextEmpty()
        {
            if (TxtFirstname.Text == "" ||
            TxtLastname.Text == "" ||
            TxtAddress.Text == "" ||
            TxtMobile.Text == "" ||
            TxtEmail.Text == "" ||
            TxtPlaceBirth.Text == "" ||
            CbGender.Text == "" ||
            CbYearLevel.Text == "" ||
            CbProgram.Text == "" ||
            CbCollege.Text == "")
            {
                return true;
            }
            return false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}

