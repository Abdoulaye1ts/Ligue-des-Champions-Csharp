using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1_tp7
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Les catégories
            Categorie categorie1 = new Categorie("01", "Football");
            Categorie categorie2 = new Categorie("02", "Volley Ball");
            Categorie categorie3 = new Categorie("03", "Hand Ball");

            // Les licences 
            Licence licence1 = new Licence(2022, "000A1", categorie1);
            Licence licence2 = new Licence(2024, "000B1", categorie2);
            Licence licence3 = new Licence(2026, "000C1", categorie3);

            // Les joueurs
            Joueur joueur1 = new Joueur("01", "Danilo", "Pereira", "Guinnée-Bissau", new DateTime(1991, 09, 09));
            Joueur joueur2 = new Joueur("02", "Davy", "Klaassen", "Pays-Bas", new DateTime(1993, 02, 21));
            Joueur joueur3 = new Joueur("03", "Lisandro", "Martinez", "Argentine", new DateTime(1998, 01, 18));
            Joueur joueur7 = new Joueur("07", "Manuel", "Neuer", "Allemagne", new DateTime(1986, 03, 27));
            Joueur joueur8 = new Joueur("08", "Corentin", "Tolisso", "France", new DateTime(1994, 08, 03));
            Joueur joueur9 = new Joueur("09", "Robert", "Lewandowski", "Pologne", new DateTime(1988, 08, 21));
            Joueur joueur88 = new Joueur("88", "Lucas", "Vázquez", "Espagne", new DateTime(1991, 07, 01));
            Joueur joueur89 = new Joueur("89", "Vinícius", "Júnior", "Brésil", new DateTime(2000, 07, 12));
            Joueur joueur90 = new Joueur("90", "Karim", "Benzema", "France", new DateTime(1987, 12, 19));
            Joueur joueur94 = new Joueur();
            Joueur joueur95 = new Joueur();
            Joueur joueur96 = new Joueur();
            Joueur joueur97 = new Joueur();
            Joueur joueur98 = new Joueur();
            Joueur joueur99 = new Joueur();

            // Ajout de licence(s) aux joueurs
            joueur1.AjouterLicence(licence1);

            joueur2.AjouterLicence(licence1);
            joueur2.AjouterLicence(licence2);

            joueur3.AjouterLicence(licence1);
            joueur3.AjouterLicence(licence2);
            joueur3.AjouterLicence(licence3);

            joueur7.AjouterLicence(licence1);
            joueur8.AjouterLicence(licence1);
            joueur9.AjouterLicence(licence1);
            joueur88.AjouterLicence(licence1);
            joueur89.AjouterLicence(licence1);
            joueur90.AjouterLicence(licence1);
            joueur94.AjouterLicence(licence1);
            joueur95.AjouterLicence(licence1);
            joueur96.AjouterLicence(licence1);
            joueur97.AjouterLicence(licence1);
            joueur98.AjouterLicence(licence1);
            joueur99.AjouterLicence(licence1);

            // Les clubs
            Club club1 = new Club("AFC", "Ajax", "NED");
            Club club2 = new Club("CAM", "Club Atlético de Madrid", "ESP");
            Club club3 = new Club("FCB", "FC Bayern Munchen", "GER");
            Club club4 = new Club("RMC", "Real Madrid CF", "ESP");

            // La ligue des champions
            LigueDesChampions ligue = new LigueDesChampions(2022, "UEFA", "La ligue des champions");

            // Autres          
            string murEtoile = new string('*', 40);
            string murDiese = new string('#', 100);


            // -- DEBUT DU PROGRAM --
            Console.WriteLine(murEtoile);

            // Infos ligue
            Console.WriteLine("\nLa ligue des champions : ");
            Console.WriteLine(ligue.ToString());

            Console.WriteLine(murEtoile);

            //---------------------------------------------------------------------------------------------------------------
            // Club 1

            Console.WriteLine($"{club1.ToString()}");

            Console.WriteLine(murEtoile);

            // Infos joueur 1
            Console.WriteLine($"\n{joueur1.ToString()}");

            Console.WriteLine(murEtoile);

            // Infos joueur 2
            Console.WriteLine($"\n{joueur2.ToString()}");

            Console.WriteLine(murEtoile);

            // Infos joueur 3
            Console.WriteLine($"\n{joueur3.ToString()}");

            Console.WriteLine(murDiese);

            //---------------------------------------------------------------------------------------
            // Club 2

            Console.WriteLine($"{club2.ToString()}");

            Console.WriteLine(murEtoile);

            // Infos du joueur 1
            Console.WriteLine($"\n{joueur1.ToString()}");

            Console.WriteLine(murEtoile);

            // Infos du joueur 2
            Console.WriteLine($"\n{joueur2.ToString()}");

            Console.WriteLine(murEtoile);

            // Infos du joueur 3
            Console.WriteLine($"\n{joueur3.ToString()}");

            Console.WriteLine(murDiese);

            //---------------------------------------------------------------------------------------------------
            // Club 3 

            Console.WriteLine($"{club3.ToString()}");
            Console.WriteLine(murEtoile);

            // Infos du joueur 7
            Console.WriteLine($"\n{joueur7.ToString()}");

            Console.WriteLine(murEtoile);

            // Infos du joueur 8
            Console.WriteLine($"\n{joueur8.ToString()}");

            Console.WriteLine(murEtoile);

            // Infos du joueur 9
            Console.WriteLine($"\n{joueur9.ToString()}");

            Console.WriteLine(murDiese);

            //---------------------------------------------------------------------------------------------------
            // Club 4

            Console.WriteLine(club4.ToString());

            Console.WriteLine(murEtoile);

            // Infos joueur 88
            Console.WriteLine($"\n{joueur88.ToString()}");

            Console.WriteLine(murEtoile);

            // Infos joueur 89
            Console.WriteLine($"\n{joueur89.ToString()}");

            // Status des licences
            Console.WriteLine($"Status de la licence n°{licence1.NumeroLicence}: {licence1.estLicenceActive()}");
            Console.WriteLine($"Status de la licence n°{licence2.NumeroLicence}: {licence2.estLicenceActive()}");
            Console.WriteLine($"Status de la licence n°{licence3.NumeroLicence}: {licence3.estLicenceActive()}");




        }
    }
}
