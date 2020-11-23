using CC01.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.DAL
{
 public  class EcoleDAO
    {

        public static List<Ecole> Ecoles;

        private const string FILE_NAME1 = @"Ecoles.json";
        private readonly string dbFoler1;
        private FileInfo file1;

        public EcoleDAO(string dbFolder)
        {
            this.dbFoler1 = dbFolder;
            file1 = new FileInfo(Path.Combine(this.dbFoler1, FILE_NAME1));
            if (!file1.Directory.Exists)
            {
                file1.Directory.Create();
            }
            if (!file1.Exists)
            {
                file1.Create().Close();
                file1.Refresh();
            }
            if (file1.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file1.FullName))
                {
                    string json1 = sr.ReadToEnd();
                    Ecoles = JsonConvert.DeserializeObject<List<Ecole>>(json1);
                }

            }
            if (Ecoles == null)
            {
                Ecoles = new List<Ecole>();
            }

        }
        public void Set(Ecole oldEcole, Ecole newEcole)
        {
            var oldIndex = Ecoles.IndexOf(oldEcole);
            var newIndex = Ecoles.IndexOf(newEcole);
            if (oldIndex < 0)

                throw new KeyNotFoundException("cette ecole n'existe pas");

            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("cette ecole existe deja");
            Ecoles[oldIndex] = newEcole;
            Save();

        }
        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(file1.FullName, false))
            {
                string json = JsonConvert.SerializeObject(Ecoles);
                sw.WriteLine(json);
            }

        }
        public void Remove(Ecole ecole)
        {
            Ecoles.Remove(ecole);
            Save();
        }
        public void Add(Ecole ecole)
        {
            var index = Ecoles.IndexOf(ecole);
            if (index >= 0)

                throw new DuplicateNameException("cette ecole n'existe pas ");
            Ecoles.Add(ecole);
            Save();
        }
        public IEnumerable<Ecole> Find()
        {
            return new List<Ecole>(Ecoles);
        }
        public IEnumerable<Ecole> Find(Func<Ecole, bool> Predicate)
        {
            return new List<Ecole>(Ecoles.Where(Predicate).ToArray());
        }

    }
}
