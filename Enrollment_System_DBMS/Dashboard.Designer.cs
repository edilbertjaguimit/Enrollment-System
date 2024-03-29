﻿
namespace Enrollment_System_DBMS
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSubjects = new System.Windows.Forms.Button();
            this.BtnColleges = new System.Windows.Forms.Button();
            this.BtnStudentRecords = new System.Windows.Forms.Button();
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.mainContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enrollment System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.BtnSubjects);
            this.panel2.Controls.Add(this.BtnColleges);
            this.panel2.Controls.Add(this.BtnStudentRecords);
            this.panel2.Controls.Add(this.BtnAddStudent);
            this.panel2.Controls.Add(this.BtnDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 476);
            this.panel2.TabIndex = 1;
            // 
            // BtnSubjects
            // 
            this.BtnSubjects.BackColor = System.Drawing.Color.Gold;
            this.BtnSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubjects.Location = new System.Drawing.Point(0, 216);
            this.BtnSubjects.Name = "BtnSubjects";
            this.BtnSubjects.Size = new System.Drawing.Size(200, 48);
            this.BtnSubjects.TabIndex = 4;
            this.BtnSubjects.Text = "Subjects";
            this.BtnSubjects.UseVisualStyleBackColor = false;
            this.BtnSubjects.Click += new System.EventHandler(this.BtnSubjects_Click);
            // 
            // BtnColleges
            // 
            this.BtnColleges.BackColor = System.Drawing.Color.Gold;
            this.BtnColleges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnColleges.Location = new System.Drawing.Point(0, 162);
            this.BtnColleges.Name = "BtnColleges";
            this.BtnColleges.Size = new System.Drawing.Size(200, 48);
            this.BtnColleges.TabIndex = 3;
            this.BtnColleges.Text = "Colleges";
            this.BtnColleges.UseVisualStyleBackColor = false;
            this.BtnColleges.Click += new System.EventHandler(this.BtnColleges_Click);
            // 
            // BtnStudentRecords
            // 
            this.BtnStudentRecords.BackColor = System.Drawing.Color.Gold;
            this.BtnStudentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentRecords.Location = new System.Drawing.Point(0, 108);
            this.BtnStudentRecords.Name = "BtnStudentRecords";
            this.BtnStudentRecords.Size = new System.Drawing.Size(200, 48);
            this.BtnStudentRecords.TabIndex = 2;
            this.BtnStudentRecords.Text = "Student Records";
            this.BtnStudentRecords.UseVisualStyleBackColor = false;
            this.BtnStudentRecords.Click += new System.EventHandler(this.BtnStudentRecords_Click);
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.BackColor = System.Drawing.Color.Gold;
            this.BtnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStudent.Location = new System.Drawing.Point(0, 54);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(200, 48);
            this.BtnAddStudent.TabIndex = 1;
            this.BtnAddStudent.Text = "Add Student";
            this.BtnAddStudent.UseVisualStyleBackColor = false;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.Gold;
            this.BtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.Location = new System.Drawing.Point(0, 0);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(200, 48);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // mainContent
            // 
            this.mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContent.Location = new System.Drawing.Point(200, 52);
            this.mainContent.Name = "mainContent";
            this.mainContent.Size = new System.Drawing.Size(760, 476);
            this.mainContent.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 528);
            this.Controls.Add(this.mainContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnStudentRecords;
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnColleges;
        private System.Windows.Forms.Button BtnSubjects;
        public System.Windows.Forms.Panel mainContent;
    }
}