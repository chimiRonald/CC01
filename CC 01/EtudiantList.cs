using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_01
{
    class EtudiantList
    {
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public byte[] Picture { get; set; }
        public string NomEcole { get; set; }
        public string AddressEcole { get; set; }
        public string Section { get; set; }
    //    public string CompanyPostalCode { get; set; }
        public byte[] EcoleLogo { get; set; }

        public EtudiantList(string matricule, string nom, string prenom, byte[] picture, string nomEcole, string addressEcole, string section, byte[] ecoleLogo)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            Picture = picture;
            NomEcole = nomEcole;
            AddressEcole = addressEcole;
            Section = section;
            EcoleLogo = ecoleLogo;
        }
    }
}
