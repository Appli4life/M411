using System;

namespace T1
{
    /// <summary>
    /// Klasse TrainingCalc
    /// </summary>
    public class TrainingCalc
    {
        /// <summary>
        /// Rundenzeiten
        /// </summary>
        protected double[] Rundenzeiten; // Theoretisch mit einer Liste eifacher (Ich wollte eine Herausforderung :))

        /// <summary>
        /// Zähler
        /// </summary>
        public int Count { get; private set; } = 0;

        /// <summary>
        /// Hinzufügen
        /// </summary>
        /// <param name="zeit">Rundenzeit</param>
        public void Add(double zeit)
        {
            // Der lauf kann nicht in 0 Sekunden erfolgen!
            if (zeit < 0.0)
            {
                throw new Exception($"Ungültige Rundenzeit. Rundenzeit: {zeit}");
            }
            // Beim Hinzufügen wird das Array um eines Verlängert
            double[] temp = new double[Count + 1];
            Array.Copy(Rundenzeiten, temp, this.Count);
            Rundenzeiten = temp;
            Rundenzeiten[Count] = zeit;
            Count++;
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public TrainingCalc()
        {
            Rundenzeiten = new double[0];
        }

        /// <summary>
        /// Nidrigste Rundenzeiz
        /// </summary>
        /// <returns>Rundenzeit</returns>
        public double GetMin()
        {
            double m = Rundenzeiten[0];
            foreach (var item in Rundenzeiten)
            {
                if (item < m)
                {
                    m = item;
                }
            }
            return m;
        }

        /// <summary>
        /// Höchste Rundenzeit
        /// </summary>
        /// <returns>Rundenzeit</returns>
        public double GetMax()
        {
            double m = Rundenzeiten[0];
            foreach (var item in Rundenzeiten)
            {
                if (item > m)
                {
                    m = item;
                }
            }
            return m;
        }

        /// <summary>
        /// Durchschnitt
        /// </summary>
        /// <returns>Rundenzeit Durchschnitt</returns>
        public double GetAvg()
        {
            // Durch null teilen geht nicht
            if (Count == 0)
            {
                throw new Exception($"Durchschnitt kann nicht mit keinen Zahlen gerechnet werden!");
            }

            double d = 0;
            foreach (var item in Rundenzeiten)
            {
                d += item;
            }

            d = d / this.Count;

            return d;
        }

        /// <summary>
        /// Summe der Rundenzahlen
        /// </summary>
        /// <returns>Summe</returns>
        public double GetSum()
        {
            double s = 0;
            foreach (var item in Rundenzeiten)
            {
                s += item;
            }
            return s;
        }
    }
}
