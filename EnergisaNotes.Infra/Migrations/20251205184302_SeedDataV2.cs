using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnergisaNotes.Infra.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(617), "Tecnologia da Informação" },
                    { 2, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(620), "Infraestrutura Predial" },
                    { 3, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(621), "Recursos Humanos" },
                    { 4, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(622), "Segurança do Trabalho" },
                    { 5, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(623), "Operações de Rede" },
                    { 6, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(624), "Frota e Logística" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Area", "AzureAdObjectId", "Cargo", "DataAtualizacao", "DataCriacao", "DataNascimento", "Email", "Endereco", "IsSupervisor", "Nome", "TelefonePessoal" },
                values: new object[,]
                {
                    { 1, "Corporativo", "00000000-0000-0000-0000-000000000001", "Gerente de T.I.", null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(675), null, "admin@energisa.com.br", null, true, "Admin Energisa", null },
                    { 2, "Atendimento", "00000000-0000-0000-0000-000000000002", "Analista Jr", null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(676), null, "joao.silva@energisa.com.br", null, false, "João Colaborador", null }
                });

            migrationBuilder.InsertData(
                table: "Incidentes",
                columns: new[] { "Id", "CategoriaId", "DataAtualizacao", "DataCriacao", "TextoTemplate", "Titulo", "UltimoEditorId" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(695), "Prezados, informamos que a unidade [Unidade] encontra-se sem acesso à internet devido a uma falha massiva na operadora. A previsão de retorno é para as [Horario]. Equipe de T.I.", "Indisponibilidade de Link (Internet)", 1 },
                    { 2, 1, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(697), "Identificamos lentidão no módulo [ModuloSAP] do sistema SAP. O time de sustentação já está atuando. Chamado técnico: [NumeroChamado].", "Lentidão no SAP", 1 },
                    { 3, 2, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(698), "Atenção colaboradores do setor [Setor]. Haverá manutenção preventiva nos aparelhos de ar condicionado no dia [Data] entre [HoraInicio] e [HoraFim].", "Manutenção Ar Condicionado", 1 },
                    { 4, 3, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(699), "Informamos que o sistema de ponto apresenta instabilidade hoje, dia [Data]. Favor registrar o ponto manualmente via formulário entregue pelo gestor [NomeGestor].", "Erro no Ponto Eletrônico", 1 },
                    { 5, 5, null, new DateTime(2025, 12, 5, 18, 43, 1, 848, DateTimeKind.Utc).AddTicks(700), "Alerta para as equipes de campo da região [Regiao]: Previsão de tempestades severas para as próximas [Horas] horas. Redobrem a atenção e sigam o protocolo de segurança [Protocolo].", "Alerta de Chuvas Fortes", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Incidentes",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
