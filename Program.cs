using CAPcronyms.Components;
using System;
using System.Collections.Generic;

namespace CAPcronyms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = FileHandling.GetInputFileLines();

            SortedDictionary<string, string> dictionary = DataPopulation.PopulateDictionary(data);

            string html = HTMLGeneration.GenerateHTML(dictionary);

            FileHandling.WriteHTMLToFile(html);
        }
    }
}
