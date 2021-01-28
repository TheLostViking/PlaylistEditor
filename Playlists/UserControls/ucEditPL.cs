using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;


namespace Playlists
{
    public partial class ucEditPL : UserControl
    {

        private PlayListContext db = new PlayListContext();
        public ucEditPL()
        {
            InitializeComponent();            
        }

        public Button delButton
        {
            get
            {
                return bDeletePL;
            }
            set { bDeletePL = value; }
        }
        private void ucEditPL_Load(object sender, EventArgs e)
        {
            AddPlaylistsToList();
            AddTracksToList();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Tag is Playlist playlist)
            {
                tbSelectedPL.Text = playlist.Name;
            }
        }
        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeletePlaylist();
            }
        }
        private void bDeletePL_Click(object sender, EventArgs e)
        {
            DeletePlaylist();
        }
        private void tWTr_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Track track)
            {
                tbSelectedTrack.Text = track.Name;
            }
        }

        private void buttonAddTracks_Click(object sender, EventArgs e)
        {
            if (tWPL.SelectedNode != null)
            {
                if (tWPL.SelectedNode.Tag is Playlist playlist && tWTr.SelectedNode.Tag is Track track)
                {
                    var ptTrack = new PlaylistTrack()
                    {
                        PlaylistId = playlist.PlaylistId,
                        TrackId = track.TrackId
                    };
                    db.PlaylistTracks.Add(ptTrack);

                    DialogResult result = MessageBox.Show($"Are you sure you want to add '{track.Name}'\n" +
                        $" to playlist '{playlist.Name}'?",
                        "Add tracks to playlist",
                        MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        db.SaveChanges();
                        MessageBox.Show("Track added!");
                                              
                        AddPlaylistsToList();

                        var selectedNode = tWPL.Nodes.Find(tbSelectedPL.Text, false);
                        if (selectedNode != null)
                        {
                            selectedNode[0].Expand();
                        }
                        tbSelectedPL.Clear();
                        tbSelectedTrack.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Select a playlist!");
                }
            }
        }

        //Method for deleting playlist in treeview. Deletes node too and saves changes.
        public void DeletePlaylist()
        {
            if (tWPL.SelectedNode.Tag is Playlist playlist)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete playlist {playlist.Name}?",
                    "Delete playlist",
                    MessageBoxButtons.OKCancel
                    );

                if (result == DialogResult.OK)
                {
                    db.Remove(playlist);
                    tWPL.Nodes.Remove(tWPL.SelectedNode);
                    db.SaveChanges();
                }
            }
        }
        //Method to add tracks to list with genres.
        public void AddTracksToList()
        {
            if (db.Database.CanConnect())
            {
                var genres = db.Genres.ToList();
                var tracks = db.Tracks.ToList();

                foreach (Genre genre in genres)
                {
                    TreeNode genreNode = new TreeNode 
                    {
                        Text = genre.Name,
                        Tag = genre
                    };
                    tWTr.Nodes.Add(genreNode);

                    foreach (Track track in tracks)
                    {
                        if (genre.GenreId == track.GenreId)
                        {
                            TreeNode tackNode = new TreeNode
                            {
                                Text = track.Name,
                                Tag = track
                            };
                            genreNode.Nodes.Add(tackNode);
                        }
                    }

                }
            }
        }
        //Method to add playlists to treeview.
        public void AddPlaylistsToList()
        {

            if (db.Database.CanConnect())
            {
                tWPL.Nodes.Clear();

                var playlists = db.Playlists.ToList();

                foreach (Playlist playlist in playlists)
                {
                    TreeNode playlistNode = new TreeNode()
                    {
                        Text = playlist.Name,
                        Name = playlist.Name,
                        Tag = playlist
                    };
                    tWPL.Nodes.Add(playlistNode);

                    var pt = db.PlaylistTracks
                        .Include(t => t.Track).ToList();

                    foreach (PlaylistTrack playlistTrack in pt)
                    {
                        if (playlistTrack.PlaylistId == playlist.PlaylistId)
                        {
                            TreeNode trackNode = new TreeNode()
                            {
                                Text = playlistTrack.Track.Name,
                                Tag = playlistTrack
                            };
                            playlistNode.Nodes.Add(trackNode);
                        }
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
