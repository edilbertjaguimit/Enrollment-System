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
    public partial class Subjects : UserControl
    {
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();
        }

        private void BtnAddSubject_Click(object sender, EventArgs e)
        {

        }

        public void DisplaySubjects()
        {
            try
            {
                //TblSubjects.DataSource = db.SP_DISPLAY_PROGRAM();
                if (TblSubjects.Rows.Count == 0)
                {
                    lblNoSubject.Text = "No Subjects Yet";
                    lblNoSubject.Visible = true;
                    TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    lblNoSubject.Visible = false;
                    TblSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
