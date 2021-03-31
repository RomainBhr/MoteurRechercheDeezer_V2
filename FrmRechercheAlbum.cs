using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer;
using Btssio.Tools;

namespace ZiknCo_MoteurRechercheDeezer_V2
{
    public partial class FrmRechercheAlbum : Form
    {
        public FrmRechercheAlbum()
        {
            InitializeComponent();
        }

        private void LblArtiste_Click(object sender, EventArgs e)
        {

        }

        private void BtnRecherches_Click(object sender, EventArgs e)
        {
            Album unalbum = new Album() ;
            lblTitreAlbum.Text = txtBoxRecherche.Text;

        }

        private void TxtBoxRecherche_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
