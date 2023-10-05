using Api.Funcionalidades.Administradores;
using Api.Funcionalidades.Roles;
using Api.Funcionalidades.Usuarios;

namespace Api.Funcionalidades;
public static class ServiceManager
{
    public static IServiceCollection AddFuncionalidadesServices(this IServiceCollection services)
    {
        services.AddScoped<IUsuarioService, UsuarioService>();

        services.AddScoped<IAdministradorService, AdministradorService>();

        services.AddScoped<IRolService, RolService>();

        return services;
    }
}