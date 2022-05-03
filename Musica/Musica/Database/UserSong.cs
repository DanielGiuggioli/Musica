using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musica
{
    public class UserSong
    {
        public string Id { get; set; }
        public string IdUser { get; set; }
        public int IdSong { get; set; }
        public bool IsFavourite { get; set; }
    }
}
