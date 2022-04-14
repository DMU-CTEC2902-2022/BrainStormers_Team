using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace assingment2.Data
{
    public class assingment2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public assingment2Context() : base("name=assingment2Context")
        {
        }

        public DbSet<Models.Modules> Modules { get; set; }

        public DbSet<Models.Courses> Courses { get; set; }
    }
}
