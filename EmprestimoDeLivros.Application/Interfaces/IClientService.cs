using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmprestimoDeLivros.Application.DTOs;
using EmprestimoDeLivros.Domain.Entities;

namespace EmprestimoDeLivros.Application.Interfaces
{
    public interface IClientService
    {
        Task<ClienteDTO> Incluir(ClienteDTO clientDTO);
        Task<ClienteDTO> Alterar(ClienteDTO clientDTO);
        Task<ClienteDTO> Excluir(int id );
        Task<ClienteDTO> SelecionarAsync(int id);
        Task<IEnumerable<ClienteDTO>> SelecionarTodosAsync();


    }
}
