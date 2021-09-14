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
        public LinkedListSimple.LinkedList<Person> Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                LinkedListSimple.LinkedList<Person> people = new LinkedListSimple.LinkedList<Person>();

                foreach (string line in File.ReadAllLines(fileName, Encoding.UTF7))
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
