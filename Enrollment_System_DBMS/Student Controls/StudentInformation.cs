using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Enrollment_System_DBMS.Student_Controls
{
    //public interface IStudentInformation
    //{
    //    void GetStudentID(string student);
    //}
    public partial class StudentInformation : UserControl
    {
        public string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        public StudentInformation()
        {
            InitializeComponent();
            StudentDetails();
            AcademicYearList();
            SemesterList();
            SubjectList();
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {

        }

        public void StudentDetails()
        {
            //MessageBox.Show($"{GetStudentID()}");
            try
            {
                //MessageBox.Show($"{GetStudentID()} Hello");
                using (var db = new SqlConnection(_conn))
                {
                //MessageBox.Show($"{GetStudentID()} Hi");
                    db.Open();
                    using (var cmd = db.CreateCommand())
                    {
                        //MessageBox.Show($"{GetStudentID()} Musta?");

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

                                    if (imageData.Length > 2)
                                    {
                                        Image image;
                                        using (MemoryStream ms = new MemoryStream(imageData))
                                        {
                                            image = Image.FromStream(ms);
                                        }
                                        lblPhoto.Image = image;
                                    }
                                    else
                                    {
                                        this.lblPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                                        lblPhoto.Image = Image.FromFile("C:/Users/Sir/source/repos/Enrollment_System_DBMS/Enrollment_System_DBMS/Images/person.png");
                                    }
                                }
                                else
                                {
                                    this.lblPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                                    lblPhoto.Image = Image.FromFile("C:/Users/Sir/source/repos/Enrollment_System_DBMS/Enrollment_System_DBMS/Images/person.png");
                                }
                                lblStudentNumber.Text = reader["STUD_NUMBER"].ToString();
                                lblStudentID.Text = reader["STUD_ID"].ToString();
                                lblName.Text = reader["Name"].ToString();
                                lblAge.Text = reader["STUD_AGE"].ToString();
                                DateTime birthDate = (DateTime)reader["STUD_BIRTH_DATE"];
                                string formattedDate = birthDate.ToString("MMMM d, yyyy");
                                lblBirthDate.Text = formattedDate;
                                lblBirthPlace.Text = reader["STUD_PLACE_OF_BIRTH"].ToString();
                                lblAddress.Text = reader["STUD_ADDRESS"].ToString();
                                lblEmail.Text = reader["STUD_EMAIL"].ToString();
                                lblMobile.Text = reader["STUD_MOBILE"].ToString();
                                lblStatus.Text = reader["STUD_STATUS"].ToString();
                                lblYearLevel.Text = reader["YEAR_ID"].ToString();
                                lblProgram.Text = reader["PROG_NAME"].ToString();
                                lblCollege.Text = reader["COLL_NAME"].ToString();
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

        private void BtnBackToStudentRecords_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = this.ParentForm as Dashboard;
            if (dashboard != null)
            {
                StudentRecords studentRecords = new StudentRecords();
                studentRecords.Dock = DockStyle.Fill;
                dashboard.mainContent.Controls.Clear();
                dashboard.mainContent.Controls.Add(studentRecords);
            }
            else
            {
                MessageBox.Show("Dashboard not found. Make sure your Dashboard form is open.");
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

        private void BtnUpdateStudentInformation_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = this.ParentForm as Dashboard;
            if (dashboard != null)
            {
                UpdateStudentInformation updateStudentInformation = new UpdateStudentInformation();
                updateStudentInformation.Dock = DockStyle.Fill;
                dashboard.mainContent.Controls.Clear();
                dashboard.mainContent.Controls.Add(updateStudentInformation);
            }
            else
            {
                MessageBox.Show("Dashboard not found. Make sure your Dashboard form is open.");
            }
        }

        private void CbStudentAcadYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbStudentSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbStudentSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AcademicYearList()
        {
            try
            {
                using (var dbAcadYear = new SqlConnection(_conn))
                {
                    dbAcadYear.Open();
                    using (var cmd = dbAcadYear.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_ACADEMIC_YEAR";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string acadYear = reader["ACAD_YEAR"].ToString();
                                CbStudentAcadYear.Items.Add(acadYear);
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
        public void SemesterList()
        {
            try
            {
                using (var dbSemester = new SqlConnection(_conn))
                {
                    dbSemester.Open();
                    using (var cmd = dbSemester.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_SEMESTER";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string semName = reader["SEM_NAME"].ToString();
                                CbStudentSemester.Items.Add(semName);
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

        public void SubjectList()
        {
            try
            {
                using (var dbSubject = new SqlConnection(_conn))
                {
                    dbSubject.Open();
                    using (var cmd = dbSubject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_SUBJECT_LIST";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string subName = reader["SUB_DESCRIPTION"].ToString();
                                CbStudentSemester.Items.Add(subName);
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
    }
}
