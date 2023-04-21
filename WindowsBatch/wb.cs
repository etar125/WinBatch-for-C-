using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsBatch
{
    public class WinBatch
    {
        public string[] code;

        public WinBatch() { }
        public WinBatch(string[] code) { this.code = code; }

        public void Do()
        {
            foreach (string s in code)
            {
                Dictionary<char, ConsoleColor> colors = new Dictionary<char, ConsoleColor>
                {
                    { '0', ConsoleColor.Black },
                    { '1', ConsoleColor.DarkBlue },
                    { '2', ConsoleColor.DarkGreen },
                    { '3', ConsoleColor.DarkCyan },
                    { '4', ConsoleColor.DarkRed },
                    { '5', ConsoleColor.DarkMagenta},
                    { '6', ConsoleColor.DarkYellow },
                    { '7', ConsoleColor.Gray },
                    { '8', ConsoleColor.Black },
                    { '9', ConsoleColor.Blue },
                    { 'a', ConsoleColor.Green },
                    { 'b', ConsoleColor.Cyan },
                    { 'c', ConsoleColor.Red },
                    { 'd', ConsoleColor.Magenta },
                    { 'e', ConsoleColor.Yellow },
                    { 'f', ConsoleColor.White },
                };
                if (s == "cls")
                    Console.Clear();
                else if (s.StartsWith("color "))
                {
                    string co = s.Remove(0, 6).ToLower();
                    Console.BackgroundColor = colors[co[0]];
                    Console.ForegroundColor = colors[co[1]];
                }
                else if (s.StartsWith("echo "))
                {
                    string co = s.Remove(0, 5);
                    Console.WriteLine(co);
                }
                else if (s.StartsWith("title "))
                {
                    string co = s.Remove(0, 6);
                    Console.Title = co;
                }
                else if (s == "pause")
                    Console.ReadKey(true);
                else if (s == "echo.")
                    Console.Write("\n");
            }
        }
        public string[] Convert()
        {
            return null;
        }
    }
}
