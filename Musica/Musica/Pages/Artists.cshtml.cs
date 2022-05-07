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
        public User GetUser() => CookiesManager.GetUserByCookies(HttpContext.Request, _context);

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var apiCaller = new ApiCaller();
            if (SearchedArtist != null)
            {
                Artist = apiCaller.GetArtistData(SearchedArtist);
                if (_context.Artists.Where(x => x.id == Artist.Artist.id).SingleOrDefault() == default)
                    _context.Artists.Add(Artist.Artist);
                if (GetUser() != null)
                {
                    if (_context.UsersArtists.Where(x => x.IdArtist == Artist.Artist.id && x.IdUser == GetUser().Id).SingleOrDefault() == default)
                        _context.UsersArtists.Add(new UserArtist() { Id = Guid.NewGuid().ToString(), IdArtist = Artist.Artist.id, IdUser = GetUser().Id });
                }
            }

            foreach (var s in Artist.Songs)
            {
                if (_context.Songs.Where(x => x.id == s.id).SingleOrDefault() == default)
                    _context.Songs.Add(s);
                if (GetUser() != null)
                {
                    if (_context.UsersSongs.Where(x => x.IdSong == s.id && x.IdUser == GetUser().Id).SingleOrDefault() == default)
                        _context.UsersSongs.Add(new UserSong() { Id = Guid.NewGuid().ToString(), IdSong = s.id, IdUser = GetUser().Id });
                }
                _context.SaveChangesAsync();
            }

            return Page();
        }
    }
}
