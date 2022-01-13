using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPcronyms.Components
{
    class HTMLGeneration
    {
        public static string GenerateHTML(SortedDictionary<string, string> dictionary)
        {
            string output = string.Empty;

            output += GenerateHTMLOpenTag();
            output += GenerateHeadSection();
            output += GenerateStyles();
            output += GenerateBodyOpen();
            output += GenerateTable(dictionary);
            output += GenerateBodyClose();
            output += GenerateHTMLCloseTag();

            return output;
        }

        public static string GenerateHTMLOpenTag()
        {
            return "<html>\r\n";
        }

        public static string GenerateHTMLCloseTag()
        {
            return "</html>\r\n";
        }

        public static string GenerateHeadSection()
        {
            return "" +
                "<head>" +
                "<title>CAPcronyms</title>" +
                "</head>";
        }

        public static string GenerateStyles()
        {
            return "<style>" +
                FileHandling.GetCSSStyles() +
                "</style>";
        }

        public static string GenerateBodyOpen()
        {
            return "<body>";
        }

        public static string GenerateBodyClose()
        {
            return "</body>";
        }

        public static string GenerateTable(SortedDictionary<string, string> dictionary)
        {
            string output = string.Empty;

            output += "<table>" +
                "<thead>" +
                "<tr>" +
                "<td>Letter</td>" +
                "<td>Acronym</td>" +
                "<td>Definition</td>" +
                "</tr>" +
                "</thead>" +
                "<tbody>" +
                GenerateTableContents(dictionary) +
                "</tbody>" +
                "</table>";

            return output;
        }

        public static string GenerateTableContents(SortedDictionary<string, string> dictionary)
        {
            string output = string.Empty;

            char currentLetter = ' ';

            foreach (var line in dictionary)
            {
                output += "<tr>" +
                    "<td>";

                if (currentLetter != line.Key[0])
                {
                    currentLetter = line.Key[0];

                    output += currentLetter;
                }

                output += "</td>" +
                    "<td>" +
                    line.Key +
                    "</td>" +
                    "<td>" +
                    line.Value +
                    "</td>" +
                    "</tr>";
            }

            return output;
        }

    }
}
