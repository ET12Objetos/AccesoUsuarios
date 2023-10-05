using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidad;
public class UsuarioEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/usuario", ([FromServices] IUsuarioService usuarioService) =>
       {
           return Results.Ok(usuarioService.GetUsuarios());
       });
    }
}