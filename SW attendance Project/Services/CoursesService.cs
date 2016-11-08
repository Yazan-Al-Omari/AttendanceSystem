using SW_attendance_Project.Core;
using SW_attendance_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Services
{
    public class CoursesService : ICoursesService
    {
        private SystemContext _db;

        public CoursesService(SystemContextFactory factory)
        {
            _db = factory.GetNewSystemContext();
        }
        public void AddCourse(Course course)
        {
            _db.Courses.Add(course);
            _db.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            var course = GetCourseById(id);
            _db.Entry(course).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();
        }

        public Course GetCourseById(int id)
        {
            var course = _db.Courses.SingleOrDefault(x => x.Id == id);
            _db.Entry(course).Reload();
            return course;
        }

        public IQueryable<Entities.Course> GetAllCoureses()
        {
            return _db.Courses.AsQueryable();
        }

        public IQueryable<Entities.Course> GetCoursesForInstructor(int instructorId)
        {
            return _db.Courses.Where(x => x.InstructorId == instructorId);
        }

        public IQueryable<Entities.Course> GetCoursesForStudent(int studentId)
        {
            var student = _db.Users.OfType<Student>().SingleOrDefault(x => x.Id == studentId);
            _db.Entry(student).Reload();
            return student.Courses.AsQueryable();
        }

        public Lecture StartLecture(int courseId)
        {
            var lecture = new Lecture()
            {
                Course = GetCourseById(courseId),
                StartTime = DateTime.Now
            };
            _db.Lectures.Add(lecture);
            _db.SaveChanges();
            return lecture;
        }

        public Lecture GetActiveLectureForStudent(int studentId)
        {
            var student = _db.Users.OfType<Student>().SingleOrDefault(x => x.Id == studentId);
            _db.Entry(student).Reload();
            return student.Courses
                .Where(c => c.StartDate <= DateTime.Now && c.EndDate > DateTime.Now)
                .SelectMany(x => x.Lectures)
                .Where(x => !x.Attendances.Any(j => j.StudentId == studentId))
                .Where(x => x.StartTime <= DateTime.Now && x.StartTime.AddMinutes(x.Course.Duration) >= DateTime.Now)
                .FirstOrDefault();
        }

        public Attendance RegisterAttendance(int studentId, int lectureId)
        {
            var student = _db.Users.OfType<Student>().SingleOrDefault(x => x.Id == studentId);
            var lecture = _db.Lectures.SingleOrDefault(x => x.Id == lectureId);

            var attenance = new Attendance()
            {
                Lecture = lecture,
                Student = student,
                Time = DateTime.Now
            };
            lecture.Attendances.Add(attenance);
            _db.SaveChanges();

            return attenance;
        }


        public void AddLecture(Lecture lecture)
        {
            throw new NotImplementedException();
        }


        public Lecture GetLectureById(int id)
        {
            var l = _db.Lectures.Find(id);
            _db.Entry(l).Reload();
            return l;
        }
    }
}
    