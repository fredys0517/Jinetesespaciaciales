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

namespace RBT.App.Frontend.Pages.ReparacionPage
{
    public class ListarReparaciones : PageModel
    {
        
       private readonly IRepositorioReparacion repositorioReparacion = new RepositorioReparacion(new Persistencia.AppContext());
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public IEnumerable<Reparacion> ListaReparaciones { get; set; }

        public void OnGet()
        {
            ListaReparaciones = repositorioReparacion.ListarReparacionAll();
        }
        
        // Esta es la accion del boton eliminar--------------
        public IActionResult OnPost(int repId)
        {
            repositorioReparacion.EliminarReparacion(repId);
            return RedirectToAction("Get");
        }
        //----------------------------------------------------
    }
}