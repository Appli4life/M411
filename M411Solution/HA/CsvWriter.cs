using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA
{
    public class CsvWriter
    {

        private const string  dateiname = "daten.csv";

        public void Save(LinkedListSimple.LinkedList<Person> list)
        {
            
            if (File.Exists(dateiname))
            {
                var sw = new StreamWriter(dateiname, true, encoding: Encoding.UTF7);

                for (int i = 1; i <= list.Count; i++)
                {
                    string daten = $"\n{list.FindByIndex(i).Nachname};{list.FindByIndex(i).Vorname};{list.FindByIndex(i).Geburtsjahr}";
                    sw.Write(daten);
                } 
               
                sw.Close();
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

    }
}
