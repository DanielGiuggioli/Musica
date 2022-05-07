using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Musica.Pages
{
    public class SongDetailModel : PageModel
    {
        private readonly MusicaDbContext _context;
        public SongDetailModel(MusicaDbContext context)
        {
            _context = context;
        }
        public Song Song { get; set; }
        public string Lyrics { get; set; }
        public User GetUser() => CookiesManager.GetUserByCookies(HttpContext.Request, _context);
        public void OnGet(int? id)
        {
            if (id != null)
            {
                Song = _context.Songs.SingleOrDefault(x => x.id == id);
                Lyrics = new LyricsScreper().GetLyricsByUrl(Song.url);
                
            }
        }
    }
}
