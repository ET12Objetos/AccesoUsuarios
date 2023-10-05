using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Administrador")]
public class Administrador : Usuario
{
    public Administrador() { }
    public Administrador(string nombre, string contraseña) : base(nombre, contraseña)
    {
    }
    public void AsignarDatosCreacion()
    {
        UsuarioCreacion = Nombre;
        FechaCreacion = DateTime.Now;
    }
}