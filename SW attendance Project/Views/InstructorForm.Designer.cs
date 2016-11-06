namespace SW_attendance_Project.Views
{
    partial class InstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            this.lstLectures = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripLabel();
            this.btnStartLecture = new System.Windows.Forms.ToolStripButton();
            this.btnViewLectures = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddCourse = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCourse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTitle = new System.Windows.Forms.ToolStripLabel();
            this.lstCourses = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLectures
            // 
            this.lstLectures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader19,
            this.columnHeader18,
            this.columnHeader20});
            this.lstLectures.FullRowSelect = true;
            this.lstLectures.GridLines = true;
            this.lstLectures.Location = new System.Drawing.Point(12, 44);
            this.lstLectures.Name = "lstLectures";
            this.lstLectures.Size = new System.Drawing.Size(711, 284);
            this.lstLectures.TabIndex = 0;
            this.lstLectures.UseCompatibleStateImageBehavior = false;
            this.lstLectures.View = System.Windows.Forms.View.Details;
            this.lstLectures.Visible = false;
            this.lstLectures.SelectedIndexChanged += new System.EventHandler(this.lstLectures_SelectedIndexChanged);
            this.lstLectures.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstLectures_MouseDoubleClick);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Id";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Start Time";
            this.columnHeader19.Width = 210;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Attended";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Apsent";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.toolStripSeparator3,
            this.btnLogout,
            this.lblCurrentUser,
            this.btnStartLecture,
            this.btnViewLectures,
            this.toolStripSeparator1,
            this.btnAddCourse,
            this.btnDeleteCourse,
            this.toolStripSeparator2,
            this.lblTitle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(735, 41);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Enabled = false;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 38);
            this.btnBack.Text = "Back";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // btnLogout
            // 
            this.btnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(23, 38);
            this.btnLogout.Text = "Logout";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(93, 38);
            this.lblCurrentUser.Text = "Welcome, Yazan";
            // 
            // btnStartLecture
            // 
            this.btnStartLecture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStartLecture.Enabled = false;
            this.btnStartLecture.Image = ((System.Drawing.Image)(resources.GetObject("btnStartLecture.Image")));
            this.btnStartLecture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartLecture.Name = "btnStartLecture";
            this.btnStartLecture.Size = new System.Drawing.Size(23, 38);
            this.btnStartLecture.Tag = "0";
            this.btnStartLecture.Text = "Start lecture";
            // 
            // btnViewLectures
            // 
            this.btnViewLectures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnViewLectures.Enabled = false;
            this.btnViewLectures.Image = ((System.Drawing.Image)(resources.GetObject("btnViewLectures.Image")));
            this.btnViewLectures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewLectures.Name = "btnViewLectures";
            this.btnViewLectures.Size = new System.Drawing.Size(23, 38);
            this.btnViewLectures.Tag = "0";
            this.btnViewLectures.Text = "btnViewLectuers";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            this.toolStripSeparator1.Tag = "0";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(23, 38);
            this.btnAddCourse.Tag = "0";
            this.btnAddCourse.Text = "toolStripButton2";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCourse.Enabled = false;
            this.btnDeleteCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCourse.Image")));
            this.btnDeleteCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(23, 38);
            this.btnDeleteCourse.Tag = "0";
            this.btnDeleteCourse.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            this.toolStripSeparator2.Tag = "";
            // 
            // lblTitle
            // 
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 38);
            this.lblTitle.Text = "Title";
            // 
            // lstCourses
            // 
            this.lstCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lstCourses.FullRowSelect = true;
            this.lstCourses.GridLines = true;
            this.lstCourses.Location = new System.Drawing.Point(12, 44);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(711, 284);
            this.lstCourses.TabIndex = 3;
            this.lstCourses.UseCompatibleStateImageBehavior = false;
            this.lstCourses.View = System.Windows.Forms.View.Details;
            this.lstCourses.Visible = false;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            this.lstCourses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCourses_MouseDoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Id";
            this.columnHeader9.Width = 40;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Name";
            this.columnHeader10.Width = 140;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Time";
            this.columnHeader11.Width = 87;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Duration";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Start Date";
            this.columnHeader13.Width = 113;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "End Date";
            this.columnHeader14.Width = 115;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Location";
            this.columnHeader15.Width = 92;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Students";
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 340);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.lstLectures);
            this.Name = "InstructorForm";
            this.Text = "Instructor Courses";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstLectures;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripButton btnStartLecture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddCourse;
        private System.Windows.Forms.ToolStripButton btnDeleteCourse;
        private System.Windows.Forms.ToolStripButton btnViewLectures;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblTitle;
        private System.Windows.Forms.ListView lstCourses;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader20;
    }
}