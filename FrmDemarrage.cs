using ValentinMarie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiknCo_MoteurRechercheDeezer_V2
{
    public partial class FrmDemarrage : Form
    {

        #region Champs
            private Artist selectedArtist = new Artist();
            private Album selectedAlbum = new Album();
            private Track selectedTrack = new Track();
            Artist selectedArtistDetail = new Artist();

            private const string MESSAGE_RECHERCHE_ARTISTE = "Recherche en cours, veuillez patienter...";
            private const string MESSAGE_SAISIE_ARTISTE = "Veuillez saisir un artiste à rechercher";

            Boolean isConnected;
        #endregion

        #region Constructeurs
        public FrmDemarrage()
            {
                InitializeComponent();
            }

            private void FrmDemarrage_Load(object sender, EventArgs e)
            {


                isConnected = NetManager.isConnected();

                if (isConnected == false)
                {
                    Application.Exit();
                }
            }

            private void FrmDemarrage_Activated(object sender, EventArgs e)
            {
                txtArtisteRecherche.Focus();
            }
        #endregion

        #region Méthodes gestionnaire d'évenement

            private void BtnRechercher_Click(object sender, EventArgs e)
            {
                if (NetManager.isConnected() == false)
                {
              notifyIconEtat.ShowBalloonTip(1000,"Connexion Internet inactive","La recherche sur le site DEEZER est impossible", notifyIconEtat.BalloonTipIcon);
                System.Media.SystemSounds.Exclamation.Play();
                }
                else
            {
                notifyIconEtat.ShowBalloonTip(1000, "Bienvenue", "Appli Zik'nco DEEZER lancée le " + System.DateTime.Now, notifyIconEtat.BalloonTipIcon);

                System.Media.SystemSounds.Exclamation.Play();
            }
                if (txtArtisteRecherche.Text == String.Empty)
                {
                lblMessage.Text = MESSAGE_SAISIE_ARTISTE;
                    erp.SetError(txtArtisteRecherche, MESSAGE_SAISIE_ARTISTE);
                }
                else
            {
            
                Cursor.Current = Cursors.WaitCursor;
                lblMessage.Text = MESSAGE_RECHERCHE_ARTISTE;
                lblMessage.Refresh();

                this.lstArtistes.SelectedIndexChanged -= new System.EventHandler(this.LstArtistes_SelectedIndexChanged);


                rechercherArtistes();


                txtArtisteRecherche.Clear();

                this.lstArtistes.SelectedIndexChanged += new System.EventHandler(this.LstArtistes_SelectedIndexChanged);

                LstArtistes_SelectedIndexChanged(this, new EventArgs());


            }
        }

            private void BtnEcouterExtraits_Click(object sender, EventArgs e)
            {
                //Artist selectedArtistDetail = new Artist();

                //selectedArtistDetail = DeezerApi.getDetailsArtistById(selectedArtist.id);

                if (selectedArtistDetail.nbAlbums == 0)
                {
                    //MessageBox.Show("Désolé, les extrait pour '" + selectedArtist.name + "' ne sont pas disponibles...", "Zik'nCo : Avertissement ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblMessage.Text = "Désolé, les extrait pour '" + selectedArtist.name + "' ne sont pas disponibles...";
                    erp.SetError(btnEcouterExtraits, "Aucun extrait pour cette artiste");
                }
                else
                {
                    FrmLecteurMultemedia formulaire = new FrmLecteurMultemedia();

                    List<Album> lesAlbums = selectedArtistDetail.getLesAlbums();

                    foreach (Album unAlbum in lesAlbums)
                    {
                        List<Track> lesTracks = unAlbum.getLesTracks();

                        foreach (Track unTrack in lesTracks)
                        {
                 
                            WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                            formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                        }
                    }

                    formulaire.Show();
                    formulaire.wmpLecteur.Ctlcontrols.play();

                }
            }

            #region Menu

                    private void FrmDemarrage_FormClosing(object sender, FormClosingEventArgs e)
                    {
                        if (isConnected == false)
                        {
                            MessageBox.Show("L'application necessite un accès internet", "Internet Requis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "Zik'nCo : Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            e.Cancel = true;
                        }
                    }

                    private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
                            {
                                    Application.Exit();
                            }

                    private void LecteurMultimédiaToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        FrmLecteurMultemedia formulaire = new FrmLecteurMultemedia();
                        formulaire.Show();
                    }

                    private void AproposToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        FrmAPropos formulaire = new FrmAPropos();
                        formulaire.ShowDialog();
                    }

                    private void RechercheAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        FrmRechercheAlbums formulaire = new FrmRechercheAlbums();
                        formulaire.ShowDialog();
                    }
            #endregion

            #region Autres

        private void TxtArtisteRecherche_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == (char)Keys.Return) btnRechercher.PerformClick();
            }

            private void PicDeezer_Click(object sender, EventArgs e)
            {
                Process.Start("http://www.deezer.com/fr/");
            }

            private void LklDeezerLien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start(lklDeezerLien.Text);
            }
            #endregion

            #region Gestion des ListBox

            private void LstArtistes_SelectedIndexChanged(object sender, EventArgs e)
            {


                this.lstAlbums.SelectedIndexChanged -= new System.EventHandler(this.LstAlbums_SelectedIndexChanged);

                selectedArtist = (Artist)lstArtistes.SelectedItem;

                lblArtisteNom.Text = selectedArtist.name;
                picArtiste.ImageLocation = selectedArtist.picture;
                lklDeezerLien.Text = selectedArtist.link;

                grbArtisteInfos.Visible = true;


                selectedArtistDetail = DeezerApi.getDetailsArtistById(selectedArtist.id);
                btnEcouterExtraits.Enabled = true;

                if (selectedArtistDetail.nbAlbums == 0)
                {
                    //MessageBox.Show("Désolé, les extrait pour '" + selectedArtist.name + "' ne sont pas disponibles...", "Zik'nCo : Avertissement ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblMessage.Text = "Désolé, les extrait pour '" + selectedArtist.name + "' ne sont pas disponibles...";
                    erp.SetError(btnEcouterExtraits, "Aucun extrait pour cette artiste");
                }
                else
                {
                    lblMessage.Text = "";
                    List<Album> lesAlbums = selectedArtistDetail.getLesAlbums();

                    lstAlbums.DataSource = lesAlbums;
                    lstAlbums.DisplayMember = "title";
 

                    this.lstAlbums.SelectedIndexChanged += new System.EventHandler(this.LstAlbums_SelectedIndexChanged);
                    LstAlbums_SelectedIndexChanged(this, new EventArgs());
                }
            }

            private void LstAlbums_SelectedIndexChanged(object sender, EventArgs e)
            {

              
                selectedAlbum = (Album)lstAlbums.SelectedItem;
                List<Track> lesTracks = selectedAlbum.getLesTracks();
                lstTracks.DataSource = lesTracks;
                lstTracks.DisplayMember = "title";
                picDisco.ImageLocation = selectedAlbum.cover;
            }

            private void LstTracks_Click(object sender, EventArgs e)
            {
                selectedTrack = (Track)lstTracks.SelectedItem;

                wmpLecteurDisco.currentMedia = wmpLecteurDisco.newMedia(selectedTrack.preview);
            }

        
        #endregion

        #endregion

        #region Méthodes

        private void rechercherArtistes()
        {

            List<Artist> lesArtistes = new List<Artist>();

            String artisteRecherche = txtArtisteRecherche.Text;

            lesArtistes = DeezerApi.getAllArtistsByName(artisteRecherche);



            lblMessage.Text = string.Empty;

            if (lesArtistes.Count == 0)
            {
                //.MessageBox.Show("Désolé, l'artiste " + artisteRecherche + "n'est pas sur Deezer", "Zik'nCo : Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblMessage.Text = "Désolé, l'artiste " + artisteRecherche + "n'est pas sur Deezer";
                erp.SetError(txtArtisteRecherche, "Artiste inconnu");
            }
            else
            {
                lstArtistes.DataSource = lesArtistes;
                lstArtistes.DisplayMember = "name";
                erp.SetError(txtArtisteRecherche, string.Empty);
                grbArtisteInfos.Visible = true;
            }
        }





        #endregion

        private void LstAlbums_DoubleClick(object sender, EventArgs e)
        {
            FrmPlaylist formulaire = new FrmPlaylist();
            List<Track> lesTracks = selectedAlbum.getLesTracks();
            foreach (Track unTrack in lesTracks)
            {
                formulaire.lstGauche.Items.Add(unTrack);
                formulaire.lstGauche.DisplayMember = "name";
            }
            formulaire.Show();

        }

        private void PicIpod_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmCoverFlow formulaire = new FrmCoverFlow();
            formulaire.selectedArtistDetail = selectedArtistDetail;
            formulaire.Show();
            Cursor.Current = Cursors.Default;
        }

        private void NotifyIconEtat_BalloonTipShown(object sender, EventArgs e)
        {

        }

        private void QuitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
