namespace Aplicacion.Dominio;
public class Administrador : Usuario
{
    public List<Rol> RolesExistentes { get; private set; }
    public List<Usuario> Usuarios { get; private set; }
    public Administrador(string nombre, string contraseña)
    : base(nombre, contraseña)
    {
        RolesExistentes = new List<Rol>();
        Usuarios = new List<Usuario>();
    }

    public void CrearUsuario(string nombre, string contraseña)
        => Usuarios.Add(new Usuario(nombre, contraseña));

    public Usuario BuscarUsuario(string nombre)
        => Usuarios.First(x => x.Nombre.Equals(nombre));

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