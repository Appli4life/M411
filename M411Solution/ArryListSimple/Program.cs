using System;

namespace ArrayListSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListSimple ALS = new ArrayListSimple(50);

            int z = 2;

            ALS.Add(z);

            Console.WriteLine(ALS.GetAt(0));

            ALS.Clear();

            ALS.Add(z);
            Console.WriteLine(ALS.Count);

            Console.ReadKey();

        }
    }
}
