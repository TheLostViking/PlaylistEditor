using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace Playlists
{
    public class PlaylistEntityTypeConfiguration : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.ToTable("playlists", "music");

            builder.Property(e => e.PlaylistId).ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(120);
        }
    }
}
