using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace Playlists
{
    public class MediaTypeEntityTypeConfiguration : IEntityTypeConfiguration<MediaType>
    {
        public void Configure(EntityTypeBuilder<MediaType> builder)
        {
            builder.ToTable("media_types", "music");

            builder.Property(e => e.MediaTypeId).ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(120);
        }
    }
}
