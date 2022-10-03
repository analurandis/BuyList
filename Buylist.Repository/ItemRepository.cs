using Buylist.Common.Repository.Entity;
using Buylist.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buylist.Repository
{
    public class ItemRepository : BuyListServiceRepository<Item, int>
    {
        private DbContext _context;
        public ItemRepository(DbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public override List<Item> All()
        {
            return _context.Set<Item>().Include(i => i.Produto).ToList();
        }

        public override Item ByKey(int key)
        {
            return _context.Set<Item>().Include(i => i.Produto).FirstOrDefault(i => i.Id == key);
        }
    }
}