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
    public class editarVehiculo : PageModel
    {
      
        
        private readonly IRepositorioVehiculo repositorioVehiculo = new RepositorioVehiculo(
            new Persistencia.AppContext()
        );
        [BindProperty]
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public Vehiculo EditarVehi { get; set; }

        public IActionResult OnGet(int VehiculoId)
        {
            
            EditarVehi=repositorioVehiculo.ObtenerVehiculo(VehiculoId);
            return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            return Page();
            repositorioVehiculo.ActualizarVehiculo(EditarVehi);
            return RedirectToPage("./ListarVehiculo");
        }  
    }
}