using SW_attendance_Project.Core;
using SW_attendance_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Test.TestImp
{
    public class UsersServiceFake : IUsersService
    {
        private List<User> _users = new List<User>();

        public UsersServiceFake()
        {
            _users.Add(new Student() { Id = 1, Email = "yazan.omari@live.com", Name = "Yazan", Password = "123456", UserType = UserType.Student, Number = "123" });
            _users.Add(new Instructor() { Id = 1, Email = "i0@live.com", Name = "Yazan", Password = "123456", UserType = UserType.Instructor });
        }

        public SW_attendance_Project.Entities.User GetUser(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Email == username && x.Password == password);
            if (user == null)
            {
                user = _users.OfType<Student>().SingleOrDefault(x => x.Number == username && x.Password == password);
            }
            return user;
        }

        public SW_attendance_Project.Entities.User GetUserById(int id)
        {
            return _users.SingleOrDefault(x => x.Id == id);
        }
    }
}
