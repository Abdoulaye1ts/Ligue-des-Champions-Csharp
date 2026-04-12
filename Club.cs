using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1_tp7
{
    public class Club
    {
        private string code;
        private string nom;
        private string pays;
        private List<Joueur> lstJoueurs;

        public string Code { get; set; }
        public string Nom { get; set; }
        public string Pays { get; set; }
        public List<Joueur> LstJoueurs { get; set; }

        public Club()
        {
            Code = "";
            Nom = "";
            Pays = "";
            LstJoueurs = new List<Joueur>();
        }

        public Club(string code, string nom, string pays)
        {
            Code = code;
            Nom = nom;
            Pays = pays;
            LstJoueurs = new List<Joueur>();
        }

        public void AjouterJoueur(Joueur leJoueur)
        {
            foreach (var joueur in LstJoueurs)
            {
                if (joueur.Id == leJoueur.Id)
                {
                    return;
                }
            }
            LstJoueurs.Add(leJoueur);
        }

        public List<Licence> getNbLicenceActives()
        {
            List<Licence> listeLicencesActives = new List<Licence>();
            foreach (var joueur in LstJoueurs)
            {
                foreach (var licence in joueur.LesLicences)
                {
                    if (licence.estLicenceActive()) 
                    {
                        listeLicencesActives.Add(licence);
                    }
                }
            }
            return listeLicencesActives;
        }

        public override string ToString()
        {
            return "Code du club : " + Code +
                " - Nom du club : " + Nom +
                " - Pays du club : " + Pays;
        }
    }
}
