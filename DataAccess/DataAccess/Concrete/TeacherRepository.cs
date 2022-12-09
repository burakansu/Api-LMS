using Data;
using Data.Context;
using DataAccess.DataAccess.Abstract;

namespace Business
{
    public class TeacherRepository : ITeacherRepository
    {
        public TBL_Teachers GetTeacher(int Teacher_ID)
        {
            using (Context x = new Context())
            {
                return x.Teachers.Find(Teacher_ID);
            }
        }
        public TBL_Teachers GetTeacherForClassID(int Class_ID)
        {
            using (Context x = new Context())
            {
                return x.Teachers.Single(x => x.Class_ID == Class_ID);
            }
        }
        public void Add_Teacher(TBL_Teachers tBL_Teachers, string Mail)
        {
            using (Context x = new Context())
            {
                TBL_Users tBL_Users = new TBL_Users { Type = 1, Password = tBL_Teachers.Name + (x.Teachers.Count() + 1).ToString(), Mail = Mail };
                x.Users.Add(tBL_Users);
                x.SaveChanges();
                tBL_Teachers.User_ID = x.Users.Max(x => x.User_ID);
                x.Teachers.Add(tBL_Teachers);
            }
        }
        public void Delete_Teacher(int Teacher_ID)
        {
            using (Context x = new Context())
            {
                x.Teachers.Remove(x.Teachers.Find(Teacher_ID));
            }
        }
    }
}
