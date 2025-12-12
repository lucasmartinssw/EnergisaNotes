using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergisaNotes.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoCargos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 42, 31, 74, DateTimeKind.Utc).AddTicks(8520));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(7054));
        }
    }
}
