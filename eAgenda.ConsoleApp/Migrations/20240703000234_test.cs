using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAgenda.ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "TBTarefa");
        }
    }
}
