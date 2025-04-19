using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmprestimoDeLivros.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoDeLivros.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Book> Book { get; set;}
        public DbSet<Loan> Loan { get; set; }
        public DbSet<Client> Client { get; set; }

        // Configura o modelo de banco de dados antes da criação das tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Implementação base, para garantir que qualquer config padrão da classe base seja aplicada.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly); // Permite que as configs das entidades sejam organizadas em classes separadas.
        }


    }
}
