using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Aplicacion.Dominio.Abstract;

namespace Aplicacion.Dominio;

[Table("Usuario")]
public class Usuario : EntidadBase
{
    [Required]
    [MaxLength(50)]
    public string Contraseña { get; protected set; } = string.Empty;

    [ForeignKey("UsuarioAsignado")]
    public List<Rol> Roles { get; protected set; } = new List<Rol>();

    public Usuario() { }

    public Usuario(string nombre, string contraseña) : base(nombre)
    {
        this.Contraseña = contraseña;
        this.Roles = new List<Rol>();
    }

    public void Habilitar() => this.Habilitado = true;
    public void Deshabilitar() => this.Habilitado = false;
    public void CambiarContraseña(string nuevaContraseña) => this.Contraseña = nuevaContraseña;
}