using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
        public User GetUser() => CookiesManager.GetUserByCookies(HttpContext.Request, _context);
        public void OnGet(int? id)
        {
            if (id != null)
            {
                Song = _context.Songs.SingleOrDefault(x => x.id == id);
                if(Song.Lyrics == null)
                {
                    string Lyrics = new LyricsScreper().GetLyrics(Song.title, Song.artist_names);
                    Song.Lyrics = Lyrics;
                    _context.Songs.Attach(Song);
                    _context.SaveChangesAsync();
                }
                    
                
            }
        }
    }
}
