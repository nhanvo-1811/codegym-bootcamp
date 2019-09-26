using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeFirst.Models;
using CodeFirst.Context;

namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext _dbContext;

        public HomeController(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var _employ = _dbContext.Employees.Select(em => new EmployeeViewModel
            {
                EmployeeId = em.EmployeeId,
                Name = em.Name,
                Address = em.Address,
                CompanyName = em.CompanyName,
                Designation = em.Designation,
                Salary = em.Salary

            }).ToList();
            //IList<EmployeeViewModel> emplst = _employ;
            return View(_employ);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateModel model)
        {
            var employee = new Employee()
            {
                EmployeeId = model.EmployeeId,
                Name = model.Name,
                Address = model.Address,
                CompanyName = model.CompanyName,
                Designation = model.Designation,
                Salary = model.Salary
            };
            _dbContext.Employees.Add(employee);
            try
            {
                if (_dbContext.SaveChanges() > 0)
                {
                    TempData["Message"] = model.Name + "added successfully.";
                }
                else
                {
                    TempData["Errors"] = "Something went wrong, please contact administrator.";
                }
            }
            catch (Exception ex)
            {
                TempData["Errors"] = ex.Message;
            }
            return RedirectToAction("Create");
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            var employee = _dbContext.Employees.Find(id);
            _dbContext.Remove(employee);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Details(int id)
        {
            var _employ = _dbContext.Employees.Select(em => new EmployeeViewModel
            {
                EmployeeId = em.EmployeeId,
                Name = em.Name,
                Address = em.Address,
                CompanyName = em.CompanyName,
                Designation = em.Designation,
                Salary = em.Salary

            }).Where(e => e.EmployeeId == id).FirstOrDefault(); 
            return View(_employ);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var _employees = _dbContext.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            var employeeEdit = new EmployeeEditModel()
            {
                EmployeeId = _employees.EmployeeId,
                Name = _employees.Name,
                Address = _employees.Address,
                CompanyName = _employees.CompanyName,
                Designation = _employees.Designation,
                Salary = _employees.Salary
            };
            return View(employeeEdit);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeEditModel model)
        {
            var employee = _dbContext.Employees.Find(model.EmployeeId);
            employee.Name = model.Name;
            employee.Address = model.Address;
            employee.CompanyName = model.CompanyName;
            employee.Designation = model.Designation;
            employee.Salary = model.Salary;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
