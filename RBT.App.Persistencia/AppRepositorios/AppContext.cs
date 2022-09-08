using Microsoft.EntityFrameworkCore;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class AppContext : DbContext
    {
        
        public DbSet<Persona> Persona {get;set;}       
        public DbSet<Mecanico> Mecanico {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DATA_RBT1");
            }   

        }
        

    }
}