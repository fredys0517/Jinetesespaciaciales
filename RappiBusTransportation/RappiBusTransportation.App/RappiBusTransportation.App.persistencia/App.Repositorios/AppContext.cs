using Microsoft.EntityFrameworkCore;
using RappiBusTransportation.App.Dominio;
using RappiBusTransportation.App.Persistencia;

namespace RappiBusTransportation.App.persistencia
{
    public class AppContext : DbContext
    {
        public Dbset<Persona> Personas{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = RappiBusTransportationData");
            }   

        }


    }
}