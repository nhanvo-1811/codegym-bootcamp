using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperGroupMeeting.Models
{
    public class GroupMeetingView
    {
        [Key]
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public string GLeadName { get; set; }

        public string TLeadName { get; set; }

        public string Description { get; set; }

        public string GroupMeetingDate { get; set; }

        public string RoomName { get; set; }
       // public int RoomID { get; set; }
    }
}
