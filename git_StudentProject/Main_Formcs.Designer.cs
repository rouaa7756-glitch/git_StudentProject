namespace git_StudentProject
{
    partial class Main_Formcs
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
            this.Students = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Students.SuspendLayout();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.White;
            this.Students.Controls.Add(this.button1);
            this.Students.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.Location = new System.Drawing.Point(27, 37);
            this.Students.Name = "Students";
            this.Students.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Students.Size = new System.Drawing.Size(944, 651);
            this.Students.TabIndex = 0;
            this.Students.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(483, 145);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main_Formcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1019, 778);
            this.Controls.Add(this.Students);
            this.Name = "Main_Formcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Formcs";
            this.Students.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Students;
        private System.Windows.Forms.Button button1;
    }
}