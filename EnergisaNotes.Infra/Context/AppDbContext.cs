using EnergisaNotes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnergisaNotes.Infra.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Incidente> Incidentes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // --- 1. CONFIGURAÇÕES DAS TABELAS ---

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.ToTable("Categorias");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            entity.HasIndex(c => c.Nome).IsUnique();
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuarios");
            entity.HasKey(u => u.Id);
            entity.Property(u => u.AzureAdObjectId).IsRequired();
            entity.Property(u => u.Nome).IsRequired().HasMaxLength(150);
            entity.Property(u => u.Email).IsRequired().HasMaxLength(150);
            entity.HasIndex(u => u.AzureAdObjectId).IsUnique();
            entity.HasIndex(u => u.Email).IsUnique();
        });

        modelBuilder.Entity<Incidente>(entity =>
        {
            entity.ToTable("Incidentes");
            entity.HasKey(i => i.Id);
            entity.Property(i => i.Titulo).IsRequired().HasMaxLength(200);
            entity.Property(i => i.TextoTemplate).IsRequired().HasColumnType("TEXT"); // MySQL Text

            entity.HasOne(i => i.Categoria)
                  .WithMany()
                  .HasForeignKey(i => i.CategoriaId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(i => i.UltimoEditor)
                  .WithMany()
                  .HasForeignKey(i => i.UltimoEditorId)
                  .OnDelete(DeleteBehavior.SetNull);
        });

        // --- 2. SEED (DADOS INICIAIS) ---

        // A. Categorias
        modelBuilder.Entity<Categoria>().HasData(
            new { Id = 1, Nome = "Tecnologia da Informação", DataCriacao = DateTime.UtcNow },
            new { Id = 2, Nome = "Infraestrutura Predial", DataCriacao = DateTime.UtcNow },
            new { Id = 3, Nome = "Recursos Humanos", DataCriacao = DateTime.UtcNow },
            new { Id = 4, Nome = "Segurança do Trabalho", DataCriacao = DateTime.UtcNow },
            new { Id = 5, Nome = "Operações de Rede", DataCriacao = DateTime.UtcNow },
            new { Id = 6, Nome = "Frota e Logística", DataCriacao = DateTime.UtcNow }
        );

        // B. Usuários (Simulados)
        modelBuilder.Entity<Usuario>().HasData(
            // Supervisor Geral (Admin)
            new
            {
                Id = 1,
                AzureAdObjectId = "00000000-0000-0000-0000-000000000001",
                Nome = "Admin Energisa",
                Email = "admin@energisa.com.br",
                Cargo = "Gerente de T.I.",
                Area = "Corporativo",
                IsSupervisor = true,
                DataCriacao = DateTime.UtcNow,
                DataUltimaSync = DateTime.UtcNow
            },
            // Colaborador Comum (Para testar acesso restrito)
            new
            {
                Id = 2,
                AzureAdObjectId = "00000000-0000-0000-0000-000000000002",
                Nome = "João Colaborador",
                Email = "joao.silva@energisa.com.br",
                Cargo = "Analista Jr",
                Area = "Atendimento",
                IsSupervisor = false, // Não pode criar categorias nem editar
                DataCriacao = DateTime.UtcNow,
                DataUltimaSync = DateTime.UtcNow
            }
        );

        // C. Incidentes (Templates com Variáveis)
        modelBuilder.Entity<Incidente>().HasData(
            // T.I.
            new
            {
                Id = 1,
                Titulo = "Indisponibilidade de Link (Internet)",
                CategoriaId = 1,
                UltimoEditorId = 1,
                TextoTemplate = "Prezados, informamos que a unidade [Unidade] encontra-se sem acesso à internet devido a uma falha massiva na operadora. A previsão de retorno é para as [Horario]. Equipe de T.I.",
                DataCriacao = DateTime.UtcNow
            },
            new
            {
                Id = 2,
                Titulo = "Lentidão no SAP",
                CategoriaId = 1,
                UltimoEditorId = 1,
                TextoTemplate = "Identificamos lentidão no módulo [ModuloSAP] do sistema SAP. O time de sustentação já está atuando. Chamado técnico: [NumeroChamado].",
                DataCriacao = DateTime.UtcNow
            },
            // Infraestrutura
            new
            {
                Id = 3,
                Titulo = "Manutenção Ar Condicionado",
                CategoriaId = 2,
                UltimoEditorId = 1,
                TextoTemplate = "Atenção colaboradores do setor [Setor]. Haverá manutenção preventiva nos aparelhos de ar condicionado no dia [Data] entre [HoraInicio] e [HoraFim].",
                DataCriacao = DateTime.UtcNow
            },
            // RH
            new
            {
                Id = 4,
                Titulo = "Erro no Ponto Eletrônico",
                CategoriaId = 3,
                UltimoEditorId = 1,
                TextoTemplate = "Informamos que o sistema de ponto apresenta instabilidade hoje, dia [Data]. Favor registrar o ponto manualmente via formulário entregue pelo gestor [NomeGestor].",
                DataCriacao = DateTime.UtcNow
            },
            // Segurança
            new
            {
                Id = 5,
                Titulo = "Alerta de Chuvas Fortes",
                CategoriaId = 5, // Operações
                UltimoEditorId = 1,
                TextoTemplate = "Alerta para as equipes de campo da região [Regiao]: Previsão de tempestades severas para as próximas [Horas] horas. Redobrem a atenção e sigam o protocolo de segurança [Protocolo].",
                DataCriacao = DateTime.UtcNow
            }
        );
    }
}