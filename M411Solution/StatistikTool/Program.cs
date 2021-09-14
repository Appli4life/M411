using System;
using System.Collections.Generic;

namespace StatistikTool
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> zeilen = Lesen.Textdateilesen(args);

                Console.WriteLine($"Minimum: {Rechner.GetMin(zeilen)}");

                Console.WriteLine($"Maximum: {Rechner.GetMax(zeilen)}");

                Console.WriteLine($"Durchschnitt: {Rechner.GetAvg(zeilen)}");

                Console.WriteLine($"Anzahl: {Rechner.GetAn(zeilen)}");

            }
            catch (Exception es)
            {
                Console.WriteLine(es.Message);
            }

            Console.ReadKey();

        }
    }
}
