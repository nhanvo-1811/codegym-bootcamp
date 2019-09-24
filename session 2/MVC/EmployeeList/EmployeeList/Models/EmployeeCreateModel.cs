using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace EmployeeList.Models
{
    public class EmployeeCreateModel
    {
        [Key]

        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên nhân viên")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Bạn phải nhập lớn hơn 4 kí tự")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Bạn phải số điện thoại")]
        [RegularExpression(pattern: "(09|01[2689]){1}([0-9]{8})", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string PhoneNumber { get; set; }

        public int SkillID { get; set; }

        [Required(ErrorMessage = "Bạn phải số năm kinh nghiệm")]
        [Range(minimum: 0, maximum: 50, ErrorMessage = "Bạn phải nhập năm kinh nghiệm từ 0 đến 50")]
        public int YearsExperience { get; set; }

        public IFormFile Photo { get; set; }


    }
}
