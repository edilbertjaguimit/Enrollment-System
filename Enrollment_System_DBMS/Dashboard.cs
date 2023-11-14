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
using Enrollment_System_DBMS.Student_Controls;

namespace Enrollment_System_DBMS
{
    public partial class Dashboard : Form
    {
        string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        public string DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public bool isStudentInformationClicked { get; set; }
        public bool isBackToStudentRecordClicked { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            //comboBox1.Items.Add("IT Department");
            //var info = new StudentInformation();
            //var records = new StudentRecords();
            //if (isStudentInformationClicked)
            //{
            //    //studentInformation1.BringToFront();
            //    StudentInformation info = new StudentInformation();
            //    info.Dock = DockStyle.Fill;
            //    mainContent.Controls.Clear();
            //    mainContent.Controls.Add(info);
            //}
            //if (isBackToStudentRecordClicked)
            //{
            //    //studentRecords1.BringToFront();
            //    StudentRecords studentRecords = new StudentRecords();
            //    studentRecords.Dock = DockStyle.Fill;
            //    mainContent.Controls.Clear();
            //    mainContent.Controls.Add(studentRecords);
            //}
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //homeDashboard1.BringToFront();
            HomeDashboard homeDashboard = new HomeDashboard();
            homeDashboard.Dock = DockStyle.Fill;
            mainContent.Controls.Clear();
            mainContent.Controls.Add(homeDashboard);
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            //addStudent1.BringToFront();
            AddStudent addStudent = new AddStudent();
            addStudent.Dock = DockStyle.Fill;
            mainContent.Controls.Clear();
            mainContent.Controls.Add(addStudent);
        }

        private void BtnStudentRecords_Click(object sender, EventArgs e)
        {
            //studentRecords1.BringToFront();
            // Load the StudentRecords user control into the contentPanel
            StudentRecords studentRecords = new StudentRecords();
            studentRecords.Dock = DockStyle.Fill;
            mainContent.Controls.Clear();
            mainContent.Controls.Add(studentRecords);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //homeDashboard1.BringToFront();
            //new StudentInformation();
            HomeDashboard homeDashboard = new HomeDashboard();
            homeDashboard.Dock = DockStyle.Fill;
            mainContent.Controls.Clear();
            mainContent.Controls.Add(homeDashboard);
        }

        private void BtnColleges_Click(object sender, EventArgs e)
        {
            Colleges colleges = new Colleges();
            colleges.Dock = DockStyle.Fill;
            mainContent.Controls.Clear();
            mainContent.Controls.Add(colleges);
        }

        private void BtnSubjects_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            subjects.Dock = DockStyle.Fill;
            mainContent.Controls.Clear();
            mainContent.Controls.Add(subjects);
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    label2.Text = comboBox1.Text;
        //}
        //public void AddStudentWithCollege()
        //{
        //    using (var db = new SqlConnection(_conn))
        //    {
        //        db.Open();
        //        using (var cmd = db.CreateCommand())
        //        {
        //            cmd.CommandType = CommandType.Text;
        //            cmd.CommandText = "INSERT INTO COLLEGE (STUD)";
        //            int ctr = cmd.ExecuteNonQuery();
        //            if(ctr > 0)
        //            {
        //                //Insert Successfully
        //            }
        //        }
        //    }
        //}
        //public void COLLEGE()
        //{
        //    comboBox1.Items.Clear(); // Clear existing items
        //    using (var db = new SqlConnection(_conn))
        //    {
        //        db.Open();
        //        using (var cmd = db.CreateCommand())
        //        {
        //            cmd.CommandType = CommandType.Text;
        //            cmd.CommandText = "SELECT COLL_NAME FROM COLLEGE";
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    comboBox1.Items.Add(reader["COLL_NAME"].ToString());
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
