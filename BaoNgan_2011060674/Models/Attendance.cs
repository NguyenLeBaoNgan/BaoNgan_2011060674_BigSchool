using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaoNgan_2011060674.Models
{
    public class Attendance
    {
      
        public virtual Course Course { get; set; }
        [Key]
        [Column(Order = 0)]
        public int CourseId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string AttendeeId { get; set; }

    }
}