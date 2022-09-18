using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RBT.App.Frontend.Pages.VehiculoPage
{
    public class Vehiculo : PageModel
    {
        private readonly ILogger<Vehiculo> _logger;

        public Vehiculo(ILogger<Vehiculo> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}