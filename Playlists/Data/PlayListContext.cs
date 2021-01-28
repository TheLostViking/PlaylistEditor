using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Playlists
{
    public partial class PlayListContext : DbContext
    {
        public PlayListContext()
        {
        }
        public PlayListContext(DbContextOptions<PlayListContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<MediaType> MediaTypes { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<PlaylistTrack> PlaylistTracks { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=everyloopNET;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS");

            new AlbumEntityTypeConfiguration().Configure(modelBuilder.Entity<Album>());

            new ArtistEntityTypeConfiguration().Configure(modelBuilder.Entity<Artist>());

            new GenreEntityTypeConfiguration().Configure(modelBuilder.Entity<Genre>());

            new MediaTypeEntityTypeConfiguration().Configure(modelBuilder.Entity<MediaType>());

            new PlaylistEntityTypeConfiguration().Configure(modelBuilder.Entity<Playlist>());

            new PlaylistTrackEntityTypeConfiguration().Configure(modelBuilder.Entity<PlaylistTrack>());

            new TrackEntityTypeConfiguration().Configure(modelBuilder.Entity<Track>());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
