using Api.Infraestructura;
using Aplicacion.Dominio;
using Mapster;

namespace Api.Funcionalidades.Usuarios;

public interface IUsuarioService
{
    IEnumerable<UsuarioQueryResponseDto> GetAllUsuarios();
}

public class UsuarioService : IUsuarioService
{
    private readonly AplicacionDbContext aplicacionDbContext;

    List<Usuario> usuarios;

    public UsuarioService(AplicacionDbContext aplicacionDbContext)
    {
        this.aplicacionDbContext = aplicacionDbContext;

        usuarios = new List<Usuario>() {
            new Usuario("Luciano", "1234"),
            new Usuario("Ulises", "asdasd"),
            new Usuario("Roque", "zxczxcz"),
        };
    }

    public IEnumerable<UsuarioQueryResponseDto> GetAllUsuarios()
    {
        //return aplicacionDbContext.Usuarios.Adapt<IEnumerable<UsuarioQueryResponseDto>>();
        return usuarios.Adapt<IEnumerable<UsuarioQueryResponseDto>>();
    }
}
