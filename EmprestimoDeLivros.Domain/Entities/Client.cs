using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmprestimoDeLivros.Domain.Validation;

namespace EmprestimoDeLivros.Domain.Entities
{
    public class Client
    {
        public Client(int id, string clienteCPF, string clienteNome,
            string clienteEndereco, string clienteCidade, string clienteBairro)
        {
            DomainExceptionValidation.When(id < 0, "O Id precisa ser maior que 0");

            this.id = id;
            ValidateDomain(clienteCPF, clienteNome, clienteEndereco, clienteCidade, clienteBairro);
        }
        public Client(string clienteCPF, string clienteNome, 
            string clienteEndereco, string clienteCidade, string clienteBairro )
        {
            ValidateDomain(clienteCPF, clienteNome, clienteEndereco, clienteCidade, clienteBairro);
        }

        public void Update(string clienteCPF, string clienteNome,
            string clienteEndereco, string clienteCidade, string clienteBairro)
        {
            ValidateDomain(clienteCPF, clienteNome, clienteEndereco, clienteCidade, clienteBairro);
        }

        public int id { get; private set;}
        public string clienteCPF { get; private set; }
        public string clienteNome { get; private set; }
        public string clienteEndereco { get; private set; }
        public string clienteCidade { get; private set; }
        public string clienteBairro { get; private set; }

        // Criar uma collection de Loan aqui
        public ICollection<Loan> Loans { get; set; }


        // Método para validar os campos
        public void ValidateDomain(string clienteCPF, string clienteNome,
            string clienteEndereco, string clienteCidade, string clienteBairro) {
            

            DomainExceptionValidation.When(clienteCPF.Length != 11, "CPF precisa ter apenas 11 caracteres");
            DomainExceptionValidation.When(clienteNome.Length > 50, "O nome do cliente deve ter, no máximo, 50 caracteres");
            DomainExceptionValidation.When(clienteEndereco.Length > 50, "O endereço do cliente deve ter, no máximo, 50 caracteres");
            DomainExceptionValidation.When(clienteCidade.Length > 50, "A cidade deve ter, no máximo, 50 caracteres");
            DomainExceptionValidation.When(clienteBairro.Length > 50, "o bairro deve ter, no máximo, 50 caracteres");




            clienteCPF = clienteCPF;
            clienteNome = clienteNome;
            clienteEndereco = clienteEndereco;
            clienteCidade = clienteCidade;
            clienteBairro = clienteBairro;

        }

    }
}
