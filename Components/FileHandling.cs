using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPcronyms.Components
{
    class FileHandling
    {
        public static string[] GetInputFileLines()
        {
            string path = GetDefaultDataLocation();

            string[] lines = System.IO.File.ReadAllLines(path);

            return lines;
        }

        public static string[] GetInputFileLines(string path)
        { 
            string[] lines = System.IO.File.ReadAllLines(path);

            return lines;
        }

        public static string GetDefaultDataLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\acronyms.txt";
        }

        public static string[] GetCSSStyles()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\styles.css";

            return File.ReadLines(path).ToArray();
        }

        public static void WriteHTMLToFile(string html)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\index.html";

            System.IO.File.WriteAllText(path, html);
        }
    }
}
