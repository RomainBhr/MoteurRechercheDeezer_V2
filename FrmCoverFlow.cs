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
using System.Net;
using CDI.IndexCard3D;

namespace ZiknCo_MoteurRechercheDeezer_V2
{
    public partial class FrmCoverFlow : Form
    {
        public FrmCoverFlow()
        {
            InitializeComponent();
        }

        private void FrmCoverFlow_Load(object sender, EventArgs e)
        {
            lesAlbums = selectedArtistDetail.getLesAlbums();
            WebClient wclient = new WebClient();
            string nomImage;
            int i;
            for (i = 0; i < lesAlbums.Count; i++)
            {
                    nomImage = "image" + i + ".jpeg";
                    wclient.DownloadFile(lesAlbums[i].cover, nomImage);
                    Card c = new Card(lesAlbums[i].title, nomImage);
                    iC3DAlbums.IndexCards.Add(c);
                

            }
            iC3DAlbums.IndexCards.LoadTexturesToMemory();
            chargerTitresSelectedAlbum();
        }

        #region Champs
        private List<Album> lesAlbums = new List<Album>();
        private List<Track> lesTracks = new List<Track>();
        public Artist selectedArtistDetail = new Artist();
        #endregion
        #region Méthodes
        private void chargerTitresSelectedAlbum()
        {
            lstTitres.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            Album selectedAlbum = lesAlbums.ElementAt(iC3DAlbums.ActiveCard -1);
            List<Track> lesTracks = selectedAlbum.getLesTracks();
            int indexTitres = 0;
            wmpLecteur.currentPlaylist.clear();
            foreach (Track unTrack in lesTracks)
            {
                
                    WMPLib.IWMPMedia unMedia = wmpLecteur.newMedia(unTrack.preview);
                    unMedia.setItemInfo("montitre", unTrack.title);
                    unMedia.setItemInfo("XsurY", indexTitres.ToString());
                lstTitres.Items.Add(unTrack.title);
                    wmpLecteur.currentPlaylist.appendItem(unMedia);
                indexTitres++;
                    
               
            }
            int XsurY = Convert.ToInt32(wmpLecteur.currentMedia.getItemInfo("XsurY") + 1);
            lblXsurY.Text = XsurY.ToString() + "sur" + wmpLecteur.currentPlaylist.count;
     
        }
        #endregion

        private void IC3DAlbums_RenderText(object sender, EventArgs e)
        {
            Font fntNom = new Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Pixel);
            Font fntTitre = new Font("Arial", 20, FontStyle.Italic, GraphicsUnit.Pixel);
            string titre = iC3DAlbums.IndexCards.ElementAt(iC3DAlbums.ActiveCard - 1).Title;
            iC3DAlbums.DrawText(0, iC3DAlbums.Height - 75, selectedArtistDetail.name, IC3D.TextAlignment.Center, fntNom, Color.FloralWhite);
            iC3DAlbums.DrawText(0, iC3DAlbums.Height - 45, titre, IC3D.TextAlignment.Center, fntTitre, Color.Wheat);
        }

        private void IC3DAlbums_IndexCardChanged(object sender, IndexCardEventArgs e)
        {
            chargerTitresSelectedAlbum();
        }

        private void WmpLecteur_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            lblTitre.Text = wmpLecteur.currentMedia.getItemInfo("nomTitre");
            //int XsurY = Convert.ToInt32(wmpLecteur.currentMedia.getItemInfo("XsurY") + 1);
            //lblXsurY.Text = XsurY.ToString() + "sur" + wmpLecteur.currentPlaylist.count;
            //lstTitres.SelectedIndex = Convert.ToInt32(wmpLecteur.currentMedia.getItemInfo("XsurY"));
            lblXsurY.Text = wmpLecteur.currentMedia.getItemInfo("XsurY") + "sur" + wmpLecteur.currentPlaylist.count;
        }

        private void LstTitres_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPMedia unMedia = wmpLecteur.currentPlaylist.get_Item(lstTitres.SelectedIndex);
            wmpLecteur.Ctlcontrols.playItem(unMedia);
        }


        private void LblXsurY_MouseHover(object sender, EventArgs e)
        {
            panListeTitres.Visible = true;
        }

        private void LstTitres_MouseLeave(object sender, EventArgs e)
        {
           panListeTitres.Visible = false;
        }

        private void PanListeTitres_MouseLeave(object sender, EventArgs e)
        {
            panListeTitres.Visible = false;
        }
    }
}
