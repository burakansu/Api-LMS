using Data;

namespace Business.DataAccess.Abstract
{
    public interface IClassService
    {
        public TBL_Classes GetClass(int Class_ID);
        public TBL_Classes GetClassStudent(int Student_ID);
        public List<TBL_Classes> GetAllClass();
        public void SaveClass(TBL_Classes TBL_Class);
        public void DeleteClass(int Class_ID);
        public void UpdateClass(TBL_Classes TBL_Classes);
    }
}
