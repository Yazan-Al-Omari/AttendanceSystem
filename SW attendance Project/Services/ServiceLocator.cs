using SW_attendance_Project.Core;
using SW_attendance_Project.Infrastructer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Services
{
    public class ServiceLocator : IServiceLocator
    {

        private static SystemContextFactory _factory = new SystemContextFactory();

        public ICoursesService GetCoursesService()
        {
            return new CoursesService(_factory);
        }

        public IUsersService GetUsersService()
        {
            return new UsersService(_factory);
        }

        public IAuthenticationManager GetAuthenticationManager()
        {
            return AuthenticationManager.GetInstance(GetUsersService());
        }


        public IAttendanceNotifier GetAttendanceNotifier()
        {
            return new AttendanceNotifier(_factory, new EmailClient());
        }

        public IAttendanceChecker GetAttendanceChecker()
        {
            return new AttendanceChecker(_factory);
        }
    }
}
