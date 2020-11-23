using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    class EcoleBLO
    {
        
        EcoleDAO EcoleRepo;
        public EcoleBLO(string dbFolder)
        {
            EcoleRepo = new EcoleDAO(dbFolder);
            
        }
        public void CreateEcole(Ecole ecole)
        {
            EcoleRepo.Add(ecole);

        }
        public void EditEcole(Ecole oldEcole, Ecole newEcole )
        {
            EcoleRepo.Set(oldEcole, newEcole);
        }
        public void DeleteEcole (Ecole Ecole)
        {
            EcoleRepo.Remove(Ecole);
        }
        public IEnumerable<Ecole>GetEcoles()
        {
            return EcoleRepo.Find();
        }
        public IEnumerable<Ecole> GetEcoleBy(Func<Ecole,bool>Predicate)
        {
            return EcoleRepo.Find(Predicate);
        }
    }
}
