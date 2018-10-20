using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_36: Տրված են X իրական(|X|<1) և N բնական թվերը։ Գտնել X–X2/2 + X3/3 –…+ (–1)N–1·XN/N արտահայտության արժեքը։
//           Ստացված թիվը ln(1+X)-ի մոտավոր արժեքն է։

namespace Homework_12_Task_36_One_Plus_X_approximation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OnePlusXApprox(0.5, 10_000_000));
            Console.ReadKey();
        }

        // Returns the sum of first n elements of the approximation sequence of function ln(1+x).
        static double OnePlusXApprox(double x, int n)
        {
            double elem = x, sum = elem;

            for (int i = 2; i <= n; i++)
            {
                elem *= (-1) * x * (i - 1.0) / i;
                sum += elem;
            }

            return sum;
        }
    }
}
