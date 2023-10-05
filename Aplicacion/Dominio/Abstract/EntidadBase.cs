using System.ComponentModel.DataAnnotations;

namespace Aplicacion.Dominio.Abstract;
public abstract class EntidadBase : EntidadAuditable
{
    [Key]
    public Guid Id { get; protected set; } = Guid.NewGuid();

    [Required]
    [MaxLength(50)]
    public string Nombre { get; protected set; } = string.Empty;

    [Required]
    public bool Habilitado { get; protected set; } = false;

    public EntidadBase(string nombre)
    {
        Nombre = nombre;
        UsuarioCreacion = nombre;
    }

    public EntidadBase() { }

    public void AsignarDatosCreacion(Administrador administrador)
    {
        UsuarioCreacion = administrador.Nombre;
    }
}