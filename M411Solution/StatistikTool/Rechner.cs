using System;
using System.Collections.Generic;

namespace StatistikTool
{
    public static class Rechner
    {
        public static int GetMin(List<string> zahlen)
        {
            int curr = Convert.ToInt32(zahlen[0]);
            int m = curr;

            foreach (var item in zahlen)
            {
                curr = Convert.ToInt32(item);
                if (curr < m)
                {
                    m = curr;
                }

            }

            return m;
        }

        public static int GetMax(List<string> zahlen)
        {
            int curr = Convert.ToInt32(zahlen[0]);
            int m = curr;

            foreach (var item in zahlen)
            {
                curr = Convert.ToInt32(item);
                if (curr > m)
                {
                    m = curr;
                }

            }

            return m;
        }

        public static double GetAvg(List<string> zahlen)
        {
            int s = 0;

            foreach (var item in zahlen)
            {
                s += Convert.ToInt32(item);
            }

            return s / GetAn(zahlen);
        }

        public static int GetAn(List<string> zahlen)
        {
            return zahlen.Count;
        }

    }
}
