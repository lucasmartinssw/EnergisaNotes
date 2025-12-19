using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergisaNotes.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AjusteAreaCoordenadorFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 583, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 583, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 583, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 583, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 586, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 586, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 586, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 12, 3, 586, DateTimeKind.Utc).AddTicks(1067));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 661, DateTimeKind.Utc).AddTicks(4751));

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

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 659, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 659, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 659, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 16, 17, 16, 22, 659, DateTimeKind.Utc).AddTicks(6213));

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
        }
    }
}
