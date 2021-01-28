using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Playlists
{
    public partial class ucTreeView : UserControl
    {
        private PlayListContext db = new PlayListContext();

        public ucTreeView()
        {
            InitializeComponent();
        }

        private void ucTreeView_Load(object sender, EventArgs e)
        {
            if (db.Database.CanConnect())
            {
                var artists = db.Artists.
                    Include(artist => artist.Albums).
                    ToList().OrderBy(a => a.Name);

                foreach (Artist artist in artists)
                {
                    TreeNode artistNode = new TreeNode()
                    {
                        Text = artist.Name,
                        Tag = artist
                    };
                    treeView1.Nodes.Add(artistNode);

                    foreach (Album album in artist.Albums)
                    {
                        TreeNode albumNode = new TreeNode()
                        {
                            Text = album.Title,
                            Tag = album
                        };
                        artistNode.Nodes.Add(albumNode);
                    }
                }
            }
        }
    }
}

