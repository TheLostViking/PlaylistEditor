using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace Playlists
{
    public class PlaylistTrackEntityTypeConfiguration : IEntityTypeConfiguration<PlaylistTrack>
    {
        public void Configure(EntityTypeBuilder<PlaylistTrack> builder)
        {
            builder.HasKey(e => new { e.PlaylistId, e.TrackId });

            builder.ToTable("playlist_track", "music");

            builder.HasOne(d => d.Playlist)
                .WithMany()
                .HasForeignKey(d => d.PlaylistId)
                .OnDelete(DeleteBehavior.ClientCascade)
                .HasConstraintName("FK_playlist_track_playlists");

            builder.HasOne(d => d.Track)
                .WithMany()
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientCascade)
                .HasConstraintName("FK_playlist_track_tracks");
        }
    }
}
