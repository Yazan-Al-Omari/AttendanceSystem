namespace SW_attendance_Project.Views
{
    partial class StudentForm
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
            this.btnCheckin = new System.Windows.Forms.Button();
            this.grpCheckin = new System.Windows.Forms.GroupBox();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCourses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstApsent = new System.Windows.Forms.ListBox();
            this.lblApsent = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCheckin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(24, 42);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(131, 43);
            this.btnCheckin.TabIndex = 0;
            this.btnCheckin.Text = "Check In";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // grpCheckin
            // 
            this.grpCheckin.Controls.Add(this.lblCheckin);
            this.grpCheckin.Controls.Add(this.btnCheckin);
            this.grpCheckin.Location = new System.Drawing.Point(12, 284);
            this.grpCheckin.Name = "grpCheckin";
            this.grpCheckin.Size = new System.Drawing.Size(550, 113);
            this.grpCheckin.TabIndex = 1;
            this.grpCheckin.TabStop = false;
            this.grpCheckin.Text = "Active Lecture";
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Location = new System.Drawing.Point(175, 57);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(49, 13);
            this.lblCheckin.TabIndex = 1;
            this.lblCheckin.Text = "Lecture: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblApsent);
            this.groupBox2.Controls.Add(this.lstApsent);
            this.groupBox2.Controls.Add(this.lstCourses);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 266);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Courses";
            // 
            // lstCourses
            // 
            this.lstCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.lstCourses.FullRowSelect = true;
            this.lstCourses.GridLines = true;
            this.lstCourses.Location = new System.Drawing.Point(6, 19);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(345, 241);
            this.lstCourses.TabIndex = 0;
            this.lstCourses.UseCompatibleStateImageBehavior = false;
            this.lstCourses.View = System.Windows.Forms.View.Details;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 29;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apsents";
            // 
            // lstApsent
            // 
            this.lstApsent.FormattingEnabled = true;
            this.lstApsent.Location = new System.Drawing.Point(357, 48);
            this.lstApsent.Name = "lstApsent";
            this.lstApsent.Size = new System.Drawing.Size(187, 212);
            this.lstApsent.TabIndex = 1;
            // 
            // lblApsent
            // 
            this.lblApsent.AutoSize = true;
            this.lblApsent.Location = new System.Drawing.Point(354, 32);
            this.lblApsent.Name = "lblApsent";
            this.lblApsent.Size = new System.Drawing.Size(148, 13);
            this.lblApsent.TabIndex = 2;
            this.lblApsent.Text = "Selected Course Apsent Days";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Instructor";
            this.columnHeader4.Width = 131;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCheckin);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.grpCheckin.ResumeLayout(false);
            this.grpCheckin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.GroupBox grpCheckin;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblApsent;
        private System.Windows.Forms.ListBox lstApsent;
        private System.Windows.Forms.ListView lstCourses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}