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
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.clienteCPF).HasMaxLength(11).IsRequired();
            builder.Property(x => x.clienteNome).HasMaxLength(50).IsRequired();
            builder.Property(x => x.clienteEndereco).HasMaxLength(50).IsRequired();
            builder.Property(x => x.clienteCidade).HasMaxLength(50).IsRequired();
            builder.Property(x => x.clienteBairro).HasMaxLength(50).IsRequired();
        }
    }
}
