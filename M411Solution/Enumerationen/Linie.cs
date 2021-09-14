using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerationen
{
    public class Linie
    {
        public enum LinienTyp
        {
            /// <summary>
            /// Durchgezogene Linie
            /// </summary>
            durchgezogen,
            /// <summary>
            /// Gestrichelte Linie
            /// </summary>
            gestrichelt,
            /// <summary>
            /// Gepunktete Linie
            /// </summary>
            gepucktet,
            /// <summary>
            /// Punkt, Strich Linie
            /// </summary>
            punktStrich
        }

        /// <summary>
        /// Länge der Linie
        /// </summary>
        private double _length;

        /// <summary>
        /// Typ der Linie
        /// </summary>
        private LinienTyp _typ; 

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="length">Länge der Linie</param>
        /// <param name="typ">Typ der Linie</param>
        public Linie(double length, LinienTyp typ)
        {
            _length = length;
            _typ = typ;
        }

        /// <summary>
        /// Linie Zeichnen
        /// </summary>
        public void Draw()
        {
            switch (this._typ)
            {
                case LinienTyp.durchgezogen:
                    Console.WriteLine($"Linie ist Durchgezogen, Länge: {this._length}");
                    break;
                case LinienTyp.gestrichelt:
                    Console.WriteLine($"Linie ist Gestrichelt, Länge: {this._length}");
                    break;
                case LinienTyp.gepucktet:
                    Console.WriteLine($"Linie ist Gebunktet, Länge: {this._length}");
                    break;
                case LinienTyp.punktStrich:
                    Console.WriteLine($"Linie ist punkt-strich, Länge: {this._length}");
                    break;
                default:
                    break;
            }
        }
    }
}
