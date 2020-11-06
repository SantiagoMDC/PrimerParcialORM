using Microsoft.EntityFrameworkCore;
using Entidad;

namespace Datos
{
    public class AyudasContext: DbContext
    {
        public AyudasContext(DbContextOptions options):base(options)
        {
            
        }
        
        public DbSet<Persona>personas{get;set;}
    }
}