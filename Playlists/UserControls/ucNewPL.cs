using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Playlists
{
    public partial class ucNewPL : UserControl
    {
        public ucNewPL()
        {
            InitializeComponent();
        }

        public bool IsCorrectString(string s)
        {
            return s.All(x => char.IsLetterOrDigit(x) || char.IsWhiteSpace(x));
        }



        private void buttonSavePL_Click(object sender, EventArgs e)
        {
            using (var db = new PlayListContext())
            {
                if (db.Database.CanConnect())
                {
                    var playlists = db.Playlists.ToList().OrderBy(pl => pl.PlaylistId);
                    int newId = playlists.LastOrDefault().PlaylistId + 1;

                    if (!string.IsNullOrEmpty(tbPLName.Text))
                    {
                        Playlist playlist = new Playlist()
                        {
                            Name = tbPLName.Text,
                            PlaylistId = newId
                        };

                        db.Playlists.Add(playlist);
                        DialogResult result = MessageBox.Show($"Do you want to save the playlist as '{playlist.Name}'?"
                            , "Save playlist",
                            MessageBoxButtons.OKCancel);

                        if (result == DialogResult.OK)
                        {
                            db.SaveChanges();
                        }
                        tbPLName.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a title for your playlist!");
                    }

                }
                else
                {
                    MessageBox.Show("Connection Failed!");
                }

            }

        }
        private void buttonCancelPL_Click(object sender, EventArgs e)
        {
            if (!FormMain.Instance.PnlContainer.Controls.ContainsKey("UCHome"))
            {
                ucHome uc = new ucHome();
                uc.Dock = DockStyle.Fill;
                FormMain.Instance.PnlContainer.Controls.Add(uc);
            }
            else
            {
                FormMain.Instance.PnlContainer.Controls["ucHome"].BringToFront();
            }
            tbPLName.Clear();
        }

        private void tbPLName_TextChanged(object sender, EventArgs e)
        {
            if(IsCorrectString(tbPLName.Text) == false)
            {
                MessageBox.Show("Please use only letters or digits!");
                tbPLName.Clear();
            }
        }
    }
}
