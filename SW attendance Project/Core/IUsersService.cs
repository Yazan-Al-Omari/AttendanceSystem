using SW_attendance_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Core
{
    public interface IUsersService
    {
        User Login(string username, string password);

        void Logout();

        User GetLoggedInUser();
        bool IsAuthenticated();

        User GetUserById(int id);
    }
}
