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
        private readonly MusicaDbContext _context;
        public IndexModel(MusicaDbContext context)
        {
            _context = context;
        }
        public User User { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            return Page();
        }
    }
}
