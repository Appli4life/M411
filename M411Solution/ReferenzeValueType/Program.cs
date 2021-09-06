using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenzeValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int z1 = 0;
            int z2 = z1;
            z1 = 0;

            change(z1);
            Console.WriteLine($"Wertetyp: z1 = {z1}");

            change(ref z1);
            Console.WriteLine($"Referenztyp: z1 = {z1}");

            var zClass = new ZahlClass() { zahl1 = 0 };
            change(zClass);
            Console.WriteLine($"Referenztyp (Klasse): zahl1 = {zClass.zahl1}");


            zClass.zahl1 = 100;
            var zClass2 = zClass;
            change(zClass2);
            Console.WriteLine($"Referenztyp (Klasse): zahl2 = {zClass.zahl1}");
           
            
            var zStruct = new ZahlStruct() { zahl1 = 0 };
            change(zStruct);
            Console.WriteLine($"Referenztyp (Struct): zah3 = {zStruct.zahl1}");

            var zStruct2 = zStruct;
            zStruct2.zahl1 = 10;
            Console.WriteLine($"Referenztyp (Struct): zahl4 = {zStruct.zahl1}");


            Console.Read();

        }

        /// <summary>
        /// Call by Value
        /// </summary>
        /// <param name="zahl1"></param>
        private static void change(int zahl1)
        {
            zahl1 = 100;
        }

        /// <summary>
        /// Call by Referenz
        /// </summary>
        /// <param name="zahl1"></param>
        private static void change(ref int zahl1)
        {
            zahl1 = 100;
        }
        /// <summary>
        /// class (Call by Referenze)
        /// </summary>
        /// <param name="zahl"></param>
        private static void change(ZahlClass zahl)
        {
            zahl.zahl1 = 100;
        }
        /// <summary>
        /// struct (Call by Value)
        /// </summary>
        /// <param name="zahl"></param>
        private static void change(ZahlStruct zahl)
        {
            zahl.zahl1 = 100;
        }
    }
}
