using Data.Model;
using DataAccess.DataAccess.Abstract;

namespace Business.Concrete
{
    public class DirectorManager : IDirectorService
    {
        private IDirectorRepository Repository;
        public DirectorManager()
        {
            Repository = new DirectorRepository();
        }
        public TBL_Directors GetDirector(int Director_ID)
        {
            if (Director_ID > 0)
                return Repository.GetDirector(Director_ID);
            throw new Exception("ID 0 dan büyük olmalı");
        }
    }
}
