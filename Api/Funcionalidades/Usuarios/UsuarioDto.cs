using Aplicacion.Dominio;

namespace Api.Funcionalidades.Usuarios;

public class UsuarioCommandRequestDto
{
    public required string Nombre { get; set; }
    public required string Contraseña { get; set; }
    public required Guid IdAdministrador { get; set; }
}

public class UsuarioQueryResponseDto
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Contraseña { get; set; }
}

public class UsuarioCommandResponseDto : UsuarioQueryResponseDto
{

}