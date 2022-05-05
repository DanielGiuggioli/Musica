using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Musica
{
    public class IndexModel : PageModel
    {
        private readonly MusicaDbContext _context;
        public IndexModel(MusicaDbContext context)
        {
            _context = context;
        }

        public new User User { get; set; }
        public int FavCount { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            if (User != null)
            {
                int favACount = _context.UsersArtists.Where(x => x.IdUser == User.Id && x.IsFavourite)
                                             .ToList()
                                             .Count;
                int favSCount = _context.UsersSongs.Where(x => x.IdUser == User.Id && x.IsFavourite)
                                             .ToList()
                                             .Count;
                FavCount = favACount + favSCount;
            }
                
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var cookies = Response.Cookies;
            var index = CookiesManager.UserIdKey;
            var options = CookiesManager.CookieOptions;
            cookies.Append(index, string.Empty, options);
            return Page();
        }
    }
}
