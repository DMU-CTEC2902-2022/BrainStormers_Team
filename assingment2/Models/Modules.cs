using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assingment2.Models
{
    public class Modules
    {
        public virtual int ModuleId { get; set; }
        public virtual string ModuleContent { get; set; }
        public virtual string ModuleName { get; set; }
    }
}