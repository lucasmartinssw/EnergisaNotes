using EnergisaNotes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnergisaNotes.Infra.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Incidente> Incidentes { get; set; }
    public DbSet<Area> Areas { get; set; }
    public DbSet<Cargo> Cargos { get; set; }
    public DbSet<Colaborador> Colaboradores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // --- 1. CONFIGURAÇÃO: AREA ---
        modelBuilder.Entity<Area>(entity =>
        {
            entity.ToTable("Areas");
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Nome).IsRequired().HasMaxLength(100);

            entity.HasData(
                new { Id = 1, Nome = "Corporativo", DataCriacao = DateTime.UtcNow },
                new { Id = 2, Nome = "Tecnologia da Informação", DataCriacao = DateTime.UtcNow },
                new { Id = 3, Nome = "Recursos Humanos", DataCriacao = DateTime.UtcNow },
                new { Id = 4, Nome = "Operações", DataCriacao = DateTime.UtcNow },
                new { Id = 5, Nome = "Comercial", DataCriacao = DateTime.UtcNow },
                new { Id = 6, Nome = "Atendimento", DataCriacao = DateTime.UtcNow }
            );
        });

        // --- 2. CONFIGURAÇÃO: CARGO ---
        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.ToTable("Cargos");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Nome).IsRequired().HasMaxLength(100);

            entity.HasData(
                new { Id = 1, Nome = "Colaborador", DataCriacao = DateTime.UtcNow },
                new { Id = 2, Nome = "Analista de T.I.", DataCriacao = DateTime.UtcNow },
                new { Id = 3, Nome = "Gerente", DataCriacao = DateTime.UtcNow },
                new { Id = 4, Nome = "Eletricista", DataCriacao = DateTime.UtcNow },
                new { Id = 5, Nome = "Atendente", DataCriacao = DateTime.UtcNow },
                new { Id = 6, Nome = "Supervisor", DataCriacao = DateTime.UtcNow }
            );
        });

        // --- 3. CONFIGURAÇÃO: CATEGORIA ---
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.ToTable("Categorias");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            entity.HasIndex(c => c.Nome).IsUnique();

            entity.HasData(
                new { Id = 1, Nome = "Tecnologia da Informação", DataCriacao = DateTime.UtcNow },
                new { Id = 2, Nome = "Infraestrutura Predial", DataCriacao = DateTime.UtcNow },
                new { Id = 3, Nome = "Recursos Humanos", DataCriacao = DateTime.UtcNow },
                new { Id = 4, Nome = "Segurança do Trabalho", DataCriacao = DateTime.UtcNow },
                new { Id = 5, Nome = "Operações de Rede", DataCriacao = DateTime.UtcNow },
                new { Id = 6, Nome = "Frota e Logística", DataCriacao = DateTime.UtcNow }
            );
        });

        // --- 4. CONFIGURAÇÃO: COLABORADOR ---
        modelBuilder.Entity<Colaborador>(entity =>
        {
            entity.ToTable("Colaboradores");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Nome).IsRequired().HasMaxLength(150);
            entity.Property(c => c.Email).IsRequired().HasMaxLength(150);
            entity.Property(c => c.Endereco).HasMaxLength(250);
            entity.Property(c => c.Empresa).HasMaxLength(100);
            entity.Property(c => c.Aniversario).HasMaxLength(5); // Apenas "DD/MM"

            entity.HasIndex(c => c.Email).IsUnique();

            entity.HasOne(c => c.Area)
                  .WithMany()
                  .HasForeignKey(c => c.AreaId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(c => c.Cargo)
                  .WithMany()
                  .HasForeignKey(c => c.CargoId)
                  .OnDelete(DeleteBehavior.Restrict);

            // SEED COLABORADORES
            entity.HasData(
                new
                {
                    Id = 1,
                    Nome = "Admin Energisa",
                    Email = "admin@energisa.com.br",
                    AreaId = 1,
                    CargoId = 3,
                    Empresa = "Energisa Participações",
                    Aniversario = "01/01",
                    Endereco = "Rua da Matriz, 100",
                    DataCriacao = DateTime.UtcNow
                },
                new
                {
                    Id = 2,
                    Nome = "João Colaborador",
                    Email = "joao.silva@energisa.com.br",
                    AreaId = 6,
                    CargoId = 2,
                    Empresa = "Energisa Mato Grosso",
                    Aniversario = "15/05",
                    Endereco = "Av. Historiador Rubens de Mendonça, 200",
                    DataCriacao = DateTime.UtcNow
                }
            );
        });

        // --- 5. CONFIGURAÇÃO: USUARIO (AGORA SÓ ACESSO) ---
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuarios");
            entity.HasKey(u => u.Id);
            entity.Property(u => u.AzureAdObjectId).IsRequired();
            entity.HasIndex(u => u.AzureAdObjectId).IsUnique();

            // Relacionamento 1:1 com Colaborador
            entity.HasOne(u => u.Colaborador)
                  .WithOne(c => c.Usuario)
                  .HasForeignKey<Usuario>(u => u.ColaboradorId)
                  .OnDelete(DeleteBehavior.Cascade);

            // SEED USUARIOS (VINCULADOS AOS COLABORADORES)
            entity.HasData(
                new
                {
                    Id = 1,
                    AzureAdObjectId = "00000000-0000-0000-0000-000000000001",
                    ColaboradorId = 1, // Vincula ao Admin Energisa
                    IsSupervisor = true,
                    DataCriacao = DateTime.UtcNow,
                    DataUltimaSync = DateTime.UtcNow
                },
                new
                {
                    Id = 2,
                    AzureAdObjectId = "00000000-0000-0000-0000-000000000002",
                    ColaboradorId = 2, // Vincula ao João Colaborador
                    IsSupervisor = false,
                    DataCriacao = DateTime.UtcNow,
                    DataUltimaSync = DateTime.UtcNow
                }
            );
        });

        // --- 6. CONFIGURAÇÃO: INCIDENTE ---
        modelBuilder.Entity<Incidente>(entity =>
        {
            entity.ToTable("Incidentes");
            entity.HasKey(i => i.Id);
            entity.Property(i => i.Titulo).IsRequired().HasMaxLength(200);
            entity.Property(i => i.TextoTemplate).IsRequired().HasColumnType("TEXT");

            entity.HasOne(i => i.Categoria)
                  .WithMany()
                  .HasForeignKey(i => i.CategoriaId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(i => i.UltimoEditor)
                  .WithMany()
                  .HasForeignKey(i => i.UltimoEditorId)
                  .OnDelete(DeleteBehavior.SetNull);

            // SEED INCIDENTES
            entity.HasData(
                new
                {
                    Id = 1,
                    Titulo = "Indisponibilidade de Link (Internet)",
                    CategoriaId = 1,
                    UltimoEditorId = 1,
                    TextoTemplate = "Prezados, informamos que a unidade [Unidade] encontra-se sem acesso à internet...",
                    DataCriacao = DateTime.UtcNow
                },
                new
                {
                    Id = 2,
                    Titulo = "Lentidão no SAP",
                    CategoriaId = 1,
                    UltimoEditorId = 1,
                    TextoTemplate = "Identificamos lentidão no módulo [ModuloSAP] do sistema SAP...",
                    DataCriacao = DateTime.UtcNow
                }
            );
        });
    }
}