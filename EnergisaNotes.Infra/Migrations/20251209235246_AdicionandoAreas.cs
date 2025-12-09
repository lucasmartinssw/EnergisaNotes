using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnergisaNotes.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoAreas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios");

            migrationBuilder.DeleteData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Areas",
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
                    table.PrimaryKey("PK_Areas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2764), "Corporativo" },
                    { 2, null, new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2771), "Tecnologia da Informação" },
                    { 3, null, new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2772), "Recursos Humanos" },
                    { 4, null, new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2774), "Operações" },
                    { 5, null, new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2775), "Comercial" },
                    { 6, null, new DateTime(2025, 12, 9, 23, 52, 45, 652, DateTimeKind.Utc).AddTicks(2777), "Atendimento" }
                });

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
                columns: new[] { "DataCriacao", "TextoTemplate" },
                values: new object[] { new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(7103), "Prezados, informamos que a unidade [Unidade] encontra-se sem acesso à internet..." });

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "TextoTemplate" },
                values: new object[] { new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(7105), "Identificamos lentidão no módulo [ModuloSAP] do sistema SAP..." });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AreaId", "DataCriacao" },
                values: new object[] { 1, new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AreaId", "DataCriacao" },
                values: new object[] { 6, new DateTime(2025, 12, 9, 23, 52, 45, 653, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_AreaId",
                table: "Usuarios",
                column: "AreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Areas_AreaId",
                table: "Usuarios",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Areas_AreaId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_AreaId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Usuarios",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "TextoTemplate" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(695), "Prezados, informamos que a unidade [Unidade] encontra-se sem acesso à internet devido a uma falha massiva na operadora. A previsão de retorno é para as [Horario]. Equipe de T.I." });

            migrationBuilder.UpdateData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "TextoTemplate" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(697), "Identificamos lentidão no módulo [ModuloSAP] do sistema SAP. O time de sustentação já está atuando. Chamado técnico: [NumeroChamado]." });

            migrationBuilder.InsertData(
                table: "Incidentes",
                columns: new[] { "Id", "CategoriaId", "DataAtualizacao", "DataCriacao", "TextoTemplate", "Titulo", "UltimoEditorId" },
                values: new object[,]
                {
                    { 3, 2, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(698), "Atenção colaboradores do setor [Setor]. Haverá manutenção preventiva nos aparelhos de ar condicionado no dia [Data] entre [HoraInicio] e [HoraFim].", "Manutenção Ar Condicionado", 1 },
                    { 4, 3, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(699), "Informamos que o sistema de ponto apresenta instabilidade hoje, dia [Data]. Favor registrar o ponto manualmente via formulário entregue pelo gestor [NomeGestor].", "Erro no Ponto Eletrônico", 1 },
                    { 5, 5, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(700), "Alerta para as equipes de campo da região [Regiao]: Previsão de tempestades severas para as próximas [Horas] horas. Redobrem a atenção e sigam o protocolo de segurança [Protocolo].", "Alerta de Chuvas Fortes", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Area", "DataCriacao" },
                values: new object[] { "Corporativo", new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "DataCriacao" },
                values: new object[] { "Atendimento", new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);
        }
    }
}
