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

namespace Enrollment_System_DBMS
{
    public partial class UpdateProgram : Form
    {
        public string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        private int CollegeID { get; set; }
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();

        public UpdateProgram()
        {
            InitializeComponent();
            CollegeList();
        }

        private void BtnCancelProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnUpdateProgram_Click(object sender, EventArgs e)
        {
            //Update
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
                                CollegeID = Convert.ToInt32(reader["COLL_ID"]); // PASS THIS ID TO CbProgram
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
    }
}
