using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EmprestimoDeLivros.Application.DTOs;
using EmprestimoDeLivros.Domain.Entities;

namespace EmprestimoDeLivros.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        {
            CreateMap<Client, ClienteDTO>().ReverseMap();
        
        }
    }
}
