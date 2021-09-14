using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA
{
    public class Person
    {
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public string Geburtsjahr { get; set; }

        public Person(string vorname, string nachname, string geburtsjahr)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geburtsjahr = geburtsjahr;
        }
        public override string ToString()
        {
            return $"Vorname:{Vorname}, Nachname: {Nachname}, Geb. Jahr: {Geburtsjahr}";
        }
    }
}
