using Data.Context;
using Data.Model;
using DataAccess.DataAccess.Abstract;
using System.Data;

namespace Business
{
    public class StudentRepository : IStudentRepository
    {
        public void Add_Student(TBL_Students tBL_Students,string Mail)
        {
            using (Context x = new Context())
            {
                TBL_Users tBL_Users = new TBL_Users { Type = 0, Password = tBL_Students.Name + (x.Students.Count() + 1).ToString(), Mail = Mail };
                x.Users.Add(tBL_Users);
                x.SaveChanges();
                tBL_Students.User_ID = x.Users.Max(x => x.User_ID);
                x.Students.Add(tBL_Students);
                x.SaveChanges();
                foreach (var item in x.Lessons.Where(x => x.Class_ID == tBL_Students.Class_ID).ToList()) 
                {
                    TBL_Lessons tBL_Lessons = new TBL_Lessons { Name = item.Name, Class_ID = tBL_Students.Class_ID, Student_ID = x.Students.Max(x => x.Student_ID) };
                    x.Lessons.Add(tBL_Lessons);
                }
                x.SaveChanges();
            }
        }
        public List<TBL_Students> GetSelectedClassStudents(int Class_ID)
        {
            using (Context x = new Context())
            {
                return x.Students.Where(x => x.Class_ID == Class_ID).ToList();
            }
        }
        public TBL_Students GetStudent(int Student_ID)
        {
            using (Context x = new Context())
            {
                return x.Students.Find(Student_ID);
            }
        }
        public void DeleteStudent(int id)
        {
            using (Context x = new Context())
            {
                x.Students.Remove(x.Students.Find(id));
                x.SaveChanges();
            }
        }
    }
}
