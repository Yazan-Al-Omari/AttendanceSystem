namespace SW_attendance_Project.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SystemContext : DbContext
    {
        public SystemContext()
            : base("name=SystemContext")
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(e => e.Lectures)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.CourseId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Instructor)
                .HasForeignKey(e => e.InstructorId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Lecture>()
                .HasMany(e => e.Attendances)
                .WithRequired(e => e.Lecture)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Student>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Attendances)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(true);


            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<Student>().ToTable("Students");

            modelBuilder.Entity<Instructor>().ToTable("Instructors");
        }
    }
}
