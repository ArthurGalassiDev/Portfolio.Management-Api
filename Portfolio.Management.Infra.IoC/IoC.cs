using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Portfolio.Management.Domain.Services;
using Portfolio.Management.Infra.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Management.Domain.Services.Abstractions;

namespace Portfolio.Management.Infra.IoC
{
    public static class IoC
    {
        public static IServiceCollection ConfigureContainer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<TransacaoService>();
            services.AddScoped<IProdutoFinanceiroService, ProdutoFinanceiroService>();
            services.AddScoped<EmailNotificationService>();

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
           
            return services;
        }

        public static IServiceCollection SetupDatabases(this IServiceCollection services, IServiceProvider provider, IConfiguration configuration)
        {
            using (var serviceScope = provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();
            }

            return services;
        }
    }
}