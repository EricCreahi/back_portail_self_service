using WebApi.Interfaces;
using WebApi.Persistences;

namespace WebApi.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbApiContext db;

        public UnitOfWork(DbApiContext db)
        {
            this.db = db;
        }


        public void Complete()
        {
            try
            {
                db.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
