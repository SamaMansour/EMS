using EMS_project.Data;
using EMS_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMS_project.Controllers
{
    public class DepartmentsController : Controller

        
    {

        private readonly VacationDbContext _context;

        public DepartmentsController(VacationDbContext context)
        {
            _context = context;
        }
        public IActionResult Departments()
        {
            return View(_context.Departments.OrderBy(x=>x.Name).ToList());
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Department model)
        {

            if (ModelState.IsValid)
            {
                _context.Departments.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Departments");
            }
            return View();
        }

        //GET EDIT
        public IActionResult Edit(int? Id)
        {

            if (Id != null)
            {
                var result = _context.Departments.FirstOrDefault(x => x.Id == Id);
            }
            return View();
        }

        //POST EDIT 
        public IActionResult Edit (Department model )
        {

            if (ModelState.IsValid)
            {
                _context.Departments.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Departments");
            }


            return View();
        }



        //GET EDIT
        public IActionResult Delete(int? Id)
        {

            if (Id != null)
            {
                var result = _context.Departments.FirstOrDefault(x => x.Id == Id);
            }
            return View();
        }

        //POST EDIT 
        public IActionResult Delete(Department model)
        {

            if (model != null)
            {
                _context.Departments.Remove(model);
                _context.SaveChanges();
                return RedirectToAction("Departments");
            }


            return View();
        }



    }
}
