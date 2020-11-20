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
   public class EtudiantDAO
    {
        
        public static List<Etudiant> Etudiants;
        private const string FILE_NAME = @"Carte.json";
        private readonly string dbFoler;
        private FileInfo file;
        public EtudiantDAO(string dbFolder)
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
                    Etudiants = JsonConvert.DeserializeObject<List<Etudiant>>(json);
                }

            }
            if(Etudiants==null)
            {
                Etudiants = new List<Etudiant>();
            }

        }
        public void Set(Etudiant oldcarteEtudiant,Etudiant newcarteEtudiant)
        {
            var oldIndex = Etudiants.IndexOf(oldcarteEtudiant);
            var newIndex = Etudiants.IndexOf(newcarteEtudiant);
            if(oldIndex<0)
            
                throw new KeyNotFoundException("ce matricule n'existe pas");

            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("ce matricule existe deja");
            Etudiants[oldIndex] = newcarteEtudiant;
            Save();

        }
        public void Save()
        {
           using(StreamWriter sw=new StreamWriter(file.FullName,false))
            {
                string json = JsonConvert.SerializeObject(Etudiants);
                sw.WriteLine(json);
            }

        }
        public void Remove(Etudiant carteEtudiant)
        {
            Etudiants.Remove(carteEtudiant);
            Save();
        }
        public void Add(Etudiant carteEtudiant)
        {
            var index = Etudiants.IndexOf(carteEtudiant);
            if(index>=0)
            
                throw new DuplicateNameException("ce matricule n'existe pas ");
                Etudiants.Add(carteEtudiant);
                Save();
        }
        public IEnumerable<Etudiant> Find()
        {
            return new List<Etudiant>(Etudiants);
        }
        public IEnumerable<Etudiant> Find(Func<Etudiant,bool>Predicate)
        {
            return new List<Etudiant>(Etudiants.Where(Predicate).ToArray());
        }
          


    }
}
