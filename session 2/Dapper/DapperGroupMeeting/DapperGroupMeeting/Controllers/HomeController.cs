using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DapperGroupMeeting.Models;
using DapperGroupMeeting.DAL;
using Dapper;

namespace DapperGroupMeeting.Controllers
{
    public class HomeController : Controller
    {
        private readonly GroupMeetingService groupMeeting = new GroupMeetingService();
        public IActionResult Index()
        {
            var Gmeeting = groupMeeting.GetGroupMeetings();
            var data = Gmeeting.Select(s => new GroupMeetingView()
            {
                Id = s.Id,
                ProjectName = s.ProjectName,
                Description = s.Description,
                GroupMeetingDate = s.GroupMeetingDate.ToString("ddd dd/MM/yyyy"),
                GLeadName = s.GroupMeetingLeadName,
                TLeadName = s.TeamLeadName
            }).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(GroupMeetingCreate groupMeetingCreate)
        {

            if (ModelState.IsValid)
            {
                var GMeeting = new GroupMeeting()
                {
                    ProjectName = groupMeetingCreate.ProjectName,
                    Description = groupMeetingCreate.Description,
                    GroupMeetingDate = groupMeetingCreate.GroupMeetingDate,
                    GroupMeetingLeadName = groupMeetingCreate.GLeadName,
                    TeamLeadName = groupMeetingCreate.TLeadName
                };
                try
                {
                    if (groupMeeting.AddGroupMeeting(GMeeting) > 0)
                    {
                        TempData["Message"] = groupMeetingCreate.ProjectName + "added successfully.";
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
            }
            return View();
        }
        [HttpGet]
        public IActionResult EditMeeting(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            GroupMeeting group = groupMeeting.GetGroupMeetingById(id);
            var groupEdit = new GroupMeetingEdit() 
            {
                Id = group.Id,
                ProjectName = group.ProjectName,
                Description = group.Description,
                GroupMeetingDate = group.GroupMeetingDate,
                GroupMeetingLeadName = group.GroupMeetingLeadName,
                TeamLeadName = group.TeamLeadName
            };
            if (groupEdit == null)
                return NotFound();
            return View(groupEdit);
        }

        [HttpPost]
        public IActionResult EditMeeting(int id, [Bind] GroupMeetingEdit groupMeting)
        {
            
            if (id != groupMeting.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                groupMeeting.UpdateGroupMeeting(groupMeting);
                return RedirectToAction("Index");
            }
            return View(groupMeting);
        }


        public IActionResult DeleteMeeting(int id)
        {
            GroupMeeting group = groupMeeting.GetGroupMeetingById(id);
            if (group == null)
            {
                return NotFound();
            }
            return View(group);
        }
        [HttpPost]
        public IActionResult DeleteMeeting(int id, GroupMeeting groupMeting)
        {
            if (groupMeeting.DeleteGroupMeeting(id) > 0)
            {
                return RedirectToAction("Index");
            };
            return View(groupMeeting);
        }

    }


}
