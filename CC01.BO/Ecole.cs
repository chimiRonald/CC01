using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
   public class Ecole
    {
        public string Nom { get; set; }
        public string Picture { get; set; }
        public string Addresse { get; set; }
        public string Section { get; set; }

        public Ecole(string nom, string picture, string addresse, string section)
        {
            Nom = nom;
            Picture = picture;
            Addresse = addresse;
            Section = section;
        }

        public Ecole()
        {

        }
    }
}
