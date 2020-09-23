using CrudFinalASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CrudFinalASP.NET.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly CrudContext _context = new CrudContext();

        // GET: Employees
        public ActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var employee = _context.Employees.SingleOrDefault(e=>e.EmployeeId == id);
            if (employee==null)
            {
                return HttpNotFound(); 
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            
                return View(employee);
            
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id== null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var employee = _context.Employees.SingleOrDefault(e => e.EmployeeId == id);
             if (employee == null)
            {
                return HttpNotFound(); 
            }

            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid) 
            {
                _context.Entry(employee).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            
                return View(employee);
           
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id ==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
            }
            var employee = _context.Employees.SingleOrDefault(e => e.EmployeeId == id);
            if (employee==null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var employee = _context.Employees.SingleOrDefault(x => x.EmployeeId == id);
            _context.Employees.Remove(employee ?? throw new InvalidOperationException());
            _context.SaveChanges();
            return View(employee);
           
        }
    }
}
