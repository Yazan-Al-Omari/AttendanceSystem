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
    public partial class InstructorForm : Form
    {
        private IUsersService _usersServcie;
        private ICoursesService _coursesService;
        private LoginForm _loginForm;
        public InstructorForm(IUsersService usersServcie, ICoursesService coursesService, LoginForm loginForm)
        {
            InitializeComponent();
            _usersServcie = usersServcie;
            _coursesService = coursesService;
            _loginForm = loginForm;
            checkUser();
            refreshForm();
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "btnLogout":
                    _usersServcie.Logout();
                    _loginForm.Show();
                    this.Hide();
                    break;
            }
        }

        private void checkUser()
        {
            var currentInstrutor = _usersServcie.GetLoggedInUser();
            if (_usersServcie.IsAuthenticated() && currentInstrutor is Instructor)
            {
                _coursesService.GetCoursesForInstructor(currentInstrutor.Id);
            }
            else
            {
                throw new Exception("Instructor Is Not LoggedIn");
            }

        }

        private void refreshForm(){
            var currentInstrutor = _usersServcie.GetLoggedInUser();
            lblCurrentUser.Text = "Welcome, " + currentInstrutor.Name;
        }
    }
}
