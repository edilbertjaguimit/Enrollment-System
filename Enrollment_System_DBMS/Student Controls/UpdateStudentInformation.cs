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
    public partial class UpdateStudentInformation : UserControl
    {
        public string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        private string Photo { get; set; }
        private string Gender { get; set; }

        private int ProgramID { get; set; }
        private int CollegeID { get; set; }

        private int YearLevelID { get; set; }
        private byte[] currentImage { get; set; }

        EnrollmentDBDataContext db = new EnrollmentDBDataContext();

        public UpdateStudentInformation()
        {
            InitializeComponent();
            YearLevelList();
            CollegeList();
            ProgramList();
            StudentDetails();
        }

        private void BtnBackToStudentInformation_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = this.ParentForm as Dashboard;
            if (dashboard != null)
            {
                StudentInformation studentInformation = new StudentInformation();
                studentInformation.Dock = DockStyle.Fill;
                dashboard.mainContent.Controls.Clear();
                dashboard.mainContent.Controls.Add(studentInformation);
            }
            else
            {
                MessageBox.Show("Dashboard not found. Make sure your Dashboard form is open.");
            }
        }

        private void BtnUpdateStudentInformation_Click(object sender, EventArgs e)
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
                        if (currentAge >= 18)
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
                                else
                                {
                                    if (currentImage != null)
                                    {
                                        try
                                        {
                                            photoBytes = currentImage;
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show($"An Image Error Occured: {ex}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No photo provided or available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return; // Exit the method to prevent further execution
                                    }
                                }
                                db.SP_UPDATE_STUDENT_INFORMATION(GetStudentID(), photoBytes, TxtFirstname.Text, TxtMiddlename.Text, TxtLastname.Text, currentAge.ToString(), birthDate, TxtPlaceBirth.Text, TxtAddress.Text, email, mobile, Gender, DateTime.Now, CollegeID, ProgramID, YearLevelID);
                                MessageBox.Show("Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //btlViewData.DataSource = db.sp_view();
                                StudentRecords records = new StudentRecords();
                                records.DisplayStudentRecords();
                                StudentDetails();
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

        public string GetStudentID()
        {
            string studID = "";
            try
            {
                using (var dbYearLevel = new SqlConnection(_conn))
                {
                    dbYearLevel.Open();
                    using (var cmd = dbYearLevel.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT ID FROM ID_STORAGE";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                studID = reader["ID"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return studID;
        }

        private void BtnReUploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
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

        private void CbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gender = CbGender.Text;
        }

        private void CbYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                            if (reader.Read())
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

        public void StudentDetails()
        {
            try
            {
                using (var db = new SqlConnection(_conn))
                {
                    db.Open();
                    using (var cmd = db.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_DISPLAY_STUDENT_INFORMATION";
                        cmd.Parameters.AddWithValue("KEY", GetStudentID());
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["STUD_PHOTO"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["STUD_PHOTO"];
                                    currentImage = imageData;

                                    if (imageData.Length > 2)
                                    {
                                        Image image;
                                        using (MemoryStream ms = new MemoryStream(imageData))
                                        {
                                            image = Image.FromStream(ms);
                                        }
                                        LblPhoto.Image = image;
                                    }
                                    else
                                    {
                                        this.LblPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                                        LblPhoto.Image = Image.FromFile("C:/Users/Sir/source/repos/Enrollment_System_DBMS/Enrollment_System_DBMS/Images/person.png");
                                    }
                                }
                                else
                                {
                                    this.LblPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                                    LblPhoto.Image = Image.FromFile("C:/Users/Sir/source/repos/Enrollment_System_DBMS/Enrollment_System_DBMS/Images/person.png");
                                }
                                lblStudentNumber.Text = reader["STUD_NUMBER"].ToString();
                                lblStudentID.Text = reader["STUD_ID"].ToString();
                                TxtFirstname.Text = reader["STUD_FIRSTNAME"].ToString();
                                TxtMiddlename.Text = reader["STUD_MIDDLENAME"].ToString();
                                TxtLastname.Text = reader["STUD_LASTNAME"].ToString();
                                DateTime birthDate = (DateTime)reader["STUD_BIRTH_DATE"];
                                DpBirthDate.Value = birthDate;
                                TxtPlaceBirth.Text = reader["STUD_PLACE_OF_BIRTH"].ToString();
                                TxtAddress.Text = reader["STUD_ADDRESS"].ToString();
                                TxtEmail.Text = reader["STUD_EMAIL"].ToString();
                                TxtMobile.Text = reader["STUD_MOBILE"].ToString();
                                CbGender.SelectedItem = reader["STUD_GENDER"].ToString();
                                CbYearLevel.SelectedItem = reader["YEAR_NAME"].ToString();
                                CbProgram.SelectedItem = reader["PROG_NAME"].ToString();
                                CbCollege.SelectedItem = reader["COLL_NAME"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //lblStudentID.Text = GetStudentID();

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

        private void UpdateStudentInformation_Load(object sender, EventArgs e)
        {
            StudentDetails();
        }
    }
}
