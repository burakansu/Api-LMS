using Business.Concrete;
using Business.DataAccess.Abstract;
using Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("[controller]")]
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
        [HttpGet]
        [Route("{id}")]
        public TBL_Classes Get(int id)
        {
            return Service.GetClass(id);
        }
        [HttpGet("ClassStudent")]
        [Route("{id}")]
        public TBL_Classes ClassStudent(int id)
        {
            return Service.GetClassStudent(id);
        }
        [HttpPost]
        public void Post([FromBody]TBL_Classes obj)
        {
            Service.SaveClass(obj);
        }
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Service.DeleteClass(id);
        }
        [HttpPut]
        public void Put([FromBody] TBL_Classes obj)
        {
            Service.UpdateClass(obj);
        }
    }
}
