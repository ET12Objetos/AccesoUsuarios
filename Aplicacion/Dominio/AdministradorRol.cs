namespace Aplicacion.Dominio;
public class AdministradorRol : Administrador
{
    public AdministradorRol() { }

    public void AsignarRol(Usuario usuario, Rol rol)
        => usuario.Roles.Add(rol);

    public Rol BuscarRol(string nombre)
        => Roles.First(x => x.Nombre.Equals(nombre));

    public void CrearRol(string nombre)
    {
        Rol nuevoRol = new Rol(nombre);
        Roles.Add(nuevoRol);
    }

    public void BorrarRol(string nombre)
    {
        Rol rol = Roles.First(x => x.Nombre.Equals(nombre));
        Roles.Remove(rol);
    }
}