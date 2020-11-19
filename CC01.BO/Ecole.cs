using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
   public abstract class Ecole
    {
        public string Nom { get; set; }

        public Ecole(string nom)
        {
            Nom = nom;
        }
        public Ecole()
        {

        }
    }
}
