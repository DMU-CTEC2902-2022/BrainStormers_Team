using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace assingment2.Models
{
    public class Courses
    {
        [Key]
        public virtual int CourseId { get; set; }

        public virtual int CourseFee { get; set; }
        public virtual string CourseName { get; set; }



    }
}