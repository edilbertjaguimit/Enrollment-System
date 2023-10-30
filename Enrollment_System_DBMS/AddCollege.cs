using Enrollment_System_DBMS.Student_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System_DBMS
{
    public partial class AddCollege : Form
    {
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();

        public AddCollege()
        {
            InitializeComponent();
        }
        private void BtnCancelCollege_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAddCollege_Click(object sender, EventArgs e)
        {
            if (txtCollegeName.Text != "")
            {
                try
                {
                    db.SP_INSERT_COLLEGE(txtCollegeName.Text, DateTime.Now, DateTime.Now);
                    MessageBox.Show("College Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCollegeName.Text = "";
                    //var college = new CollegeAndProgram();
                    //college.DisplayCollege();
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
    }
}
