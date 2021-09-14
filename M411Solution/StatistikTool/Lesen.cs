using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StatistikTool
{
    public static class Lesen
    {
        public static List<string> Textdateilesen(string[] args)
        {
            if (File.Exists(args[0]))
            {
                List<string> zeilen = new List<string>();

                foreach (string line in File.ReadAllLines(args[0], Encoding.UTF7))
                {
                    zeilen.Add(line);
                }

                return zeilen;
            }

            throw new FileNotFoundException();
        }

    }
}
