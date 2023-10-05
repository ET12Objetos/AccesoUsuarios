using Api.Persistencia;
using Aplicacion.Dominio;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Api.Funcionalidades.Usuarios;

public interface IUsuarioService
{
    IEnumerable<UsuarioQueryResponseDto> GetAllUsuarios();
    UsuarioQueryResponseDto GetUsuarioById(Guid idUsuario);
    UsuarioCommandResponseDto CreateUsuario(UsuarioCommandRequestDto nuevoUsuario);
    UsuarioCommandResponseDto AssignRolToUsuario(Guid idUsuario, Guid idRol);
    Usuario GetAllRoles(Guid idUsuario);
}

public class UsuarioService : IUsuarioService
{
    private readonly AplicacionDbContext context;

    public UsuarioService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public UsuarioCommandResponseDto AssignRolToUsuario(Guid idUsuario, Guid idRol)
    {
        var usuario = context.Usuarios.Single(x => x.Id == idUsuario);

        var rol = context.Roles.Single(x => x.Id == idRol);

        var administrador = new AdministradorRol();

        administrador.AsignarRol(usuario, rol);

        context.SaveChanges();

        return usuario.Adapt<UsuarioCommandResponseDto>();
    }

    public UsuarioCommandResponseDto CreateUsuario(UsuarioCommandRequestDto usuario)
    {
        var nuevoUsuario = usuario.Adapt<Usuario>();

        var administrador = context.Administradores.Single(x => x.Id == usuario.IdAdministrador);

        nuevoUsuario.AsignarDatosCreacion(administrador);

        context.Usuarios.Add(nuevoUsuario);

        context.SaveChanges();

        return nuevoUsuario.Adapt<UsuarioCommandResponseDto>();
    }

    public Usuario GetAllRoles(Guid idUsuario)
    {
        return context.Usuarios
            .Where(x => x.Id == idUsuario)
            .Include(x => x.Roles)
            .Single();
    }

    public IEnumerable<UsuarioQueryResponseDto> GetAllUsuarios()
    {
        return context.Usuarios.Adapt<IEnumerable<UsuarioQueryResponseDto>>();
    }

    public UsuarioQueryResponseDto GetUsuarioById(Guid idUsuario)
    {
        return context.Usuarios.SingleOrDefault(u => u.Id == idUsuario).Adapt<UsuarioQueryResponseDto>();
    }
}
