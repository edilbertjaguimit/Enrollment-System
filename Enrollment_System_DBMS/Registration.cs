using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace Enrollment_System_DBMS
{
    public partial class Registration : Form
    {
        private bool isUseCameraIsClicked = false;
        FaceRec faceRec = new FaceRec();
        EnrollmentDBDataContext db = new EnrollmentDBDataContext();
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (isUseCameraIsClicked)
            {
                if(txtUsername.Text.Trim() != "")
                {
                    try
                    {
                        faceRec.Save_IMAGE(txtUsername.Text);
                        faceRec.isTrained = true;
                        db.SP_ADMIN_REGISTER(txtUsername.Text, null);
                        MessageBox.Show("Face Register Successfully.");
                    }
                    catch(Exception ex)
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
                if(txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtRetypePassword.Text.Trim() != "")
                {
                    if(txtPassword.Text == txtRetypePassword.Text)
                    {
                        try
                        {
                            db.SP_ADMIN_REGISTER(txtUsername.Text, txtPassword.Text);
                            MessageBox.Show("Text Register Successfully.");
                        }catch(Exception ex)
                        {
                            MessageBox.Show($"Database Error: {ex}");
                        }
                    }
                    else
                        MessageBox.Show("Password not matched.");
                }
                else
                    MessageBox.Show("Input field is empty.");
            }
        }

        private void btnUseText_Click(object sender, EventArgs e)
        {
            isUseCameraIsClicked = false;
            txtPassword.Enabled = true;
            txtRetypePassword.Enabled = true;
        }

        private void btnUseCamera_Click(object sender, EventArgs e)
        {
            isUseCameraIsClicked = true;
            txtPassword.Enabled = false;
            txtRetypePassword.Enabled = false;
            faceRec.openCamera(pbCamera, pbCaptured);
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
