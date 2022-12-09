using Data;
using DataAccess.DataAccess.Abstract;

namespace Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private ITeacherRepository Repository;
        public TeacherManager()
        {
            Repository = new TeacherRepository();
        }
        public TBL_Teachers GetTeacher(int Teacher_ID)
        {
            return Repository.GetTeacher(Teacher_ID);
        }
        public TBL_Teachers GetTeacherForClassID(int Class_ID)
        {
            return Repository.GetTeacher(Class_ID);
        }
        public void Add_Teacher(TBL_Teachers tBL_Teachers, string Mail)
        {
            Repository.Add_Teacher(tBL_Teachers,Mail);
        }
        public void Delete_Teacher(int Teacher_ID)
        {
            Repository.Delete_Teacher(Teacher_ID);
        }
    }
}
