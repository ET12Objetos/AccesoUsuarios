using Api.Funcionalidades.Usuarios;

namespace Api.Funcionalidades;
public static class ServiceManager
{
    public static IServiceCollection AddFuncionalidadesServices(this IServiceCollection services)
    {
        services.AddSingleton<IUsuarioService, UsuarioService>();

        return services;
    }
}