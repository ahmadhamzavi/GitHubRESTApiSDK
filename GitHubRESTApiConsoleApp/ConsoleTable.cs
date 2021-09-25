using GitHubRESTApiSDK;
using System;

namespace GitHubRESTApiConsoleApp
{
    public class ConsoleTable
    {
        private int tableWidth = 100;
        private string[] _headers;
        private static ConsoleTable _consoleTable;
        public ConsoleTable(string[] headers)
        {
            _headers = headers;
        }
        public static ConsoleTable getInstance(string[] headers)
        {
            if (_consoleTable.IsNull())
            {
                _consoleTable = new ConsoleTable(headers);
            }
            return _consoleTable;
        }
        public void PrintHeaders()
        {
            Console.WriteLine("\n");
            PrintLine();
            PrintRow(_headers);
            PrintLine();
        }
        public void PrintData(string[] data)
        {          
            if (data.Length != _headers.Length)
            {
                throw new ArgumentException();
            }
            PrintRow(data);
            PrintLine();
        }
        public void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth - 2));
        }
        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (text.IsNullOrWhiteSpace())
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

    }
}
