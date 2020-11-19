using CC01.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CC01.DAL
{
   public class CarteEtudiantDAO
    {
        public static List<CarteEtudiant> carteEtudiants;
        private const string FILE_NAME = @"Carte.json";
        private readonly string dbFoler;
        private FileInfo file;
        public CarteEtudiantDAO(string dbFolder)
        {
            this.dbFoler = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFoler, FILE_NAME));
            if(!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if(!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if(file.Length>0)
            {
                using(StreamReader sr=new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    carteEtudiants = JsonConvert.DeserializeObject<List<CarteEtudiant>>(json);
                }

            }
            if(carteEtudiants==null)
            {
                carteEtudiants = new List<CarteEtudiant>();
            }

        }
        public void Set(CarteEtudiant oldcarteEtudiant,CarteEtudiant newcarteEtudiant)
        {
            var oldIndex = carteEtudiants.IndexOf(oldcarteEtudiant);
            var newIndex = carteEtudiants.IndexOf(newcarteEtudiant);
            if(oldIndex<0)
            
                throw new KeyNotFoundException("ce matricule n'existe pas");

            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("ce matricule existe deja");
            carteEtudiants[oldIndex] = newcarteEtudiant;
            Save();

        }
        public void Save()
        {
           using(StreamWriter sw=new StreamWriter(file.FullName,false))
            {
                string json = JsonConvert.SerializeObject(carteEtudiants);
                sw.WriteLine(json);
            }

        }
        public void Remove(CarteEtudiant carteEtudiant)
        {
            carteEtudiants.Remove(carteEtudiant);
            Save();
        }
        public void Add(CarteEtudiant carteEtudiant)
        {
            var index = carteEtudiants.IndexOf(carteEtudiant);
            if(index>=0)
            
                throw new DuplicateNameException("ce matricule n'existe pas ");
                carteEtudiants.Add(carteEtudiant);
                Save();
        }
        public IEnumerable<CarteEtudiant> Find()
        {
            return new List<CarteEtudiant>(carteEtudiants);
        }
        public IEnumerable<CarteEtudiant> Find(Func<CarteEtudiant,bool>Predicate)
        {
            return new List<CarteEtudiant>(carteEtudiants.Where(Predicate).ToArray());
        }
          


    }
}
