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
    public partial class FrmLecteurMultemedia : Form
    {
        public FrmLecteurMultemedia()
        {
            InitializeComponent();
        }

        private void BtnChoisirFichier_Click(object sender, EventArgs e)
        {
            diaMultimedia.ShowDialog();
            wmpLecteur.URL = diaMultimedia.FileName;
        }
    }
}
