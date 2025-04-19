using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmprestimoDeLivros.Application.DTOs;
using EmprestimoDeLivros.Application.Interfaces;

namespace EmprestimoDeLivros.Application.Services
{
    class ClientService : IClientService
    {

        private readonly IClienteRepository
        public Task<ClienteDTO> Alterar(ClienteDTO clientDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ClienteDTO> Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ClienteDTO> Incluir(ClienteDTO clientDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ClienteDTO> SelecionarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClienteDTO>> SelecionarTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
