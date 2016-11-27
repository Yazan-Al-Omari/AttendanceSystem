using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Entities
{
    public class AbsentNotification
    {
        [Key, Column(Order = 1)]
        public int StudentId { get; set; }

        [Key, Column(Order = 2)]
        public int CourseId { get; set; }

        [Key, Column(Order = 3)]
        public int Percentage { get; set; }

        public bool IsSent { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }

     
    }
}
