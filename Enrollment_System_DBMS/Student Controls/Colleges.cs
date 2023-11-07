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
        private int CollegeID { get; set; }
        private int ProgramID { get; set; }
        private string College { get; set; }

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
            try
            {
                db.SP_PROGRAM_ID_STORAGE(Convert.ToInt32(studentRecord.Cells[0].Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show($"{GetProgramID()}");
        }
        // Table cell clicked
        private void TblCollege_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentRecord = TblCollege.CurrentRow;
            TblCollege.CurrentRow.Selected = true;
            try
            {
                db.SP_COLLEGE_ID_STORAGE(Convert.ToInt32(studentRecord.Cells[0].Value));
            }catch(Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show($"{GetCollegeID()}");
        }

        // College Update
        private void BtnUpdateCollege_Click(object sender, EventArgs e)
        {
            if(TblCollege.SelectedRows.Count > 0)
            {
                UpdateCollege updateCollege = new UpdateCollege();
                updateCollege.Show();
            }
            else
            {
                MessageBox.Show("Please select a Subject", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // College Delete
        private void BtnDeleteCollege_Click(object sender, EventArgs e)
        {
            if (TblCollege.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        db.SP_DELETE_PROGRAM(GetCollegeID());
                        MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Subject", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Program Update
        private void BtnUpdateProgram_Click(object sender, EventArgs e)
        {
            if (TblProgram.SelectedRows.Count > 0)
            {
                UpdateProgram updateProgram = new UpdateProgram();
                updateProgram.Show();
            }
            else
            {
                MessageBox.Show("Please select a Subject", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Program Delete
        private void BtnDeleteProgram_Click(object sender, EventArgs e)
        {
            if (TblProgram.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        db.SP_DELETE_PROGRAM(GetProgramID());
                        MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select a Subject", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetCollegeID()
        {
            int id = 0;

            try
            {
                using (var dbID = new SqlConnection(_conn))
                {
                    dbID.Open();
                    using (var cmd = dbID.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT ID FROM COLLEGE_ID_STORAGE";
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            id = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;
        }

        private int GetProgramID()
        {
            int id = 0;

            try
            {
                using(var dbID = new SqlConnection(_conn))
                {
                    dbID.Open();
                    using(var cmd = dbID.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT ID FROM PROGRAM_ID_STORAGE";
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            id = (int)result;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;
        }
    }
}
