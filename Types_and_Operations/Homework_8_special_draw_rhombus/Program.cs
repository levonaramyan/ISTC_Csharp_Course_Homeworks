using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PROBLEM: Given the side a of a rhombus, draw a rhombus with '*' symbols with a given side = a.

namespace Homework_8_special_draw_rhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type the length of the rhombus");
            int a = int.Parse(Console.ReadLine()); // reading the side

            // initializing the longest line of a rhombus
            string rhombus = "";
            for (int i = 1; i <= 2 * a - 1; i++)
                rhombus = $"{rhombus}*";

            // adding symmetrically one line below and one line above
            for (int i = a - 1; i > 0; i--)
            {
                int b = 2 * i - 1;
                int c = a - i;
                string currentLine = "";

                // Adding '*'-s in currrent line
                for (int j = 1; j <= b; j++)
                {
                    currentLine = $"{currentLine}*";
                }

                // Adding spaces in current line
                for (int j = 1; j <= c; j++)
                {
                    currentLine = $" {currentLine}";
                }

                // putting one currentLine below, and one above
                rhombus = $"{currentLine}\n{rhombus}\n{currentLine}";
            }

            // Printing the rhombus
            Console.WriteLine(rhombus);
            Console.ReadKey();
        }
    }
}
