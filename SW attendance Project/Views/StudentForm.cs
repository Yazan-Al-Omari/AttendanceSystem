using SW_attendance_Project.Core;
using SW_attendance_Project.Entities;
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
    public partial class StudentForm : Form
    {
        private IUsersService _usersServcie;
        private ICoursesService _coursesService;
        private LoginForm _loginForm;


        public StudentForm(IUsersService usersServcie, ICoursesService coursesService, LoginForm loginForm)
        {
            InitializeComponent();
            _usersServcie = usersServcie;
            _coursesService = coursesService;
            _loginForm = loginForm;
        
            refreshForm();
        }
    
     
        private void refreshForm()
        {
            lstCourses.Items.Clear();
            var student = (Student)(_usersServcie.GetUserById(_usersServcie.GetLoggedInUser().Id));
            foreach (var course in _coursesService.GetCoursesForStudent(student.Id))
            {
                var item = new ListViewItem(new string[] {
                    course.Id.ToString(), 
                    course.Name, 
                    course.Instructor.Name,
                    student.GetApsentForCourse(course.Id).Count().ToString(),
                });
                item.Tag = course;
                lstCourses.Items.Add(item);
            }
            var activeLecture = _coursesService.GetActiveLectureForStudent(student.Id);
           if (activeLecture != null)
            {
                btnCheckin.Enabled = true;
                lblCheckin.Text = "Lecture: " + activeLecture.Course.Name + " is currantly being held!";
            }
            else
            {
                btnCheckin.Enabled = false; ;
                lblCheckin.Text = "No Active Lectures At The Moment!";
            }
            
            
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstApsent.Items.Clear();
            var student = (Student)_usersServcie.GetLoggedInUser();
            if(lstCourses.SelectedItems.Count != 1) return ;

            var selectedCourse = (Course) lstCourses.SelectedItems[0].Tag;
            foreach (var lecture in student.GetApsentForCourse(selectedCourse.Id))
            {
                lstApsent.Items.Add(lecture.StartTime.ToShortDateString());
            }
        }


        private void StudentForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            logout();
        }


        private void logout()
        {
            _usersServcie.Logout();
            _loginForm.Show();
            this.Hide();
        }
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            var student = (Student)_usersServcie.GetLoggedInUser();
            var activeLecture = (Lecture)_coursesService.GetActiveLectureForStudent(student.Id);
            if (activeLecture != null)
            {
                _coursesService.RegisterAttendance(student.Id, activeLecture.Id);
               lblCheckin.Text = "Successfully Checked In...";
               refreshForm();
            }

        }

    
    }
}
