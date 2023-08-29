using Aplicacion.Dominio.Abstract;

namespace Aplicacion.Dominio;
public class Rol : EntidadBase
{
    public Rol(string nombre) : base(nombre)
    {
    }

    // public void Habilitar() => this.Habilitado = true;
    // public void Deshabilitar() => this.Habilitado = false;
}