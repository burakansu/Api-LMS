using Data.Context;
using Data.Model;

namespace DataAccess.DataAccess.Abstract
{
    public interface IStudentService
    {
        public void Add_Student(TBL_Students tBL_Students, string Mail);
        public List<TBL_Students> GetSelectedClassStudents(int Class_ID);
        public TBL_Students GetStudent(int Student_ID);
        public void DeleteStudent(int id);
    }
}
