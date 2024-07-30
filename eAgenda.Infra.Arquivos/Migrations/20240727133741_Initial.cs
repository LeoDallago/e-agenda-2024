using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAgenda.Infra.Arquivos.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBCompromisso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assunto = table.Column<string>(type: "varchar(250)", nullable: false),
                    DataCompromisso = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    Inicio = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    Termino = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    Contato = table.Column<string>(type: "varchar(250)", nullable: false),
                    Localização = table.Column<string>(type: "varchar(250)", nullable: false),
                    Local = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCompromisso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBContato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(250)", nullable: false),
                    Empresa = table.Column<string>(type: "varchar(250)", nullable: false),
                    Cargo = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBContato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBTarefa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(150)", nullable: false),
                    Prioridade = table.Column<string>(type: "varchar(150)", nullable: false),
                    DataCriacao = table.Column<string>(type: "varchar(150)", nullable: false),
                    DataConclusao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBTarefa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTarefa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Concluido = table.Column<bool>(type: "bit", nullable: false),
                    TarefaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTarefa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemTarefa_TBTarefa_TarefaId",
                        column: x => x.TarefaId,
                        principalTable: "TBTarefa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemTarefa_TarefaId",
                table: "ItemTarefa",
                column: "TarefaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemTarefa");

            migrationBuilder.DropTable(
                name: "TBCompromisso");

            migrationBuilder.DropTable(
                name: "TBContato");

            migrationBuilder.DropTable(
                name: "TBTarefa");
        }
    }
}
