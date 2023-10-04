using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Usuarios;
public static class UsuarioEndpoints
{
    public static void MapUsuarioEndpoints(this WebApplication app)
    {
        app.MapGet("/api/usuario", ([FromServices] IUsuarioService usuarioService) =>
        {
            return Results.Ok(usuarioService.GetAllUsuarios());
        });

        app.MapGet("/api/usuario/{id}", ([FromServices] IUsuarioService usuarioService, Guid idUsuario) =>
        {
            return Results.Ok(usuarioService.GetUsuarioById(idUsuario));
        });

        app.MapPost("/api/usuario", ([FromServices] IUsuarioService usuarioService, UsuarioCommandRequestDto nuevoUsuario) => { return Results.Ok(usuarioService.CreateUsuario(nuevoUsuario)); });
    }
}