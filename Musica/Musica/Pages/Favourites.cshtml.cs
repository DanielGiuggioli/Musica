using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Musica
{
    public class FavouritesModel : PageModel
    {
        private readonly MusicaDbContext _context;
        public FavouritesModel(MusicaDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public IList<Artist> FavArtists { get; set; }
        [BindProperty]
        public IList<Song> FavSongs { get; set; }
        public User User { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            User = CookiesManager.GetUserByCookies(HttpContext.Request, _context);
            if (User != null)
            {
                var usersArtists = _context.UsersArtists.ToList();
                IList<int> IdArtists = usersArtists.Where(x => x.IdUser == User.Id && x.IsFavourite)
                                                       .ToList()
                                                       .Select(y => y.IdArtist)
                                                       .ToList();
                FavArtists = _context.Artists.Where(x => IdArtists.Contains(x.id))
                                            .ToList();

                var usersSongs = _context.UsersSongs.ToList();
                IList<int> IdSongs = usersSongs.Where(x => x.IdUser == User.Id && x.IsFavourite)
                                                       .ToList()
                                                       .Select(y => y.IdSong)
                                                       .ToList();
                FavSongs = _context.Songs.Where(x => IdSongs.Contains(x.id))
                                            .ToList();
            }

            return Page();
        }

        /// <summary>
        /// Pages/Favourites?handler=SetFavouriteArtist&userId={userId}&artistId={artistId}
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IActionResult OnGetSetFavouriteArtist(string userId, int artistId)
        {
            var u = _context.UsersArtists
                .Where(x => x.IdUser == userId && x.IdArtist == artistId)
                .FirstOrDefault();

            u.IsFavourite = true;

            _context.SaveChanges();

            return Content("true");
        }

        /// <summary>
        /// Pages/Favourites?handler=DeleteFavouriteArtist&userId={userId}&artistId={artistId}
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="artistId"></param>
        /// <returns></returns>
        public IActionResult OnGetDeleteFavouriteArtist(string userId, int artistId)
        {
            var u = _context.UsersArtists
                .Where(x => x.IdUser == userId && x.IdArtist == artistId)
                .FirstOrDefault();

            u.IsFavourite = false;

            _context.SaveChanges();

            return Content("true");
        }
    }
}
