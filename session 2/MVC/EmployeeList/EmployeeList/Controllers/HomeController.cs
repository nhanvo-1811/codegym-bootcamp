using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeList.Models;

namespace EmployeeList.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeContext _dbContext;

        public HomeController(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var _emplst = _dbContext.tblEmployees.
                            Join(_dbContext.tblSkills, e => e.SkillID, s => s.SkillID,
                            (e, s) => new EmployeeViewModel
                            {
                                EmployeeID = e.EmployeeID,
                                EmployeeName = e.EmployeeName,
                                PhoneNumber = e.PhoneNumber,
                                Skill = s.Title,
                                YearsExperience = e.YearsExperience
                            }).ToList();
            IList<EmployeeViewModel> emplst = _emplst;
            return View(emplst);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //  TempData["Message"] = "Employee has been added successfully.";
            ViewBag.Skills = GetSkills();
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateModel model)
        {
            var employee = new tblEmployee()
            {
                EmployeeID = model.EmployeeID,
                EmployeeName = model.EmployeeName,
                PhoneNumber = model.PhoneNumber,
                SkillID = model.SkillID,
                YearsExperience = model.YearsExperience
            };
            _dbContext.tblEmployees.Add(employee);
            try
            {
                if (_dbContext.SaveChanges() > 0)
                {
                    TempData["Message"] = "Employee has been added successfully.";
                }
                else
                {
                    TempData["Message"] = "Something went wrong, please contact administrator.";
                }
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
            }

            ViewBag.Skills = GetSkills();
            return View(new EmployeeCreateModel());
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _dbContext.tblEmployees.Find(id);
            _dbContext.Remove(employee);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var _emplst = _dbContext.tblEmployees.
                           Join(_dbContext.tblSkills, e => e.SkillID, s => s.SkillID,
                           (e, s) => new EmployeeViewModel
                           {
                               EmployeeID = e.EmployeeID,
                               EmployeeName = e.EmployeeName,
                               PhoneNumber = e.PhoneNumber,
                               Skill = s.Title,
                               YearsExperience = e.YearsExperience
                           }).Where(e => e.EmployeeID == id).FirstOrDefault();
            return View(_emplst);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var _employees = _dbContext.tblEmployees.Where(e => e.EmployeeID == id).FirstOrDefault();
            var employeeEdit = new EmployeeEditModel()
            {
                EmployeeID = _employees.EmployeeID,
                EmployeeName = _employees.EmployeeName, 
                PhoneNumber = _employees.PhoneNumber,
                SkillID = _employees.SkillID,
                YearsExperience = _employees.YearsExperience
            };
            ViewBag.Skills = GetSkills();
            return View(employeeEdit);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeEditModel model)
        {
            var employee = _dbContext.tblEmployees.Find(model.EmployeeID);
            employee.EmployeeName = model.EmployeeName;
            employee.PhoneNumber = model.PhoneNumber;
            employee.SkillID = model.SkillID;
            employee.YearsExperience = model.YearsExperience;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        private List<SkillModel> GetSkills()
        {
            var skills = _dbContext.tblSkills.Select(s => new SkillModel()
            {
                Name = s.Title,
                Value = s.SkillID
            }).ToList();
            return skills;
        }
    }
}
