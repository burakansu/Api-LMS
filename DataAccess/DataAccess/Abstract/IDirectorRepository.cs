using Data;

namespace DataAccess.DataAccess.Abstract
{
    public interface IDirectorRepository
    {
        public TBL_Directors GetDirector(int Director_ID);
    }
}
