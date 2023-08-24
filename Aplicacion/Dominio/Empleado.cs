namespace Aplicacion.Dominio;
public class Empleado : EntidadBase
{
    public string Apellido { get; set; }
    public string Email { get; set; }
    public Usuario? Usuario { get; set; }

    public Empleado(string nombre, string apellido, string email)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Email = email;
    }
}