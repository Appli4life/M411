using System;

namespace ArrayListSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayListSimple ALS = new ArrayListSimple(50);

                int z = 2;

                ALS.Add(z);

                Console.WriteLine(ALS.GetAt(0));

                ALS.Clear();

                ALS.Add(z);
                Console.WriteLine(ALS.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
            Console.ReadKey();

        }
    }
}
