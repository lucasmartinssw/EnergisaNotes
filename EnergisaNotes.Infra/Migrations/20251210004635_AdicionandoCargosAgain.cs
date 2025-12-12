using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnergisaNotes.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoCargosAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cargos",
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
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.InsertData(
                table: "Cargos",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6166), "Colaborador" },
                    { 2, null, new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6167), "Analista de T.I." },
                    { 3, null, new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6168), "Gerente" },
                    { 4, null, new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6169), "Eletricista" },
                    { 5, null, new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6169), "Atendente" },
                    { 6, null, new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6170), "Supervisor" }
                });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CargoId", "DataCriacao" },
                values: new object[] { 3, new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CargoId", "DataCriacao" },
                values: new object[] { 2, new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CargoId",
                table: "Usuarios",
                column: "CargoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Cargos_CargoId",
                table: "Usuarios",
                column: "CargoId",
                principalTable: "Cargos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Cargos_CargoId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CargoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Usuarios",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cargo", "DataCriacao" },
                values: new object[] { "Gerente de T.I.", new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cargo", "DataCriacao" },
                values: new object[] { "Analista Jr", new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8520) });
        }
    }
}
