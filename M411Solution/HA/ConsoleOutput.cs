using System;
using System.Collections.Generic;
using System.Linq;

namespace HA
{
    public class ConsoleOutput
    {
        public ConsoleOutput()
        {
            PrintList();
        }

        public void PrintList()
        {
            // Referenz auf die Liste erstellen, die Sortiert ist nach Geburtsjahr
            // (Andere Referenz wird von C# automatisch gelöscht, wenn sie nicht mehr gebraucht wird)
            //var sortetList = people.OrderByDescending(o => o.Geburtsjahr).ToList();

            //foreach (var person in sortetList)
            //{
            //    Console.WriteLine($"{person.Nachname};{person.Vorname};{person.Geburtsjahr}");
            //}

            CsvReader kevin = new CsvReader();

            LinkedListSimple.LinkedList<Person> people = kevin.Load("daten.csv");

            for (int i = 1; i <= people.Count; i++)
            {
                Console.WriteLine(people.FindByIndex(i));
            }

        }
    }
}
