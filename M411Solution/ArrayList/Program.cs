using System;
using My.Collections;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList<string>();

            list.Add("Muster");
            list.Add("Müller");
            list.Add("Schmidt");
            
            

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(list[i]);
            }

            // Änderungen an der Liste nicht in foreach-Schleife möglich,
            // da íntern Schleifenzähler mitgeführt wird
            for (int i = list.Count-1; i >= 0; i-- )
            {
                list.RemoveAt(i);
            }
            Console.ReadLine();
        }
    }
}
