using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Musica
{
    public class SongsModel : PageModel
    {
        [BindProperty]
        public string SearchedSong { get; set; }
        [BindProperty]
        public IList<Song> Songs { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var apiCaller = new ApiCaller();
            if (SearchedSong != null)
            {
                Songs = apiCaller.GetSongs(SearchedSong);
            }

            return Page();
        }
    }
}
