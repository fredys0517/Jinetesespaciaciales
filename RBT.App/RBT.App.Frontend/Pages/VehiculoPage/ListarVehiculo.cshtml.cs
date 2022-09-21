using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

//---------------------------------------
using RBT.App.Dominio;
using RBT.App.Persistencia;

namespace RBT.App.Frontend.Pages.VehiculoPage
{
    public class ListarVehiculo : PageModel
    {
        
       private readonly IRepositorioVehiculo repositorioVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public IEnumerable<Vehiculo> ListaVehiculo { get; set; }

        public void OnGet()
        {
            ListaVehiculo = repositorioVehiculo.ListarVehiculoAll();
        }
        
        // Esta es la accion del boton eliminar--------------
        public IActionResult OnPost(int numeroId)
        {
            repositorioVehiculo.EliminarVehiculo(numeroId);
            return RedirectToAction("Get");
        }
        //----------------------------------------------------
    }
}