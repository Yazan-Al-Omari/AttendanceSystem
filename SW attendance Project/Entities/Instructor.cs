namespace SW_attendance_Project.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Instructor : User
    {
        public Instructor()
        {
            Courses = new HashSet<Course>();
        }

      
        public virtual ICollection<Course> Courses { get; set; }
    }
}
