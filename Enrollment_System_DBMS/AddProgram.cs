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
    public partial class AddProgram : Form
    {
        public AddProgram()
        {
            InitializeComponent();
        }
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        private void BtnCancelProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAddProgram_Click(object sender, EventArgs e)
        {
            if(txtProgramName.Text != "")
            {
                try
                {
                    db.SP_INSERT_PROGRAM(txtProgramName.Text, DateTime.Now, DateTime.Now);
                    MessageBox.Show("Program Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProgramName.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Program Field is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
