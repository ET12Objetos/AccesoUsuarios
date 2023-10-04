using Aplicacion.Dominio;
using Mapster;

namespace Api.Funcionalidades.Usuarios;

public interface IUsuarioService
{
    IEnumerable<UsuarioQueryResponseDto> GetAllUsuarios();
    UsuarioQueryResponseDto GetUsuarioById(Guid idUsuario);
    UsuarioCommandResponseDto CreateUsuario(UsuarioCommandRequestDto nuevoUsuario);
}

public class UsuarioService : IUsuarioService
{
    List<Usuario> usuarios;

    public UsuarioService()
    {
        usuarios = new List<Usuario>() {
            new Usuario("Luciano", "1234"),
            new Usuario("Ulises", "asdasd"),
            new Usuario("Roque", "zxczxcz"),
        };
    }

    public UsuarioCommandResponseDto CreateUsuario(UsuarioCommandRequestDto usuario)
    {
        var nuevoUsuario = usuario.Adapt<Usuario>();

        usuarios.Add(nuevoUsuario);

        return nuevoUsuario.Adapt<UsuarioCommandResponseDto>();
    }

    public IEnumerable<UsuarioQueryResponseDto> GetAllUsuarios()
    {
        return usuarios.Adapt<IEnumerable<UsuarioQueryResponseDto>>();
    }

    public UsuarioQueryResponseDto GetUsuarioById(Guid idUsuario)
    {
        return usuarios.SingleOrDefault(u => u.Id == idUsuario).Adapt<UsuarioQueryResponseDto>();
    }
}
