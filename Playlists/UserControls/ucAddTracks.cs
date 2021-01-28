using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Playlists
{
    public partial class ucAddTracks : UserControl
    {
        private PlayListContext db = new PlayListContext();
        private Album activeAlbum = null;

        private bool IsCorrectString(string s)
        {
            return s.All(x => char.IsLetterOrDigit(x) || char.IsWhiteSpace(x));
        }       
        public ucAddTracks()
        {
            InitializeComponent();

            AddNodes();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Album album)
            {
                activeAlbum = album;
                daGrTracks.Rows.Clear();

                foreach (Track track in album.Tracks)
                {
                    int rowIndex = daGrTracks.Rows.Add();
                    daGrTracks.Rows[rowIndex].Tag = track;

                    daGrTracks.Rows[rowIndex].Cells["cTrackTitle"].Value = track.Name;
                    daGrTracks.Rows[rowIndex].Cells["cTrackLength"].Value =
                        TimeSpan.FromMilliseconds(track.Milliseconds).ToString("mm\\:ss");
                }
            }
        }

        //Event for adding songs to albums. 
        private void bAddRows_Click(object sender, EventArgs e)
        {
            if (activeAlbum != null)
            {
                bool trackExists = activeAlbum.Tracks.Any(a => a.Name == tbTrackTitle.Text);

                if (trackExists)
                {
                    MessageBox.Show("Track already exists!");
                }
                else
                {
                    if (IsCorrectString(tbTrackTitle.Text) == true)
                    {
                        var allTracks = db.Tracks.ToList().OrderBy(track => track.TrackId);
                        int newId = allTracks.LastOrDefault().TrackId + 1;


                        if (TimeSpan.TryParseExact(tbTrackMin.Text, "mm\\:ss", null, out TimeSpan result))
                        {

                            var trackTime = result.TotalMilliseconds;

                            var newTrack = new Track()
                            {
                                MediaTypeId = 1,
                                UnitPrice = 0.99,
                                Name = tbTrackTitle.Text,
                                Milliseconds = (int)trackTime,
                                AlbumId = activeAlbum.AlbumId,
                                Album = activeAlbum,
                                TrackId = newId
                            };

                            activeAlbum.Tracks.Add(newTrack);

                            int rowIndex = daGrTracks.Rows.Add();
                            daGrTracks.Rows[rowIndex].Tag = newTrack;
                            daGrTracks.Rows[rowIndex].Cells["cTrackLength"].Value =
                                TimeSpan.FromMilliseconds(newTrack.Milliseconds).ToString("mm\\:ss");
                            daGrTracks.Rows[rowIndex].Cells["cTrackTitle"].Value = newTrack.Name;
                        }
                        else
                        {
                            MessageBox.Show("Invalid input!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input!");
                    }
                }
            };
            db.SaveChanges();
        }
        private void daGrTracks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cell = daGrTracks.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (e.ColumnIndex == 0)

            {
                var trackdetails = daGrTracks.Rows[e.RowIndex].Tag as Track;
                if (cell.Value != null)
                {
                    trackdetails.Name = (string)cell.Value;
                }
                else
                {
                    MessageBox.Show("Track title can't be empty!");
                }
            }
            else if (e.ColumnIndex == 1)
            {
                var trackdetails = daGrTracks.Rows[e.RowIndex].Tag as Track;

                if (cell.Value != null)
                {
                    string[] subs = cell.Value.ToString().Split(':');

                    Int32.TryParse(subs[0], out int seconds);
                    Int32.TryParse(subs[1], out int plusSec);
                    int totalSeconds = (seconds * 60) + plusSec;
                    TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
                    var length = time.TotalMilliseconds;

                    trackdetails.Milliseconds = (int)length;
                }
                else
                {
                    MessageBox.Show($"Track length can't be empty!");
                }
            }
        }

        //Event for deleting tracks in DatagridView.
        private void daGrTracks_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Tag is Track track)
            {
                var result = MessageBox.Show($"Do you want to delete '{track.Name}'" +
                    $" from '{track.Album.Title}'?",
                    "Delete Track?",
                    MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    db.Remove(track);
                    db.SaveChanges();
                    MessageBox.Show("Track successfully removed!");
                    tbTrackMin.Clear();
                    tbTrackTitle.Clear();
                }

            }
        }

        //Event to delete albums in treeview.
        private void twAlbums_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (twAlbums.SelectedNode.Tag is Album album)
                {
                    var result = MessageBox.Show(
                        $"Are you sure you want to delete album '{album.Title}'?\n" +
                        $"This will also delete ALL the tracks on that album.",
                        "Delete album",
                        MessageBoxButtons.OKCancel
                        );

                    if (result == DialogResult.OK)
                    {
                        if (album.Tracks != null)
                        {
                            var tracksToRemove = db.Tracks.Where(track => track.AlbumId == album.AlbumId).ToList();
                            db.RemoveRange(tracksToRemove);
                        }

                        db.Remove(album);
                        twAlbums.Nodes.Remove(twAlbums.SelectedNode);
                        db.SaveChanges();
                        daGrTracks.Rows.Clear();
                    }
                }
            }
        }
        private void saveTracks_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This will save ALL changes made on all rows, proceed?",
                "Save changes.",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                db.SaveChanges();
                AddNodes();

                var selectedNode = twAlbums.Nodes.Find(activeAlbum.Artist.Name, false);
                if (selectedNode != null)
                {
                    selectedNode[0].Expand();
                }
                tbTrackMin.Clear();
                tbTrackTitle.Clear();

            }
        }
        //Method to add Nodes to TW.
        public void AddNodes()
        {
            if (db.Database.CanConnect())
            {
                twAlbums.Nodes.Clear();

                var artists = db.Artists.
                    Include(artist => artist.Albums).
                    ThenInclude(album => album.Tracks).
                    ToList().OrderBy(a => a.Name);

                foreach (Artist artist in artists)
                {
                    TreeNode artistNode = new TreeNode()
                    {
                        Text = $"{artist.Name}",
                        Name = artist.Name,
                        Tag = artist
                    };

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

                    twAlbums.Nodes.Add(artistNode);
                }
            }
        }
    }

}
