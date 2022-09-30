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
            return _context.Set<TEntity>().ToList();
        }

        public TEntity ByKey(TKey key)
        {
            return _context.Set<TEntity>().Find(key);
        }

        public void Delete(TEntity entity)
        {
            if(entity != null)
            {
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public void DeleteByKey(TKey key)
        {
            TEntity entity = ByKey(key);
            Delete(entity);
        }

        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}