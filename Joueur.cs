using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligue_des_champions 
{
    public class Joueur
    {
        private string id;
        private string nom;
        private string prenom;
        private string paysNaissance;
        private DateTime dateNaissance;
        private List<Licence> lesLicences;

        public string Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string PaysNaissance { get; set; }
        public DateTime DateNaissance { get; set; }
        public List<Licence> LesLicences { get; set; }

        public Joueur()
        {
            Id = "";
            Nom = "";
            Prenom = "";
            PaysNaissance = "";
            DateNaissance = new DateTime();
            LesLicences = new List<Licence>();
        }
        public Joueur(string id, string nom, string prenom, string paysNaissance, DateTime dateNaissance)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            PaysNaissance = paysNaissance;
            DateNaissance = dateNaissance;
            LesLicences = new List<Licence>();
        }

        public void AjouterLicence(Licence laLicence)
        {
            foreach (var licence in LesLicences)
            {
                if (licence.NumeroLicence == laLicence.NumeroLicence)
                {
                    return;
                }
            }
            LesLicences.Add(laLicence);
        }
        
        public override string ToString()
        {
            string licences = "";
            foreach (var licence in LesLicences)
            {
                licences += licence.ToString();
            }

            return "Id pratiquant : " + Id +
                " - Nom pratiquant : " + Nom +
                " - Prénom pratiquant : " + Prenom +
                " - Pays de naissance : " + PaysNaissance +
                " - Date de naissance du pratiquant : " + DateNaissance + 
                "\n" + licences;
        }
    }
}


