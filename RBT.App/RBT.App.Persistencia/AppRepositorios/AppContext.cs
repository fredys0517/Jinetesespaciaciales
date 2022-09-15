using Microsoft.EntityFrameworkCore;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class AppContext : DbContext
    {
        
       
        public DbSet<Mecanico> Mecanicos {get;set;}
        public DbSet<Auxiliar> Auxiliares {get;set;}
        public DbSet<JefeOperaciones> JefesOperaciones {get;set;}
        
        public DbSet<Propietario> Propietarios {get;set;}
       
        public DbSet<UsuarioApp> UsuariosApp {get;set;}
      
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DATA2-RBT");
            }   

        }
        

    }
}
