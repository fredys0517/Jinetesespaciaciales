using System;
using RBT.App.Dominio;
using RBT.App.Persistencia;

namespace RBT.App.Consola
{
    class Program
    {
        private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Persistencia.AppContext());
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World Entity Framework!");
        }
    }

    //private static void IRepositorioAuxiliar.AgregarAuxiliar(RBT.App.Dominio.Auxiliar auxiliar);

    

}

