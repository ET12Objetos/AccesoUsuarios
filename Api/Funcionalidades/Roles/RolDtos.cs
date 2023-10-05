namespace Api.Funcionalidades.Roles;

public class RolCommandRequestDto
{
    public required string Nombre { get; set; }
    public required Guid IdAdministrador { get; set; }
}

public class RolQueryResponseDto
{
    public Guid Id { get; set; }
    public required string Nombre { get; set; }
}

public class RolCommandResponseDto : RolQueryResponseDto
{

}