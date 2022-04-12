using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musica
{
    public class CodeResult
    {
        public ResponseCode response { get; set; }
    }

    public class ResponseCode
    {
        public Hit[] hits { get; set; }
    }

    public class Hit
    {
        public ResultCode result { get; set; }
    }

    public class ResultCode
    {
        public PrimaryArtist primary_artist { get; set; }
    }

    public class PrimaryArtist
    {
        public int id { get; set; }
    }
}
