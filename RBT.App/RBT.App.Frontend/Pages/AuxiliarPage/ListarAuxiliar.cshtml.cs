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

namespace RBT.App.Frontend.Pages.AuxiliarPage
{
    public class ListarAuxiliar : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar = new RepositorioAuxiliar(new Persistencia.AppContext());
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public IEnumerable<Auxiliar> ListaAuxiliares { get; set; }

        public void OnGet()
        {
            ListaAuxiliares = repositorioAuxiliar.ListarAuxiliarAll();
        }
        
        // Esta es la accion del boton eliminar--------------
        public IActionResult OnPost(int numeroId)
        {
            repositorioAuxiliar.EliminarAuxiliar(numeroId);
            return RedirectToAction("Get");
        }
        //----------------------------------------------------
    }
}
