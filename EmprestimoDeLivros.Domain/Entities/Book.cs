using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmprestimoDeLivros.Domain.Validation;

namespace EmprestimoDeLivros.Domain.Entities
{
    public class Book
    {

        public Book(int id, string livroNome, string livroAutor, string livroEditora,
            DateTime livroAnoPublicacao, string livroEdicao)
        {
            DomainExceptionValidation.When(id < 0, "O Id precisa ser maior que 0");
            ValidateDomain(livroNome, livroAutor, livroEditora, livroAnoPublicacao, livroEdicao);
            this.id = id;
        }
        public Book(string livroNome, string livroAutor, string livroEditora,
            DateTime livroAnoPublicacao, string livroEdicao)
        {

            ValidateDomain(livroNome, livroAutor, livroEditora, livroAnoPublicacao, livroEdicao);
        
        }

        public void Update(string livroNome, string livroAutor, string livroEditora,
            DateTime livroAnoPublicacao, string livroEdicao)
        {
            ValidateDomain(livroNome, livroAutor, livroEditora, livroAnoPublicacao, livroEdicao);
        }

        public int id { get; private set; }
        public string livroNome { get; private set; }
        public string livroAutor { get; private set; }
        public string livroEditora { get; private set; }
        public DateTime livroAnoPublicacao { get; private set; }
        public string livroEdicao { get; private set; }

        // Criar uma collection de Loan aqui
        public ICollection<Loan> Loans { get; set; }


        public void ValidateDomain(string livroNome, string livroAutor, string livroEditora,
            DateTime livroAnoPublicacao, string livroEdicao)
        {
            DomainExceptionValidation.When(livroNome.Length > 50, "O nome do livro deve ter, no máximo, 50 caracteres");
            DomainExceptionValidation.When(livroAutor.Length > 50, "O autor do livro deve ter, no máximo, 50 caracteres");
            DomainExceptionValidation.When(livroEditora.Length > 50, "A editora do livro deve ter, no máximo, 50 caracteres");
            DomainExceptionValidation.When(livroEdicao.Length > 50, "A edição do livro deve ter, no máximo, 50 caracteres");
            DomainExceptionValidation.When(livroAnoPublicacao > DateTime.Now, "O ano de publicação não pode ser maior que o ano atual");
       
            livroNome = livroNome;
            livroAutor = livroAutor;
            livroEditora = livroEditora;
            livroAnoPublicacao = livroAnoPublicacao;
            livroEdicao = livroEdicao;
        }
    }
}
