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
    public partial class ViewLectureForm : Form
    {
        private IUsersService _usersServcie;
        private ICoursesService _coursesService;

        private Timer _timer;

        private Lecture _selectedLecture;

        public ViewLectureForm(IUsersService usersServcie, ICoursesService coursesService, Lecture selectedLecture)
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Enabled = false;
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;

            _selectedLecture = selectedLecture;
            lblTitle.Text = "Lecture: " + selectedLecture.Course.Name + " | " + selectedLecture.StartTime.ToShortDateString();
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            refreshData();
        }

        void refreshData()
        {
            foreach (var attendance in _selectedLecture.Attendances)
            {
                lstAttended.Items.Clear();
                lstAttended.Items.Add(new ListViewItem(new string[] {
                    attendance.Student.Id.ToString(),
                    attendance.Student.Number,
                    attendance.Student.Name,
                    attendance.Time.ToString("hh:mm:ss")
                }));
            }

            foreach (var student in _selectedLecture.StudentsApsent)
            {
                lstAttended.Items.Clear();
                lstAttended.Items.Add(new ListViewItem(new string[] {
                    student.Id.ToString(),
                    student.Number,
                    student.Name
                }));
            }
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            _timer.Enabled = chkAuto.Checked;
            if (chkAuto.Checked) _timer.Start();
            else _timer.Stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshData();
        }
    }
}
