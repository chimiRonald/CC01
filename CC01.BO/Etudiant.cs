using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.BO
{
    [Serializable]
    public class Etudiant
    {

        public string NomEtudiant { get; set; }
        public string Prenom { get; set; }
        public string Matricule { get; set; }
        public DateTime Age { get; set; }
        public string Numero_Tell { get; set; }
        public string Classe { get; set; }
        public byte[] PhotoEtudiant { get; set; }
        public Etudiant() : base()
        {

        }

        public Etudiant(string nom, string prenom, string matricule, DateTime age, string numero_Tell, string classe,byte[] photoEtudiant, string nom_ecole) 
        {
            NomEtudiant = nom;
            Prenom = prenom;
            Matricule = matricule;
            Age = age;
            Numero_Tell = numero_Tell;
            Classe = classe;
            PhotoEtudiant = photoEtudiant;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Matricule == etudiant.Matricule;
        }
        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}
