using Microsoft.EntityFrameworkCore;
namespace CatalogoLibreria.Modelos

{
    public class LibreriaDBContext : DbContext
    {
        public LibreriaDBContext(DbContextOptions<LibreriaDBContext> options): base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
       
    }
    
    }

    