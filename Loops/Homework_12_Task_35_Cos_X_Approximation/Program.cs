using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_35: Տրված են X իրական և N բնական թվերը։ Գտնել 1 – X2/(2!) + X4/(4!) – … + (–1)N·X2·N/((2·N)!)
//           արտահայտության արժեքը(N! = 1·2·…·N)։ Ստացված թիվը cos(X)-ի մոտավոր արժեքն է։

namespace Homework_12_Task_35_Cos_X_Approximation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing and printing the result
            Console.WriteLine(CosX(Math.PI/4, 10_000_000));
            Console.ReadKey();
        }

        // Returns the sum of first n elements of Cos(x) approximation sequence
        static double CosX(double x, int n)
        {
            double elem = 1, sum = elem;

            for (int i = 1; i <= n; i++)
            {
                elem *= ((-1) * x * x) / (2 * i * (2 * i - 1));
                sum += elem;
            }

            return sum;
        }
    }
}
