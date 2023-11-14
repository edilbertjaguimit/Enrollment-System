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
using Enrollment_System_DBMS.Student_Controls;

namespace Enrollment_System_DBMS
{
    public partial class AddProgram : Form
    {
        public string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        private int CollegeID { get; set; }
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();

        public AddProgram()
        {
            InitializeComponent();
            CollegeList();
        }
        private void BtnCancelProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAddProgram_Click(object sender, EventArgs e)
        {
            if(txtProgramName.Text != "" && CbCollege.SelectedIndex != -1)
            {
                try
                {
                    db.SP_INSERT_PROGRAM(txtProgramName.Text, DateTime.Now, DateTime.Now, CollegeID);
                    MessageBox.Show("Program Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProgramName.Text = "";
                    CbCollege.SelectedIndex = -1;
                    this.Close();
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
