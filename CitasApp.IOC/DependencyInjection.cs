using Microsoft.Extensions.DependencyInjection;
using CitasApp.Application.Services;
using CitasApp.Domain.Repositories;
using CitasApp.Persistance.Repositories;

namespace CitasApp.IOC
{
    public static class DependencyInjection
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            // Registrar servicios de aplicación
            services.AddScoped<ICitaService, CitaService>();

            // Registrar repositorios
            services.AddScoped<ICitaRepository, CitaRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IPagoRepository, PagoRepository>();
        }
    }
}
