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
    public partial class HomeDashboard : UserControl
    {
        public string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        public HomeDashboard()
        {
            InitializeComponent();
            CountAllColleges();
            CountAllPrograms();
            CountAllStudents();
        }

        private void HomeDashboard_Load(object sender, EventArgs e)
        {
            
        }

        public void CountAllColleges()
        {
            try
            {
                using(var db1 = new SqlConnection(_conn))
                {
                    db1.Open();
                    using(var cmd = db1.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_COUNT_COLLEGES";
                        int count = (int)cmd.ExecuteScalar();
                        lblNumberOfColleges.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CountAllPrograms()
        {
            try
            {
                using (var db1 = new SqlConnection(_conn))
                {
                    db1.Open();
                    using (var cmd = db1.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_COUNT_PROGRAMS";
                        int count = (int)cmd.ExecuteScalar();
                        lblNumberOfPrograms.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CountAllStudents()
        {
            try
            {
                using (var db1 = new SqlConnection(_conn))
                {
                    db1.Open();
                    using (var cmd = db1.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_COUNT_ALL_STUDENTS";
                        int count = (int)cmd.ExecuteScalar();
                        lblNumberOfStudents.Text = count.ToString();
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
