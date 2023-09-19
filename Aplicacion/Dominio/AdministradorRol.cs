namespace Aplicacion.Dominio;
public class AdministradorRol : Administrador
{
    public AdministradorRol(string nombre, string contraseña)
        : base(nombre, contraseña)
    {
    }

    public void AsignarRol(Usuario usuario, Rol rol)
        => usuario.RolesAsignados.Add(rol);

    public Rol BuscarRol(string nombre)
        => RolesExistentes.First(x => x.Nombre.Equals(nombre));

    public void CrearRol(string nombre)
    {
        Rol nuevoRol = new Rol(nombre);
        RolesExistentes.Add(nuevoRol);
    }

    public void BorrarRol(string nombre)
    {
        Rol rol = RolesExistentes.First(x => x.Nombre.Equals(nombre));
        RolesExistentes.Remove(rol);
    }
}