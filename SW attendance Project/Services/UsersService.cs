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
        private SystemContext _db;

        public UsersService(SystemContextFactory factory)
        {
            _db = factory.GetNewSystemContext();
        }

        public User GetUser(string username, string password)
        {
            User user = _db.Users.OfType<Instructor>().SingleOrDefault(x => x.Password == password && x.Email == username);
            if (user == null)
            {
                user = _db.Users.OfType<Student>().SingleOrDefault(x => x.Password == password && x.Number == username);
            }
            return user;
        }

        public User GetUserById(int id)
        {
            var user = _db.Users.SingleOrDefault(x => x.Id == id);
            _db.Entry(user).Reload();
            return user;
        }


    }
}
