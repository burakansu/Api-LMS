using Data.Model;

namespace DataAccess.DataAccess.Abstract
{
    public interface INoteService
    {
        public List<TBL_Notes> GetNotes(int Student_ID, int Lesson_ID);
        public void UpdateNote(TBL_Notes tBL_Notes);
        public void AddStudentLessonNote(TBL_Notes tBL_Notes);
    }
}
