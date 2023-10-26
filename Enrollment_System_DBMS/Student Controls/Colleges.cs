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
        public Colleges()
        {
            InitializeComponent();
        }

        private void BtnAddCollege_Click(object sender, EventArgs e)
        {
            var addCollege = new AddCollege();
            addCollege.Show();
        }

        private void BtnAddProgram_Click(object sender, EventArgs e)
        {
            var addProgram = new AddProgram();
            addProgram.Show();
        }
    }
}
