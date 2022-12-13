using Data.Model;
using DataAccess.DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository Repository;
        public UserManager()
        {
            Repository = new UserRepository();
        }
        public List<TBL_Users> GetUsers()
        {
            return Repository.GetUsers();
        }
        public int CheckUser(string Mail, string Password)
        {
            return Repository.CheckUser(Mail, Password);
        }
        public int GetUserType(int User_ID, string Password)
        {
            return Repository.GetUserType(User_ID, Password);
        }
        public int GetStudentID_Use_UserID(int User_ID)
        {
            return Repository.GetStudentID_Use_UserID(User_ID);
        }
        public int GetTeacher_ID_Use_UserID(int User_ID)
        {
            return Repository.GetTeacher_ID_Use_UserID(User_ID);
        }
        public int GetDirector_ID_Use_UserID(int User_ID)
        {
            return Repository.GetDirector_ID_Use_UserID(User_ID);
        }
    }
}
