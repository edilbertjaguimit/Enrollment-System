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
    public partial class StudentInformation : UserControl
    {
        public StudentInformation()
        {
            InitializeComponent();
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {
            StudentDetails();
        }

        public async Task StudentDetails()
        {
            AddStudent student = new AddStudent();
            //using(var db = new SqlConnection(student._conn))
            //{
            //    await db.OpenAsync();
            //    using(var cmd = db.CreateCommand())
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.CommandText = "";

            //        using(SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            if (await reader.ReadAsync())
            //            {
            //                lblStudentID.Text = student.StudentID;
            //            }
            //        }
            //    }
            //}
            lblStudentID.Text = student.StudentID;

        }

        private void BtnBackToStudentRecords_Click(object sender, EventArgs e)
        {
            StudentRecords records = new StudentRecords();
            records.Show();
            this.Hide();
        }
    }
}
