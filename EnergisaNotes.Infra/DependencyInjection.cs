using EnergisaNotes.Domain.Interfaces;
using EnergisaNotes.Infra.Context;
using EnergisaNotes.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EnergisaNotes.Infra;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // 1. Configura o MySQL
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(connectionString,
                ServerVersion.AutoDetect(connectionString),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

        // 2. Registra os Repositórios (DI)
        services.AddScoped<ICategoriaRepository, CategoriaRepository>(); // *Crie este arquivo seguindo a lógica dos outros
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        services.AddScoped<IIncidenteRepository, IncidenteRepository>();

        return services;
    }
}