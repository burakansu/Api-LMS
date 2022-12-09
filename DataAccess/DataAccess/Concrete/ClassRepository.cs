using Business.DataAccess.Abstract;
using Data;
using Data.Context;

namespace Business
{
    public class ClassRepository : IClassRepository
    {
        public TBL_Classes GetClass(int Class_ID)
        {
            using (Context x = new Context())
            {
                return x.Classes.Find(Class_ID);
            }
        }
        public TBL_Classes GetClassStudent(int Student_ID)
        {
            using (Context x = new Context())
            {
                var Class_ID = x.Students.Find(Student_ID).Class_ID;
                return x.Classes.Single(x => x.Class_ID == Class_ID);
            }
        }
        public List<TBL_Classes> GetAllClass()
        {
            using (Context x = new Context())
            {
                return x.Classes.ToList();
            }
        }
        public void SaveClass(TBL_Classes TBL_Class)
        {
            using (Context x = new Context())
            {
                x.Classes.Add(TBL_Class);
                x.SaveChanges();
            }
        }
        public void DeleteClass(int Class_ID)
        {
            using (Context x = new Context())
            {
                x.Classes.Remove(x.Classes.Single(x => x.Class_ID == Class_ID));
                x.Students.Remove(x.Students.Single(x => x.Class_ID == Class_ID));
                x.Teachers.Remove(x.Teachers.Single(x => x.Class_ID == Class_ID));
                x.SaveChanges();
            }
        }
        public void UpdateClass(TBL_Classes TBL_Classes)
        {
            using (Context x = new Context())
            {
                x.Classes.Update(TBL_Classes);
                x.SaveChanges();
            }
        }
    }
}
