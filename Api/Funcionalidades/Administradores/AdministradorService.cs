using Api.Persistencia;
using Aplicacion.Dominio;
using Mapster;

namespace Api.Funcionalidades.Administradores;

public interface IAdministradorService
{
    AdministradorCommandResponseDto CreateAdministrador(AdministradorCommandRequestDto administradorDto);
    IEnumerable<AdministradorQueryResponseDto> GetAllAdministradores();
}

public class AdministradorService : IAdministradorService
{
    private readonly AplicacionDbContext context;

    public AdministradorService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public AdministradorCommandResponseDto CreateAdministrador(AdministradorCommandRequestDto administradorDto)
    {
        var nuevoAdministrador = administradorDto.Adapt<Administrador>();

        nuevoAdministrador.AsignarDatosCreacion();

        context.Administradores.Add(nuevoAdministrador);

        context.SaveChanges();

        return nuevoAdministrador.Adapt<AdministradorCommandResponseDto>();
    }

    public IEnumerable<AdministradorQueryResponseDto> GetAllAdministradores()
    {
        return context.Administradores.Adapt<IEnumerable<AdministradorQueryResponseDto>>();
    }
}