using Assignment2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Database
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Artist> Idols { get; set; }
        public DbSet<Assignment2.Entities.Song> Song { get; set; } 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist { ArtistId = 1, FirstName = "Minji", LastName = "Kim" },
                new Artist { ArtistId = 2, FirstName = "Ryujin", LastName = "Shin" },
                new Artist { ArtistId = 3, FirstName = "Yeji", LastName = "Hwang" },
                new Artist { ArtistId = 4, FirstName = "Hanni", LastName = "Pham" }
                );

            modelBuilder.Entity<Song>().HasData(
                new Song { songId = 1, albumName = "Supernatural", songName = "RightNow" },
                new Song { songId = 2, albumName = "BornToBe", songName = "RunAway" },
                new Song { songId = 3, albumName = "ItzMe", songName = "Wannabe" },
                new Song { songId = 4, albumName = "NJWMX", songName = "Ditto(250Remix)" }
                );
        }
        



    }

  

}
