using Data;
using DataAccess.DataAccess.Abstract;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentRepository Repository;
        public StudentManager()
        {
            Repository = new StudentRepository();
        }
        public void Add_Student(TBL_Students tBL_Students, string Mail)
        {
            Repository.Add_Student(tBL_Students, Mail);
        }
        public List<TBL_Students> GetSelectedClassStudents(int Class_ID)
        {
           return Repository.GetSelectedClassStudents(Class_ID).ToList();
        }
        public TBL_Students GetStudent(int Student_ID)
        {
            return Repository.GetStudent(Student_ID);
        }
        public void DeleteStudent(int id)
        {
            Repository.DeleteStudent(id);
        }
    }
}
