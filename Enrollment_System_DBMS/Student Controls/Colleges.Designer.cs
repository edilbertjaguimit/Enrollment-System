
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
            this.ucStudentRecords = new System.Windows.Forms.Label();
            this.BtnAddCollege = new System.Windows.Forms.Button();
            this.BtnAddProgram = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnDeleteCollege = new System.Windows.Forms.Button();
            this.BtnUpdateCollege = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnDeleteProgram = new System.Windows.Forms.Button();
            this.BtnUpdateProgram = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRefreshAll = new System.Windows.Forms.Button();
            this.lblNoProgram = new System.Windows.Forms.Label();
            this.lblNoCollege = new System.Windows.Forms.Label();
            this.TblProgram = new System.Windows.Forms.DataGridView();
            this.TxtSearchCollege = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumberOfPrograms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNumberOfColleges = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearchProgram = new System.Windows.Forms.TextBox();
            this.TblCollege = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblProgram)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblCollege)).BeginInit();
            this.SuspendLayout();
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
            this.BtnAddCollege.Location = new System.Drawing.Point(6, 6);
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
            this.BtnAddProgram.Location = new System.Drawing.Point(3, 5);
            this.BtnAddProgram.Name = "BtnAddProgram";
            this.BtnAddProgram.Size = new System.Drawing.Size(114, 33);
            this.BtnAddProgram.TabIndex = 12;
            this.BtnAddProgram.Text = "Add Program";
            this.BtnAddProgram.UseVisualStyleBackColor = false;
            this.BtnAddProgram.Click += new System.EventHandler(this.BtnAddProgram_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnDeleteCollege);
            this.panel3.Controls.Add(this.BtnUpdateCollege);
            this.panel3.Controls.Add(this.BtnAddCollege);
            this.panel3.Location = new System.Drawing.Point(3, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 46);
            this.panel3.TabIndex = 24;
            // 
            // BtnDeleteCollege
            // 
            this.BtnDeleteCollege.BackColor = System.Drawing.Color.Gold;
            this.BtnDeleteCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCollege.ForeColor = System.Drawing.Color.Red;
            this.BtnDeleteCollege.Location = new System.Drawing.Point(246, 5);
            this.BtnDeleteCollege.Name = "BtnDeleteCollege";
            this.BtnDeleteCollege.Size = new System.Drawing.Size(114, 33);
            this.BtnDeleteCollege.TabIndex = 13;
            this.BtnDeleteCollege.Text = "Delete";
            this.BtnDeleteCollege.UseVisualStyleBackColor = false;
            this.BtnDeleteCollege.Click += new System.EventHandler(this.BtnDeleteCollege_Click);
            // 
            // BtnUpdateCollege
            // 
            this.BtnUpdateCollege.BackColor = System.Drawing.Color.Gold;
            this.BtnUpdateCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateCollege.Location = new System.Drawing.Point(126, 5);
            this.BtnUpdateCollege.Name = "BtnUpdateCollege";
            this.BtnUpdateCollege.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdateCollege.TabIndex = 12;
            this.BtnUpdateCollege.Text = "Update";
            this.BtnUpdateCollege.UseVisualStyleBackColor = false;
            this.BtnUpdateCollege.Click += new System.EventHandler(this.BtnUpdateCollege_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.BtnDeleteProgram);
            this.panel4.Controls.Add(this.BtnUpdateProgram);
            this.panel4.Controls.Add(this.BtnAddProgram);
            this.panel4.Location = new System.Drawing.Point(386, 419);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 46);
            this.panel4.TabIndex = 25;
            // 
            // BtnDeleteProgram
            // 
            this.BtnDeleteProgram.BackColor = System.Drawing.Color.Gold;
            this.BtnDeleteProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteProgram.ForeColor = System.Drawing.Color.Red;
            this.BtnDeleteProgram.Location = new System.Drawing.Point(243, 5);
            this.BtnDeleteProgram.Name = "BtnDeleteProgram";
            this.BtnDeleteProgram.Size = new System.Drawing.Size(114, 33);
            this.BtnDeleteProgram.TabIndex = 15;
            this.BtnDeleteProgram.Text = "Delete";
            this.BtnDeleteProgram.UseVisualStyleBackColor = false;
            this.BtnDeleteProgram.Click += new System.EventHandler(this.BtnDeleteProgram_Click);
            // 
            // BtnUpdateProgram
            // 
            this.BtnUpdateProgram.BackColor = System.Drawing.Color.Gold;
            this.BtnUpdateProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateProgram.Location = new System.Drawing.Point(123, 5);
            this.BtnUpdateProgram.Name = "BtnUpdateProgram";
            this.BtnUpdateProgram.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdateProgram.TabIndex = 14;
            this.BtnUpdateProgram.Text = "Update";
            this.BtnUpdateProgram.UseVisualStyleBackColor = false;
            this.BtnUpdateProgram.Click += new System.EventHandler(this.BtnUpdateProgram_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnRefreshAll);
            this.panel1.Controls.Add(this.lblNoProgram);
            this.panel1.Controls.Add(this.lblNoCollege);
            this.panel1.Controls.Add(this.TblProgram);
            this.panel1.Controls.Add(this.TxtSearchCollege);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtSearchProgram);
            this.panel1.Controls.Add(this.TblCollege);
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 382);
            this.panel1.TabIndex = 26;
            // 
            // BtnRefreshAll
            // 
            this.BtnRefreshAll.BackColor = System.Drawing.Color.Gold;
            this.BtnRefreshAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefreshAll.Location = new System.Drawing.Point(3, 74);
            this.BtnRefreshAll.Name = "BtnRefreshAll";
            this.BtnRefreshAll.Size = new System.Drawing.Size(114, 33);
            this.BtnRefreshAll.TabIndex = 28;
            this.BtnRefreshAll.Text = "Refresh All";
            this.BtnRefreshAll.UseVisualStyleBackColor = false;
            this.BtnRefreshAll.Click += new System.EventHandler(this.BtnRefreshAll_Click);
            // 
            // lblNoProgram
            // 
            this.lblNoProgram.AutoSize = true;
            this.lblNoProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoProgram.Location = new System.Drawing.Point(458, 223);
            this.lblNoProgram.Name = "lblNoProgram";
            this.lblNoProgram.Size = new System.Drawing.Size(209, 25);
            this.lblNoProgram.TabIndex = 34;
            this.lblNoProgram.Text = "No Program Found";
            // 
            // lblNoCollege
            // 
            this.lblNoCollege.AutoSize = true;
            this.lblNoCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCollege.Location = new System.Drawing.Point(85, 223);
            this.lblNoCollege.Name = "lblNoCollege";
            this.lblNoCollege.Size = new System.Drawing.Size(201, 25);
            this.lblNoCollege.TabIndex = 33;
            this.lblNoCollege.Text = "No College Found";
            // 
            // TblProgram
            // 
            this.TblProgram.AllowUserToAddRows = false;
            this.TblProgram.AllowUserToDeleteRows = false;
            this.TblProgram.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TblProgram.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblProgram.BackgroundColor = System.Drawing.Color.White;
            this.TblProgram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TblProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblProgram.Location = new System.Drawing.Point(375, 113);
            this.TblProgram.Name = "TblProgram";
            this.TblProgram.ReadOnly = true;
            this.TblProgram.Size = new System.Drawing.Size(371, 262);
            this.TblProgram.TabIndex = 32;
            this.TblProgram.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblProgram_CellClick);
            // 
            // TxtSearchCollege
            // 
            this.TxtSearchCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchCollege.Location = new System.Drawing.Point(193, 79);
            this.TxtSearchCollege.Name = "TxtSearchCollege";
            this.TxtSearchCollege.Size = new System.Drawing.Size(176, 22);
            this.TxtSearchCollege.TabIndex = 31;
            this.TxtSearchCollege.TextChanged += new System.EventHandler(this.TxtSearchCollege_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNumberOfPrograms);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(375, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 64);
            this.panel2.TabIndex = 29;
            // 
            // lblNumberOfPrograms
            // 
            this.lblNumberOfPrograms.AutoSize = true;
            this.lblNumberOfPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPrograms.Location = new System.Drawing.Point(188, 19);
            this.lblNumberOfPrograms.Name = "lblNumberOfPrograms";
            this.lblNumberOfPrograms.Size = new System.Drawing.Size(25, 25);
            this.lblNumberOfPrograms.TabIndex = 2;
            this.lblNumberOfPrograms.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Programs:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblNumberOfColleges);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 64);
            this.panel5.TabIndex = 27;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search";
            // 
            // TxtSearchProgram
            // 
            this.TxtSearchProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchProgram.Location = new System.Drawing.Point(569, 79);
            this.TxtSearchProgram.Name = "TxtSearchProgram";
            this.TxtSearchProgram.Size = new System.Drawing.Size(176, 22);
            this.TxtSearchProgram.TabIndex = 25;
            this.TxtSearchProgram.TextChanged += new System.EventHandler(this.TxtSearchProgram_TextChanged);
            // 
            // TblCollege
            // 
            this.TblCollege.AllowUserToAddRows = false;
            this.TblCollege.AllowUserToDeleteRows = false;
            this.TblCollege.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TblCollege.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblCollege.BackgroundColor = System.Drawing.Color.White;
            this.TblCollege.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TblCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblCollege.Location = new System.Drawing.Point(3, 113);
            this.TblCollege.Name = "TblCollege";
            this.TblCollege.ReadOnly = true;
            this.TblCollege.Size = new System.Drawing.Size(366, 262);
            this.TblCollege.TabIndex = 24;
            this.TblCollege.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblCollege_CellClick);
            // 
            // Colleges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ucStudentRecords);
            this.Name = "Colleges";
            this.Size = new System.Drawing.Size(760, 476);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblProgram)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblCollege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ucStudentRecords;
        private System.Windows.Forms.Button BtnAddCollege;
        private System.Windows.Forms.Button BtnAddProgram;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnDeleteCollege;
        private System.Windows.Forms.Button BtnUpdateCollege;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnDeleteProgram;
        private System.Windows.Forms.Button BtnUpdateProgram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRefreshAll;
        public System.Windows.Forms.Label lblNoProgram;
        public System.Windows.Forms.Label lblNoCollege;
        public System.Windows.Forms.DataGridView TblProgram;
        private System.Windows.Forms.TextBox TxtSearchCollege;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumberOfPrograms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblNumberOfColleges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchProgram;
        public System.Windows.Forms.DataGridView TblCollege;
    }
}
