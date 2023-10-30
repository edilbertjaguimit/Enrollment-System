
namespace Enrollment_System_DBMS.Student_Controls
{
    partial class HomeDashboard
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
            this.ucDashboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumberOfStudents = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumberOfSubjects = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumberOfPrograms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNumberOfColleges = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucDashboard
            // 
            this.ucDashboard.AutoSize = true;
            this.ucDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDashboard.Location = new System.Drawing.Point(3, 3);
            this.ucDashboard.Name = "ucDashboard";
            this.ucDashboard.Size = new System.Drawing.Size(126, 25);
            this.ucDashboard.TabIndex = 1;
            this.ucDashboard.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 442);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblNumberOfStudents);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(380, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 64);
            this.panel4.TabIndex = 16;
            // 
            // lblNumberOfStudents
            // 
            this.lblNumberOfStudents.AutoSize = true;
            this.lblNumberOfStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfStudents.Location = new System.Drawing.Point(180, 19);
            this.lblNumberOfStudents.Name = "lblNumberOfStudents";
            this.lblNumberOfStudents.Size = new System.Drawing.Size(25, 25);
            this.lblNumberOfStudents.TabIndex = 1;
            this.lblNumberOfStudents.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Students:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblNumberOfSubjects);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 64);
            this.panel3.TabIndex = 19;
            // 
            // lblNumberOfSubjects
            // 
            this.lblNumberOfSubjects.AutoSize = true;
            this.lblNumberOfSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfSubjects.Location = new System.Drawing.Point(180, 19);
            this.lblNumberOfSubjects.Name = "lblNumberOfSubjects";
            this.lblNumberOfSubjects.Size = new System.Drawing.Size(25, 25);
            this.lblNumberOfSubjects.TabIndex = 1;
            this.lblNumberOfSubjects.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Subjects:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNumberOfPrograms);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(380, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 64);
            this.panel2.TabIndex = 17;
            // 
            // lblNumberOfPrograms
            // 
            this.lblNumberOfPrograms.AutoSize = true;
            this.lblNumberOfPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPrograms.Location = new System.Drawing.Point(180, 19);
            this.lblNumberOfPrograms.Name = "lblNumberOfPrograms";
            this.lblNumberOfPrograms.Size = new System.Drawing.Size(25, 25);
            this.lblNumberOfPrograms.TabIndex = 1;
            this.lblNumberOfPrograms.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Programs";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblNumberOfColleges);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(367, 64);
            this.panel5.TabIndex = 18;
            // 
            // lblNumberOfColleges
            // 
            this.lblNumberOfColleges.AutoSize = true;
            this.lblNumberOfColleges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfColleges.Location = new System.Drawing.Point(180, 19);
            this.lblNumberOfColleges.Name = "lblNumberOfColleges";
            this.lblNumberOfColleges.Size = new System.Drawing.Size(25, 25);
            this.lblNumberOfColleges.TabIndex = 1;
            this.lblNumberOfColleges.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Colleges:";
            // 
            // HomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucDashboard);
            this.Name = "HomeDashboard";
            this.Size = new System.Drawing.Size(760, 476);
            this.Load += new System.EventHandler(this.HomeDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ucDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumberOfStudents;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumberOfSubjects;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumberOfPrograms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblNumberOfColleges;
        private System.Windows.Forms.Label label3;
    }
}
