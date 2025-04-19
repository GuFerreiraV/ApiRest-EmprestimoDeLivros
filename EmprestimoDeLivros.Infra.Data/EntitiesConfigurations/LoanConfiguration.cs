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
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.idCliente).IsRequired();
            builder.Property(x => x.idLivro).IsRequired();
            builder.Property(x => x.dataEmprestimo).IsRequired();
            builder.Property(x => x.dataDevolucao).IsRequired();
            builder.Property(x => x.LceEntrega).IsRequired();

            builder.HasOne(x => x.Client).WithMany(x => x.Loans)
                .HasForeignKey(x => x.idCliente).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Book).WithMany(x => x.Loans)
                .HasForeignKey(x => x.idLivro).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
