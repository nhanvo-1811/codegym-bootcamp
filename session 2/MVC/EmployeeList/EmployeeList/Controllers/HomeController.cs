using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeList.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace EmployeeList.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeContext _dbContext;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(EmployeeContext dbContext, IHostingEnvironment hostingEnvironment)
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
                                YearsExperience = e.YearsExperience,
                                img = e.img

                            }).ToList();
            IList<EmployeeViewModel> emplst = _emplst;
            return View(emplst);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //TempData["Errors"] = "Employee has been added successfully.";
            ViewBag.Skills = GetSkills();
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                var employee = new tblEmployee()
                {
                    EmployeeID = model.EmployeeID,
                    EmployeeName = model.EmployeeName,
                    PhoneNumber = model.PhoneNumber,
                    SkillID = model.SkillID,
                    YearsExperience = model.YearsExperience,
                    img = uniqueFileName
                };
                _dbContext.tblEmployees.Add(employee);
                try
                {
                    if (_dbContext.SaveChanges() > 0)
                    {
                        TempData["Message"] = model.EmployeeName + "added successfully.";
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

                ViewBag.Skills = GetSkills();
                return RedirectToAction("Details", new { id = employee.EmployeeID });
            }
            return View();

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
