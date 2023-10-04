using Api.Infraestructura;
using Mapster;

namespace Api.Funcionalidades.Usuarios;

public interface IUsuarioService
{
    IEnumerable<UsuarioQueryResponseDto> GetAllUsuarios();
}

public class UsuarioService : IUsuarioService
{
    private readonly AplicacionDbContext aplicacionDbContext;

    public UsuarioService(AplicacionDbContext aplicacionDbContext)
    {
        this.aplicacionDbContext = aplicacionDbContext;
    }

    public IEnumerable<UsuarioQueryResponseDto> GetAllUsuarios()
    {
        return aplicacionDbContext.Usuarios.Adapt<IEnumerable<UsuarioQueryResponseDto>>();
    }
}
