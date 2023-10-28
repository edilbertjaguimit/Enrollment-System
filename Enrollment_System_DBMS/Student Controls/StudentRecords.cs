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
    public partial class StudentRecords : UserControl
    {
        public string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        string StudentID { get; set; }
        //private readonly IStudentInformation _information;
        public StudentRecords()
        {
            InitializeComponent();
        }

        //public StudentRecords(IStudentInformation information)
        //{
        //    _information = information;
        //}
        private void StudentRecords_Load(object sender, EventArgs e)
        {
            DisplayStudentRecords();
        }
        public void DisplayStudentRecords()
        {
            TblStudentRecords.DataSource = db.SP_DISPLAY_STUDENT_RECORDS();
            if (TblStudentRecords.Rows.Count == 0)
            {
                lblNoStudentFound.Visible = true;
                TblStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                lblNoStudentFound.Visible = false;
                TblStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void TblStudentRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentRecord = TblStudentRecords.CurrentRow;
            TblStudentRecords.CurrentRow.Selected = true;
            try
            {
                db.SP_ID_STORAGE(studentRecord.Cells[0].Value.ToString());
                MessageBox.Show(studentRecord.Cells[0].Value.ToString());

            }catch(Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            StudentID = studentRecord.Cells[0].Value.ToString();
        }

        private void TxtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            TblStudentRecords.DataSource = db.SP_SEARCH_STUDENT_RECORDS_BY_TEXTBOX(TxtSearchStudent.Text);
            if (TblStudentRecords.Rows.Count == 0)
            {
                lblNoStudentFound.Visible = true;
                TblStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                lblNoStudentFound.Visible = false;
                TblStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void BtnStudentDetails_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = this.ParentForm as Dashboard;
            if (dashboard != null)
            {
                if (TblStudentRecords.SelectedRows.Count > 0)
                {
                    StudentInformation studentInformation = new StudentInformation();
                    studentInformation.Dock = DockStyle.Fill;
                    dashboard.mainContent.Controls.Clear();
                    dashboard.mainContent.Controls.Add(studentInformation);
                }
                else
                {
                    MessageBox.Show("Please select a student", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Dashboard not found. Make sure your Dashboard form is open.");
            }
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (TblStudentRecords.SelectedRows.Count > 0)
            {
                try
                {
                    var result = MessageBox.Show("Are sure you want to delete?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        db.SP_DELETE_STUDENT(StudentID);
                        MessageBox.Show("Student Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayStudentRecords();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An Error Occured: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
