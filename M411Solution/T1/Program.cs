using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Instanziieren
                TrainingCalc tc = new TrainingCalc();

                // Hinzufügen der Zeiten
                tc.Add(14.41);
                tc.Add(15.02);
                tc.Add(15.11);
                tc.Add(14.78);
                tc.Add(14.89);
                tc.Add(15.05);

                // Schreiben der Resultate
                Console.WriteLine($"Durchschnitt: {tc.GetAvg()}");
                Console.WriteLine($"Summe: {tc.GetSum()}");
                Console.WriteLine($"Min: {tc.GetMin()}");
                Console.WriteLine($"Max: {tc.GetMax()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
