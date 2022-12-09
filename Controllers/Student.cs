using Business.Concrete;
using Data;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Student : ControllerBase
    {
        private IStudentService Service;
        public Student()
        {
            Service = new StudentManager();
        }
        [HttpPost]
        public void Add_Student(TBL_Students tBL_Students, string Mail)
        {
            Service.Add_Student(tBL_Students, Mail);
        }
        [HttpGet("{Class_ID}")]
        public List<TBL_Students> GetSelectedClassStudents(int Class_ID)
        {
            return Service.GetSelectedClassStudents(Class_ID).ToList();
        }
        [HttpGet("{Student_ID}")]
        public TBL_Students GetStudent(int Student_ID)
        {
            return Service.GetStudent(Student_ID);
        }
        [HttpGet("{id}")]
        public void DeleteStudent(int id)
        {
            Service.DeleteStudent(id);
        }
    }
}
