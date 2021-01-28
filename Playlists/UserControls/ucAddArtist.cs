using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Playlists
{
    public partial class ucAddArtist : UserControl
    {
        public ucAddArtist()
        {
            InitializeComponent();
        }
        public bool IsCorrectString(string s)
        {
            return s.All(x => char.IsLetterOrDigit(x) || char.IsWhiteSpace(x));
        }
        private void buttonSaveArtist_Click(object sender, EventArgs e)
        {
            using(var db = new PlayListContext())
            {
                if (db.Database.CanConnect())
                {
                    var artists = db.Artists.ToList().OrderBy(artist => artist.ArtistId);
                    int newId = artists.LastOrDefault().ArtistId + 1;
                    bool artistExists = db.Artists.Any(a => a.Name == tbNewArtist.Text);

                    if (tbNewArtist.Text != null || tbNewArtist.Text != "")
                    {
                        if (artistExists)
                        {
                            MessageBox.Show("Artist already exists in Database!");
                        }
                        else
                        {
                            var result = MessageBox.Show($"Do you want to save the artist {tbNewArtist.Text} to the Database?",
                                "Save artist",
                                MessageBoxButtons.OKCancel);

                            if (result == DialogResult.OK)
                            {
                                Artist newArtist = new Artist()
                                {
                                    Name = tbNewArtist.Text,
                                    ArtistId = newId
                                };
                                db.Artists.Add(newArtist);
                                db.SaveChanges();

                                MessageBox.Show("Artist successfully saved!");
                            }                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Artist name can't be blank!");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsCorrectString(tbNewArtist.Text) == false)
            {
                MessageBox.Show("Only digits and letters please!");
            }
        }

        private void buttonCancelArtist_Click(object sender, EventArgs e)
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
            tbNewArtist.Clear();
        }
    }
}
