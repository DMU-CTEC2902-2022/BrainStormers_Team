using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using assingment2.Models;
using System.Diagnostics;
namespace assingment2.Controllers
{
    public class ModulesController : Controller
    {
        // GET: Modules
        private List<Modules> _modules = new List<Modules>() {
         new Modules { ModuleID = 1,
         ModuleCode = "COS1903",
         ModuleTitle = "Scala Programming",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 2,
         ModuleCode = "COS1920",
         ModuleTitle = "Database Management",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 3,
         ModuleCode = "COS2905",
         ModuleTitle = "Object Oriented Programming (Java)",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 4,
         ModuleCode = "COS2910",
         ModuleTitle = "Database Management",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 5,
         ModuleCode = "COS3911",
         ModuleTitle = "Mobile Application",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 6,
         ModuleCode = "IMAT3611",
         ModuleTitle = "Computer Ethics and Privacy",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 7,
         ModuleCode = "COS3451",
         ModuleTitle = "Development Project",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},
         //------------------------------------------------------------------------------------------
          new Modules { ModuleID = 8,
         ModuleCode = "SE3906",
         ModuleTitle = "Interaction Design",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID =9,
         ModuleCode = "SE3410",
         ModuleTitle = "Web Application Penetration Testing",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 10,
         ModuleCode = "SE3406",
         ModuleTitle = "Fuzzy Logic & Knowledge Based Systems",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 11,
         ModuleCode = "SE3613",
         ModuleTitle = "Data Mining",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 12,
         ModuleCode = "SE3614",
         ModuleTitle = "Big Data & Business Models",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 13,
         ModuleCode = "IMAT3611",
         ModuleTitle = "Computer Ethics and Privacy",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID =14,
         ModuleCode = "SE3451",
         ModuleTitle = "Development Project",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},
         //----------------------------------------------------------------------
          new Modules { ModuleID = 15,
         ModuleCode = "SE3901",
         ModuleTitle = "C Programming ",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID =16,
         ModuleCode = "SE3902",
         ModuleTitle = "Computer Law and Cyber Security Management",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 17,
         ModuleCode = "SE3903",
         ModuleTitle = "Linux Security",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 18,
         ModuleCode = "SE3904",
         ModuleTitle = "Cyber Threat Intelligence and Incident Response",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 19,
         ModuleCode = "SE3905",
         ModuleTitle = "Malware Analysis",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID = 20,
         ModuleCode = "IMAT3611",
         ModuleTitle = "Computer Ethics and Privacy",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},

         new Modules { ModuleID =21,
         ModuleCode = "SE3451",
         ModuleTitle = "Development Project",
         StartDate = new DateTime(2022,2,11),
         EndDate = new DateTime(2023,2,3)},


};
        // GET: Details/id
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            Modules selectedModules = _modules.First(p => p.ModuleID == id);

            if (selectedModules == null) return new HttpNotFoundResult();
            Students students = new Students

            {
            StudentID = 1,
            FirstName = "Ibrahim",
            LastName = "Zahid"
            };
            StudentsModulesViewModels viewModel = new StudentsModulesViewModels
            {
                Students = students,
                Modules = selectedModules
            };
            return View(viewModel);
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(_modules);
        }
        // GET: Edit/id
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            Modules selectedModules = _modules.First(p => p.ModuleID == id);
            if (selectedModules == null) return new HttpNotFoundResult();
            return View(selectedModules);
        }
        // POST: Edit
        [HttpPost]
        public ActionResult Edit(Modules modules)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine(modules.ModuleID);
                Debug.WriteLine(modules.ModuleCode);
                Debug.WriteLine(modules.ModuleTitle);
                return RedirectToAction("Index");
            }
            else
            {
                return View(modules);
            }
            
        }
    }
}