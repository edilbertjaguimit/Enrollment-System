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

namespace Enrollment_System_DBMS.Student_Controls
{
    public partial class Colleges : UserControl
    {
        public string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        public Colleges()
        {
            InitializeComponent();
            DisplayCollege();
            DisplayProgram();
            CountAllColleges();
            CountAllPrograms();
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

        public void DisplayCollege()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DisplayProgram()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefreshAll_Click(object sender, EventArgs e)
        {
            DisplayCollege();
            DisplayProgram();
            CountAllColleges();
            CountAllPrograms();
        }

        private void TxtSearchCollege_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TblCollege.DataSource = db.SP_SEARCH_COLLEGE(TxtSearchCollege.Text);
                if (TblCollege.Rows.Count == 0)
                {
                    lblNoCollege.Visible = true;
                    TblCollege.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    lblNoCollege.Visible = false;
                    TblCollege.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearchProgram_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TblProgram.DataSource = db.SP_SEARCH_PROGRAM(TxtSearchProgram.Text);
                if (TblProgram.Rows.Count == 0)
                {
                    lblNoProgram.Visible = true;
                    TblProgram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    lblNoProgram.Visible = false;
                    TblProgram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CountAllColleges()
        {
            try
            {
                using (var db1 = new SqlConnection(_conn))
                {
                    db1.Open();
                    using (var cmd = db1.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_COUNT_COLLEGES";
                        int count = (int)cmd.ExecuteScalar();
                        lblNumberOfColleges.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CountAllPrograms()
        {
            try
            {
                using (var db1 = new SqlConnection(_conn))
                {
                    db1.Open();
                    using (var cmd = db1.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_COUNT_PROGRAMS";
                        int count = (int)cmd.ExecuteScalar();
                        lblNumberOfPrograms.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TblProgram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentRecord = TblProgram.CurrentRow;
            TblProgram.CurrentRow.Selected = true;
        }

        private void TblCollege_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentRecord = TblCollege.CurrentRow;
            TblCollege.CurrentRow.Selected = true;
        }
    }
}
