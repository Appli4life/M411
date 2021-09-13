using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA
{
    public class CsvReader
    {
        public List<Person> Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                List<Person> people = new List<Person>();

                foreach (string line in File.ReadAllLines(fileName, Encoding.UTF8))
                {
                    string[] parts = line.Split(';');

                    Person p = new Person(parts[0], parts[1], parts[2]);    

                    people.Add(p);
                }

                return people;
            }

            throw new FileNotFoundException();
        }
    }
}
