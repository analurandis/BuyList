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
    public  class LocalRepository : BuyListRepository<Local, int>
    {
        private DbContext _context;
        public LocalRepository(DbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}