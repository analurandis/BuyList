using Buylist.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buylist.DataAccess.TypeConfigurations
{
    public class CompraTypeConfiguration : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.Property(b => b.CompraId)
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Property(b => b.Descricao)
                .HasMaxLength(200);
            builder.Property(b => b.Data)
                .HasColumnType("date");

        }
    }
}
