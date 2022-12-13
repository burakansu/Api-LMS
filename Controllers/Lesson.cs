using Business.Concrete;
using Data;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Lesson : ControllerBase
    {
        private ILessonService Service;
        public Lesson()
        {
            Service = new LessonManager();
        }
       // [HttpPost("{name},{cid}")]
        public void AddLessonClass(string name, int cid)
        {
            Service.AddLessonClass(name, cid);
        }
        [HttpPost]
        public void AddLessonStudent([FromBody] TBL_Lessons obj)
        {
            Service.AddLessonStudent(obj);
        }
       // [HttpPost("{Lesson_Name},{cid}")]
        public void DeleteLesson(string Lesson_Name, int cid)
        {
            Service.DeleteLesson(Lesson_Name, cid);
        }
        [HttpGet("GetClassLessons/{cid}")]
        public List<TBL_Lessons> GetClassLessons(int cid)
        {
           return Service.GetClassLessons(cid);
        }
        [HttpGet("GetLessonsStudent/{sid}")]
        public List<TBL_Lessons> GetLessonsStudent(int sid)
        {
           return Service.GetLessonsStudent(sid);
        }
        [HttpGet("GetStudentLessons/{sid}")]
        public List<TBL_Lessons> GetStudentLessons(int sid)
        {
            return Service.GetStudentLessons(sid);
        }
    }
}
