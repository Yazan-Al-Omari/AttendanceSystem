using SW_attendance_Project.Core;
using SW_attendance_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Services
{
    public class AuthenticationManager : IAuthenticationManager
    {

        private IUsersService _usersService;
        private User _user;

        private static AuthenticationManager _instance;

        public static AuthenticationManager GetInstance(IUsersService usersService)
        {
            if (_instance == null)
            {
                _instance = new AuthenticationManager(usersService);
            }
            return _instance;
        }

        private AuthenticationManager(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public User Login(string username, string password)
        {
            Logout();
            _user = _usersService.GetUser(username, password);
            return _user;
        }

        public User GetLoggedInUser()
        {
            return _user;
        }

        public bool IsAuthenticated()
        {
            return (_user != null);
        }


        public void Logout()
        {
            _user = null;
        }
    }
}
