using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA
{
    public static class PersonenVerwaltung
    {
        private const string dateiname = "daten.csv"; 

        public static void AddPerson(Person person)
        {
            if (File.Exists(dateiname))
            {
                var sw = new StreamWriter(dateiname, true);

                string daten = $"\n{person.Nachname};{person.Vorname};{person.Geburtsjahr}";

                sw.Write(daten);

                sw.Close();
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
