using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assingment2.Models
{
    public class Courses
    {
        
            public virtual int CourseID { get; set; }
            public virtual int CourseFee { get; set; }
            public virtual string CourseName { get; set; }
            public virtual DateTime StartDate { get; set; }
            public virtual DateTime EndDate { get; set; }

        

    }
}