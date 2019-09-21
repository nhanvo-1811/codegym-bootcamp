using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeListEFDbFist.Models;

namespace EmployeeListEFDbFist.Controllers
{

    public class HomeController : Controller
    {
        private readonly EmployeeContext _dbcontext;
        public HomeController(EmployeeContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public IActionResult Index()
        {
            var _emplst = _dbcontext.tblEmployees.
                            Join(_dbcontext.tblSkills, e => e.SkillID, s => s.SkillID,
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

    }

}