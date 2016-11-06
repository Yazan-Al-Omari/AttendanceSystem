namespace SW_attendance_Project.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lecture
    {
        public Lecture()
        {
            Attendances = new HashSet<Attendance>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public TimeSpan StartTime { get; set; }

        public int CourseId { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }

        public virtual Course Course { get; set; }
    }
}
