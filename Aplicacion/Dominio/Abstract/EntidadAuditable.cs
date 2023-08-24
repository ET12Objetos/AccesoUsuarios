namespace Aplicacion.Dominio.Abstract;
public abstract class EntidadAuditable
{
    public DateTime FechaCreacion { get; private set; }
    public string UsuarioCreacion { get; private set; }
    public DateTime FechaModificacion { get; private set; }
    public string UsuarioModificacion { get; private set; }

    public EntidadAuditable()
    {

    }

    public void Crear(string usuario)
    {
        FechaCreacion = DateTime.Now;
        UsuarioCreacion = usuario;
    }

    public void Actualizar(string usuario)
    {
        FechaModificacion = DateTime.Now;
        UsuarioModificacion = usuario;
    }
}