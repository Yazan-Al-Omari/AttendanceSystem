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
    public partial class LoginForm : Form
    {
        private IUsersService _usersService;
        public LoginForm(IUsersService usersService)
        {    
            InitializeComponent();
            _usersService = usersService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           var user =  _usersService.Login(txtUsername.Text, txtPassword.Text);
           if (_usersService.IsAuthenticated())
           {
               if (user is Student)
               {
                   var studentForm = new StudentForm(_usersService);
                   studentForm.Show();
                   
               }
               else if(user is Instructor)
               {
                   var instructorForm = new InstructorForm(_usersService);
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
