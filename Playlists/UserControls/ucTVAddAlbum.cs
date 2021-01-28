using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Playlists
{
    public partial class ucTVAddAlbum : UserControl
    {
        private PlayListContext db = new PlayListContext();

        public ucTVAddAlbum()
        {
            InitializeComponent();

            AddAlbums();
        }
        public bool IsCorrectString(string s)
        {
            return s.All(x => char.IsLetterOrDigit(x) || char.IsWhiteSpace(x));
        }
        private void bAddnewAlbum_Click(object sender, EventArgs e)
        {
            var albums = db.Albums.ToList().OrderBy(album => album.AlbumId);
            int id = albums.LastOrDefault().AlbumId + 1;
            bool albumExists = db.Albums.Any(a => a.Title == tbAlbumTitle.Text);

            if (twAddAlbums.SelectedNode != null)
            {
                if (twAddAlbums.SelectedNode.Tag is Artist artist)
                {
                    if (!string.IsNullOrEmpty(tbAlbumTitle.Text))
                    {
                        if (albumExists)
                        {
                            MessageBox.Show("Album already exists!");
                        }
                        else
                        {
                            Album newAlbum = new Album()
                            {
                                Title = tbAlbumTitle.Text,
                                AlbumId = id,
                                ArtistId = artist.ArtistId
                            };
                            db.Albums.Add(newAlbum);

                            var result = MessageBox.Show($"Are you sure you want to add '{newAlbum.Title}'," +
                                $" to '{artist.Name}'s albums?",
                                "Save Album",
                                MessageBoxButtons.OKCancel);

                            if (result == DialogResult.OK)
                            {
                                db.SaveChanges();
                                AddAlbums();
                                var selectedNode = twAddAlbums.Nodes.Find(artist.Name, false);
                                if (selectedNode != null)
                                {
                                    selectedNode[0].Expand();
                                }
                                
                                tbAlbumTitle.Clear();
                                
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Album title can't be blank!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select artist in the list!");
            }
        }
        private void AddAlbums()
        {
            if (db.Database.CanConnect())
            {
                twAddAlbums.Nodes.Clear();

                var artists = db.Artists.
                    Include(artist => artist.Albums)
                    .ThenInclude(album => album.Tracks).
                    ToList().OrderBy(a => a.Name);

                foreach (Artist artist in artists)
                {
                    TreeNode artistNode = new TreeNode()
                    {
                        Text = artist.Name,
                        Name = artist.Name,
                        Tag = artist
                    };
                    twAddAlbums.Nodes.Add(artistNode);

                    foreach (Album album in artist.Albums)
                    {
                        TreeNode albumNode = new TreeNode()
                        {
                            Text = album.Title,
                            Name = album.Title,
                            Tag = album
                        };
                        artistNode.Nodes.Add(albumNode);
                    }
                }
            }
        }

        private void tbAlbumTitle_TextChanged(object sender, EventArgs e)
        {
            if (IsCorrectString(tbAlbumTitle.Text) == false)
            {
                MessageBox.Show("No special characters!");
            }
        }
        private void twAddAlbums_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (twAddAlbums.SelectedNode.Tag is Artist artist)
                {
                    var result = MessageBox.Show(
                        $"Are you sure you want to delete artist '{artist.Name}'?\n" +
                        $"This will also delete ALL the Albums and Tracks from that artist!",
                        "Delete Artist",
                        MessageBoxButtons.OKCancel
                        );

                    if (result == DialogResult.OK)
                    {
                        if (artist.Albums.Count != 0)
                        {
                            foreach (Album album in artist.Albums)
                            {
                                if (album.Tracks.Count != 0)
                                {
                                    var tracksToRemove = db.Tracks.Where(t => t.AlbumId == album.AlbumId).ToList();
                                    db.RemoveRange(tracksToRemove);
                                }
                            }
                            var albumsToRemove = db.Albums.Where(a => a.ArtistId == artist.ArtistId).ToList();
                            db.RemoveRange(albumsToRemove);
                        }

                        db.Remove(artist);
                        twAddAlbums.Nodes.Remove(twAddAlbums.SelectedNode);
                        db.SaveChanges();
                        
                    }
                }
            }
        }

    }
}
