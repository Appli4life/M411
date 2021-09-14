using System;

namespace LinkedListSimple
{
    class Program
    {
        static void Main()
        {
            try
            {
               
                Console.WriteLine(Rekursion(3));

                Console.ReadKey();

                LinkedList<string> mylist = new LinkedList<string>();

                mylist.Clear();
                mylist.Add("Simon");

                Console.WriteLine(mylist.ToString());

                Console.WriteLine(mylist.ToString());

                Console.WriteLine($"Beinhaltet(Tim): {mylist.Contains("Tim")}");

                Console.WriteLine(mylist.FindByIndex(1));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
        public static ulong Rekursion(ulong n)
        {
            if (n > 1)
            {
                return n * Rekursion(n - 1);
            }

            return 1;
        }
    }
}
