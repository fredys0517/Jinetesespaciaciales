using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
//--------------------------------
using RBT.App.Dominio;
using RBT.App.Persistencia;

namespace RBT.App.Frontend.Pages.MantenimientoPage
{
    public class ListarMantenimiento : PageModel
    {
        private readonly IRepositorioMantenimiento repositorioMantenimiento = new RepositorioMantenimiento(new Persistencia.AppContext());
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public IEnumerable<Mantenimiento> ListaMantenimiento { get; set; }

        public void OnGet()
        {
            ListaMantenimiento = repositorioMantenimiento.ListarMantenimientoAll();
        }
        
        // Esta es la accion del boton eliminar--------------
        public IActionResult OnPost(int numeroId)
        {
            repositorioMantenimiento.EliminarMantenimiento(numeroId);
            return RedirectToAction("Get");
        }
    }
}