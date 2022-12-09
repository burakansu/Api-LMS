using Data;
using Data.Context;
using DataAccess.DataAccess.Abstract;

namespace Business
{
    public class UserRepository : IUserRepository
    {
        public List<TBL_Users> GetUsers()
        {
            using (Context x = new Context())
            {
                x.Database.EnsureCreated();
                return x.Users.ToList();
            }
        }
        public int CheckUser(string Mail, string Password)
        {
            using (Context x = new Context())
            {
                var res = x.Users.SingleOrDefault(x => x.Mail == Mail && x.Password == Password).User_ID;
                if (res != null)
                    return res;
                return 0;
            }
        }
        public int GetUserType(int User_ID, string Password)
        {
            using (Context x = new Context())
            {
                var res = x.Users.SingleOrDefault(x => x.User_ID == User_ID && x.Password == Password).Type;
                if (res != null)
                    return res;
                return 0;
            }
        }
        public int GetStudentID_Use_UserID(int User_ID)
        {
            using (Context x = new Context())
            {
                var res = x.Students.SingleOrDefault(x => x.User_ID == User_ID).Student_ID;
                if (res != null)
                    return res;
                return 0;
            }
        }
        public int GetTeacher_ID_Use_UserID(int User_ID)
        {
            using (Context x = new Context())
            {
                var res = x.Teachers.SingleOrDefault(x => x.User_ID == User_ID).Teacher_ID;
                if (res != null)
                    return res;
                return 0;
            }
        }
        public int GetDirector_ID_Use_UserID(int User_ID)
        {
            using (Context x = new Context())
            {
                var res = x.Directors.SingleOrDefault(x => x.User_ID == User_ID).Director_ID;
                if (res != null)
                    return res;
                return 0;
            }
        }
    }
}
