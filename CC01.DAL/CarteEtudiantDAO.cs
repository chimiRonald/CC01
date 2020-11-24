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
        private static List<Etudiant> Etudiants;
        private const string FILE_NAME = @"Etudiants.json";
        private readonly string dbFolder;
        private FileInfo file;
        public EtudiantDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    Etudiants = JsonConvert.DeserializeObject<List<Etudiant>>(json);
                }
            }
            if (Etudiants == null)
            {
                Etudiants = new List<Etudiant>();
            }
        }

        public void Set(Etudiant oldEtudiant, Etudiant newEtudiant)
        {
            var oldIndex = Etudiants.IndexOf(oldEtudiant);
            var newIndex = Etudiants.IndexOf(newEtudiant);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The students does'texist !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This student matricule already exists !");
            Etudiants[oldIndex] = newEtudiant;
            Save();
        }

        public void Add(Etudiant etudiant)
        {
            var index = Etudiants.IndexOf(etudiant);
            if (index >= 0)
                throw new DuplicateNameException("This student matricule already exists !");
            Etudiants.Add(etudiant);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(Etudiants);
                sw.WriteLine(json);
            }
        }

        public void Remove(Etudiant etudiant)
        {
            Etudiants.Remove(etudiant);//base sur Product.Equals redefini
            Save();
        }

        public IEnumerable<Etudiant> Find()
        {
            return new List<Etudiant>(Etudiants);
        }

        public IEnumerable<Etudiant> Find(Func<Etudiant, bool> predicate)
        {
            return new List<Etudiant>(Etudiants.Where(predicate).ToArray());
        }


    }
}
