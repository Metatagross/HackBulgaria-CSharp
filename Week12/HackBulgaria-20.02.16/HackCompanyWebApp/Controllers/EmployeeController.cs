using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackCompanyWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        HackCompanyEntities db = new HackCompanyEntities();
        // GET: Employee
        public ActionResult Index()
        {
            return View(db.Employee.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View(db.Employee.ToList()[id]);
        }

        // GET: Employee/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Employee.Add(employee);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View(employee);
            }
        }

        // GET: Employee/Edit/5
        [HttpGet]
        public ActionResult Edit(int id=0)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
