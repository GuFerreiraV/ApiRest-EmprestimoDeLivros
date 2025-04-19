using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmprestimoDeLivros.Domain.Validation;

namespace EmprestimoDeLivros.Domain.Entities
{
    public class Loan
    {
         public int id { get; private set; }
         public int idLivro { get; private set; }
         public int idCliente { get; private set; }
         public DateTime dataEmprestimo { get; private set; }
         public DateTime dataDevolucao { get; private set; }
         public bool LceEntrega { get; private set; }

        // criar propriedades Client e Book aqui
        public Client Client { get; set; }
        public Book Book{ get; set; }


        public Loan(int id, int idLivro, int idCliente, DateTime dataEmprestimo,
            DateTime dataDevolucao, bool LceEntrega) 
        {
            DomainExceptionValidation.When(id < 0, "O Id precisa ser maior que 0");
            ValidateDomain(idCliente, idLivro, dataEmprestimo, dataDevolucao, LceEntrega);

        }

        public Loan(int idLivro, int idCliente, DateTime dataEmprestimo,DateTime dataDevolucao, bool LceEntrega) 
        {

            ValidateDomain(idCliente, idLivro, dataEmprestimo, dataDevolucao, LceEntrega);

        }

        public void Update(int idLivro, int idCliente, DateTime dataEmprestimo, DateTime dataDevolucao, bool LceEntrega)
        {
            ValidateDomain(idCliente, idLivro, dataEmprestimo, dataDevolucao, LceEntrega);

        }

        public void ValidateDomain(int idLivro, int idCliente, DateTime dataEmprestimo, DateTime dataDevolucao, bool LceEntrega)
        {

            DomainExceptionValidation.When(idCliente < 0, "O id do cliente precisa ser maior que 0");
            DomainExceptionValidation.When(idLivro < 0, "O id do livro precisa ser maior que 0");

            idLivro = idLivro;
            idCliente = idCliente;
            dataEmprestimo = dataEmprestimo;
            dataDevolucao = dataDevolucao;
            LceEntrega = LceEntrega;

        }

    }
}
