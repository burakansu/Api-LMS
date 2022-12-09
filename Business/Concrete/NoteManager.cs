using Data;
using Data.Context;
using DataAccess.DataAccess.Abstract;

namespace Business.Concrete
{
    public class NoteManager : INoteService
    {
        private INoteRepository Repository;
        public NoteManager()
        {
            Repository = new NoteRepository();
        }
        public List<TBL_Notes> GetNotes(int Student_ID, int Lesson_ID)
        {
            return Repository.GetNotes(Student_ID, Lesson_ID);
        }
        public void UpdateNote(TBL_Notes tBL_Notes)
        {
            Repository.UpdateNote(tBL_Notes);
        }
        public void AddStudentLessonNote(TBL_Notes tBL_Notes)
        {
            Repository.AddStudentLessonNote(tBL_Notes);
        }
    }
}
