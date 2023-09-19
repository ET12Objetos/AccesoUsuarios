namespace Aplicacion.Dominio;
public abstract class Administrador : Usuario
{
    public List<Rol> RolesExistentes { get; private set; }
    public List<Usuario> Usuarios { get; private set; }
    public Administrador(string nombre, string contraseña)
    : base(nombre, contraseña)
    {
        RolesExistentes = new List<Rol>();
        Usuarios = new List<Usuario>();
    }
}