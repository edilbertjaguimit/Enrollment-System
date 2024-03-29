﻿using System;
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

        private string EnrollID { get; set; }
        private int SemesterID { get; set; }
        private int SubjectID { get; set; }
        private int AcademicYearID { get; set; }

        EnrollmentDBDataContext db = new EnrollmentDBDataContext();

        public StudentInformation()
        {
            InitializeComponent();
            StudentDetails();
            AcademicYearList();
            SemesterList();
            SubjectList();
            SpecificSubjectList();
            DisplayStudentSubjects();
            CbStudentSemester.SelectedIndex = 0;
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
                using (var dbStudent = new SqlConnection(_conn))
                {
                    //MessageBox.Show($"{GetStudentID()} Hi");
                    dbStudent.Open();
                    using (var cmd = dbStudent.CreateCommand())
                    {
                        //MessageBox.Show($"{GetStudentID()} Musta?");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_DISPLAY_STUDENT_INFORMATION_LEFT_JOIN";
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
            try
            {
                using (var dbAcadYear = new SqlConnection(_conn))
                {
                    dbAcadYear.Open();
                    using (var cmd = dbAcadYear.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_ACADEMIC_YEAR_ID";
                        cmd.Parameters.AddWithValue("KEY", CbStudentAcadYear.Text);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            AcademicYearID = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbStudentSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var dbSemester = new SqlConnection(_conn))
                {
                    dbSemester.Open();
                    using (var cmd = dbSemester.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_SEMESTER_ID";
                        cmd.Parameters.AddWithValue("KEY", CbStudentSemester.Text);
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            SemesterID = (int)result;
                        }
                        CbStudentSubject.Items.Clear();
                        SpecificSubjectList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Subject combobox
        private void CbStudentSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var dbSubject = new SqlConnection(_conn))
                {
                    dbSubject.Open();
                    using (var cmd = dbSubject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_SUBJECT_ID";
                        cmd.Parameters.AddWithValue("KEY", CbStudentSubject.Text);
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            SubjectID = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AcademicYearList()
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
        private void SemesterList()
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

        private void SubjectList()
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
                                CbStudentSubject.Items.Add(subName);
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

        private void SpecificSubjectList()
        {
            try
            {
                using (var dbSubject = new SqlConnection(_conn))
                {
                    dbSubject.Open();
                    using (var cmd = dbSubject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_SPECIFIC_SUBJECT_FROM_SEMESTER";
                        cmd.Parameters.AddWithValue("@KEY", SemesterID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string subName = reader["SUB_DESCRIPTION"].ToString();
                                CbStudentSubject.Items.Add(subName);
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

        private int StudentNumber()
        {
            int studentNumber = 0;
            try
            {
                using (var dbSubject = new SqlConnection(_conn))
                {
                    dbSubject.Open();
                    using (var cmd = dbSubject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_STUDENT_NUMBER";
                        cmd.Parameters.AddWithValue("@KEY", GetStudentID());
                        studentNumber = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return studentNumber;
        }

        private void BtnAddSubjectToStudent_Click(object sender, EventArgs e)
        {
            if (CbStudentAcadYear.SelectedIndex != -1 && CbStudentSemester.SelectedIndex != -1 && CbStudentSubject.SelectedIndex != -1)
            {
                try
                {
                    db.SP_ENROLL_STUDENT_TO_SUBJECTS(DateTime.Now, DateTime.Now, AcademicYearID, SubjectID, SemesterID, StudentNumber());
                    MessageBox.Show("Student Successfully Enrolled to a Subject", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentDetails();
                    DisplayStudentSubjects();
                    CbStudentAcadYear.SelectedIndex = -1;
                    CbStudentSemester.SelectedIndex = 0;
                    CbStudentSubject.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Field is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void DisplayStudentSubjects()
        {
            try
            {
                if (TblStudentSubjects.Rows.Count == 0)
                {
                    lblNoSubject.Text = "No Subjects Yet";
                    lblNoSubject.Visible = true;
                    TblStudentSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    lblNoSubject.Visible = false;
                    TblStudentSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    TblStudentSubjects.Rows.Clear();
                    //TblStudentSubjects.DataSource = db.SP_DISPLAY_STUDENT_SUBJECTS();
                    using (var dbStudSub = new SqlConnection(_conn))
                    {
                        dbStudSub.Open();
                        using (var cmd = dbStudSub.CreateCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "SP_DISPLAY_STUDENT_SUBJECTS";
                            cmd.Parameters.AddWithValue("KEY", StudentNumber());
                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int rowIndex = TblStudentSubjects.Rows.Add();
                                    TblStudentSubjects.Rows[rowIndex].Cells[0].Value = reader["ID"].ToString();
                                    TblStudentSubjects.Rows[rowIndex].Cells[1].Value = reader["SECTION"].ToString();
                                    TblStudentSubjects.Rows[rowIndex].Cells[2].Value = reader["SUBJECT"].ToString();
                                    TblStudentSubjects.Rows[rowIndex].Cells[3].Value = reader["DESCRIPTION"].ToString();
                                    TblStudentSubjects.Rows[rowIndex].Cells[4].Value = reader["UNITS"].ToString();
                                    TblStudentSubjects.Rows[rowIndex].Cells[5].Value = reader["ACADEMIC YEAR"].ToString();
                                    TblStudentSubjects.Rows[rowIndex].Cells[6].Value = reader["SEMESTER"].ToString();
                                    DateTime birthDate = (DateTime)reader["DATE"];
                                    string formattedDate = birthDate.ToString("MMMM d, yyyy");
                                    TblStudentSubjects.Rows[rowIndex].Cells[7].Value = formattedDate;
                                }
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

        private void TblStudentSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentRecord = TblStudentSubjects.CurrentRow;
            TblStudentSubjects.CurrentRow.Selected = true;
            if(studentRecord.Cells[1].Value != null && studentRecord.Cells[2].Value != null && studentRecord.Cells[4].Value != null && studentRecord.Cells[5].Value != null)
            {
                EnrollID = studentRecord.Cells[0].Value.ToString();
                CbStudentAcadYear.SelectedItem = studentRecord.Cells[5].Value.ToString();
                CbStudentSemester.SelectedItem = studentRecord.Cells[6].Value.ToString();
                CbStudentSubject.SelectedItem = studentRecord.Cells[3].Value.ToString();
            }
            BtnAddSubjectToStudent.Enabled = false;
        }

        private void TxtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            SearchStudentSubject(TxtSearchSubject.Text);
            if (TblStudentSubjects.Rows[0].Cells[0].Value?.ToString() == null)
            {
                lblNoSubject.Text = "No Subject Found";
                lblNoSubject.Visible = true;
                TblStudentSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                lblNoSubject.Visible = false;
                TblStudentSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        private void SearchStudentSubject(string searchKey)
        {
            try
            {
                TblStudentSubjects.Rows.Clear();
                using (var dbStudSub = new SqlConnection(_conn))
                {
                    dbStudSub.Open();
                    using (var cmd = dbStudSub.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_SEARCH_STUDENT_SUBJECT";
                        cmd.Parameters.AddWithValue("ID", StudentNumber());
                        cmd.Parameters.AddWithValue("KEY", searchKey);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int rowIndex = TblStudentSubjects.Rows.Add();
                                TblStudentSubjects.Rows[rowIndex].Cells[0].Value = reader["ID"].ToString();
                                TblStudentSubjects.Rows[rowIndex].Cells[1].Value = reader["SECTION"].ToString();
                                TblStudentSubjects.Rows[rowIndex].Cells[2].Value = reader["SUBJECT"].ToString();
                                TblStudentSubjects.Rows[rowIndex].Cells[3].Value = reader["DESCRIPTION"].ToString();
                                TblStudentSubjects.Rows[rowIndex].Cells[4].Value = reader["UNITS"].ToString();
                                TblStudentSubjects.Rows[rowIndex].Cells[5].Value = reader["ACADEMIC YEAR"].ToString();
                                TblStudentSubjects.Rows[rowIndex].Cells[6].Value = reader["SEMESTER"].ToString();
                                DateTime birthDate = (DateTime)reader["DATE"];
                                string formattedDate = birthDate.ToString("MMMM d, yyyy");
                                TblStudentSubjects.Rows[rowIndex].Cells[7].Value = formattedDate;
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

        private void BtnUpdateSubject_Click(object sender, EventArgs e)
        {
            if (TblStudentSubjects.SelectedRows.Count > 0)
            {
                if (CbStudentAcadYear.SelectedIndex != -1 && CbStudentSemester.SelectedIndex != -1 && CbStudentSubject.SelectedIndex != -1)
                {
                
                    try
                    {
                        db.SP_UPDATE_STUDENT_SUBJECT(DateTime.Now, AcademicYearID, SemesterID, SubjectID, Convert.ToInt32(EnrollID), StudentNumber());
                        MessageBox.Show("Student Subject Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayStudentSubjects();
                        CbStudentAcadYear.SelectedIndex = -1;
                        CbStudentSemester.SelectedIndex = 0;
                        CbStudentSubject.SelectedIndex = -1;
                        BtnAddSubjectToStudent.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Program Field is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a Subject", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (TblStudentSubjects.SelectedRows.Count > 0)
            {

                try
                {
                    var result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        db.SP_DELETE_STUDENT_SUBJECT(Convert.ToInt32(EnrollID), StudentNumber());
                        MessageBox.Show("Student Subject Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayStudentSubjects();
                        CbStudentAcadYear.SelectedIndex = -1;
                        CbStudentSemester.SelectedIndex = 0;
                        CbStudentSubject.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a Subject", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
