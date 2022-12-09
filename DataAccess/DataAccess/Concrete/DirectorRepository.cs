using Data;
using Data.Context;
using DataAccess.DataAccess.Abstract;

namespace Business
{
    public class DirectorRepository : IDirectorRepository
    {
        public TBL_Directors GetDirector(int Director_ID)
        {
            using (Context x = new Context())
            {
                return x.Directors.Find(Director_ID);
            }
        }
    }
}
