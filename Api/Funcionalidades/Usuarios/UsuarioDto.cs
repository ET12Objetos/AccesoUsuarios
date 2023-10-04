namespace Api.Funcionalidades.Usuarios;

public class UsuarioRequestDto
{
    public required string Nombre { get; set; }
}
public class UsuarioDto : UsuarioRequestDto
{
    public int Id { get; set; }
}

public class UsuarioQueryResponseDto : UsuarioDto
{

}

public class UsuarioCommandResponseDto
{

}