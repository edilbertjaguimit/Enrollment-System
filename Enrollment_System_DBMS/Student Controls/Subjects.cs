using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System_DBMS.Student_Controls
{
    public partial class Subjects : UserControl
    {
        public string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        private int SemesterID { get; set; }
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();
            SemesterList();
            SubjectList();
        }

        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            if (!isTextEmpty())
            {
                try
                {
                    db.SP_INSERT_SUBJECT(TxtSectionCode.Text, TxtSubjectCode.Text, TxtSubjectDescription.Text, Convert.ToDouble(TxtUnits.Text), SemesterID);
                    ClearText();
                    MessageBox.Show("Successfully Added!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Input Field Are Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void DisplaySubjects()
        {
            try
            {
                TblSubjects.DataSource = db.SP_DISPLAY_ALL_SUBJECTS();
                if (TblSubjects.Rows.Count == 0)
                {
                    lblNoSubject.Text = "No Subjects Yet";
                    lblNoSubject.Visible = true;
                    TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    lblNoSubject.Visible = false;
                    TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void AcademicYearList()
        //{
        //    try
        //    {
        //        using (var dbAcadYear = new SqlConnection(_conn))
        //        {
        //            dbAcadYear.Open();
        //            using (var cmd = dbAcadYear.CreateCommand())
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.CommandText = "SP_ACADEMIC_YEAR";
        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        string acadYear = reader["ACAD_YEAR"].ToString();
        //                        CbAcademicYear.Items.Add(acadYear);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
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
                                CbSemester.Items.Add(semName);
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

        }

        // Clear Text
        private void ClearText()
        {
            TxtSubjectDescription.Text = "";
            TxtUnits.Text = "";
            TxtSectionCode.Text = "";
            TxtSubjectCode.Text = "";
            CbSemester.SelectedIndex = -1;
        }

        // Check the field if it is empty
        private bool isTextEmpty()
        {
            if (TxtSubjectDescription.Text == "" ||
                CbSemester.SelectedIndex == -1 ||
                TxtUnits.Text == "" ||
                TxtSectionCode.Text == "" ||
                TxtSubjectCode.Text == "")
            {
                return true;
            }
            return false;
        }

        private void CbSemester_SelectedIndexChanged(object sender, EventArgs e)
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
                                SemesterID = (int)reader["SEM_ID"];
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

        private void TxtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            TblSubjects.DataSource = db.SP_SEARCH_SUBJECT(TxtSearchSubject.Text);
            if (TblSubjects.Rows.Count == 0)
            {
                lblNoSubject.Text = "No Student Found";
                lblNoSubject.Visible = true;
                TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                lblNoSubject.Visible = false;
                TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void TblSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentRecord = TblSubjects.CurrentRow;
            TblSubjects.CurrentRow.Selected = true;
            //try
            //{
            //    db.SP_ID_STORAGE(studentRecord.Cells[0].Value.ToString());

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An Error Occured: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //StudentID = studentRecord.Cells[0].Value.ToString();
        }
    }
}
