using Data;
using Data.Context;
using DataAccess.DataAccess.Abstract;

namespace Business
{
    public class NoteRepository : INoteRepository
    {
        public List<TBL_Notes> GetNotes(int Student_ID, int Lesson_ID)
        {
            using (Context x = new Context())
            {
                return x.Notes.Where(x => x.Student_ID == Student_ID && x.Lesson_ID == Lesson_ID).ToList();
            }
        }
        public void UpdateNote(TBL_Notes tBL_Notes)
        {
            using (Context x = new Context())
            {
                x.Notes.Update(tBL_Notes);
            }
        }
        public void AddStudentLessonNote(TBL_Notes tBL_Notes)
        {
            using (Context x = new Context())
            {
                x.Notes.Add(tBL_Notes);
            }
        }
    }
}
