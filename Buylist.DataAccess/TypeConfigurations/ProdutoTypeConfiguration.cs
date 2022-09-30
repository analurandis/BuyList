using Buylist.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buylist.DataAccess.TypeConfigurations
{
    public class ProdutoTypeConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {

            builder.Property(b => b.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Property(b => b.Descricao)
                .HasMaxLength(200);
            builder.Property(b => b.CodigoBarras)
                .HasMaxLength(20);

        }
    }
}
