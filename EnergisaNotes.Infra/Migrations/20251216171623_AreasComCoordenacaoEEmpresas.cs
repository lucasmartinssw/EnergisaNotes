using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnergisaNotes.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AreasComCoordenacaoEEmpresas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Coordenacao",
                table: "Areas",
                type: "varchar(150)",
                maxLength: 150,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AreaEmpresa",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaEmpresa", x => new { x.AreaId, x.EmpresaId });
                    table.ForeignKey(
                        name: "FK_AreaEmpresa_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaEmpresa_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "Diretoria Executiva", new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "Luciana Monteiro", new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "João Silva", new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "Carlos Oper", new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "Maria Vendas", new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "Ana Call", new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 662, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 662, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 12, 16, 17, 16, 22, 659, DateTimeKind.Utc).AddTicks(6203), "Energisa Mato Grosso" },
                    { 2, null, new DateTime(2025, 12, 16, 17, 16, 22, 659, DateTimeKind.Utc).AddTicks(6210), "Energisa Sul-Sudeste" },
                    { 3, null, new DateTime(2025, 12, 16, 17, 16, 22, 659, DateTimeKind.Utc).AddTicks(6212), "Energisa Tocantins" },
                    { 4, null, new DateTime(2025, 12, 16, 17, 16, 22, 659, DateTimeKind.Utc).AddTicks(6213), "Energisa Paraíba" }
                });

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 662, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 662, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 662, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 662, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.InsertData(
                table: "AreaEmpresa",
                columns: new[] { "AreaId", "EmpresaId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaEmpresa_EmpresaId",
                table: "AreaEmpresa",
                column: "EmpresaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaEmpresa");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropColumn(
                name: "Coordenacao",
                table: "Areas");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 875, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(6109));
        }
    }
}
