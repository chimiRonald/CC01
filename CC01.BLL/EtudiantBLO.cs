using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
   public  class EtudiantBLO
    {
        EtudiantDAO etudiantRepo;
        public EtudiantBLO(string dbFolder)
        {
            etudiantRepo = new EtudiantDAO(dbFolder);
        }
        public void CreateEtudiant(Etudiant product)
        {
            etudiantRepo.Add(product);
        }

        public void DeleteEtudiant(Etudiant product)
        {
            etudiantRepo.Remove(product);
        }


        public IEnumerable<Etudiant> GetAllEtudiants()
        {
            return etudiantRepo.Find();
        }


        public IEnumerable<Etudiant> GetByMatricule(string matricule)
        {
            return etudiantRepo.Find(x => x.Matricule == matricule);
        }

        public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> predicate)
        {
            return etudiantRepo.Find(predicate);
        }

        public void EditProduct(Etudiant oldEtudiant, Etudiant newEtudiant)
        {
            etudiantRepo.Set(oldEtudiant, newEtudiant);
        }
    }
}
