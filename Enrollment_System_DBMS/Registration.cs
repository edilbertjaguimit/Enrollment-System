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
                    faceRec.Save_IMAGE(txtUsername.Text.ToUpper());
                    faceRec.isTrained = true;
                    MessageBox.Show("Face Register Successfully.");
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

                    }else
                        MessageBox.Show("Password not matched.");
                }
                else
                    MessageBox.Show("Input field is empty.");
            }
        }

        private void btnUseText_Click(object sender, EventArgs e)
        {
            isUseCameraIsClicked = false;
        }

        private void btnUseCamera_Click(object sender, EventArgs e)
        {
            isUseCameraIsClicked = true;
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
