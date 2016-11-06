using SW_attendance_Project.Core;
using SW_attendance_Project.Entities;
using SW_attendance_Project.Services;
using SW_attendance_Project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_attendance_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IUsersService usersService = UsersService.GetInstance(); 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(usersService, new CoursesService()));
            
        }
    }
}
