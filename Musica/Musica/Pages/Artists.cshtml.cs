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
        private readonly MusicaDbContext _context;
        public ArtistsModel(MusicaDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string SearchedArtist { get; set; }
        [BindProperty]
        public ArtistSearch Artist { get; set; }
        public User User { get; set; }
        public void OnGet()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
        }
        public IActionResult OnPost()
        {
            var apiCaller = new ApiCaller();
            if (SearchedArtist != null)
            {
                Artist = apiCaller.GetArtistData(SearchedArtist);
                if (_context.Artists.Where(x => x.id == Artist.Artist.id).SingleOrDefault() == default)
                    _context.Artists.Add(Artist.Artist);
                foreach (var s in Artist.Songs)
                {
                    if (_context.Songs.Where(x => x.id == s.id).SingleOrDefault() == default)
                        _context.Songs.Add(s);
                }
                _context.SaveChangesAsync();
            }
            

            return Page();
        }
    }
}
