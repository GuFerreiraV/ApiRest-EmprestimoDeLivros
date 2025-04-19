using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprestimoDeLivros.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InicialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    livroNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    livroAutor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    livroEditora = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    livroAnoPublicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    livroEdicao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteCPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    clienteNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    clienteEndereco = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    clienteCidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    clienteBairro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idLivro = table.Column<int>(type: "int", nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    dataEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LceEntrega = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.id);
                    table.ForeignKey(
                        name: "FK_Loan_Book_idLivro",
                        column: x => x.idLivro,
                        principalTable: "Book",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Loan_Client_idCliente",
                        column: x => x.idCliente,
                        principalTable: "Client",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loan_idCliente",
                table: "Loan",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_idLivro",
                table: "Loan",
                column: "idLivro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loan");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
