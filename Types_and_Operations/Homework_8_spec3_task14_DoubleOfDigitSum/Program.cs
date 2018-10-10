using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_14:
// Ներածել n թիվը։ Արտածել yes, եթե այն հավասար է իր թվանշանների գումարի կրկնապատիկին, no՝ հակառակ դեպքում։

namespace Homework_8_spec3_task14_DoubleOfDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro
            Console.WriteLine("Checking if the number n is a double of the sum of its digits");

            // Initializing variables
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int nDupl = n;
            int digSum = 0;

            // calculating the sum of digits of n
            while (nDupl > 0)
            {
                digSum += nDupl % 10;
                nDupl /= 10;
            }

            // Checking and accordingly printing the result
            Console.WriteLine((n == digSum * 2) ? "yes" : "no");
            Console.ReadKey();
        }
    }
}
