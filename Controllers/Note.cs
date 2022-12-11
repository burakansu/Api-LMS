﻿using Business.Concrete;
using Data;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Note : ControllerBase
    {
        private INoteService Service;
        public Note()
        {
            Service = new NoteManager();
        }
       // [HttpGet("{sid},{id}")]
        public List<TBL_Notes> GetNotes(int sid, int id)
        {
            return Service.GetNotes(sid, id);
        }
        [HttpPost]
        public void UpdateNote(TBL_Notes obj)
        {
            Service.UpdateNote(obj);
        }
        [HttpPost]
        public void AddStudentLessonNote(TBL_Notes obj)
        {
            Service.AddStudentLessonNote(obj);
        }
    }
}
