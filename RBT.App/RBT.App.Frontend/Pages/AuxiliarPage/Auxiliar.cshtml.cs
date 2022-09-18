using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RBT.App.Frontend.Pages.AuxiliarPage
{
    public class Auxiliar : PageModel
    {
        private readonly ILogger<Auxiliar> _logger;

        public Auxiliar(ILogger<Auxiliar> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}