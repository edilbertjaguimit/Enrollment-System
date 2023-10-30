
namespace Enrollment_System_DBMS
{
    partial class AddCollege
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.BtnCancelCollege = new System.Windows.Forms.Button();
            this.BtnAddCollege = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCollegeName);
            this.panel1.Controls.Add(this.BtnCancelCollege);
            this.panel1.Controls.Add(this.BtnAddCollege);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 148);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Create College";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "College Name";
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegeName.Location = new System.Drawing.Point(15, 58);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(222, 22);
            this.txtCollegeName.TabIndex = 7;
            // 
            // BtnCancelCollege
            // 
            this.BtnCancelCollege.BackColor = System.Drawing.Color.White;
            this.BtnCancelCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelCollege.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelCollege.Location = new System.Drawing.Point(139, 103);
            this.BtnCancelCollege.Name = "BtnCancelCollege";
            this.BtnCancelCollege.Size = new System.Drawing.Size(98, 23);
            this.BtnCancelCollege.TabIndex = 6;
            this.BtnCancelCollege.Text = "BACK";
            this.BtnCancelCollege.UseVisualStyleBackColor = false;
            this.BtnCancelCollege.Click += new System.EventHandler(this.BtnCancelCollege_Click);
            // 
            // BtnAddCollege
            // 
            this.BtnAddCollege.BackColor = System.Drawing.Color.Gold;
            this.BtnAddCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCollege.Location = new System.Drawing.Point(15, 103);
            this.BtnAddCollege.Name = "BtnAddCollege";
            this.BtnAddCollege.Size = new System.Drawing.Size(98, 23);
            this.BtnAddCollege.TabIndex = 5;
            this.BtnAddCollege.Text = "ADD";
            this.BtnAddCollege.UseVisualStyleBackColor = false;
            this.BtnAddCollege.Click += new System.EventHandler(this.BtnAddCollege_Click);
            // 
            // AddCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 148);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AddCollege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add College";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.Button BtnCancelCollege;
        private System.Windows.Forms.Button BtnAddCollege;
    }
}