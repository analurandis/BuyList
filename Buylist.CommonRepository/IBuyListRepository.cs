namespace Buylist.CommonRepository
{
    public interface IBuyListRepository<TEntity, TKey>
    where TEntity : class
    {

        List<TEntity> All();

        TEntity ByKey(TKey key);

        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteByKey(TKey key);


    }
}
