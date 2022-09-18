using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RBT.App.Frontend.Pages.SoatPage
{
    public class Soat : PageModel
    {
        private readonly ILogger<Soat> _logger;

        public Soat(ILogger<Soat> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}