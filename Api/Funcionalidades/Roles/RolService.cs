using Api.Persistencia;
using Aplicacion.Dominio;
using Mapster;

namespace Api.Funcionalidades.Roles;

public interface IRolService
{
    RolCommandResponseDto CreateRol(RolCommandRequestDto rolDto);
    IEnumerable<RolQueryResponseDto> GetAllRoles();
}

public class RolService : IRolService
{
    private readonly AplicacionDbContext context;

    public RolService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public RolCommandResponseDto CreateRol(RolCommandRequestDto rolDto)
    {
        var rol = rolDto.Adapt<Rol>();

        var administrador = context.Administradores.Single(x => x.Id == rolDto.IdAdministrador);

        rol.AsignarDatosCreacion(administrador);

        context.Roles.Add(rol);

        context.SaveChanges();

        return rol.Adapt<RolCommandResponseDto>();
    }

    public IEnumerable<RolQueryResponseDto> GetAllRoles()
    {
        return context.Roles.Adapt<IEnumerable<RolQueryResponseDto>>();
    }
}
