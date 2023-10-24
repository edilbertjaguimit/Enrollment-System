
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
            // HomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucDashboard);
            this.Name = "HomeDashboard";
            this.Size = new System.Drawing.Size(760, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ucDashboard;
    }
}
