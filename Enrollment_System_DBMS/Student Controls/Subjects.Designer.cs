﻿
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDeleteSubject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnUpdateSubject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.subjectNumberEnrolled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectAcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblSubjects = new System.Windows.Forms.DataGridView();
            this.TxtSearchSubject = new System.Windows.Forms.TextBox();
            this.ucStudentRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAddSubject = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoSubject = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSubjectDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbSemester = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSubjectCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUnits = new System.Windows.Forms.TextBox();
            this.TxtSectionCode = new System.Windows.Forms.TextBox();
            this.CbAcademicYear = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblSubjects)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNoSubject);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ucStudentRecords);
            this.panel1.Controls.Add(this.TxtSearchSubject);
            this.panel1.Controls.Add(this.TblSubjects);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 470);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 241);
            this.panel2.TabIndex = 12;
            // 
            // BtnDeleteSubject
            // 
            this.BtnDeleteSubject.HeaderText = "Delete";
            this.BtnDeleteSubject.Name = "BtnDeleteSubject";
            // 
            // BtnUpdateSubject
            // 
            this.BtnUpdateSubject.HeaderText = "Update";
            this.BtnUpdateSubject.Name = "BtnUpdateSubject";
            // 
            // subjectNumberEnrolled
            // 
            this.subjectNumberEnrolled.HeaderText = "Enrolled";
            this.subjectNumberEnrolled.Name = "subjectNumberEnrolled";
            // 
            // subjectAcademicYear
            // 
            this.subjectAcademicYear.HeaderText = "AY";
            this.subjectAcademicYear.Name = "subjectAcademicYear";
            // 
            // subjectName
            // 
            this.subjectName.HeaderText = "Subject Name";
            this.subjectName.Name = "subjectName";
            // 
            // subjectCode
            // 
            this.subjectCode.HeaderText = "Subject Code";
            this.subjectCode.Name = "subjectCode";
            // 
            // TblSubjects
            // 
            this.TblSubjects.AllowUserToAddRows = false;
            this.TblSubjects.AllowUserToDeleteRows = false;
            this.TblSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblSubjects.BackgroundColor = System.Drawing.Color.White;
            this.TblSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectCode,
            this.subjectName,
            this.subjectAcademicYear,
            this.subjectNumberEnrolled,
            this.BtnUpdateSubject,
            this.BtnDeleteSubject});
            this.TblSubjects.Location = new System.Drawing.Point(3, 278);
            this.TblSubjects.Name = "TblSubjects";
            this.TblSubjects.Size = new System.Drawing.Size(744, 190);
            this.TblSubjects.TabIndex = 11;
            // 
            // TxtSearchSubject
            // 
            this.TxtSearchSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchSubject.Location = new System.Drawing.Point(539, 250);
            this.TxtSearchSubject.Name = "TxtSearchSubject";
            this.TxtSearchSubject.Size = new System.Drawing.Size(208, 22);
            this.TxtSearchSubject.TabIndex = 15;
            // 
            // ucStudentRecords
            // 
            this.ucStudentRecords.AutoSize = true;
            this.ucStudentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucStudentRecords.Location = new System.Drawing.Point(3, 247);
            this.ucStudentRecords.Name = "ucStudentRecords";
            this.ucStudentRecords.Size = new System.Drawing.Size(103, 25);
            this.ucStudentRecords.TabIndex = 6;
            this.ucStudentRecords.Text = "Subjects";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnDelete);
            this.panel3.Controls.Add(this.BtnReset);
            this.panel3.Controls.Add(this.BtnUpdate);
            this.panel3.Controls.Add(this.BtnAddSubject);
            this.panel3.Location = new System.Drawing.Point(3, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 44);
            this.panel3.TabIndex = 0;
            // 
            // BtnAddSubject
            // 
            this.BtnAddSubject.BackColor = System.Drawing.Color.Gold;
            this.BtnAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddSubject.Location = new System.Drawing.Point(3, 4);
            this.BtnAddSubject.Name = "BtnAddSubject";
            this.BtnAddSubject.Size = new System.Drawing.Size(114, 33);
            this.BtnAddSubject.TabIndex = 18;
            this.BtnAddSubject.Text = "Add";
            this.BtnAddSubject.UseVisualStyleBackColor = false;
            this.BtnAddSubject.Click += new System.EventHandler(this.BtnAddSubject_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.CbAcademicYear);
            this.panel4.Controls.Add(this.TxtSectionCode);
            this.panel4.Controls.Add(this.TxtUnits);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.TxtSubjectCode);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.CbSemester);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.TxtSubjectDescription);
            this.panel4.Location = new System.Drawing.Point(3, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(736, 158);
            this.panel4.TabIndex = 19;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Gold;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(123, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.White;
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(363, 4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(114, 33);
            this.BtnReset.TabIndex = 20;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Gold;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(243, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 33);
            this.BtnDelete.TabIndex = 21;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Add Subject";
            // 
            // lblNoSubject
            // 
            this.lblNoSubject.AutoSize = true;
            this.lblNoSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSubject.Location = new System.Drawing.Point(268, 365);
            this.lblNoSubject.Name = "lblNoSubject";
            this.lblNoSubject.Size = new System.Drawing.Size(200, 25);
            this.lblNoSubject.TabIndex = 17;
            this.lblNoSubject.Text = "No Subject Found";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 59;
            this.label11.Text = "Academic Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Description";
            // 
            // TxtSubjectDescription
            // 
            this.TxtSubjectDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubjectDescription.Location = new System.Drawing.Point(19, 106);
            this.TxtSubjectDescription.Multiline = true;
            this.TxtSubjectDescription.Name = "TxtSubjectDescription";
            this.TxtSubjectDescription.Size = new System.Drawing.Size(313, 23);
            this.TxtSubjectDescription.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Semester";
            // 
            // CbSemester
            // 
            this.CbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSemester.FormattingEnabled = true;
            this.CbSemester.Location = new System.Drawing.Point(361, 47);
            this.CbSemester.Name = "CbSemester";
            this.CbSemester.Size = new System.Drawing.Size(162, 23);
            this.CbSemester.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(545, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Subject Code";
            // 
            // TxtSubjectCode
            // 
            this.TxtSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubjectCode.Location = new System.Drawing.Point(548, 106);
            this.TxtSubjectCode.Name = "TxtSubjectCode";
            this.TxtSubjectCode.Size = new System.Drawing.Size(162, 22);
            this.TxtSubjectCode.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(545, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 69;
            this.label8.Text = "Units";
            // 
            // TxtUnits
            // 
            this.TxtUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnits.Location = new System.Drawing.Point(548, 47);
            this.TxtUnits.Name = "TxtUnits";
            this.TxtUnits.Size = new System.Drawing.Size(162, 22);
            this.TxtUnits.TabIndex = 70;
            // 
            // TxtSectionCode
            // 
            this.TxtSectionCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSectionCode.Location = new System.Drawing.Point(362, 106);
            this.TxtSectionCode.Name = "TxtSectionCode";
            this.TxtSectionCode.Size = new System.Drawing.Size(161, 22);
            this.TxtSectionCode.TabIndex = 71;
            // 
            // CbAcademicYear
            // 
            this.CbAcademicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAcademicYear.FormattingEnabled = true;
            this.CbAcademicYear.Location = new System.Drawing.Point(19, 47);
            this.CbAcademicYear.Name = "CbAcademicYear";
            this.CbAcademicYear.Size = new System.Drawing.Size(162, 23);
            this.CbAcademicYear.TabIndex = 72;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Subjects";
            this.Size = new System.Drawing.Size(760, 476);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblSubjects)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNoSubject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAddSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ucStudentRecords;
        private System.Windows.Forms.TextBox TxtSearchSubject;
        private System.Windows.Forms.DataGridView TblSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectAcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNumberEnrolled;
        private System.Windows.Forms.DataGridViewButtonColumn BtnUpdateSubject;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDeleteSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbSemester;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSubjectDescription;
        private System.Windows.Forms.ComboBox CbAcademicYear;
        private System.Windows.Forms.TextBox TxtSectionCode;
        private System.Windows.Forms.TextBox TxtUnits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSubjectCode;
        private System.Windows.Forms.Label label6;
    }
}
