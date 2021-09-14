using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enumerationen.Linie;

namespace Enumerationen
{
    class Program
    {
        static void Main(string[] args)
        {
            Linie linie = new Linie(22, LinienTyp.gestrichelt);
            linie.Draw();

            Console.ReadLine();
        }
    }
}
