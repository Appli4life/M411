using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA
{
    public class ConsoleOutput
    {
        public ConsoleOutput(List<Person> people)
        {
            PrintList(ref people);
        }

        public void PrintList(ref List<Person> people)
        {
            // Referenz auf die Liste erstellen, die Sortiert ist nach Geburtsjahr
            // (Andere Referenz wird von C# automatisch gelöscht, wenn sie nicht mehr gebraucht wird)
            var sortetList = people.OrderByDescending(o => o.Geburtsjahr).ToList();

            foreach (var person in sortetList)
            {
                Console.WriteLine($"{person.Nachname};{person.Vorname};{person.Geburtsjahr}");
            }
        }
    }
}
