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
//using RBT.App.Persistencia.AppRepositorios;


namespace RBT.App.Frontend.Pages.BuscarPage
{
    public class BuscarEntidades : PageModel
    {
        private readonly ILogger<BuscarEntidades> _logger;

        public BuscarEntidades(ILogger<BuscarEntidades> logger)
        {
            _logger = logger;
        }
        //---------------------------------------------------------//


        //DECLARAR UNA REFERENCIA DE SOLO LECTURA DEL TIPO REPOSITORIO DE AUXILIAR
        private readonly IRepositorioAuxiliar repositorioAuxiliar;

        //CONSTRUCTOR DE SOLO EL REPOSITORIO
        public BuscarEntidades(IRepositorioAuxiliar repositorioAuxiliar)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        // CONSTRUCTOR INCLUYENDO LA PROPIEDAD LOGGER Y LA LISTA
        /*public BuscarEntidades(ILogger<BuscarEntidades> logger, IRepositorioAuxiliar repositorioAuxiliar, IEnumerable<Auxiliar> listaAuxiliares) : this(logger)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
            ListaAuxiliares = listaAuxiliares;
        }*/

        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public IEnumerable<Auxiliar> ListaAuxiliares {get;set;}



        public void OnGet()
        {
            ListaAuxiliares=repositorioAuxiliar.ListarAuxiliarAll();
        }
    }
}