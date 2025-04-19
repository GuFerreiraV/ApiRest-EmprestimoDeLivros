using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoDeLivros.Application.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
           
        [Required] // Required serve para obrigar o preenchimento do campo
        [StringLength(11)]
        [Unicode(false)]
        [MinLength(11, ErrorMessage = "O CPF deve ter no mínimo 14 caracteres!")]
        public string ClienteCpf { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string ClienteNome { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string ClienteEndereco { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string ClienteCidade { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string ClienteBairro { get; set; }
    }
}
