using SW_attendance_Project.Core;
using SW_attendance_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Services
{
    public class UsersService : IUsersService
    {
        // Hello From Zaid
        private SystemContext _db;
        private User _user;

        private static IUsersService _instance;

        public static IUsersService GetInstance(SystemContext db)
        {
            if (_instance == null)
            {
                _instance = new UsersService(db);
            }
            return _instance;
        }

        private UsersService(SystemContext db)
        {
            _db = db;
        }

        public User Login(string username, string password)
        {
            Logout();
            _user = _db.Users.OfType<Instructor>().SingleOrDefault(x => x.Password == password && x.Email == username);
            if (_user == null)
            {
                _user = _db.Users.OfType<Student>().SingleOrDefault(x => x.Password == password && x.Number == username);
            }
            return _user;
        }

        public User GetUserById(int id)
        {
            var user = _db.Users.SingleOrDefault(x => x.Id == id);
            return user;
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
