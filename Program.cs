using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValentinMarie;
namespace ZiknCo_MoteurRechercheDeezer_V2
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDemarrage());

            #region TestPartie1

            //String artistName;
            //Boolean isConnected;

            //Artist monArtist = new Artist();

            //isConnected = NetManager.isConnected();

            //if(isConnected == false)
            //{
            //    Console.WriteLine("Vous n'avez aucun accès à internet.");
            //    Application.Exit();
            //}
            //else
            //{
            //    artistName = "Bob Marley";
            //    monArtist = DeezerApi.getFirstArtistByName(artistName);

            //    if (monArtist == null)
            //    {
            //        Console.WriteLine("Désoler, L'artiste '" + artistName + "' n'est pas sur Deezer");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Information du 1er artiste trouvé :");
            //        Console.WriteLine("-----------------------------------");
            //        Console.WriteLine("Nom : " + monArtist.name);
            //        Console.WriteLine("ID : " + monArtist.id);
            //        Console.WriteLine("Image : " + monArtist.picture);
            //        Console.WriteLine("Lien direct de l'artiste : " + monArtist.link);
            //        Console.WriteLine("Lien de la radio : " + DeezerPlugin.getUrlPluginRadio(monArtist.id));
            //        Console.WriteLine("");
            //        Console.WriteLine("Et voilà le trvaille !");
            //    }
            //}

            #endregion

            #region Tests Sur le parcours de collection

            ////Déclaration et instanciation de la collection (liste) d'artiste
            //List<Artist> lesArtistes = new List<Artist>();

            //string recherche = "bob";

            ////Enlever limitations à 10 recherches
            //DeezerApi.discoComplete = true;

            ////affectation de la collection qui contiendra tous les "bob" trouvé
            //lesArtistes = DeezerApi.getAllArtistsByName(recherche);

            ////affichage valeur 'lesArtistes ainsi que le nombre d'artistes trouvé"
            //Console.WriteLine("Nous avons trouvé " + lesArtistes.Count + " Artiste(s)");


            ////Version avec un "for"
            //int i;
            //for (i = 0; i <= lesArtistes.Count - 1; i++)
            //{
            //    Console.WriteLine(lesArtistes[i]);
            //}

            ////Version avec un "foreach"
            //foreach (Artist unartiste in lesArtistes)
            //{
            //    Console.WriteLine(unartiste);
            //}

            #endregion
        }
    }
}
