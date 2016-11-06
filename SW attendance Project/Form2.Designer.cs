namespace SW_attendance_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Ins_Login_button = new System.Windows.Forms.Button();
            this.Ins_user_text = new System.Windows.Forms.TextBox();
            this.Ins_password_text = new System.Windows.Forms.TextBox();
            this.Ins_login_back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ins_Login_button
            // 
            resources.ApplyResources(this.Ins_Login_button, "Ins_Login_button");
            this.Ins_Login_button.ForeColor = System.Drawing.Color.Blue;
            this.Ins_Login_button.Name = "Ins_Login_button";
            this.Ins_Login_button.UseVisualStyleBackColor = true;
            // 
            // Ins_user_text
            // 
            resources.ApplyResources(this.Ins_user_text, "Ins_user_text");
            this.Ins_user_text.Name = "Ins_user_text";
            // 
            // Ins_password_text
            // 
            resources.ApplyResources(this.Ins_password_text, "Ins_password_text");
            this.Ins_password_text.Name = "Ins_password_text";
            // 
            // Ins_login_back_button
            // 
            resources.ApplyResources(this.Ins_login_back_button, "Ins_login_back_button");
            this.Ins_login_back_button.Name = "Ins_login_back_button";
            this.Ins_login_back_button.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ins_login_back_button);
            this.Controls.Add(this.Ins_password_text);
            this.Controls.Add(this.Ins_user_text);
            this.Controls.Add(this.Ins_Login_button);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ins_Login_button;
        private System.Windows.Forms.TextBox Ins_user_text;
        private System.Windows.Forms.TextBox Ins_password_text;
        private System.Windows.Forms.Button Ins_login_back_button;
    }
}