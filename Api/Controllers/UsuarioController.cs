using Api.ViewModels;
using Aplicacion.Dominio;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    List<Usuario> usuarios;

    public UsuarioController()
    {
        usuarios = new List<Usuario>() {
            new Usuario("Luciano", "1234"),
            new Usuario("Ulises", "asdasd"),
            new Usuario("Roque", "zxczxcz"),
        };
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(usuarios);
    }

    [HttpPost]
    public ActionResult Post(UsuarioViewModel usuario)
    {
        return Ok("Usuario creado");
    }

    [HttpPut]
    public ActionResult Put(int idUsuario, UsuarioViewModel usuario)
    {
        return Ok("Usuario actualizado");
    }

    [HttpDelete]
    public ActionResult Delete(int idUsuario)
    {
        return Ok("Usuario eliminado");
    }
}