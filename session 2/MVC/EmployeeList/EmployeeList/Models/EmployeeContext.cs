using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeList.Models;

namespace EmployeeList.Models
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<tblSkill> tblSkills { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<EmployeeList.Models.EmployeeViewModel> EmployeeViewModel { get; set; }
        public DbSet<EmployeeList.Models.EmployeeCreateModel> EmployeeCreateModel { get; set; }
        public DbSet<EmployeeList.Models.EmployeeEditModel> EmployeeEditModel { get; set; }
    }
}
