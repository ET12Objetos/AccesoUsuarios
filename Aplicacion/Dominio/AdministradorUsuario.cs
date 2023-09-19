namespace Aplicacion.Dominio;
public class AdministradorUsuario : Administrador
{
    public AdministradorUsuario(string nombre, string contraseña)
        : base(nombre, contraseña)
    {
    }

    public void CrearUsuario(string nombre, string contraseña)
        => Usuarios.Add(new Usuario(nombre, contraseña));

    public Usuario BuscarUsuario(string nombre)
        => Usuarios.First(x => x.Nombre.Equals(nombre));
}