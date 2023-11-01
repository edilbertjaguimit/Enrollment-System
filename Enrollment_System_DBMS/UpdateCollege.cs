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
    public partial class UpdateCollege : Form
    {
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
            // Update
        }
    }
}
