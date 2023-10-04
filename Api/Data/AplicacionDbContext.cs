using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class AplicacionDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
