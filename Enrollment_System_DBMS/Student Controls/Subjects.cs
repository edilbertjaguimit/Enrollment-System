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
        private int SubjectID { get; set; }
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        
        public Subjects()
        {
            InitializeComponent();
            SemesterList();
            TblSubjects.BringToFront();
            TxtSearchSubject.BringToFront();
            DisplaySubjects();
            AllSubjectsIsEmpty();
            BtnAddSubject.Enabled = true;
        }

        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            if (!isTextEmpty())
            {
                try
                {
                    db.SP_INSERT_SUBJECT(TxtSectionCode.Text, TxtSubjectCode.Text, TxtSubjectDescription.Text, Convert.ToDouble(TxtUnits.Text), SemesterID);
                    ClearText(); 
                    DisplaySubjectsWithEnrolled();
                    DisplaySubjects();
                    MessageBox.Show("Successfully Added!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WithEnrolledIsEmpty();
                    AllSubjectsIsEmpty();
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

        public void DisplaySubjectsWithEnrolled()
        {
            try
            {
                TblAllSubjectsWithEnrolled.DataSource = db.SP_DISPLAY_ALL_SUBJECTS();
                if (TblSubjects.Rows.Count == 0)
                {
                    lblNoSubject.Text = "No Subjects Yet";
                    lblNoSubject.BringToFront();
                    TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    lblNoSubject.SendToBack();
                    TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DisplaySubjects()
        {
            try
            {
                TblSubjects.DataSource = db.SP_DISPLAY_SUBJECTS();
                if (TblSubjects.Rows.Count == 0)
                {
                    lblNoSubject.Text = "No Subjects Yet";
                    lblNoSubject.BringToFront();
                    TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    lblNoSubject.SendToBack();
                    TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                        cmd.CommandText = "SP_SEMESTER_ID";
                        cmd.Parameters.AddWithValue("KEY", CbSemester.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
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

        // Search for Subjects only
        private void TxtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            TblSubjects.DataSource = db.SP_SEARCH_SUBJECT_BY_TEXTBOX(TxtSearchSubject.Text);
            if (TblSubjects.Rows.Count == 0)
            {
                lblNoSubject.Text = "No Subject Found";
                lblNoSubject.BringToFront();
                TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                lblNoSubject.SendToBack();
                TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void TblSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentRecord = TblSubjects.CurrentRow;
            TblSubjects.CurrentRow.Selected = true;
            SubjectID = Convert.ToInt32(studentRecord.Cells[0].Value);
            TxtSectionCode.Text = studentRecord.Cells[1].Value.ToString();
            TxtSubjectCode.Text = studentRecord.Cells[2].Value.ToString();
            TxtSubjectDescription.Text = studentRecord.Cells[3].Value.ToString();
            TxtUnits.Text = studentRecord.Cells[4].Value.ToString();
            CbSemester.SelectedItem = studentRecord.Cells[5].Value.ToString();
            BtnAddSubject.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TblSubjects.SelectedRows.Count > 0 || TblAllSubjectsWithEnrolled.SelectedRows.Count > 0)
            {

                try
                {
                    db.SP_UPDATE_SUBJECT(SubjectID, TxtSectionCode.Text, TxtSubjectCode.Text, TxtSubjectDescription.Text, Convert.ToDouble(TxtUnits.Text));
                    MessageBox.Show("Subject Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplaySubjects();
                    DisplaySubjectsWithEnrolled();
                    ClearText();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TblSubjects.SelectedRows.Count > 0 || TblAllSubjectsWithEnrolled.SelectedRows.Count > 0)
            {

                try
                {
                    var result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        db.SP_DELETE_SUBJECT(SubjectID);
                        MessageBox.Show("Subject Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplaySubjectsWithEnrolled();
                        DisplaySubjects();
                        ClearText();
                        WithEnrolledIsEmpty(); 
                        AllSubjectsIsEmpty();
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

        // Search Subject with enrolled
        private void TxtSearchSubjectWithEnrolled_TextChanged(object sender, EventArgs e)
        {
            TblAllSubjectsWithEnrolled.DataSource = db.SP_SEARCH_SUBJECT(TxtSearchSubjectWithEnrolled.Text);
            if (TblAllSubjectsWithEnrolled.Rows.Count == 0)
            {
                lblNoSubject.Text = "No Subject Found";
                lblNoSubject.BringToFront();
                TblAllSubjectsWithEnrolled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                lblNoSubject.SendToBack();
                TblAllSubjectsWithEnrolled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void TblAllSubjectsWithEnrolled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentRecord = TblAllSubjectsWithEnrolled.CurrentRow;
            TblAllSubjectsWithEnrolled.CurrentRow.Selected = true;
            SubjectID = Convert.ToInt32(studentRecord.Cells[0].Value);
            TxtSectionCode.Text = studentRecord.Cells[1].Value.ToString();
            TxtSubjectCode.Text = studentRecord.Cells[2].Value.ToString();
            TxtSubjectDescription.Text = studentRecord.Cells[3].Value.ToString();
            TxtUnits.Text = studentRecord.Cells[4].Value.ToString();
            CbSemester.SelectedItem = studentRecord.Cells[5].Value.ToString();
        }


        private void BtnAllSubjects_Click(object sender, EventArgs e)
        {
            TblSubjects.BringToFront();
            TxtSearchSubject.BringToFront();
            DisplaySubjects();
            TxtSearchSubjectWithEnrolled.Text = "";
            AllSubjectsIsEmpty();
        }

        private void BtnWithEnrolledSubjects_Click(object sender, EventArgs e)
        {
            TblAllSubjectsWithEnrolled.BringToFront();
            TxtSearchSubjectWithEnrolled.BringToFront();
            DisplaySubjectsWithEnrolled();
            TxtSearchSubject.Text = "";
            WithEnrolledIsEmpty();
        }

        private void WithEnrolledIsEmpty()
        {
            if (TblAllSubjectsWithEnrolled.Rows.Count == 0)
            {
                lblNoSubject.BringToFront();
                lblNoSubject.Text = "No Enrollees Yet";
                TblAllSubjectsWithEnrolled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                lblNoSubject.SendToBack();
                TblAllSubjectsWithEnrolled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        private void AllSubjectsIsEmpty()
        {
            if (TblSubjects.Rows.Count == 0)
            {
                lblNoSubject.BringToFront();
                lblNoSubject.Text = "No Subjects Yet";
                TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                lblNoSubject.SendToBack();
                TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
