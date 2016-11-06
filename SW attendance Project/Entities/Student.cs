namespace SW_attendance_Project.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Student : User
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
        }


        [Required]
        [StringLength(11)]
        public string Number { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
