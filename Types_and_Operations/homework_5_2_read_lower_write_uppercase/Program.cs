using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PROBLEM: read from consol a lowercase English letter
//          and write its uppercase representation

namespace homework_5_2_read_lower_write_uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a lowercase english text, for conversion to uppercase" +
                "\nIf you want to stop conversions and exit, just type any digit");
            bool exit = false;

            while (!exit)
            {                
                ConsoleKeyInfo consolKeyInfo = Console.ReadKey();
                string key = consolKeyInfo.KeyChar.ToString();
                Console.WriteLine($" {key.ToUpper()}");
                exit = int.TryParse(key, out int i);
            }

            Console.WriteLine("press any key to exit from console");
            Console.ReadKey();
        }
    }
}
