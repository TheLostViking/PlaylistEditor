using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace Playlists
{
    public class GenreEntityTypeConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("genres", "music");

            builder.Property(e => e.GenreId).ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(120);
        }
    }
}
