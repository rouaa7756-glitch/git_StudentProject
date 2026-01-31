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
            this.stud_bt = new System.Windows.Forms.Button();
            this.emp_bt = new System.Windows.Forms.Button();
            this.Students.SuspendLayout();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.White;
            this.Students.Controls.Add(this.emp_bt);
            this.Students.Controls.Add(this.stud_bt);
            this.Students.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.Location = new System.Drawing.Point(27, 37);
            this.Students.Name = "Students";
            this.Students.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Students.Size = new System.Drawing.Size(944, 651);
            this.Students.TabIndex = 0;
            this.Students.TabStop = false;
            // 
            // stud_bt
            // 
            this.stud_bt.BackColor = System.Drawing.Color.Lavender;
            this.stud_bt.Location = new System.Drawing.Point(227, 342);
            this.stud_bt.Name = "stud_bt";
            this.stud_bt.Size = new System.Drawing.Size(483, 145);
            this.stud_bt.TabIndex = 0;
            this.stud_bt.Text = "Student";
            this.stud_bt.UseVisualStyleBackColor = false;
            this.stud_bt.Click += new System.EventHandler(this.stud_bt_Click);
            // 
            // emp_bt
            // 
            this.emp_bt.BackColor = System.Drawing.Color.Thistle;
            this.emp_bt.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emp_bt.Location = new System.Drawing.Point(230, 131);
            this.emp_bt.Name = "emp_bt";
            this.emp_bt.Size = new System.Drawing.Size(483, 145);
            this.emp_bt.TabIndex = 1;
            this.emp_bt.Text = "Employee";
            this.emp_bt.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button stud_bt;
        private System.Windows.Forms.Button emp_bt;
    }
}