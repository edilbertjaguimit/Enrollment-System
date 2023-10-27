
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoStudentFound = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnStudentDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearchStudent = new System.Windows.Forms.TextBox();
            this.TblStudentRecords = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblStudentRecords)).BeginInit();
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNoStudentFound);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BtnStudentDetails);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtSearchStudent);
            this.panel1.Controls.Add(this.TblStudentRecords);
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 442);
            this.panel1.TabIndex = 3;
            // 
            // lblNoStudentFound
            // 
            this.lblNoStudentFound.AutoSize = true;
            this.lblNoStudentFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoStudentFound.Location = new System.Drawing.Point(282, 190);
            this.lblNoStudentFound.Name = "lblNoStudentFound";
            this.lblNoStudentFound.Size = new System.Drawing.Size(202, 25);
            this.lblNoStudentFound.TabIndex = 22;
            this.lblNoStudentFound.Text = "No Student Found";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(123, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnStudentDetails
            // 
            this.BtnStudentDetails.BackColor = System.Drawing.Color.Gold;
            this.BtnStudentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentDetails.Location = new System.Drawing.Point(3, 2);
            this.BtnStudentDetails.Name = "BtnStudentDetails";
            this.BtnStudentDetails.Size = new System.Drawing.Size(114, 33);
            this.BtnStudentDetails.TabIndex = 20;
            this.BtnStudentDetails.Text = "Details";
            this.BtnStudentDetails.UseVisualStyleBackColor = false;
            this.BtnStudentDetails.Click += new System.EventHandler(this.BtnStudentDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search";
            // 
            // TxtSearchStudent
            // 
            this.TxtSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchStudent.Location = new System.Drawing.Point(539, 7);
            this.TxtSearchStudent.Name = "TxtSearchStudent";
            this.TxtSearchStudent.Size = new System.Drawing.Size(208, 22);
            this.TxtSearchStudent.TabIndex = 18;
            this.TxtSearchStudent.TextChanged += new System.EventHandler(this.TxtSearchStudent_TextChanged);
            // 
            // TblStudentRecords
            // 
            this.TblStudentRecords.AllowUserToAddRows = false;
            this.TblStudentRecords.AllowUserToDeleteRows = false;
            this.TblStudentRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TblStudentRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblStudentRecords.BackgroundColor = System.Drawing.Color.White;
            this.TblStudentRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TblStudentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblStudentRecords.Location = new System.Drawing.Point(3, 41);
            this.TblStudentRecords.Name = "TblStudentRecords";
            this.TblStudentRecords.ReadOnly = true;
            this.TblStudentRecords.Size = new System.Drawing.Size(744, 394);
            this.TblStudentRecords.TabIndex = 17;
            this.TblStudentRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblStudentRecords_CellClick);
            // 
            // StudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucStudentRecords);
            this.Name = "StudentRecords";
            this.Size = new System.Drawing.Size(760, 476);
            this.Load += new System.EventHandler(this.StudentRecords_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblStudentRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ucStudentRecords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNoStudentFound;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnStudentDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchStudent;
        private System.Windows.Forms.DataGridView TblStudentRecords;
    }
}
