using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musica
{
    public class SearchResult
    {
        public SearchResponse response { get; set; }
    }

    public class SearchResponse
    {
        public Hit[] hits { get; set; }
    }

    public class Hit
    {
        public Result result { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string full_title { get; set; }
        public PrimaryArtist primary_artist { get; set; }
    }

    public class PrimaryArtist
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
