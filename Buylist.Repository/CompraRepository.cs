using Buylist.Common.Repository.Entity;
using Buylist.Domain;
using Microsoft.EntityFrameworkCore;

namespace Buylist.Repository
{
    public class CompraRepository : BuyListServiceRepository<Compra, int>
    {
        private DbContext _context;
        public CompraRepository(DbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public override List<Compra> All()
        {
            return _context.Set<Compra>().Include(i=> i.Itens).ThenInclude(i=> i.Produto).Include(i=> i.Local).ToList();
        }

        public override Compra ByKey(int key)
        {
            return _context.Set<Compra>().Include(i => i.Itens).ThenInclude(i => i.Produto).Include(i => i.Local).FirstOrDefault(i=> i.Id == key);
        }


    }
}