using SW_attendance_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Core
{
   public interface ICoursesService
    {
       void AddCourse(Course course);
       void DeleteCourse(int id);

       Course GetCourseById(int id);

       IQueryable<Course> GetAllCoureses();

       IQueryable<Course> GetCoursesForInstructor(int instructorId);

       IQueryable<Course> GetCoursesForStudent(int studentId);

    }
}
