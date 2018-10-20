using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_33: Տրված են X իրական և N բնական թվերը։ Գտնել 1 + X + X2/(2!) + … + XN/(N!) արտահայտության արժեքը(N! = 1·2·…·N)։

namespace Homework_12_Task_33_Calc_The_Sum_Of_A_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing and printing the result
            Console.WriteLine(CalcTheSumOfSeq(10_000_000,2.3));
            Console.ReadKey();
        }

        // Returns the sum of the first n elements of the sequence.
        static double CalcTheSumOfSeq(int n, double x)
        {
            double elem = 1, sum = elem;

            for (int i = 1; i <= n; i++)
            {
                elem *= x / i;
                sum += elem;
            }

            return sum;
        }
    }
}
