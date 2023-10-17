using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System_DBMS.Student_Controls
{
    public partial class AddStudent : UserControl
    {
        int ID { get; set; }
        string StudentID { get; set; }
        string Photo { get; set; }
        string Firstname { get; set; }
        string Middlename { get; set; }
        string Lastname { get; set; }
        string Age { get; set; }
        string BirthDate { get; set; }
        string PlaceBirth { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string Mobile { get; set; }
        string Gender { get; set; }
        string Program { get; set; }
        int GenderID { get; set; }
        int ProgramID { get; set; } 
        int AcademicID { get; set; }
        int SubjectID { get; set; }
        bool emptyGender = false;

        EnrollmentDBDataContext db = new EnrollmentDBDataContext();

        public AddStudent()
        {
            InitializeComponent();
        }

        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    Photo = dialog.FileName;
                    LblPhoto.ImageLocation = Photo;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (!isTextEmpty())
            {
                DateTime birthDate = DpBirthDate.Value;
                TimeSpan age = DateTime.Now - birthDate;
                int currentAge = (int)(age.TotalDays / 365.25);
                string email = TxtEmail.Text;
                string mobile = TxtMobile.Text;
                bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                bool isNumeber = Regex.IsMatch(mobile, @"^(09|\+639)\d{9}$");
                if (isNumeber)
                {
                    if (isEmail)
                    {
                        try
                        {
                            byte[] photoBytes = null;
                            if (!string.IsNullOrEmpty(Photo))
                            {
                                try
                                {
                                    photoBytes = File.ReadAllBytes(Photo);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error reading the photo file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // Exit the method to prevent further execution
                                }
                            }
                            db.SP_INSERT(photoBytes, TxtFirstname.Text, TxtMiddlename.Text, TxtLastname.Text, currentAge.ToString(), birthDate, TxtPlaceBirth.Text, TxtAddress.Text, email, mobile, Gender, DateTime.Now, DateTime.Now);
                            emptyGender = true;
                            ClearText();
                            MessageBox.Show("Successfully Added!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //btlViewData.DataSource = db.sp_view();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An Error Occurred: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Mobile Number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Input Field Are Empty", "Empty");
            }
        }
        private void ClearText()
        {
            TxtFirstname.Text = "";
            TxtMiddlename.Text = "";
            TxtLastname.Text = "";
            DpBirthDate.Value = DateTime.Now;
            TxtAddress.Text = "";
            TxtMobile.Text = "";
            TxtEmail.Text = "";
            TxtPlaceBirth.Text = "";
            CbGender.Text = "";
        }
        private bool isTextEmpty()
        {
            if (TxtFirstname.Text == "" ||
            TxtLastname.Text == "" ||
            TxtAddress.Text == "" ||
            TxtMobile.Text == "" ||
            TxtEmail.Text == "" ||
            DpBirthDate.Value == DateTime.Now ||
            TxtPlaceBirth.Text == "" ||
            CbGender.Text == "")
            {
                return true;
            }
            return false;
        }

        private void CbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!emptyGender)
            {
                Gender = CbGender.Text;
            }
            else
                CbGender.Text = "";
        }
    }
}
