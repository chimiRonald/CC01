using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.BO
{
   public class Etudiant:Ecole
    {
        private string v1;
        private string text1;
        private string text2;
        private string text3;
        private byte[] v2;
        private string filename;

        public string NomEtudiant { get; set; }
        public string Prenom { get; set; }
        public string Matricule { get; set; }
        public int Age { get; set; }
        public string Numero_Tell { get; set; }
        public string Classe { get; set; }
        public byte[] PhotoEtudiant { get; set; }
        public Etudiant() : base()
        {

        }

        public Etudiant(string nom, string prenom, string matricule, int age, string numero_Tell, string classe,byte[] photoEtudiant, string nom_ecole,byte[] picture, string addresse, string section) : base(nom_ecole,picture, addresse,section)
        {
            NomEtudiant = nom;
            Prenom = prenom;
            Matricule = matricule;
            Age = age;
            Numero_Tell = numero_Tell;
            Classe = classe;
            PhotoEtudiant = photoEtudiant;
        }

        public Etudiant(string v1, string text1, string text2, string text3, byte[] v2)
        {
            this.Matricule = v1;
            this.Nom = text1;
            this.Prenom = text2;
            this.Classe = text3;
            this.Picture = v2;
           // this.filename = filename;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Matricule == etudiant.Matricule;
        }
    }
}
