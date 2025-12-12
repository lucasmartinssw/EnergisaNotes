using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergisaNotes.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AjusteCamposColaborador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aniversario",
                table: "Colaboradores",
                type: "varchar(5)",
                maxLength: 5,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "Colaboradores",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Colaboradores",
                type: "varchar(250)",
                maxLength: 250,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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
                columns: new[] { "Aniversario", "DataCriacao", "Empresa", "Endereco" },
                values: new object[] { "01/01", new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(3932), "Energisa Participações", "Rua da Matriz, 100" });

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aniversario", "DataCriacao", "Empresa", "Endereco" },
                values: new object[] { "15/05", new DateTime(2025, 12, 11, 22, 28, 14, 876, DateTimeKind.Utc).AddTicks(3935), "Energisa Mato Grosso", "Av. Historiador Rubens de Mendonça, 200" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aniversario",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Colaboradores");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 410, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 410, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(8767));
        }
    }
}
