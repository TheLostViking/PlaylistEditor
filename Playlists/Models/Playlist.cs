using System;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable

namespace Playlists
{
    [DebuggerDisplay("Name = {Name}")]
    public partial class Playlist
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }
    }
}
