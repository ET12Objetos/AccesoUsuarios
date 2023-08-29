using Aplicacion.Dominio.Abstract;

namespace Aplicacion.Dominio;
public class Usuario : EntidadBase
{
    public string Contraseña { get; set; }
    public List<Rol> RolesAsignados { get; protected set; }

    public Usuario(string nombre, string contraseña) : base(nombre)
    {
        this.Contraseña = contraseña;
        this.RolesAsignados = new List<Rol>();
    }

    // public void Habilitar() => this.Habilitado = true;
    // public void Deshabilitar() => this.Habilitado = false;
    // public void CambiarContraseña(string nuevaContraseña) => this.Contraseña = nuevaContraseña;

    // public void AsignarRol(Rol rol)
    // {
    //     this.Roles.Add(rol);
    // }

    // public void BorrarRol(string nombre)
    // {
    //     Rol rol = Roles.First(x => x.Nombre.Equals(nombre));
    //     Roles.Remove(rol);
    // }
}