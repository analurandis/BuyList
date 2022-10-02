using Buylist.Common.Repository.Entity;
using Buylist.Domain;
using Microsoft.EntityFrameworkCore;

namespace Buylist.Repository
{
    public class CompraRepository : BuyListRepository<Compra, int>
    {
        private DbContext _context;
        public CompraRepository(DbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}