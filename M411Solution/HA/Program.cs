using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person("Simon", "Müller", "2003");

                PersonenVerwaltung.AddPerson(p);

                ConsoleOutput consoleOutput = new ConsoleOutput(new CsvReader().Load("daten.csv"));

                Console.ReadKey();

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
