using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System_DBMS.Student_Controls
{
    class CollegeAndProgram
    {
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        public CollegeAndProgram()
        {
            DisplayProgram();
            DisplayCollege();
        }
        public void DisplayCollege()
        {
            Colleges colleges = new Colleges();
            colleges.TblCollege.DataSource = db.SP_DISPLAY_COLLEGE();
            if (colleges.TblCollege.Rows.Count == 0)
            {
                colleges.lblNoCollege.Text = "No College Yet";
                colleges.lblNoCollege.Visible = true;
                colleges.TblCollege.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                colleges.lblNoCollege.Visible = false;
                colleges.TblCollege.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        public void DisplayProgram()
        {
            Colleges colleges = new Colleges();
            colleges.TblProgram.DataSource = db.SP_DISPLAY_PROGRAM();
            if (colleges.TblCollege.Rows.Count == 0)
            {
                colleges.lblNoProgram.Text = "No Program Yet";
                colleges.lblNoProgram.Visible = true;
                colleges.TblProgram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                colleges.lblNoProgram.Visible = false;
                colleges.TblProgram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
