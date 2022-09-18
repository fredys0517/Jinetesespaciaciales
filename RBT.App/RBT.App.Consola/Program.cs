using System;
using RBT.App.Dominio;
using RBT.App.Persistencia;

namespace RBT.App.Consola
{
    class Program
    {
        private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(
            new Persistencia.AppContext()
        );

        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World Entity Framework!");
            //AgregarAuxiliar();
            Buscar(1);
        }
    
        private static void AgregarAuxiliar() 
        {
            var auxiliar = new Auxiliar
            {
                Nombres = "Pedro",
                Apellidos = "Perez",
                Telefono = "0123456789",
                FechaNacimiento = "10/10/2010",
            };
            _repositorioAuxiliar.AgregarAuxiliar(auxiliar);
        }
        
        private static void Buscar(int idAuxiliar)
        {
            var auxiliar = _repositorioAuxiliar.ObtenerAuxiliar(idAuxiliar);
            Console.WriteLine(auxiliar.Nombres+" "+auxiliar.Apellidos);
        }
    
    }

    //private static void IRepositorioAuxiliar.AgregarAuxiliar(RBT.App.Dominio.Auxiliar auxiliar);

    
}
