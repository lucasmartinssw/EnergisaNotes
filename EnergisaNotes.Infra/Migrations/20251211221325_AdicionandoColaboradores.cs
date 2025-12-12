using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnergisaNotes.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoColaboradores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Areas_AreaId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Cargos_CargoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TelefonePessoal",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "CargoId",
                table: "Usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ColaboradorId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaboradores_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Colaboradores_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.InsertData(
                table: "Colaboradores",
                columns: new[] { "Id", "AreaId", "CargoId", "DataAtualizacao", "DataCriacao", "Email", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, 1, 3, null, new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(6129), "admin@energisa.com.br", "Admin Energisa", null },
                    { 2, 6, 2, null, new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(6132), "joao.silva@energisa.com.br", "João Colaborador", null }
                });

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
                columns: new[] { "AreaId", "CargoId", "ColaboradorId", "DataCriacao" },
                values: new object[] { null, null, 1, new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AreaId", "CargoId", "ColaboradorId", "DataCriacao" },
                values: new object[] { null, null, 2, new DateTime(2025, 12, 11, 22, 13, 24, 409, DateTimeKind.Utc).AddTicks(8767) });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ColaboradorId",
                table: "Usuarios",
                column: "ColaboradorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_AreaId",
                table: "Colaboradores",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_CargoId",
                table: "Colaboradores",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_Email",
                table: "Colaboradores",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Areas_AreaId",
                table: "Usuarios",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Cargos_CargoId",
                table: "Usuarios",
                column: "CargoId",
                principalTable: "Cargos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Colaboradores_ColaboradorId",
                table: "Usuarios",
                column: "ColaboradorId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Areas_AreaId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Cargos_CargoId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Colaboradores_ColaboradorId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ColaboradorId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ColaboradorId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "CargoId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Usuarios",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Usuarios",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TelefonePessoal",
                table: "Usuarios",
                type: "longtext",
                nullable: true)
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

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Cargos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 10, 0, 46, 35, 242, DateTimeKind.Utc).AddTicks(6170));

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
                columns: new[] { "AreaId", "CargoId", "DataCriacao", "DataNascimento", "Email", "Endereco", "Nome", "TelefonePessoal" },
                values: new object[] { 1, 3, new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5839), null, "admin@energisa.com.br", null, "Admin Energisa", null });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AreaId", "CargoId", "DataCriacao", "DataNascimento", "Email", "Endereco", "Nome", "TelefonePessoal" },
                values: new object[] { 6, 2, new DateTime(2025, 12, 10, 0, 46, 35, 243, DateTimeKind.Utc).AddTicks(5842), null, "joao.silva@energisa.com.br", null, "João Colaborador", null });

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Areas_AreaId",
                table: "Usuarios",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Cargos_CargoId",
                table: "Usuarios",
                column: "CargoId",
                principalTable: "Cargos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
