
namespace Enrollment_System_DBMS
{
    partial class AddProgram
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
            this.label11 = new System.Windows.Forms.Label();
            this.CbCollege = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.BtnCancelProgram = new System.Windows.Forms.Button();
            this.BtnAddProgram = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.CbCollege);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProgramName);
            this.panel1.Controls.Add(this.BtnCancelProgram);
            this.panel1.Controls.Add(this.BtnAddProgram);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 209);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "College/Department";
            // 
            // CbCollege
            // 
            this.CbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCollege.FormattingEnabled = true;
            this.CbCollege.Location = new System.Drawing.Point(10, 61);
            this.CbCollege.Name = "CbCollege";
            this.CbCollege.Size = new System.Drawing.Size(222, 23);
            this.CbCollege.TabIndex = 56;
            this.CbCollege.SelectedIndexChanged += new System.EventHandler(this.CbCollege_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Create Program";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Program Name";
            // 
            // txtProgramName
            // 
            this.txtProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramName.Location = new System.Drawing.Point(10, 126);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(222, 22);
            this.txtProgramName.TabIndex = 12;
            // 
            // BtnCancelProgram
            // 
            this.BtnCancelProgram.BackColor = System.Drawing.Color.White;
            this.BtnCancelProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelProgram.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelProgram.Location = new System.Drawing.Point(134, 171);
            this.BtnCancelProgram.Name = "BtnCancelProgram";
            this.BtnCancelProgram.Size = new System.Drawing.Size(98, 23);
            this.BtnCancelProgram.TabIndex = 11;
            this.BtnCancelProgram.Text = "BACK";
            this.BtnCancelProgram.UseVisualStyleBackColor = false;
            this.BtnCancelProgram.Click += new System.EventHandler(this.BtnCancelProgram_Click);
            // 
            // BtnAddProgram
            // 
            this.BtnAddProgram.BackColor = System.Drawing.Color.Gold;
            this.BtnAddProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProgram.Location = new System.Drawing.Point(10, 171);
            this.BtnAddProgram.Name = "BtnAddProgram";
            this.BtnAddProgram.Size = new System.Drawing.Size(98, 23);
            this.BtnAddProgram.TabIndex = 10;
            this.BtnAddProgram.Text = "ADD";
            this.BtnAddProgram.UseVisualStyleBackColor = false;
            this.BtnAddProgram.Click += new System.EventHandler(this.BtnAddProgram_Click);
            // 
            // AddProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 209);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AddProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Program";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Button BtnCancelProgram;
        private System.Windows.Forms.Button BtnAddProgram;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbCollege;
    }
}