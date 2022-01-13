using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPcronyms.Components
{
    class DataPopulation
    { 
        public static SortedDictionary<string, string> PopulateDictionary(string[] data)
        {
            SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();

            foreach (var line in data)
            {
                if (!line.Contains("="))
                    continue;

                string[] lineFragments = line.Split('=');

                string key = lineFragments[0];
                string value = lineFragments[1];

                dictionary.Add(key, value);
            }

            return dictionary;
        }
    }
}
