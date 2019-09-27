using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace DapperGroupMeeting.Models
{
    public class GroupMeetingCreate
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Project Name!")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Enter Group Lead Name!")]
        public string GLeadName { get; set; }

        [Required(ErrorMessage = "Enter Team Lead Name!")]
        public string TLeadName { get; set; }

        [Required(ErrorMessage = "Enter Description!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter Group Meeting Date!")]
        public DateTime GroupMeetingDate { get; set; }
    }
}
