using Buylist.CommonRepository;
using Microsoft.EntityFrameworkCore;

namespace Buylist.Common.Repository.Entity
{
    public abstract class BuyListRepository<TEntity, TKey> : IBuyListRepository<TEntity, TKey>
        where TEntity : class
    {

        private DbContext _context;

        public BuyListRepository(DbContext dbContext)
        {
            _context = dbContext;
        }

        public List<TEntity> All()
        {
            throw new NotImplementedException();
        }

        public TEntity ByKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteByKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}