using SW_attendance_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Core
{
    public interface IAuthenticationManager
    {
        User Login(string username, string password);

        User GetLoggedInUser();

        bool IsAuthenticated();

        void Logout();
    }
}
