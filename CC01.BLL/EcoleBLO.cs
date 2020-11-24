using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EcoleBLO
    {
        
        //EcoleDAO EcoleRepo;
        //public EcoleBLO(string dbFolder)
        //{
        //    EcoleRepo = new EcoleDAO(dbFolder);
            
        //}
        //public void CreateEcole(Ecole ecole)
        //{
        //    EcoleRepo.Add(ecole);

        //}
        //public void EditEcole(Ecole oldEcole, Ecole newEcole )
        //{
        //    EcoleRepo.Set(oldEcole, newEcole);
        //}
        //public void DeleteEcole (Ecole Ecole)
        //{
        //    EcoleRepo.Remove(Ecole);
        //}
        //public IEnumerable<Ecole>GetEcoles()
        //{
        //    return EcoleRepo.Find();
        //}
        //public IEnumerable<Ecole> GetEcoleBy(Func<Ecole,bool>Predicate)
        //{
        //    return EcoleRepo.Find(Predicate);
        //}
        private EcoleDAO ecoleRepo;
        private string dbFolder;
        public EcoleBLO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            ecoleRepo = new EcoleDAO(dbFolder);
        }
        public void CreateEcole(Ecole oldEcole,Ecole newEcole)
        {
            string filename = null;
            if (!string.IsNullOrEmpty(newEcole.Picture))
            {
                string ext = Path.GetExtension(newEcole.Picture);
                filename = Guid.NewGuid().ToString() + ext;
                FileInfo fileSource = new FileInfo(newEcole.Picture);
                string filePath = Path.Combine(dbFolder, "logo", filename);
                FileInfo fileDest = new FileInfo(filePath);
                if (!fileDest.Directory.Exists)
                    fileDest.Directory.Create();
                fileSource.CopyTo(fileDest.FullName);
            }
            newEcole.Picture = filename;
            ecoleRepo.Add(newEcole);

            if (!string.IsNullOrEmpty(oldEcole.Picture))
                File.Delete(oldEcole.Picture);
        }

        public Ecole GetEcole()
        {
            Ecole ecole = ecoleRepo.Get();
            if (ecole != null)
                if (!string.IsNullOrEmpty(ecole.Picture))
                    ecole.Picture = Path.Combine(dbFolder, "logo", ecole.Picture);
            return ecole;
        }
    }
}
