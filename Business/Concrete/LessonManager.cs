using Data;
using DataAccess.DataAccess.Abstract;

namespace Business.Concrete
{
    public class LessonManager : ILessonService
    {
        private ILessonRepository Repository;
        public LessonManager()
        {
            Repository = new LessonRepository();
        }
        public void AddLessonClass(string Lesson_Name, int Class_ID)
        {
            Repository.AddLessonClass(Lesson_Name, Class_ID);
        }
        public void AddLessonStudent(TBL_Lessons tBL_Lessons)
        {
            Repository.AddLessonStudent(tBL_Lessons);
        }
        public void DeleteLesson(string lessonad, int classid)
        {
            Repository.DeleteLesson(lessonad, classid);
        }
        public List<TBL_Lessons> GetClassLessons(int Class_ID)
        {
            return Repository.GetClassLessons(Class_ID);
        }
        public List<TBL_Lessons> GetLessonsStudent(int Student_ID)
        {
            return Repository.GetClassLessons(Student_ID);
        }
        public List<TBL_Lessons> GetStudentLessons(int Student_ID)
        {
            return Repository.GetStudentLessons(Student_ID);
        }
    }
}
