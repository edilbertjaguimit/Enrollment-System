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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            homeDashboard1.BringToFront();
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            addStudent1.BringToFront();
        }

        private void BtnStudentRecords_Click(object sender, EventArgs e)
        {
            studentRecords1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            homeDashboard1.BringToFront();
        }
    }
}
