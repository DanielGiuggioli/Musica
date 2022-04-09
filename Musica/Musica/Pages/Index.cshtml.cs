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
        public IndexModel()
        {
            //new ApiCaller().GetArtistDataAsync("1227429");
        }
        [BindProperty]
        public string Artist { get; set; }
        [BindProperty]
        public string Result { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            var x = new ApiCaller();
            if(Artist != null)
                Result = x.GetArtistCodeAsync(Artist).Result;
            return Page();
        }
    }
}
