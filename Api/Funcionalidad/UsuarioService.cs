using Aplicacion.Dominio;

namespace Api.Funcionalidad;

public interface IUsuarioService
{
    List<Usuario> GetUsuarios();
}

public class UsuarioService : IUsuarioService
{
    public List<Usuario> GetUsuarios()
    {
        var usuarios = new List<Usuario>() {
                new Usuario("Luciano", "1234"),
                new Usuario("Ulises", "asdasd"),
                new Usuario("Roque", "zxczxcz")
            };

        return usuarios;
    }
}