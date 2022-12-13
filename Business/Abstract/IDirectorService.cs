using Data.Model;

namespace DataAccess.DataAccess.Abstract
{
    public interface IDirectorService
    {
        public TBL_Directors GetDirector(int Director_ID);
    }
}
