using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergisaNotes.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoCoordenadorId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coordenacao",
                table: "Areas");

            migrationBuilder.AddColumn<int>(
                name: "CoordenadorId",
                table: "Areas",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordenadorId", "DataCriacao" },
                values: new object[] { 1, new DateTime(2025, 12, 19, 17, 16, 33, 456, DateTimeKind.Utc).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordenadorId", "DataCriacao" },
                values: new object[] { 2, new DateTime(2025, 12, 19, 17, 16, 33, 456, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordenadorId", "DataCriacao" },
                values: new object[] { 1, new DateTime(2025, 12, 19, 17, 16, 33, 456, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordenadorId", "DataCriacao" },
                values: new object[] { null, new DateTime(2025, 12, 19, 17, 16, 33, 456, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordenadorId", "DataCriacao" },
                values: new object[] { null, new DateTime(2025, 12, 19, 17, 16, 33, 456, DateTimeKind.Utc).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordenadorId", "DataCriacao" },
                values: new object[] { null, new DateTime(2025, 12, 19, 17, 16, 33, 456, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 454, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 454, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 452, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 457, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 457, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 457, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 19, 17, 16, 33, 457, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.CreateIndex(
                name: "IX_Areas_CoordenadorId",
                table: "Areas",
                column: "CoordenadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Colaboradores_CoordenadorId",
                table: "Areas",
                column: "CoordenadorId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Colaboradores_CoordenadorId",
                table: "Areas");

            migrationBuilder.DropIndex(
                name: "IX_Areas_CoordenadorId",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "CoordenadorId",
                table: "Areas");

            migrationBuilder.AddColumn<string>(
                name: "Coordenacao",
                table: "Areas",
                type: "varchar(150)",
                maxLength: 150,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "Diretoria Executiva", new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "Luciana Monteiro", new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "João Silva", new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "Carlos Oper", new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "Maria Vendas", new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Coordenacao", "DataCriacao" },
                values: new object[] { "Ana Call", new DateTime(2025, 12, 19, 17, 12, 3, 585, DateTimeKind.Utc).AddTicks(3046) });

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
    }
}
