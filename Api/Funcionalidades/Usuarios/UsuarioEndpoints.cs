using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Usuarios;
public class UsuarioEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/usuario", ([FromServices] IUsuarioService usuarioService, ILogger<UsuarioEndpoints> logger) =>
        {
            logger.LogInformation("GetAllUsuarios");
            return Results.Ok(usuarioService.GetAllUsuarios());
        });

        app.MapGet("/api/usuario/{id}", ([FromServices] IUsuarioService usuarioService, Guid idUsuario) =>
        {
            return Results.Ok(usuarioService.GetUsuarioById(idUsuario));
        });

        app.MapPost("/api/usuario", ([FromServices] IUsuarioService usuarioService, UsuarioCommandRequestDto nuevoUsuario) =>
        {
            return Results.Ok(usuarioService.CreateUsuario(nuevoUsuario));
        });
    }
}