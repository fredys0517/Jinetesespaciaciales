using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RBT.App.Frontend.Pages.AuxiliarPage
{
    public class AuxiliarPage : PageModel
    {
        private readonly ILogger<AuxiliarPage> _logger;

        public AuxiliarPage(ILogger<AuxiliarPage> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}