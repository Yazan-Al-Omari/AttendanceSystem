using SW_attendance_Project.Core;
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
    public partial class LoginForm : Form
    {

        private IServiceLocator _serviceLocator;
        private IUsersService _usersService;
        private IAuthenticationManager _authManager;
        private ICoursesService _coursesService;

        public LoginForm(IServiceLocator serviceLocator)
        {
            InitializeComponent();
            _usersService = serviceLocator.GetUsersService();
            _coursesService = serviceLocator.GetCoursesService();
            _authManager = serviceLocator.GetAuthenticationManager();

            _serviceLocator = serviceLocator;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _authManager.Login(txtUsername.Text, txtPassword.Text);
            if (_authManager.IsAuthenticated())
           {
               if (user is Student)
               {
                   var studentForm = new StudentForm(_serviceLocator, this);
                   studentForm.Show();
                   
               }
               else if(user is Instructor)
               {
                   var instructorForm = new InstructorForm(_serviceLocator, this);
                   instructorForm.Show();
               }
               lblErrorMessage.Visible = false;
               this.Hide();
           }
           else
           {
               lblErrorMessage.Visible = true;
           }
           
        }
    }
}
