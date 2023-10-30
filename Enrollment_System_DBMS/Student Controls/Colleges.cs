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
    public partial class Colleges : UserControl
    {
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        public Colleges()
        {
            InitializeComponent();
            DisplayCollege();
            DisplayProgram();
        }

        private void BtnAddCollege_Click(object sender, EventArgs e)
        {
            var addCollege = new AddCollege();
            addCollege.Show();
            DisplayCollege();
        }

        private void BtnAddProgram_Click(object sender, EventArgs e)
        {
            var addProgram = new AddProgram();
            addProgram.Show();
            DisplayProgram();
        }

        public void DisplayCollege()
        {
            TblCollege.DataSource = db.SP_DISPLAY_COLLEGE();
            if (TblCollege.Rows.Count == 0)
            {
                lblNoCollege.Text = "No College Yet";
                lblNoCollege.Visible = true;
                TblCollege.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                lblNoCollege.Visible = false;
                TblCollege.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        public void DisplayProgram()
        {
            TblProgram.DataSource = db.SP_DISPLAY_PROGRAM();
            if (TblCollege.Rows.Count == 0)
            {
                lblNoProgram.Text = "No Program Yet";
                lblNoProgram.Visible = true;
                TblProgram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                lblNoProgram.Visible = false;
                TblProgram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
