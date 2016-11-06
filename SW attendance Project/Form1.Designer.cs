namespace SW_attendance_Project
{
    partial class Form1
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
            this.Instructor_button = new System.Windows.Forms.Button();
            this.Student_button = new System.Windows.Forms.Button();
            this.Time_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Instructor_button
            // 
            this.Instructor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructor_button.ForeColor = System.Drawing.Color.Red;
            this.Instructor_button.Location = new System.Drawing.Point(31, 37);
            this.Instructor_button.Name = "Instructor_button";
            this.Instructor_button.Size = new System.Drawing.Size(159, 37);
            this.Instructor_button.TabIndex = 0;
            this.Instructor_button.Text = "Instructor";
            this.Instructor_button.UseVisualStyleBackColor = true;
            // 
            // Student_button
            // 
            this.Student_button.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Student_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_button.ForeColor = System.Drawing.Color.Red;
            this.Student_button.Location = new System.Drawing.Point(31, 96);
            this.Student_button.Name = "Student_button";
            this.Student_button.Size = new System.Drawing.Size(159, 37);
            this.Student_button.TabIndex = 1;
            this.Student_button.Text = "Student";
            this.Student_button.UseVisualStyleBackColor = true;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Location = new System.Drawing.Point(374, 277);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(0, 13);
            this.Time_label.TabIndex = 4;
            this.Time_label.Click += new System.EventHandler(this.Time_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(394, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "DATE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.Student_button);
            this.Controls.Add(this.Instructor_button);
            this.Name = "Form1";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Instructor_button;
        private System.Windows.Forms.Button Student_button;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Label label1;
    }
}

