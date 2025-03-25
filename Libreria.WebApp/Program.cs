using Libreria.CasoDeUso_Compartida.InterfacesCU;
using Libreria.CasoDeUsoCompartida;
using Libreria.CasoDeUsoCompartida.DTOs.Usuarios;
using Libreria.CasoDeUsoCompartida.InterfacesCU;
using Libreria.CasoDeUsoCompartida.InterfacesCU.Usuarios;
using Libreria.LogicaAccesoDatos.Lista;
using Libreria.LogicaAplicacion.CasoUso.Usuarios;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;

namespace Libreria.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();

            // Inyecciones para los Caso de Uso de Usuario
            builder.Services.AddScoped<IAdd<UsuarioDto>, AddUsuario>();
            builder.Services.AddScoped<IGetAll<Usuario>, GetAllUsuario>();
            builder.Services.AddScoped<IGetById<Usuario>, GetById>();
            builder.Services.AddScoped<IGetByNameUsuario, GetByName>();
            builder.Services.AddScoped<IRemove, RemoveUsuario>();

            // Inyecciones para los repositorios
            builder.Services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Usuario}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
