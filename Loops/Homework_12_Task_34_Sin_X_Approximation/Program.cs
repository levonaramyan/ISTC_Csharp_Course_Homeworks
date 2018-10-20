using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_34: Տրված են X իրական և N բնական թվերը։ Գտնել X – X3/(3!) + X5/(5!) – … + (–1)N·X2·N+1/((2·N+1)!)
//           արտահայտության արժեքը(N! = 1·2·…·N)։ Ստացված թիվը sin(X)-ի մոտավոր արժեքն է։

namespace Homework_12_Task_34_Sin_X_Approximation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing and printing the result
            Console.WriteLine(SinX(Math.PI/6, 10_000_000));
            Console.ReadKey();
        }

        // Returns the sum of first n elements of the approximation of Sin(x) function.
        static double SinX(double x, int n)
        {
            double elem = x, sum = elem;

            for (int i = 1; i <= n; i++)
            {
                elem *= (-1)*x * x / (2 * n * (2 * n + 1));
                sum += elem;
            }

            return sum;
        }
    }
}
