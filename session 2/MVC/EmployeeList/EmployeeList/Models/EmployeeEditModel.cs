using System.ComponentModel.DataAnnotations;

namespace EmployeeList.Models
{
    public class EmployeeEditModel
    {
        [Key]
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string PhoneNumber { get; set; }

        public int SkillID { get; set; }

        public int YearsExperience { get; set; }
    }
}
