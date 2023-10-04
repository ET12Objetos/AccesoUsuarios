using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Infraestructura
{
    public class AplicacionDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
