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
using FaceRecognition;

namespace Enrollment_System_DBMS
{
    public partial class Login : Form
    {
        private string _conn = @"Data Source=EDILBERT-CRIST\SQLEXPRESS;Initial Catalog=ENROLLMENT_DB;Integrated Security=True";
        private bool isUseCameraIsClicked = false;
        FaceRec faceRec = new FaceRec();
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        Registration registration = new Registration();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isUseCameraIsClicked)
            {
                if (txtUsername.Text.Trim() != "")
                {
                    try
                    {
                        //db.SP_ADMIN_REGISTER(txtUsername.Text, null);
                        //MessageBox.Show("Face Register Successfully.");
                        using(var dbLogin = new SqlConnection(_conn))
                        {
                            dbLogin.Open();
                            using(var cmd = dbLogin.CreateCommand())
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "SELECT COUNT(*) FROM ADMIN_TBL WHERE ADMIN_USERNAME = @username";
                                cmd.Parameters.AddWithValue("username", txtUsername.Text);
                                var result = Convert.ToInt32(cmd.ExecuteScalar());
                                if(result > 0)
                                {
                                    Dashboard dashboard = new Dashboard();
                                    dashboard.Show();
                                    this.Hide();
                                }else
                                    MessageBox.Show("Username not found.");

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database Error: {ex}");
                    }
                }
                else
                {
                    MessageBox.Show("Input field is empty.");
                }
            }
            else
            {
                if (txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "")
                {
                    try
                    {
                        using (var dbLogin = new SqlConnection(_conn))
                        {
                            dbLogin.Open();
                            using (var cmd = dbLogin.CreateCommand())
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "SELECT COUNT(*) FROM ADMIN_TBL WHERE ADMIN_USERNAME = @username AND ADMIN_PASSWORD = @password";
                                cmd.Parameters.AddWithValue("username", txtUsername.Text);
                                cmd.Parameters.AddWithValue("password", txtPassword.Text);
                                var result = Convert.ToInt32(cmd.ExecuteScalar());
                                if (result > 0)
                                {
                                    Dashboard dashboard = new Dashboard();
                                    dashboard.Show();
                                    this.Hide();
                                }
                                else
                                    MessageBox.Show("Username or password not found.");

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database Error: {ex}");
                    }
                }
                else
                    MessageBox.Show("Input field is empty.");
            }
        }

        private void btnUseText_Click(object sender, EventArgs e)
        {
            isUseCameraIsClicked = false;
            txtPassword.Enabled = true;
            pbCamera.Enabled = false;
        }

        private void btnUseCamera_Click(object sender, EventArgs e)
        {
            isUseCameraIsClicked = true;
            txtPassword.Enabled = false;
            faceRec.isTrained = true;
            pbCamera.Enabled = true;
            faceRec.getPersonName(txtUsername);
            faceRec.openCamera(pbCamera, registration.pbCaptured);
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            registration.Show();
            this.Hide();
        }
    }
}
