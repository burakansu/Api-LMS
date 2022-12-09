using Business.Concrete;
using Business.DataAccess.Abstract;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Class : ControllerBase
    {
        private IClassService _classService;
        public Class()
        {
            _classService = new ClassManager();
        }
        [HttpGet]
        public List<TBL_Classes> All()
        {
            return _classService.GetAllClass();
        }
        [HttpGet("{id}")]
        public TBL_Classes Single(int id)
        {
            return _classService.GetClass(id);
        }
        [HttpGet("{id}")]
        public TBL_Classes ClassStudent(int id)
        {
            return _classService.GetClassStudent(id);
        }
        public void SaveClass(TBL_Classes TBL_Class)
        {

        }
        [HttpGet("{id}")]
        public void DeleteClass(int id)
        {
            _classService.DeleteClass(id);
        }
        public void UpdateClass(TBL_Classes TBL_Classes)
        {

        }
    }
}
