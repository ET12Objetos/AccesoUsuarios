using Aplicacion.Dominio;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Usuarios;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    List<Usuario> usuarios;
    private readonly IUsuarioService usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        usuarios = new List<Usuario>() {
            new Usuario("Luciano", "1234"),
            new Usuario("Ulises", "asdasd"),
            new Usuario("Roque", "zxczxcz"),
        };
        this.usuarioService = usuarioService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<UsuarioQueryResponseDto>> Get()
    {
        return Ok(usuarioService.GetAllUsuarios());
    }

    [HttpPost]
    public ActionResult Post(UsuarioDto usuario)
    {
        return Ok("Usuario creado");
    }

    [HttpPut]
    public ActionResult Put(int idUsuario, UsuarioDto usuario)
    {
        return Ok("Usuario actualizado");
    }

    [HttpDelete]
    public ActionResult Delete(int idUsuario)
    {
        return Ok("Usuario eliminado");
    }
}