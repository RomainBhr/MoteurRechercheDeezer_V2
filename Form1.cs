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
    public partial class FrmLecteurMultimedia : Form
    {
        public FrmLecteurMultimedia()
        {
            InitializeComponent();
        }

        private void BtnChoisirFichier_Click(object sender, EventArgs e)
        {
            diaMultimédia.ShowDialog();
            wmpLecteur.URL = diaMultimédia.FileName;
        }

        private void WmpLecteur_Enter(object sender, EventArgs e)
        {

        }

        private void FrmLecteurMultimedia_Load(object sender, EventArgs e)
        {
           
        }
    }
}
