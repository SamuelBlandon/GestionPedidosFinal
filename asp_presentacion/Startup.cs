﻿using lib_comunicaciones.Implementaciones;
using lib_comunicaciones.Interfaces;
using lib_presentaciones.Implementaciones;
using lib_presentaciones.Interfaces;

namespace asp_presentacion
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration? Configuration { set; get; }

        public void ConfigureServices(WebApplicationBuilder builder, IServiceCollection services)
        {
            // Comunicaciones
            services.AddScoped<IDetallesComunicacion, DetallesComunicacion>();
            services.AddScoped<IEstadosComunicacion, EstadosComunicacion>();
            services.AddScoped<IPaquetesComunicacion, PaquetesComunicacion>();
            services.AddScoped<IPedidosComunicacion, PedidosComunicacion>();
            services.AddScoped<IPersonasComunicacion, PersonasComunicacion>();
            services.AddScoped<ITransportistasComunicacion, TransportistasComunicacion>();
            // Presentaciones
            services.AddScoped<IDetallesPresentacion, DetallesPresentacion>();
            services.AddScoped<IEstadosPresentacion, EstadosPresentacion>();
            services.AddScoped<IPaquetesPresentacion, PaquetesPresentacion>();
            services.AddScoped<IPedidosPresentacion, PedidosPresentacion>();
            services.AddScoped<IPersonasPresentacion, PersonasPresentacion>();
            services.AddScoped<ITransportistasPresentacion, TransportistasPresentacion>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddRazorPages();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.UseSession();
            app.Run();
        }
    }
}