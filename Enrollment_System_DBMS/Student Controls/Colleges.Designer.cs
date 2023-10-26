
namespace Enrollment_System_DBMS.Student_Controls
{
    partial class Colleges
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.collegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeNumberStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeYearCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCollegeUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDeleteCollege = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ucStudentRecords = new System.Windows.Forms.Label();
            this.BtnAddCollege = new System.Windows.Forms.Button();
            this.BtnAddProgram = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.programName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programNumberStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnProgramUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnProgramDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(581, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collegeName,
            this.collegeNumberStudents,
            this.collegeYearCreated,
            this.BtnCollegeUpdate,
            this.BtnDeleteCollege});
            this.dataGridView1.Location = new System.Drawing.Point(3, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(372, 262);
            this.dataGridView1.TabIndex = 7;
            // 
            // collegeName
            // 
            this.collegeName.FillWeight = 103.2572F;
            this.collegeName.HeaderText = "Name";
            this.collegeName.Name = "collegeName";
            this.collegeName.ReadOnly = true;
            this.collegeName.Width = 68;
            // 
            // collegeNumberStudents
            // 
            this.collegeNumberStudents.HeaderText = "Students";
            this.collegeNumberStudents.Name = "collegeNumberStudents";
            this.collegeNumberStudents.ReadOnly = true;
            this.collegeNumberStudents.Width = 67;
            // 
            // collegeYearCreated
            // 
            this.collegeYearCreated.FillWeight = 96.15555F;
            this.collegeYearCreated.HeaderText = "Year Created";
            this.collegeYearCreated.Name = "collegeYearCreated";
            this.collegeYearCreated.ReadOnly = true;
            this.collegeYearCreated.Width = 63;
            // 
            // BtnCollegeUpdate
            // 
            this.BtnCollegeUpdate.FillWeight = 96.88772F;
            this.BtnCollegeUpdate.HeaderText = "Update";
            this.BtnCollegeUpdate.Name = "BtnCollegeUpdate";
            this.BtnCollegeUpdate.ReadOnly = true;
            this.BtnCollegeUpdate.Width = 64;
            // 
            // BtnDeleteCollege
            // 
            this.BtnDeleteCollege.FillWeight = 100.5626F;
            this.BtnDeleteCollege.HeaderText = "Delete";
            this.BtnDeleteCollege.Name = "BtnDeleteCollege";
            this.BtnDeleteCollege.ReadOnly = true;
            this.BtnDeleteCollege.Width = 67;
            // 
            // ucStudentRecords
            // 
            this.ucStudentRecords.AutoSize = true;
            this.ucStudentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucStudentRecords.Location = new System.Drawing.Point(3, 3);
            this.ucStudentRecords.Name = "ucStudentRecords";
            this.ucStudentRecords.Size = new System.Drawing.Size(104, 25);
            this.ucStudentRecords.TabIndex = 6;
            this.ucStudentRecords.Text = "Colleges";
            // 
            // BtnAddCollege
            // 
            this.BtnAddCollege.BackColor = System.Drawing.Color.Gold;
            this.BtnAddCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCollege.Location = new System.Drawing.Point(3, 172);
            this.BtnAddCollege.Name = "BtnAddCollege";
            this.BtnAddCollege.Size = new System.Drawing.Size(114, 33);
            this.BtnAddCollege.TabIndex = 11;
            this.BtnAddCollege.Text = "Add College";
            this.BtnAddCollege.UseVisualStyleBackColor = false;
            this.BtnAddCollege.Click += new System.EventHandler(this.BtnAddCollege_Click);
            // 
            // BtnAddProgram
            // 
            this.BtnAddProgram.BackColor = System.Drawing.Color.Gold;
            this.BtnAddProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProgram.Location = new System.Drawing.Point(381, 172);
            this.BtnAddProgram.Name = "BtnAddProgram";
            this.BtnAddProgram.Size = new System.Drawing.Size(114, 33);
            this.BtnAddProgram.TabIndex = 12;
            this.BtnAddProgram.Text = "Add Program";
            this.BtnAddProgram.UseVisualStyleBackColor = false;
            this.BtnAddProgram.Click += new System.EventHandler(this.BtnAddProgram_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(381, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 113);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Programs";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 113);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Colleges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(199, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programName,
            this.programNumberStudents,
            this.BtnProgramUpdate,
            this.BtnProgramDelete});
            this.dataGridView2.Location = new System.Drawing.Point(381, 211);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(372, 262);
            this.dataGridView2.TabIndex = 19;
            // 
            // programName
            // 
            this.programName.FillWeight = 103.2572F;
            this.programName.HeaderText = "Name";
            this.programName.Name = "programName";
            this.programName.ReadOnly = true;
            // 
            // programNumberStudents
            // 
            this.programNumberStudents.HeaderText = "Students";
            this.programNumberStudents.Name = "programNumberStudents";
            this.programNumberStudents.ReadOnly = true;
            // 
            // BtnProgramUpdate
            // 
            this.BtnProgramUpdate.FillWeight = 96.88772F;
            this.BtnProgramUpdate.HeaderText = "Update";
            this.BtnProgramUpdate.Name = "BtnProgramUpdate";
            this.BtnProgramUpdate.ReadOnly = true;
            // 
            // BtnProgramDelete
            // 
            this.BtnProgramDelete.FillWeight = 100.5626F;
            this.BtnProgramDelete.HeaderText = "Delete";
            this.BtnProgramDelete.Name = "BtnProgramDelete";
            this.BtnProgramDelete.ReadOnly = true;
            // 
            // Colleges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAddProgram);
            this.Controls.Add(this.BtnAddCollege);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ucStudentRecords);
            this.Name = "Colleges";
            this.Size = new System.Drawing.Size(760, 476);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ucStudentRecords;
        private System.Windows.Forms.Button BtnAddCollege;
        private System.Windows.Forms.Button BtnAddProgram;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeNumberStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeYearCreated;
        private System.Windows.Forms.DataGridViewButtonColumn BtnCollegeUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDeleteCollege;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn programName;
        private System.Windows.Forms.DataGridViewTextBoxColumn programNumberStudents;
        private System.Windows.Forms.DataGridViewButtonColumn BtnProgramUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn BtnProgramDelete;
    }
}
