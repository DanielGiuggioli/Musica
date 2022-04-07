using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musica.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            var x = new ApiCaller();
            string result = x.GetArtistCodeAsync("Lana Del Rey").Result;
            x.GetArtistDataAsync("16775");
        }

        public void OnGet()
        {

        }
    }
}
