using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musica
{
    public class MusicaDbContext : DbContext
    {
        public MusicaDbContext(DbContextOptions op) : base(op) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<UserArtist> UsersArtists { get; set; }
        public DbSet<UserSong> UsersSongs { get; set; }
        public DbSet<EmailToken> EmailTokens { get; set; }
    }
}
