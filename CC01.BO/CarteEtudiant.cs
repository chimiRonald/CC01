using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
   public class CarteEtudiant:Ecole
    {

        public string NomEtudiant { get; set; }
        public string Prenom { get; set; }
        public string Matricule { get; set; }
        public int Age { get; set; }
        public string Numero_Tell { get; set; }
        public string Classe { get; set; }

        public CarteEtudiant() : base()
        {

        }

        public CarteEtudiant(string nom, string prenom, string matricule, int age, string numero_Tell, string classe, string nom_ecole) : base(nom_ecole)
        {
            NomEtudiant = nom;
            Prenom = prenom;
            Matricule = matricule;
            Age = age;
            Numero_Tell = numero_Tell;
            Classe = classe;
        }

        public override bool Equals(object obj)
        {
            return obj is CarteEtudiant etudiant &&
                   Matricule == etudiant.Matricule;
        }
    }
}
