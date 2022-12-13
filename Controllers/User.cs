using Business.Concrete;
using Data;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class User : ControllerBase
    {
        private IUserService Service;
        public User()
        {
            Service = new UserManager();
        }

        [HttpGet]
        public List<TBL_Users> GetUsers()
        {
            return Service.GetUsers();
        }
        [HttpGet("CheckUser/{Mail}-{Password}")]
        public int CheckUser(string Mail, string Password)
        {
            return Service.CheckUser(Mail, Password);
        }
         [HttpGet("GetUserType/{id}-{Password}")]
        public int GetUserType(int id, string Password)
        {
            return Service.GetUserType(id, Password);
        }
        [HttpGet("GetStudentID_Use_UserID/{id}")]
        public int GetStudentID_Use_UserID(int id)
        {
            return Service.GetStudentID_Use_UserID(id);
        }
        [HttpGet("GetTeacher_ID_Use_UserID/{id}")]
        public int GetTeacher_ID_Use_UserID(int id)
        {
            return Service.GetTeacher_ID_Use_UserID(id);
        }
        [HttpGet("GetDirector_ID_Use_UserID/{id}")]
        public int GetDirector_ID_Use_UserID(int id)
        {
            return Service.GetDirector_ID_Use_UserID(id);
        }
    }
}
