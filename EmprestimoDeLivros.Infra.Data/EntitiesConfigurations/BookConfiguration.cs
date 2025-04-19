using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmprestimoDeLivros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmprestimoDeLivros.Infra.Data.EntitiesConfigurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.livroNome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.livroAutor).IsRequired().HasMaxLength(100);
            builder.Property(x => x.livroEditora).IsRequired().HasMaxLength(50);
            builder.Property(x => x.livroAnoPublicacao).IsRequired();
            builder.Property(x => x.livroEdicao).IsRequired().HasMaxLength(50);
        }
    }
}
