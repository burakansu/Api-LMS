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
        public void Add_Student(TBL_Students obj, string Mail)
        {
            Service.Add_Student(obj, Mail);
        }
        [HttpGet("{cid}")]
        public List<TBL_Students> GetSelectedClassStudents(int cid)
        {
            return Service.GetSelectedClassStudents(cid).ToList();
        }
        [HttpGet("{id}")]
        public TBL_Students GetStudent(int id)
        {
            return Service.GetStudent(id);
        }
        [HttpGet("{id}")]
        public void DeleteStudent(int id)
        {
            Service.DeleteStudent(id);
        }
    }
}
