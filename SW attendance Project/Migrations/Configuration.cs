namespace SW_attendance_Project.Migrations
{
    using SW_attendance_Project.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SW_attendance_Project.Entities.SystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SW_attendance_Project.Entities.SystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            var r = new Random();
            for (int i = 0; i < 30; i++)
            {
                context.Users.AddOrUpdate(new Student() { Id = i + 1, Name = "Student " + i, Email = "s" + i.ToString() + "@live.com", Number = "201221710" + i.ToString("00"), Password = "123456", UserType = UserType.Student });
            }
            context.SaveChanges();

            for (int i = 0; i < 5; i++)
            {
                var inst = new Instructor() { Id = i + 31, Name = "Instructor " + i, Email = "i" + i.ToString() + "@live.com", Password = "123456", UserType = UserType.Instructor };
                for (int j = 0; j < 5; j++)
                {
                    var c = new Course()
                    {
                        Name = "Course 1_" + i,
                        Duration = 60,
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddMonths(4),
                        Instructor = inst,
                        Location = "Bla",
                        TimeInDay = r.Next(0, 9) + 7

                    };
                    var stds = context.Users.OfType<Student>().Distinct().Take(10);
                    foreach (var s in stds)
                    {
                        c.Students.Add(s);
                    }
                    context.Users.AddOrUpdate(inst);
                    context.Courses.AddOrUpdate(c);
                }
            }
            context.SaveChanges();
        }
    }
}
