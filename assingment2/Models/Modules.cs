using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace assingment2.Models
{
    public class Modules
    {
       
        
        public virtual int ModuleID { get; set; }
        public virtual int CourseId { get; set; }
        [Required]
        public virtual string ModuleCode { get; set; }
        [StringLength(100)]

        public virtual string ModuleTitle { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual Courses Courses { get; set; }
    }
}