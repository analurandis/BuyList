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
    public  class ProdutoRepository : BuyListRepository<Produto, int>
    {
        private DbContext _context;
        public ProdutoRepository(DbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }


    }
}