using Data.Context;
using Data.Model;
using DataAccess.DataAccess.Abstract;

namespace Business
{
    public class LessonRepository : ILessonRepository
    {
        public List<TBL_Lessons> GetLessonsStudent(int Student_ID)
        {
            using (Context x = new Context())
            {
                return x.Lessons.Where(x => x.Student_ID == Student_ID).ToList();
            }
        }
        public List<TBL_Lessons> GetClassLessons(int Class_ID)
        {
            using (Context x = new Context())
            {
                return x.Lessons.Where(x => x.Class_ID == Class_ID).Distinct().ToList();
            }
        }
        public List<TBL_Lessons> GetStudentLessons(int Student_ID)
        {
            using (Context x = new Context())
            {
                return x.Lessons.Where(x => x.Student_ID == Student_ID).ToList();
            }
        }
        public void AddLessonClass(string Lesson_Name, int Class_ID)
        {
            using (Context x = new Context())
            {
                foreach (var item in x.Students.Where(x => x.Class_ID == Class_ID).ToList())
                {
                    TBL_Lessons tBL_Lessons = new TBL_Lessons
                    {
                        Name = Lesson_Name,
                        Class_ID = Class_ID,
                        Student_ID = item.Student_ID
                    };
                    x.Lessons.Add(tBL_Lessons);
                    x.SaveChanges();
                }
            }
        }
        public void AddLessonStudent(TBL_Lessons tBL_Lessons)
        {
            using (Context x = new Context())
            {
                x.Add(tBL_Lessons);
                x.SaveChanges();
            }
        }
        public void DeleteLesson(string lessonad, int classid)
        {
            using (Context x = new Context())
            {
                x.Lessons.Remove(x.Lessons.Single(x => x.Class_ID == classid && x.Name == lessonad));
                x.SaveChanges();
            }
        }
    }
}
