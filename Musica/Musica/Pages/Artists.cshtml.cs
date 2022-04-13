using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Musica
{
    public class ArtistsModel : PageModel
    {
        [BindProperty]
        public string SearchedArtist { get; set; }
        [BindProperty]
        public ArtistSearch Artist { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            var x = new ApiCaller();
            if (SearchedArtist != null)
            {
                Artist = x.GetArtistData(SearchedArtist);
            }

            return Page();
        }
    }
}
