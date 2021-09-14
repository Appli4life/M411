using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListSimple;

namespace HA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                LinkedListSimple.LinkedList<Person> list = new LinkedListSimple.LinkedList<Person>();
                list.Add(new Person("Müller", "Simon", "1969"));
                list.Add(new Person("Schellenberg", "Andrin", "1979"));
                list.Add(new Person("Müller", "Roger", "1889"));
                list.Add(new Person("Downsy", "MArkus", "1976"));
                list.Add(new Person("Perumpamgucci", "Nevin", "2020"));
                list.Add(new Person("Dödödöd", "Schlingel", "1990"));
                list.Add(new Person("Davis", "Marcel", "11"));



                CsvWriter csvWriter = new CsvWriter();

                csvWriter.Save(list);


                ConsoleOutput nevin = new ConsoleOutput();


                Console.ReadKey();

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
