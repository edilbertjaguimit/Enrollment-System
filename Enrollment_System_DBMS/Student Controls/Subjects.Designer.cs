
namespace Enrollment_System_DBMS.Student_Controls
{
    partial class Subjects
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridSubjects = new System.Windows.Forms.DataGridView();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectAcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNumberEnrolled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUpdateSubject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDeleteSubject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // ucStudentRecords
            // 
            this.ucStudentRecords.AutoSize = true;
            this.ucStudentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucStudentRecords.Location = new System.Drawing.Point(3, 3);
            this.ucStudentRecords.Name = "ucStudentRecords";
            this.ucStudentRecords.Size = new System.Drawing.Size(103, 25);
            this.ucStudentRecords.TabIndex = 6;
            this.ucStudentRecords.Text = "Subjects";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridSubjects);
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 442);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Subject";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(539, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 12;
            // 
            // dataGridSubjects
            // 
            this.dataGridSubjects.AllowUserToAddRows = false;
            this.dataGridSubjects.AllowUserToDeleteRows = false;
            this.dataGridSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectCode,
            this.subjectName,
            this.subjectAcademicYear,
            this.subjectNumberEnrolled,
            this.BtnUpdateSubject,
            this.BtnDeleteSubject});
            this.dataGridSubjects.Location = new System.Drawing.Point(3, 46);
            this.dataGridSubjects.Name = "dataGridSubjects";
            this.dataGridSubjects.Size = new System.Drawing.Size(744, 389);
            this.dataGridSubjects.TabIndex = 11;
            // 
            // subjectCode
            // 
            this.subjectCode.HeaderText = "Subject Code";
            this.subjectCode.Name = "subjectCode";
            // 
            // subjectName
            // 
            this.subjectName.HeaderText = "Subject Name";
            this.subjectName.Name = "subjectName";
            // 
            // subjectAcademicYear
            // 
            this.subjectAcademicYear.HeaderText = "AY";
            this.subjectAcademicYear.Name = "subjectAcademicYear";
            // 
            // subjectNumberEnrolled
            // 
            this.subjectNumberEnrolled.HeaderText = "Enrolled";
            this.subjectNumberEnrolled.Name = "subjectNumberEnrolled";
            // 
            // BtnUpdateSubject
            // 
            this.BtnUpdateSubject.HeaderText = "Update";
            this.BtnUpdateSubject.Name = "BtnUpdateSubject";
            // 
            // BtnDeleteSubject
            // 
            this.BtnDeleteSubject.HeaderText = "Delete";
            this.BtnDeleteSubject.Name = "BtnDeleteSubject";
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucStudentRecords);
            this.Name = "Subjects";
            this.Size = new System.Drawing.Size(760, 476);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ucStudentRecords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectAcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNumberEnrolled;
        private System.Windows.Forms.DataGridViewButtonColumn BtnUpdateSubject;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDeleteSubject;
    }
}
