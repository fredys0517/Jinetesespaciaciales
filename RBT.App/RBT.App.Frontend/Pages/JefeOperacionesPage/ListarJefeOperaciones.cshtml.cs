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

namespace RBT.App.Frontend.Pages.JefeOperacionesPage
{
    public class ListarJefeOperaciones : PageModel
    {
        private readonly IRepositorioJefeOperaciones repositorioJefeOperaciones = new RepositorioJefeOperaciones(new Persistencia.AppContext());
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public IEnumerable<JefeOperaciones> ListaJefesOperaciones { get; set; }

        public void OnGet()
        {
            ListaJefesOperaciones = repositorioJefeOperaciones.ListarJefeOperacionesAll();
        }
        
        // Esta es la accion del boton eliminar--------------
        public IActionResult OnPost(int numeroId)
        {
            repositorioJefeOperaciones.EliminarJefeOperaciones(numeroId);
            return RedirectToAction("Get");
        }

       
    }
}