using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SW_attendance_Project.Core;
using Attendance.Test.TestImp;
using SW_attendance_Project.Services;

namespace Attendance.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCorrectLogin()
        {

            // Setup
            IUsersService service = new UsersServiceFake();
            IAuthenticationManager manager = AuthenticationManager.GetInstance(service);

            // Action
            manager.Login("123", "123456");

            // Assertion
            Assert.IsTrue(manager.IsAuthenticated());
        }

        [TestMethod]
        public void TestFaildLogin()
        {
            // Setup
            IUsersService service = new UsersServiceFake();
            IAuthenticationManager manager = AuthenticationManager.GetInstance(service);

            // Action
            manager.Login("i0@live.com", "123");

            // Assertion
            Assert.IsFalse(manager.IsAuthenticated());
        }
    }
}
