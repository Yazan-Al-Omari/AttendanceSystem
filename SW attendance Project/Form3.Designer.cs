namespace SW_attendance_Project
{
    partial class Form3
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
            this.Student_password_text = new System.Windows.Forms.TextBox();
            this.Student_user_text = new System.Windows.Forms.TextBox();
            this.Student_Login_button = new System.Windows.Forms.Button();
            this.Student_login_back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Student_password_text
            // 
            this.Student_password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_password_text.Location = new System.Drawing.Point(86, 99);
            this.Student_password_text.Name = "Student_password_text";
            this.Student_password_text.Size = new System.Drawing.Size(113, 26);
            this.Student_password_text.TabIndex = 5;
            this.Student_password_text.Text = "Password";
            // 
            // Student_user_text
            // 
            this.Student_user_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_user_text.Location = new System.Drawing.Point(86, 67);
            this.Student_user_text.Name = "Student_user_text";
            this.Student_user_text.Size = new System.Drawing.Size(113, 26);
            this.Student_user_text.TabIndex = 4;
            this.Student_user_text.Text = "Username";
            // 
            // Student_Login_button
            // 
            this.Student_Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Login_button.ForeColor = System.Drawing.Color.Blue;
            this.Student_Login_button.Location = new System.Drawing.Point(96, 136);
            this.Student_Login_button.Name = "Student_Login_button";
            this.Student_Login_button.Size = new System.Drawing.Size(87, 38);
            this.Student_Login_button.TabIndex = 3;
            this.Student_Login_button.Text = "LogIn";
            this.Student_Login_button.UseVisualStyleBackColor = true;
            // 
            // Student_login_back_button
            // 
            this.Student_login_back_button.Location = new System.Drawing.Point(197, 226);
            this.Student_login_back_button.Name = "Student_login_back_button";
            this.Student_login_back_button.Size = new System.Drawing.Size(75, 23);
            this.Student_login_back_button.TabIndex = 6;
            this.Student_login_back_button.Text = "Back";
            this.Student_login_back_button.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Student_login_back_button);
            this.Controls.Add(this.Student_password_text);
            this.Controls.Add(this.Student_user_text);
            this.Controls.Add(this.Student_Login_button);
            this.Name = "Form3";
            this.Text = "Student_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Student_password_text;
        private System.Windows.Forms.TextBox Student_user_text;
        private System.Windows.Forms.Button Student_Login_button;
        private System.Windows.Forms.Button Student_login_back_button;
    }
}