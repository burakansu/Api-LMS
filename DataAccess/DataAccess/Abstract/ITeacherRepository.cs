using Data;

namespace DataAccess.DataAccess.Abstract
{
    public interface ITeacherRepository
    {
        public TBL_Teachers GetTeacher(int Teacher_ID);
        public TBL_Teachers GetTeacherForClassID(int Class_ID);
        public void Add_Teacher(TBL_Teachers tBL_Teachers, string Mail);
        public void Delete_Teacher(int Teacher_ID);
    }
}
