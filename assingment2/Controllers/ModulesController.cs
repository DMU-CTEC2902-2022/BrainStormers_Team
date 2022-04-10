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
         ModuleCode = "IPhone 6",
         ModuleTitle = "White",
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
            FirstName = "Bob",
            LastName = "Fossil"
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