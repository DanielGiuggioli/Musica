using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musica
{
    public class ArtistResult
    {
        public Response response { get; set; }
    }

    public class Response
    {
        public Artist artist { get; set; }
    }

    public class Artist
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image_url { get; set; }
        public string url { get; set; }
    }
}
