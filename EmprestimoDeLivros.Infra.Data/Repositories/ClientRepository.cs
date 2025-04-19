using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmprestimoDeLivros.Domain.Entities;
using EmprestimoDeLivros.Domain.Interfaces;
using EmprestimoDeLivros.Infra.Data.Context;

namespace EmprestimoDeLivros.Infra.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {

        private readonly ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Client> Alterar(Client client)
        {
            _context.Client.Update(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public Task<Client> Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Client> Incluir(Client client)
        {
            throw new NotImplementedException();
        }

        public Task<Client> SelecionarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Client>> SelecionarTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
