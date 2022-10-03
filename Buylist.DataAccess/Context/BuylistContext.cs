using Buylist.DataAccess.TypeConfigurations;
using Buylist.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Buylist.DataAccess.Context
{
    public class BuylistContext : DbContext
    {
        
        public DbSet<Compra> TbCompra { get; set; }
        public DbSet<Item> TbItem { get; set; }
        public DbSet<Local> TbLocal { get; set; }
        public DbSet<Produto> TbProduto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:randisbuylist.database.windows.net,1433;Initial Catalog=buylist;Persist Security Info=False;User ID=randis;Password=9173!LASsols;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //new CompraTypeConfiguration().Configure(modelBuilder.Entity<Compra>());
            new ProdutoTypeConfiguration().Configure(modelBuilder.Entity<Produto>());
        }

    }
}
