using System;
using System.Windows.Forms;

namespace Playlists
{
    public partial class FormMain : Form

    {
        static FormMain _obj;

        public static FormMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FormMain();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get
            {
                return panelMain;
            }
            set { panelMain = value; }
        }

       public Button ExitButton
        {
            get { return buttonExit; }
            set { buttonExit = value; }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void bEditPL_Click(object sender, EventArgs e)
        {
            ucEditPL editPL = new ucEditPL();
            panelMain.Controls.Add(editPL);
            editPL.Dock = DockStyle.Fill;
            panelMain.Controls["ucEditPL"].BringToFront();
        }

        private void bCreatePL_Click(object sender, EventArgs e)
        {
            ucNewPL newPL = new ucNewPL();
            panelMain.Controls.Add(newPL);
            newPL.Dock = DockStyle.Fill;
            panelMain.Controls["ucNewPL"].BringToFront();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _obj = this;
            ucHome uc = new ucHome();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucAddArtist ucAddArtist = new ucAddArtist();
            panelMain.Controls.Add(ucAddArtist);
            ucAddArtist.Dock = DockStyle.Fill;
            panelMain.Controls["ucAddArtist"].BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucTVAddAlbum newAlbum = new ucTVAddAlbum();
            panelMain.Controls.Add(newAlbum);
            newAlbum.Dock = DockStyle.Fill;
            panelMain.Controls["ucTVAddAlbum"].BringToFront();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucAddTracks newTracks = new ucAddTracks();
            panelMain.Controls.Add(newTracks);
            newTracks.Dock = DockStyle.Fill;
            panelMain.Controls["ucAddTracks"].BringToFront();
        }
    }
}
