using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;

namespace DataAccess.DataAccess.Abstract
{
    public interface ILessonService
    {
        public List<TBL_Lessons> GetLessonsStudent(int Student_ID);
        public List<TBL_Lessons> GetClassLessons(int Class_ID);
        public List<TBL_Lessons> GetStudentLessons(int Student_ID);
        public void AddLessonClass(string Lesson_Name, int Class_ID);
        public void AddLessonStudent(TBL_Lessons tBL_Lessons);
        public void DeleteLesson(string lessonad, int classid);
    }
}
