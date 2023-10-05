using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Administradores;
public class AdministradorEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/administrador", ([FromServices] IAdministradorService administradorService) =>
        {
            return Results.Ok(administradorService.GetAllAdministradores());
        });

        app.MapPost("/api/administrador", ([FromServices] IAdministradorService administradorService, AdministradorCommandRequestDto administradorDto) =>
        {
            return Results.Ok(administradorService.CreateAdministrador(administradorDto));
        });
    }
}