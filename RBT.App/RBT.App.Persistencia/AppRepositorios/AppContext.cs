using Microsoft.EntityFrameworkCore;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class AppContext : DbContext
    {
        
       
        
        public DbSet<Auxiliar> Auxiliares {get;set;}
        public DbSet<JefeOperaciones> JefesOperaciones {get;set;}
        public DbSet<Propietario> Propietarios {get;set;}
        public DbSet<UsuarioApp> UsuariosApp {get;set;}
        public DbSet<Mecanico> Mecanicos {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}
        public DbSet<Mantenimiento> Mantenimientos {get;set;}
        public DbSet<Reparacion> Reparaciones {get;set;}
        public DbSet<Soat> Soats {get;set;}
        

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
