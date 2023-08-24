namespace Aplicacion.Dominio.Abstract;
public abstract class EntidadBase : EntidadAuditable
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public string Nombre { get; protected set; }
    public bool Habilitado { get; protected set; } = false;

    public EntidadBase(string nombre) => Nombre = nombre;
}