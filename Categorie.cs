using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1_tp7
{
    public class Categorie
    {
        private string id;
        private string libelle;

        public string Id { get; set; }
        public string Libelle { get; set; }

        public Categorie()
        {
            Id = "";
            Libelle = "";
        }
        public Categorie(string id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }

        public override string ToString()
        {
            return Libelle;
        }
    }
}