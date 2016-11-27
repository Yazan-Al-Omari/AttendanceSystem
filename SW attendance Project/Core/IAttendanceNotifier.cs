using SW_attendance_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Core
{
    public interface IAttendanceNotifier
    {

        IEnumerable<AbsentNotification> GetUnnotifiedFor(int percentage);

        void Notify(IEnumerable<AbsentNotification> notifications);
    }

    public interface IAttendanceChecker
    {
        IEnumerable<Student> GetStudentsAbsentFor(int percentage, int courseId);
        void RegisterNotification(IEnumerable<Student> students, int courseId, int percentage);
    }
}
