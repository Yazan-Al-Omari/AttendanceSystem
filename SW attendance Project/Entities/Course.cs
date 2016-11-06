namespace SW_attendance_Project.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Course
    {
        public Course()
        {
            Lectures = new HashSet<Lecture>();
            Students = new HashSet<Student>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int InstructorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        public double TimeInDay { get; set; }

        public short Duration { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public virtual Instructor Instructor { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }

        public virtual ICollection<Student> Students { get; set; }

       
    }
}
