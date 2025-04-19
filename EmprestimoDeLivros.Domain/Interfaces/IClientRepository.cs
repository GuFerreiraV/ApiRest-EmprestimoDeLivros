using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmprestimoDeLivros.Domain.Entities;

namespace EmprestimoDeLivros.Domain.Interfaces
{
    public interface IClientRepository
    {
        Task<Client> Incluir(Client client);
        Task<Client> Alterar(Client client);
        Task<Client> Excluir(int id);
        Task<Client> SelecionarAsync(int id);
        Task<IEnumerable<Client>> SelecionarTodosAsync();
    }
}
