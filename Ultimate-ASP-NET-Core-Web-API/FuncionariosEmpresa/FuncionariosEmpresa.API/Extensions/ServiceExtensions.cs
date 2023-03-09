using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.LoggingService;
using FuncionariosEmpresa.Repository;
using FuncionariosEmpresa.Services;
using FuncionariosEmpresa.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosEmpresa.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigurarCORS(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigurarIntegracaoIIS(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

        public static void ConfigurarServicoLogger(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigurarGerenciadorRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        public static void ConfigurarGerenciadorService(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }

        public static void ConfigurarContextoSQL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(
                option => option.UseSqlServer(configuration.GetConnectionString("sqlConnection"))
            );
        }
    }
}
