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

namespace RBT.App.Frontend.Pages.MecanicoPage
{
    public class ListarMecanico : PageModel
    {
       private readonly IRepositorioMecanico repositorioMecanico = new RepositorioMecanico(new Persistencia.AppContext());
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public IEnumerable<Mecanico> ListaMecanicoes { get; set; }

        public void OnGet()
        {
            ListaMecanicoes = repositorioMecanico.ListarMecanicoAll();
        }
        
        // Esta es la accion del boton eliminar--------------
        public IActionResult OnPost(int numeroId)
        {
            repositorioMecanico.EliminarMecanico(numeroId);
            return RedirectToAction("Get");
        }
        //----------------------------------------------------
    }
}

    
