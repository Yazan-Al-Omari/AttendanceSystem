﻿using SW_attendance_Project.Core;
using SW_attendance_Project.Entities;
using SW_attendance_Project.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_attendance_Project.Views
{
    public partial class InstructorForm : Form
    {

        
        private IServiceLocator _serviceLocator;
        private IUsersService _usersService;
        private IAuthenticationManager _authManager;
        private ICoursesService _coursesService;
  
        private LoginForm _loginForm;

        private Course _selectedCourse;

        public InstructorForm(IServiceLocator serviceLocator, LoginForm loginForm)
        {
            InitializeComponent();
            _usersService = serviceLocator.GetUsersService();
            _coursesService = serviceLocator.GetCoursesService();
            _authManager = serviceLocator.GetAuthenticationManager();
            _serviceLocator = serviceLocator;
            _loginForm = loginForm;

            Mode = FormMode.ViewCourses;

            checkUser();
            refreshForm();
        }


        private FormMode _mode;

        public FormMode Mode
        {
            set
            {
                _mode = value;
                refreshForm();
            }
            get
            {
                return _mode;
            }
        }



        private void InstructorForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            logout();
        }


        private void logout()
        {
            _authManager.Logout();
            _loginForm.Show();
            this.Hide();
           
        }

        private void checkUser()
        {
            var currentInstrutor = _authManager.GetLoggedInUser();
            if (_authManager.IsAuthenticated() && currentInstrutor is Instructor)
            {
                _coursesService.GetCoursesForInstructor(currentInstrutor.Id);
            }
            else
            {
                throw new Exception("Instructor Is Not LoggedIn");
            }

        }

        private void refreshForm()
        {
            var currentInstrutor = _authManager.GetLoggedInUser();
            lblCurrentUser.Text = "Welcome, " + currentInstrutor.Name;

            activateStrip();

            switch (_mode)
            {
                default:
                case FormMode.ViewCourses: loadCoursesMode(); break;
                case FormMode.ViewLectures: loadLecturesMode(); break;
            }
           
        }

        void activateStrip()
        {
            btnBack.Enabled = false;
            foreach (var item in toolStrip1.Items)
            {
                if (item is ToolStripItem)
                {
                    var casted = ((ToolStripItem)item);

                    if (casted.Tag != null && casted.Tag.ToString() == "0") casted.Visible = (Mode == FormMode.ViewCourses);
                    else if (casted.Tag != null && casted.Tag.ToString() == "1") casted.Visible = (Mode == FormMode.ViewLectures);
                }

            }
            lstCourses.Visible = Mode == FormMode.ViewCourses;
            lstLectures.Visible = Mode == FormMode.ViewLectures;
            lblTitle.Text = "Courses List";
        }

        private void loadLecturesMode()
        {
            lstLectures.Items.Clear();
            foreach(var lecture in _selectedCourse.Lectures)
            {
                var item = new ListViewItem(new string[] {
                    lecture.Id.ToString(), 
                    lecture.StartTime.ToString(), 
                    lecture.StudentsAttended.Count().ToString(),
                    lecture.StudentsApsent.Count().ToString()
                });
                item.Tag = lecture;
                lstLectures.Items.Add(item);
            }
            btnBack.Enabled = true;
            lblTitle.Text = "Lectures Of Course " + _selectedCourse.Name;
        }

        private void loadCoursesMode()
        {
            var currentInstrutor = _authManager.GetLoggedInUser();
            lstCourses.Items.Clear();
            foreach (var course in _coursesService.GetCoursesForInstructor(currentInstrutor.Id).OrderBy(x => x.TimeInDay))
            {
                var item = new ListViewItem(new string[] {
                    course.Id.ToString(), 
                    course.Name, 
                    course.TimeInDay.ToString(),
                    course.Duration.ToString(),
                    course.StartDate.ToShortDateString(),
                    course.EndDate.ToShortDateString(),
                    course.Location,
                    course.Students.Count.ToString()
                });
                item.Tag = course;
                lstCourses.Items.Add(item);
            }
        }

        private void lstLectures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstLectures_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstLectures.SelectedItems.Count != 1) return;
            var casted = (Lecture)lstLectures.SelectedItems[0].Tag;
            var viewLectureForm = new ViewLectureForm(_serviceLocator, casted);
            viewLectureForm.ShowDialog();
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStartLecture.Enabled = lstCourses.SelectedItems.Count == 1;
            btnViewLectures.Enabled = lstCourses.SelectedItems.Count == 1;
            btnDeleteCourse.Enabled = lstCourses.SelectedItems.Count == 1;

            if (lstCourses.SelectedItems.Count != 1)
            {
                _selectedCourse = null;
                return;
            }
            _selectedCourse = (Course)lstCourses.SelectedItems[0].Tag;
        }

        private void lstCourses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstCourses.SelectedItems.Count != 1)
            {
                _selectedCourse = null;
                return;
            }
            Mode = FormMode.ViewLectures;
        }

        private void btnStartLecture_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please Select a Course!");
                return;
            }
           var newLecture =  _coursesService.StartLecture(_selectedCourse.Id);
           var viewLectureForm = new ViewLectureForm(_serviceLocator, newLecture);
           viewLectureForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Mode = FormMode.ViewCourses;
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}

public enum FormMode : byte {
    ViewCourses,
    ViewLectures
}