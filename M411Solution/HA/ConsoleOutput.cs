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
            var sortetList = people.OrderBy(o => o.Geburtsjahr).ToList();

            foreach (var person in sortetList)
            {
                Console.WriteLine($"{person.Nachname};{person.Vorname};{person.Geburtsjahr}");
            }
        }
    }
}
