using System.ComponentModel.DataAnnotations.Schema;
using Aplicacion.Dominio.Abstract;

namespace Aplicacion.Dominio;

[Table("Rol")]
public class Rol : EntidadBase
{
    [ForeignKey("AdministradorUsuario")]
    public List<Usuario> Usuarios { get; private set; } = new List<Usuario>();

    public Rol(string nombre) { this.Nombre = nombre; }
    public Rol() { }

    public void Habilitar() => this.Habilitado = true;
    public void Deshabilitar() => this.Habilitado = false;
}