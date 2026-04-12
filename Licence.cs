using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1_tp7
{
    public class Licence
    {
        private int anneeLicence;
        private string numeroLicence;
        private Categorie laCategorie;

        public int AnneeLicence { get; set; }
        public string NumeroLicence { get; set; }
        public Categorie LaCategorie { get; set; }

        public Licence()
        {
            AnneeLicence = 0;
            NumeroLicence = "";
            LaCategorie = new Categorie();
        }
        public Licence(int annee, string numeroLicence, Categorie laCategorie)
        {
            AnneeLicence = annee;
            NumeroLicence = numeroLicence;
            LaCategorie = laCategorie;
        }

        public bool estLicenceActive()
        {
            return AnneeLicence == DateTime.Now.Year;
        }

        public override string ToString()
        {
            return "\nAnnée : " + AnneeLicence +
                " - Numéro de licence : " + NumeroLicence +
                " - Catégorie rattachement licence : " + LaCategorie.ToString();
        }
    }
}