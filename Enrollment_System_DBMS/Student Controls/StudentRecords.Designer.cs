
namespace Enrollment_System_DBMS.Student_Controls
{
    partial class StudentRecords
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucStudentRecords = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.studentFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDateEnrolled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnStudentDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDeleteStudent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucStudentRecords
            // 
            this.ucStudentRecords.AutoSize = true;
            this.ucStudentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucStudentRecords.Location = new System.Drawing.Point(3, 3);
            this.ucStudentRecords.Name = "ucStudentRecords";
            this.ucStudentRecords.Size = new System.Drawing.Size(187, 25);
            this.ucStudentRecords.TabIndex = 2;
            this.ucStudentRecords.Text = "Student Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.studentImage,
            this.studentFullName,
            this.studentAge,
            this.studentStatus,
            this.studentAcademicYear,
            this.studentSemester,
            this.studentYear,
            this.studentDateEnrolled,
            this.BtnStudentDetails,
            this.BtnDeleteStudent});
            this.dataGridView1.Location = new System.Drawing.Point(3, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 418);
            this.dataGridView1.TabIndex = 3;
            // 
            // studentID
            // 
            this.studentID.HeaderText = "Student ID";
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            // 
            // studentImage
            // 
            this.studentImage.HeaderText = "Image";
            this.studentImage.Name = "studentImage";
            this.studentImage.ReadOnly = true;
            // 
            // studentFullName
            // 
            this.studentFullName.HeaderText = "Name";
            this.studentFullName.Name = "studentFullName";
            this.studentFullName.ReadOnly = true;
            // 
            // studentAge
            // 
            this.studentAge.HeaderText = "Age";
            this.studentAge.Name = "studentAge";
            this.studentAge.ReadOnly = true;
            // 
            // studentStatus
            // 
            this.studentStatus.HeaderText = "Status";
            this.studentStatus.Name = "studentStatus";
            this.studentStatus.ReadOnly = true;
            // 
            // studentAcademicYear
            // 
            this.studentAcademicYear.HeaderText = "AY";
            this.studentAcademicYear.Name = "studentAcademicYear";
            this.studentAcademicYear.ReadOnly = true;
            // 
            // studentSemester
            // 
            this.studentSemester.HeaderText = "Semester";
            this.studentSemester.Name = "studentSemester";
            this.studentSemester.ReadOnly = true;
            // 
            // studentYear
            // 
            this.studentYear.HeaderText = "Year";
            this.studentYear.Name = "studentYear";
            this.studentYear.ReadOnly = true;
            // 
            // studentDateEnrolled
            // 
            this.studentDateEnrolled.HeaderText = "Date Enrolled";
            this.studentDateEnrolled.Name = "studentDateEnrolled";
            this.studentDateEnrolled.ReadOnly = true;
            // 
            // BtnStudentDetails
            // 
            this.BtnStudentDetails.HeaderText = "Details";
            this.BtnStudentDetails.Name = "BtnStudentDetails";
            this.BtnStudentDetails.ReadOnly = true;
            // 
            // BtnDeleteStudent
            // 
            this.BtnDeleteStudent.HeaderText = "Delete";
            this.BtnDeleteStudent.Name = "BtnDeleteStudent";
            this.BtnDeleteStudent.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(549, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // StudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ucStudentRecords);
            this.Name = "StudentRecords";
            this.Size = new System.Drawing.Size(760, 476);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ucStudentRecords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewImageColumn studentImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDateEnrolled;
        private System.Windows.Forms.DataGridViewButtonColumn BtnStudentDetails;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDeleteStudent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
