using Business.Concrete;
using Data;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("api/[controller]")]
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
       // [HttpGet("{Mail},{Password}")]
        public int CheckUser(string Mail, string Password)
        {
            return Service.CheckUser(Mail, Password);
        }
       // [HttpGet("{User_ID},{Password}")]
        public int GetUserType(int User_ID, string Password)
        {
            return Service.GetUserType(User_ID, Password);
        }
        [HttpGet("{User_ID}")]
        public int GetStudentID_Use_UserID(int User_ID)
        {
            return Service.GetStudentID_Use_UserID(User_ID);
        }
        [HttpGet("{User_ID}")]
        public int GetTeacher_ID_Use_UserID(int User_ID)
        {
            return Service.GetTeacher_ID_Use_UserID(User_ID);
        }
        [HttpGet("{User_ID}")]
        public int GetDirector_ID_Use_UserID(int User_ID)
        {
            return Service.GetDirector_ID_Use_UserID(User_ID);
        }
    }
}
