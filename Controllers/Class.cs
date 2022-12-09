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
        public List<TBL_Classes> All()
        {
            return Service.GetAllClass();
        }
        [HttpGet("{id}")]
        public TBL_Classes Single(int id)
        {
            return Service.GetClass(id);
        }
        [HttpGet("{id}")]
        public TBL_Classes ClassStudent(int id)
        {
            return Service.GetClassStudent(id);
        }
        [HttpPost]
        public void SaveClass(TBL_Classes TBL_Class)
        {
            Service.SaveClass(TBL_Class);
        }
        [HttpGet("{id}")]
        public void DeleteClass(int id)
        {
            Service.DeleteClass(id);
        }
        [HttpPost]
        public void UpdateClass(TBL_Classes TBL_Classes)
        {
            Service.UpdateClass(TBL_Classes);
        }
    }
}
