using Business.Concrete;
using Data;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lesson : ControllerBase
    {
        private ILessonService Service;
        public Lesson()
        {
            Service = new LessonManager();
        }
        [HttpPost("{Lesson_Name},{Class_ID}")]
        public void AddLessonClass(string Lesson_Name, int Class_ID)
        {
            Service.AddLessonClass(Lesson_Name, Class_ID);
        }
        [HttpPost]
        public void AddLessonStudent(TBL_Lessons tBL_Lessons)
        {
            Service.AddLessonStudent(tBL_Lessons);
        }
        [HttpPost("{Lesson_Name},{Class_ID}")]
        public void DeleteLesson(string Lesson_Name, int Class_ID)
        {
            Service.DeleteLesson(Lesson_Name, Class_ID);
        }
        [HttpGet("{Class_ID}")]
        public List<TBL_Lessons> GetClassLessons(int Class_ID)
        {
           return Service.GetClassLessons(Class_ID);
        }
        [HttpGet("{Student_ID}")]
        public List<TBL_Lessons> GetLessonsStudent(int Student_ID)
        {
           return Service.GetLessonsStudent(Student_ID);
        }
        [HttpGet("{Student_ID}")]
        public List<TBL_Lessons> GetStudentLessons(int Student_ID)
        {
            return Service.GetStudentLessons(Student_ID);
        }
    }
}
