using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligue_des_champions
{
    public class LigueDesChampions
    {
        private int annee;
        private string code;
        private string nom;
        private List<Club> lesClubs;

        public int Annee { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public List<Club> LesClubs { get; set; }

        public LigueDesChampions()
        {
            Annee = 0;
            Code = "";
            Nom = "";
            LesClubs = new List<Club>();
        }

        public LigueDesChampions(int annee, string code, string nom)
        {
            Annee = annee;
            Code = code;
            Nom = nom;
            LesClubs = new List<Club>();
        }

        public void AjouterClub(Club leClub)
        {
            foreach (var club in LesClubs)
            {
                if (club.Code == leClub.Code)
                {
                    return;
                }
            }
            LesClubs.Add(leClub);
        }

        public List<Licence> getNbLicenceParLigue()
        {
            List<Licence> listLicencesActives = new List<Licence>();
            foreach (var club in LesClubs)
            {
                foreach (var joueur in club.LstJoueurs) 
                {
                    foreach (var licence in joueur.LesLicences)
                    {
                        if (licence.estLicenceActive())
                        {
                            listLicencesActives.Add(licence);
                        }
                    }

                }
            }
            return listLicencesActives;
        }

        public override string ToString()
        {
            return "Code : " + Code +
                " - Nom : " + Nom +
                " - Année : " + Annee;
        }
    }
}
