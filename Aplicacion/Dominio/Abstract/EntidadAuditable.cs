namespace Aplicacion.Dominio.Abstract;
public abstract class EntidadAuditable
{
    public DateTime FechaCreacion { get; protected set; } = DateTime.Now;
    public string UsuarioCreacion { get; protected set; } = string.Empty;
    public DateTime FechaModificacion { get; protected set; }
    public string UsuarioModificacion { get; protected set; } = string.Empty;

    public void Actualizar(string usuarioModificacion)
    {
        this.FechaModificacion = DateTime.Now;
        this.UsuarioModificacion = usuarioModificacion;
    }
}