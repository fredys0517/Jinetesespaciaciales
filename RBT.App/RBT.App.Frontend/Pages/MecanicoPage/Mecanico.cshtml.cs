using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RBT.App.Frontend.Pages.MecanicoPage
{
    public class Mecanico : PageModel
    {
        private readonly ILogger<Mecanico> _logger;

        public Mecanico(ILogger<Mecanico> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}