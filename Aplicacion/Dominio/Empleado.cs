using Aplicacion.Dominio.Abstract;

namespace Aplicacion.Dominio;
public class Empleado : EntidadBase
{
    public string Apellido { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Usuario? Usuario { get; set; }

    public Empleado() { }
}