using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using assingment2.Data;

namespace assingment2.Models
{
    public class ModuleDataInitialiser : DropCreateDatabaseAlways<assingment2Context>
    {
        protected override void Seed(assingment2Context context)
        {
            Courses con1 = new Courses();
            con1.CourseId = 1;
            con1.CourseName = "Computer Science";
            con1.CourseFee = 222;
            context.Courses.Add(con1);

            Courses con2 = new Courses();
            con2.CourseId = 2;
            con2.CourseName = "Software Engineering";
            con2.CourseFee = 222;
            context.Courses.Add(con2);

            Courses con3 = new Courses();
            con3.CourseId = 3;
            con3.CourseName = "Cyber Security";
            con3.CourseFee = 222;
            context.Courses.Add(con3);

            //...................................................................

           Modules mod1 = new Modules();
            mod1.ModuleID = 1;
            mod1.CourseId = 1; 
            mod1.ModuleTitle = "Scala Programming";
            mod1.ModuleCode = "COS1903";
            mod1.StartDate = Convert.ToDateTime("1/1/2010");
            mod1.EndDate = Convert.ToDateTime("1/1/2010");
            context.Modules.Add(mod1);

            Modules mod2 = new Modules();
            mod2.ModuleID = 2;
            mod2.CourseId = 1; 
            mod2.ModuleTitle = "Scala Programming";
            mod2.ModuleCode = "COS1903";
            mod2.StartDate = Convert.ToDateTime("1/1/2010");
            mod2.EndDate = Convert.ToDateTime("1/1/2010");
            context.Modules.Add(mod2);

            Modules mod3 = new Modules();
            mod3.ModuleID = 3;
            mod3.CourseId = 1; 
            mod3.ModuleTitle = "Scala Programming";
            mod3.ModuleCode = "COS1903";
            mod3.StartDate = Convert.ToDateTime("1/1/2010");
            mod3.EndDate = Convert.ToDateTime("1/1/2010");

            context.Modules.Add(mod3);

            Modules mod4 = new Modules();
            mod4.ModuleID = 4;
            mod4.CourseId = 1; 
            mod4.ModuleTitle = "Scala Programming";
            mod4.ModuleCode = "COS1903";
            mod4.StartDate = Convert.ToDateTime("1/1/2010");
            mod4.EndDate = Convert.ToDateTime("1/1/2010");

            context.Modules.Add(mod4);

            Modules mod5 = new Modules();
            mod5.ModuleID = 5;
            mod5.CourseId = 1; 
            mod5.ModuleTitle = "Scala Programming";
            mod5.ModuleCode = "COS1903";
            mod5.StartDate = Convert.ToDateTime("1/1/2010");
            mod5.EndDate = Convert.ToDateTime("1/1/2010");

            context.Modules.Add(mod5);

            Modules mod6 = new Modules();
            mod6.ModuleID = 6;
            mod6.CourseId = 1; 
            mod6.ModuleTitle = "Scala Programming";
            mod6.ModuleCode = "COS1903";
            mod6.StartDate = Convert.ToDateTime("1/1/2010");
            mod6.EndDate = Convert.ToDateTime("1/1/2010");

            context.Modules.Add(mod6);

            Modules mod7 = new Modules();
            mod7.ModuleID = 7;
            mod7.CourseId = 2; 
            mod7.ModuleTitle = "Scala Programming";
            mod7.ModuleCode = "COS1903";
            mod7.StartDate = Convert.ToDateTime("1/1/2010");
            mod7.EndDate = Convert.ToDateTime("1/1/2010");

            context.Modules.Add(mod7);

            base.Seed(context);
        }
    }

}