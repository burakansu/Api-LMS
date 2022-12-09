using Business.Concrete;
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
        [HttpGet("{Student_ID},{Lesson_ID}")]
        public List<TBL_Notes> GetNotes(int Student_ID, int Lesson_ID)
        {
            return Service.GetNotes(Student_ID, Lesson_ID);
        }
        [HttpPost]
        public void UpdateNote(TBL_Notes tBL_Notes)
        {
            Service.UpdateNote(tBL_Notes);
        }
        [HttpPost]
        public void AddStudentLessonNote(TBL_Notes tBL_Notes)
        {
            Service.AddStudentLessonNote(tBL_Notes);
        }
    }
}
