namespace SW_attendance_Project
{
    partial class Form6
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
            this.Student_report_button = new System.Windows.Forms.Button();
            this.Student_back_button = new System.Windows.Forms.Button();
            this.Student_name_label = new System.Windows.Forms.Label();
            this.Submet_button = new System.Windows.Forms.Button();
            this.Submet_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Student_report_button
            // 
            this.Student_report_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_report_button.Location = new System.Drawing.Point(12, 98);
            this.Student_report_button.Name = "Student_report_button";
            this.Student_report_button.Size = new System.Drawing.Size(242, 28);
            this.Student_report_button.TabIndex = 0;
            this.Student_report_button.Text = "Report";
            this.Student_report_button.UseVisualStyleBackColor = true;
            // 
            // Student_back_button
            // 
            this.Student_back_button.Location = new System.Drawing.Point(206, 229);
            this.Student_back_button.Name = "Student_back_button";
            this.Student_back_button.Size = new System.Drawing.Size(71, 27);
            this.Student_back_button.TabIndex = 1;
            this.Student_back_button.Text = "Back";
            this.Student_back_button.UseVisualStyleBackColor = true;
            // 
            // Student_name_label
            // 
            this.Student_name_label.AutoSize = true;
            this.Student_name_label.Location = new System.Drawing.Point(13, 13);
            this.Student_name_label.Name = "Student_name_label";
            this.Student_name_label.Size = new System.Drawing.Size(75, 13);
            this.Student_name_label.TabIndex = 2;
            this.Student_name_label.Text = "Student Name";
            this.Student_name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Submet_button
            // 
            this.Submet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submet_button.Location = new System.Drawing.Point(65, 177);
            this.Submet_button.Name = "Submet_button";
            this.Submet_button.Size = new System.Drawing.Size(160, 32);
            this.Submet_button.TabIndex = 5;
            this.Submet_button.Text = "Submet";
            this.Submet_button.UseVisualStyleBackColor = true;
            // 
            // Submet_text
            // 
            this.Submet_text.Location = new System.Drawing.Point(65, 141);
            this.Submet_text.Name = "Submet_text";
            this.Submet_text.Size = new System.Drawing.Size(160, 20);
            this.Submet_text.TabIndex = 4;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Submet_button);
            this.Controls.Add(this.Submet_text);
            this.Controls.Add(this.Student_name_label);
            this.Controls.Add(this.Student_back_button);
            this.Controls.Add(this.Student_report_button);
            this.Name = "Form6";
            this.Text = "Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Student_report_button;
        private System.Windows.Forms.Button Student_back_button;
        private System.Windows.Forms.Label Student_name_label;
        private System.Windows.Forms.Button Submet_button;
        private System.Windows.Forms.TextBox Submet_text;
    }
}