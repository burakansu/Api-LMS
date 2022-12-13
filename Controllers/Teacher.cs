using Business.Concrete;
using Data;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Teacher : ControllerBase
    {
        private ITeacherService Service;
        public Teacher()
        {
            Service = new TeacherManager();
        }

        [HttpGet("Get/{id}")]
        public TBL_Teachers GetTeacher(int id)
        {
            return Service.GetTeacher(id);
        }
        [HttpGet("GetTeacherForClassID/{cid}")]
        public TBL_Teachers GetTeacherForClassID(int cid)
        {
            return Service.GetTeacher(cid);
        }
        [HttpPost]
        public void Add_Teacher([FromBody] TBL_Teachers obj, string Mail)
        {
            Service.Add_Teacher(obj, Mail);
        }
        [HttpDelete("Delete/{id}")]
        public void Delete_Teacher(int id)
        {
            Service.Delete_Teacher(id);
        }
    }
}
