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
    public partial class UpdateCollege : Form
    {
        public string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        public UpdateCollege()
        {
            InitializeComponent();
        }

        private void BtnCancelCollege_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnUpdateCollege_Click(object sender, EventArgs e)
        {
            if (txtCollegeName.Text != "")
            {
                try
                {
                    db.SP_UPDATE_COLLEGE(CollegeID(), txtCollegeName.Text, DateTime.Now);
                    MessageBox.Show("College Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCollegeName.Text = "";
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("College Field is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public int CollegeID()
        {
            int id = 0;
            try
            {
                using (var dbCollege = new SqlConnection(_conn))
                {
                    dbCollege.Open();
                    using(var cmd = dbCollege.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_GET_COLLEGE_ID_STORAGE";
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            id = (int)result;
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }
    }
}
