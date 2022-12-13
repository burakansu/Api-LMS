using Business.Concrete;
using Data.Model;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Director : ControllerBase
    {
        private IDirectorService Service;
        public Director()
        {
            Service = new DirectorManager();
        }

        [HttpGet]
        [Route("{id}")]
        public TBL_Directors Get(int id)
        {
            return Service.GetDirector(id);
        }
    }
}
