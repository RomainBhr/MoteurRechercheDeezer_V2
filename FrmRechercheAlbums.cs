using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValentinMarie;

namespace ZiknCo_MoteurRechercheDeezer_V2
{
    public partial class FrmRechercheAlbums : Form
    {
        public FrmRechercheAlbums()
        {
            InitializeComponent();
        }

        Album selectedAlbumDetail = new Album();
        private Album selectedAlbum = new Album();
        private Track selectedTrack = new Track();
        private const string MESSAGE_RECHERCHE_ALBUMS = "Recherche en cours, veuillez patienter...";
        private const string MESSAGE_SAISIE_ALBUMS = "Veuillez saisir un album à rechercher";

        private void FrmRechercheAlbums_Activated(object sender, EventArgs e)
        {
            txtBoxRecherche.Focus();
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            if (txtBoxRecherche.Text == String.Empty)
            {
                lblMessage.Text = MESSAGE_SAISIE_ALBUMS;
                erp.SetError(txtBoxRecherche, MESSAGE_SAISIE_ALBUMS);
            }
            else
            {
                 Cursor.Current = Cursors.WaitCursor;
                lblMessage.Text = MESSAGE_RECHERCHE_ALBUMS;
                lblMessage.Refresh();



                rechercherAlbum();
                txtBoxRecherche.Clear();

              
               
            }
        }


        private void rechercherAlbum()
        {

            List<Album> lesAlbums = new List<Album>();

            String albumRecherche = txtBoxRecherche.Text;


            lesAlbums = DeezerApi.getAllAlbumsByName(albumRecherche);



            lblMessage.Text = string.Empty;

             if (lesAlbums.Count == 0)
            {
                lblMessage.Text = "Désolé, l'album " + albumRecherche + " n'est pas sur Deezer";
                erp.SetError(txtBoxRecherche, "Album inconnu");
            }
            else
            {
                this.lstBoxAlbum.SelectedIndexChanged -= new System.EventHandler(this.LstBoxAlbum_SelectedIndexChanged);

                lstBoxAlbum.DataSource = lesAlbums;
                lstBoxAlbum.DisplayMember = "title";

                this.lstBoxAlbum.SelectedIndexChanged += new System.EventHandler(this.LstBoxAlbum_SelectedIndexChanged);

                erp.SetError(txtBoxRecherche, string.Empty);
                LstBoxAlbum_SelectedIndexChanged(this, new EventArgs());
            }
        }

        private void TxtBoxRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnRechercher.PerformClick();
        }

        private void LstBoxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Album> lesAlbums = new List<Album>();

            selectedAlbum = (Album)lstBoxAlbum.SelectedItem;

         
                selectedAlbumDetail = DeezerApi.getDetailsAlbumById(selectedAlbum.id);

                lblNomAlbum.Text = selectedAlbum.title;
                lblNomArtiste.Text = selectedAlbum.theArtist.name;
                picAlbum.ImageLocation = selectedAlbum.cover;
                picArtiste.ImageLocation = selectedAlbum.theArtist.picture;
                linkAlbum.Text = selectedAlbumDetail.link;

                btnEcouterExtrait.Enabled = true;


                lblMessage.Text = "";
                List<Track> lesTracks = selectedAlbumDetail.getLesTracks();

                lstBoxTitre.DataSource = lesTracks;
                lstBoxTitre.DisplayMember = "title";
            
        }

        private void BtnEcouterExtrait_Click(object sender, EventArgs e)
        {
            FrmLecteurMultemedia formulaire = new FrmLecteurMultemedia();


            selectedAlbum = (Album)lstBoxAlbum.SelectedItem;
            selectedAlbumDetail = DeezerApi.getDetailsAlbumById(selectedAlbum.id);


            List<Track> lesTracks = selectedAlbumDetail.getLesTracks();

            foreach (Track unTrack in lesTracks)
                {
                     WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                    formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                }

            formulaire.Show();
            formulaire.wmpLecteur.Ctlcontrols.play();
        }

        private void LstBoxTitre_Click(object sender, EventArgs e)
        {
            selectedTrack = (Track)lstBoxTitre.SelectedItem;

            wmpLecteur.currentMedia = wmpLecteur.newMedia(selectedTrack.preview);
        }

        private void PicAlbum_Click(object sender, EventArgs e)
        {

        }
    }
}
