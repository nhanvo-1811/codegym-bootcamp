﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeList.Models
{
    public class EmployeeViewModel
    {

        [Key]
        public int EmployeeID { get; set; }

        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        [Display(Name = "Contact Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Your Skill")]
        public string Skill { get; set; }

        [Display(Name = "Years of Experience")]
        public int YearsExperience { get; set; }


    }
}
