using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musica
{
    public class SongResult
    {
        public SongResponse response { get; set; }
    }

    public class SongResponse
    {
        public Song song { get; set; }
    }

    public class Song
    {
        public int id { get; set; }
        public string title { get; set; }
        public string artist_names { get; set; }
        public string full_title { get; set; }
        public string recording_location { get; set; }
        public string release_date_for_display { get; set; }
        public string header_image_url { get; set; }
        public string url { get; set; }
        public string Lyrics { get; set; }
    }
}
