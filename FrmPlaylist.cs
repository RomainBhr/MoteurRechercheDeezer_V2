using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiknCo_MoteurRechercheDeezer_V2
{
    public partial class FrmPlaylist : Form
    {
        public FrmPlaylist()
        {
            InitializeComponent();
        }

        private void BtnUnDroite_Click(object sender, EventArgs e)
        {
            lstDroite.Items.Add(lstGauche.SelectedItem);
            lstGauche.Items.Remove(lstGauche.SelectedItem);
            btnUnGauche.Enabled = true;
            btnTousGauche.Enabled = true;
        }

        private void BtnUnGauche_Click(object sender, EventArgs e)
        {
            lstGauche.Items.Add(lstDroite.SelectedItem);
            lstDroite.Items.Remove(lstDroite.SelectedItem);
            if (lstDroite.Items.Count == 0)
            {
                btnUnGauche.Enabled = true;
                btnTousGauche.Enabled = true;
            }
        }

        private void BtnTousDroite_Click(object sender, EventArgs e)
        {
            foreach (object element in lstGauche.Items)
                lstDroite.Items.Add(element);
            lstGauche.Items.Clear();
            btnUnGauche.Enabled = true;
            btnTousGauche.Enabled = true;
        }

        private void BtnTousGauche_Click(object sender, EventArgs e)
        {
            foreach (object element in lstDroite.Items)
                lstGauche.Items.Add(element);
            lstDroite.Items.Clear();

            btnUnGauche.Enabled = false;
            btnTousGauche.Enabled = false;
        }

        private void BtnJouerExtraits_Click(object sender, EventArgs e)
        {
            //WIP
            FrmLecteurMultemedia formulaire = new FrmLecteurMultemedia();
            foreach  (string unTrack in lstDroite.Items)
            {
                WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack);
                formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);

            }
            formulaire.Show();
            formulaire.wmpLecteur.Ctlcontrols.play();
        }

        private void FrmPlaylist_Load(object sender, EventArgs e)
        {
            lstGauche.SelectedIndex = 0;

            btnUnGauche.Enabled = false;
            btnTousGauche.Enabled = false;

        }
    }
}
