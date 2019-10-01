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
        private readonly RoomService roomService = new RoomService();

        public IActionResult Index()
        {
            var rooms = roomService.GetRooms();
            var _gmeetings = groupMeeting.GetGroupMeetings().
                Join(rooms, gr => gr.RoomID, r => r.RoomID,
                (gr, r) => new GroupMeetingView()
                //var groupMeetings = groupMeeting.GetGroupMeetings().Select(s => new GroupMeetingView()
                {
                    Id = gr.Id,
                    ProjectName = gr.ProjectName,
                    GLeadName = gr.GLeadName,
                    TLeadName = gr.TLeadName,
                    Description = gr.Description,
                    GroupMeetingDate = gr.GroupMeetingDate.ToString("ddd dd/MM/yyyy"),
                    // RoomId = s.RoomId,
                    // RoomName = rooms.Where(r => r.RoomId == s.RoomId).FirstOrDefault().RoomName
                    RoomName = r.RoomName
                }).ToList();
            IList<GroupMeetingView> gmeetings = _gmeetings;
            return View(gmeetings);
            // return View(groupMeeting.GetGroupMeetings().Select(s=>new GroupMeetingView() { GroupMeetingDate = s.GroupMeetingDate.ToString("ddd dd/MM/yyyy")}));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Rooms = GetRooms();
            return View();
        }

        [HttpPost]
        public IActionResult Create(GroupMeetingCreate GMCreate)
        {

            if (ModelState.IsValid)
            {
                var gMeeting = groupMeeting.AddGroupMeeting(new GroupMeeting()
                {
                    ProjectName = GMCreate.ProjectName,
                    Description = GMCreate.Description,
                    GroupMeetingDate = GMCreate.GroupMeetingDate,
                    GLeadName = GMCreate.GLeadName,
                    TLeadName = GMCreate.TLeadName,
                    RoomID = GMCreate.RoomID

                });
                try
                {
                    if (gMeeting > 0)
                    {
                        TempData["Message"] = GMCreate.ProjectName + "added successfully.";
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
            ModelState.Clear();
            ViewBag.Rooms = GetRooms();
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var group = groupMeeting.GetGroupMeetingById(id);

            if (group == null)
                return NotFound();
            ViewBag.Rooms = GetRooms();
            return View(group);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind] GroupMeeting groupMeting)
        {

            if (id != groupMeting.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                groupMeeting.UpdateGroupMeeting(groupMeting);
                return RedirectToAction("Index");
            }
            ViewBag.Rooms = GetRooms();
            return View(groupMeting);
        }

        public IActionResult Details(int id)
        {
            var group = groupMeeting.GetGroupMeetingById(id);
            if (group == null)
            {
                return NotFound();
            }
            return View(group);
        }

        public IActionResult Delete(int id)
        {
            #region parse sang GroupMeetingView
            //var rooms = roomService.GetRooms();
            //var _gmeetings = groupMeeting.GetGroupMeetingById(id);
            //Join(rooms, gr => gr.RoomID, r => r.RoomID,
            //(gr, r) => new GroupMeetingView()
            //{
            //    Id = gr.Id,
            //    ProjectName = gr.ProjectName,
            //    GLeadName = gr.GroupMeetingLeadName,
            //    TLeadName = gr.TeamLeadName,
            //    Description = gr.Description,
            //    GroupMeetingDate = gr.GroupMeetingDate.ToString("ddd dd/MM/yyyy"),
            //    RoomName = r.RoomName
            //});
            #endregion
            var group = groupMeeting.GetGroupMeetingById(id);
            if (group == null)
            {
                return NotFound();
            }
            return View(group);
        }

        [HttpPost]
        public IActionResult Delete(int id, GroupMeeting groupMeting)
        {
            if (groupMeeting.DeleteGroupMeeting(id) > 0)
            {
                return RedirectToAction("Index");
            };
            return View(groupMeting);
        }

        private List<RoomView> GetRooms()
        {
            var data = roomService.GetRooms().Select(r => new RoomView
            {
                Name = r.RoomName,
                Value = r.RoomID
            }).ToList();
            return data;
        }

    }



}
