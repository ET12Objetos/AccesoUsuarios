namespace Aplicacion.Dominio;
public class AdministradorUsuario : Administrador
{
    public AdministradorUsuario() { }

    public Administrador CrearUsuario(string nombre, string contraseña) => new(nombre, contraseña);

    // public Usuario BuscarUsuario(string nombre)
    //     => Usuarios.First(x => x.Nombre.Equals(nombre));
}