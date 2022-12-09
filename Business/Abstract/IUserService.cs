using Data.Context;
using Data;

namespace DataAccess.DataAccess.Abstract
{
    public interface IUserService
    {
        public List<TBL_Users> GetUsers();
        public int CheckUser(string Mail, string Password);
        public int GetUserType(int User_ID, string Password);
        public int GetStudentID_Use_UserID(int User_ID);
        public int GetTeacher_ID_Use_UserID(int User_ID);
        public int GetDirector_ID_Use_UserID(int User_ID);
    }
}
