using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
   public  class CarteEtudiantBLO
    {
        CarteEtudiantDAO carteEtudiantRepo;
        public  CarteEtudiantBLO(string dbFolder)
        {
            carteEtudiantRepo = new CarteEtudiantDAO(dbFolder);
            
        }
        public void CreateCarteEtudiant(CarteEtudiant  carteEtudiant)
        {
            carteEtudiantRepo.Add(carteEtudiant);

        }
        public void DeleteCarteEtudiant (CarteEtudiant carteEtudiant)
        {
            carteEtudiantRepo.Remove(carteEtudiant);
        }
        public IEnumerable<CarteEtudiant>GetCarteEtudiants()
        {
            return carteEtudiantRepo.Find();
        }
        public IEnumerable<CarteEtudiant> GetBy(Func<CarteEtudiant,bool>Predicate)
        {
            return carteEtudiantRepo.Find(Predicate);
        }
    }
}
