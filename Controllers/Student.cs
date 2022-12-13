using Business.Concrete;
using Data.Model;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Student : ControllerBase
    {
        private IStudentService Service;
        public Student()
        {
            Service = new StudentManager();
        }
        [HttpPost]
        [Route("{Mail}")]
        public void Add_Student(string Mail,[FromBody] TBL_Students obj)
        {
            Service.Add_Student(obj, Mail);
        }
        [HttpGet("GetSelectedClassStudents")]
        [Route("{cid}")]
        public List<TBL_Students> GetSelectedClassStudents(int cid)
        {
            return Service.GetSelectedClassStudents(cid).ToList();
        }
        [HttpGet]
        [Route("{id}")]
        public TBL_Students Get(int id)
        {
            return Service.GetStudent(id);
        }
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Service.DeleteStudent(id);
        }
    }
}
