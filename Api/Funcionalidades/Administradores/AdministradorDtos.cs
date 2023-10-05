namespace Api.Funcionalidades.Administradores;
public class AdministradorCommandRequestDto
{
    public required string Nombre { get; set; }
    public required string Contraseña { get; set; }
}

public class AdministradorQueryResponseDto
{
    public Guid Id { get; set; }
    public required string Nombre { get; set; }
    public required string Contraseña { get; set; }
}

public class AdministradorCommandResponseDto : AdministradorQueryResponseDto
{

}