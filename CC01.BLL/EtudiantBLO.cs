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
        EtudiantDAO EtudiantRepo;
        public  EtudiantBLO(string dbFolder)
        {
            EtudiantRepo = new EtudiantDAO(dbFolder);
            
        }
        public void CreateCarteEtudiant(Etudiant  carteEtudiant)
        {
            EtudiantRepo.Add(carteEtudiant);

        }
        public void EditEtudiant(Etudiant oldEtudiant, Etudiant newEtudiant )
        {
            EtudiantRepo.Set(oldEtudiant, newEtudiant);
        }
        public void DeleteCarteEtudiant (Etudiant carteEtudiant)
        {
            EtudiantRepo.Remove(carteEtudiant);
        }
        public IEnumerable<Etudiant>GetCarteEtudiants()
        {
            return EtudiantRepo.Find();
        }
        public IEnumerable<Etudiant> GetBy(Func<Etudiant,bool>Predicate)
        {
            return EtudiantRepo.Find(Predicate);
        }
    }
}
