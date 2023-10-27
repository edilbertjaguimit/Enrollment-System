using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System_DBMS.Student_Controls
{
    public partial class StudentRecords : UserControl
    {
        public StudentRecords()
        {
            InitializeComponent();
        }
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
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
            AddStudent student = new AddStudent
            {
                StudentID = studentRecord.Cells[0].Value.ToString()
            };
            //AddStudent student = new AddStudent
            //{
            //    StudentID = TblStudentRecords.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString()
            //};
            TblStudentRecords.CurrentRow.Selected = true;
            MessageBox.Show($"{student.StudentID}");
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
            //if(TblStudentRecords.Rows. > 0)
            //{
            //    StudentInformation info = new StudentInformation();
            //    //info.BringToFront();
            //    info.Show();
            //    this.Hide();
            //}
        }
    }
}
