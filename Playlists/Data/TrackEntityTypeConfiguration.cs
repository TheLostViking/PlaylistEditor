using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace Playlists
{
    public class TrackEntityTypeConfiguration : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.ToTable("tracks", "music");

            builder.Property(e => e.TrackId).ValueGeneratedNever();

            builder.Property(e => e.Composer).HasMaxLength(220);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasOne(d => d.Album)
                .WithMany(p => p.Tracks)
                .HasForeignKey(d => d.AlbumId)
                .HasConstraintName("FK_tracks_albums");

            builder.HasOne(d => d.Genre)
                .WithMany(p => p.Tracks)
                .HasForeignKey(d => d.GenreId)
                .HasConstraintName("FK_tracks_genres");

            builder.HasOne(d => d.MediaType)
                .WithMany(p => p.Tracks)
                .HasForeignKey(d => d.MediaTypeId)
                .OnDelete(DeleteBehavior.ClientCascade)
                .HasConstraintName("FK_tracks_media_types");
        }
    }
}
