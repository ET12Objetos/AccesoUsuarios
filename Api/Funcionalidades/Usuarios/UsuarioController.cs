using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Usuarios;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
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
}0