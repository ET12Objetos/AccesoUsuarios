using Aplicacion.Dominio.Abstract;

namespace Aplicacion.Dominio;
public class Usuario : EntidadBase
{
    public string Contraseña { get; set; } = string.Empty;
    public List<Rol> RolesAsignados { get; protected set; } = new List<Rol>();

    public Usuario()
    {

    }

    public Usuario(string nombre, string contraseña) : base(nombre)
    {
        this.Contraseña = contraseña;
        this.RolesAsignados = new List<Rol>();
        this.Crear("Administrador");
    }

    public void Habilitar() => this.Habilitado = true;
    public void Deshabilitar() => this.Habilitado = false;
    public void CambiarContraseña(string nuevaContraseña) => this.Contraseña = nuevaContraseña;
}