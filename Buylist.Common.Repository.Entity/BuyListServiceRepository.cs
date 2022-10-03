using Buylist.CommonRepository;
using Microsoft.EntityFrameworkCore;

namespace Buylist.Common.Repository.Entity
{
    public abstract class BuyListServiceRepository<TEntity, TKey> : IBuyListRepository<TEntity, TKey>
        where TEntity : class
    {

        private readonly DbContext _context;

        public BuyListServiceRepository(DbContext dbContext)
        {
            _context = dbContext;
        }

        public virtual List<TEntity> All()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual TEntity ByKey(TKey key)
        {
            var retorno = _context.Set<TEntity>().Find(key);
            return retorno;


        }

        public virtual void Delete(TEntity entity)
        {
            if(entity != null)
            {
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
    
            }
        }

        public virtual void DeleteByKey(TKey key)
        {
            TEntity entity = ByKey(key);
            Delete(entity);
            
        }

        public virtual void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

        }

        public virtual void Update(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public virtual void Dispose()
        {
            _context.Dispose();
        }

    }
}