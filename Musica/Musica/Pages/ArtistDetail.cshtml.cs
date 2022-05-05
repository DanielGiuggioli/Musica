using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Musica.Pages
{
    public class ArtistDetailModel : PageModel
    {
        private readonly MusicaDbContext _context;
        public ArtistDetailModel(MusicaDbContext context)
        {
            _context = context;
        }
        public ArtistSearch Artist { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                Artist = new ArtistSearch();
                Artist.Artist = _context.Artists.SingleOrDefault(x => x.id == id);
                var apiCaller = new ApiCaller();
                apiCaller.PopulateFamousSongs(apiCaller.GetHits(Artist.Artist.name), Artist);

            }
            
           
        }
    }
}
