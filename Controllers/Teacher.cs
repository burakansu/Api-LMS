using Business.Concrete;
using Data;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Teacher : ControllerBase
    {
        private ITeacherService Service;
        public Teacher()
        {
            Service = new TeacherManager();
        }

        [HttpGet("{Teacher_ID}")]
        public TBL_Teachers GetTeacher(int Teacher_ID)
        {
            return Service.GetTeacher(Teacher_ID);
        }
        [HttpGet("{Class_ID}")]

        public TBL_Teachers GetTeacherForClassID(int Class_ID)
        {
            return Service.GetTeacher(Class_ID);
        }
        [HttpPost]
        public void Add_Teacher(TBL_Teachers tBL_Teachers, string Mail)
        {
            Service.Add_Teacher(tBL_Teachers, Mail);
        }
        [HttpPost]
        public void Delete_Teacher(int Teacher_ID)
        {
            Service.Delete_Teacher(Teacher_ID);
        }
    }
}
