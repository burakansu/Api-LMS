using Business.DataAccess.Abstract;
using Data.Model;

namespace Business.Concrete
{
    public class ClassManager : IClassService
    {
        private IClassRepository Repository;
        public ClassManager()
        {
            Repository= new ClassRepository();
        }
        public TBL_Classes GetClass(int Class_ID)
        {
            if (Class_ID > 0)
                return Repository.GetClass(Class_ID);
            throw new Exception("ID 0 dan büyük olmalı");
            
        }
        public TBL_Classes GetClassStudent(int Student_ID)
        {
            if (Student_ID > 0)
                return Repository.GetClassStudent(Student_ID);
            throw new Exception("ID 0 dan büyük olmalı");
        }
        public List<TBL_Classes> GetAllClass()
        {
                return Repository.GetAllClass();
        }
        public void SaveClass(TBL_Classes TBL_Class)
        {
            Repository.SaveClass(TBL_Class);
        }
        public void DeleteClass(int Class_ID)
        {
            Repository.DeleteClass(Class_ID);
        }
        public void UpdateClass(TBL_Classes TBL_Classes)
        {
            Repository.UpdateClass(TBL_Classes);
        }
    }
}
