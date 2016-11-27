using SW_attendance_Project.Core;
using SW_attendance_Project.Entities;
using SW_attendance_Project.Services;
using SW_attendance_Project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

            IServiceLocator serviceLocator = new ServiceLocator();
            Task t = new Task(() =>
            {
                AbsentNotifier(serviceLocator);
            });
            t.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(serviceLocator));
            
        }

        static void AbsentNotifier(IServiceLocator serviceLocator)
        {
            var checker = serviceLocator.GetAttendanceChecker();
            var notifier = serviceLocator.GetAttendanceNotifier();
            var coursesService = serviceLocator.GetCoursesService();
            int[] percentages = new int[] {10, 15, 20};
            do
            {
                foreach (var course in coursesService.GetAllCoureses())
                {
                    foreach (int p in percentages)
                    {
                        var students = checker.GetStudentsAbsentFor(p, course.Id);
                        checker.RegisterNotification(students, course.Id, p);
                    }
                }

                foreach (int p in percentages)
                {
                    var notifications = notifier.GetUnnotifiedFor(p);
                    notifier.Notify(notifications);
                }
                
                Thread.Sleep(5 * 60 * 1000);
            } while (true);
        }
    }
}
