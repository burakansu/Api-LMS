using Business.Concrete;
using Business.DataAccess.Abstract;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Class : ControllerBase
    {
        private IClassService Service;
        public Class()
        {
            Service = new ClassManager();
        }

        [HttpGet]
        public List<TBL_Classes> Get()
        {
            return Service.GetAllClass();
        }
        [HttpGet("{id}")]
        public TBL_Classes Get(int id)
        {
            return Service.GetClass(id);
        }
        [HttpGet("{id}")]
        public TBL_Classes ClassStudent(int id)
        {
            return Service.GetClassStudent(id);
        }
        [HttpPost]
        public void Post(TBL_Classes obj)
        {
            Service.SaveClass(obj);
        }
        [HttpGet("{id}")]
        public void Delete(int id)
        {
            Service.DeleteClass(id);
        }
        [HttpPost]
        public void Put(TBL_Classes obj)
        {
            Service.UpdateClass(obj);
        }
    }
}
