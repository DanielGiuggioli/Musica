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
        private readonly MusicaDbContext _context;
        public SongsModel(MusicaDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string SearchedSong { get; set; }
        [BindProperty]
        public IList<Song> Songs { get; set; }
        public User GetUser() => CookiesManager.GetUserByCookies(HttpContext.Request, _context);
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var apiCaller = new ApiCaller();
            if (SearchedSong != null)
            {
                Songs = apiCaller.GetSongs(SearchedSong);
                foreach(var s in Songs)
                {
                    if (_context.Songs.Where(x => x.id == s.id).SingleOrDefault() == default)
                        _context.Songs.Add(s);
                    if (_context.UsersSongs.Where(x => x.IdUser == GetUser().Id && x.IdSong == s.id).SingleOrDefault() == default)
                        _context.UsersSongs.Add(new UserSong() { Id = Guid.NewGuid().ToString(), IdSong = s.id, IdUser = GetUser().Id });
                    _context.SaveChanges();
                }    
            }
            return Page();
        }
    }
}
