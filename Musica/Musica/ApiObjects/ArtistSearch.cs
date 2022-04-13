using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musica
{
    public class ArtistSearch
    {
        public Artist Artist { get; set; }
        public IList<Song> Songs { get; set; }
    }
}
