using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Տրված են X իրական (|X|<1)  և N բնական թվերը։  Հաշվել
// 1 + X/2 – 1·X^2/(2·4) + 1·3·X^3/(2·4·6) – … + (–1)^(N–1)·1·3·…·(2·N–3)·X^N/(2·4·…·(2·N)) արտահայտության արժեքը։
// Ստացված թիվը 1+X-ի մոտավոր արժեքն է։

namespace Homework_9_Task_special1_one_plus_x_approximation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the problem
            Console.WriteLine("Given real-X (|X| < 1) and normal-N numbers, calculate and return:\n");
            Console.WriteLine("1 + X/2 – 1·X^2/(2·4) + 1·3·X^3/(2·4·6) – … + (–1)^(N–1)·1·3·…·(2·N–3)·X^N/(2·4·…·(2·N)) sequence\n");

            // Reading a double X and integer N
            int N = ReadInt();
            Console.WriteLine();
            double X = ReadDouble();

            // Printing the sum of a sequence
            Console.WriteLine("\nSum = " + ApproxOnePlusX(X,N));
            Console.ReadKey();
        }

        /// <summary>
        /// Returning a sum of predefined sequence for X and N
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static double ApproxOnePlusX(double x, int n)
        {
            double res = 1;
            for (int i = 1; i <= n; i++)
            {
                res += GetCurrentElement(x,i);
            }

            return res;
        }

        /// <summary>
        /// Recursively getting and returning n-th selement of the sequence 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static double GetCurrentElement(double x, int n)
        {
            return (n == 1) ? (x / 2) : ((-1) * x * (2 * n - 3.0) / (2 * n) * GetCurrentElement(x, n - 1));
        }

        /// <summary>
        /// Returns an integer, which the user entered in a Console
        /// </summary>
        /// <returns></returns>
        static int ReadInt()
        {
            int num = 0;
            bool isInt = false;
            do
            {
                Console.Write("N = ");
                isInt = int.TryParse(Console.ReadLine(), out num);
                if (!isInt) Console.WriteLine("Incorrect input, please try again:");
            } while (!isInt);

            return num;
        }

        /// <summary>
        /// Returns a double, which the user entered in a Console
        /// </summary>
        /// <returns></returns>
        static double ReadDouble()
        {
            double num = 0;
            bool isDouble = false;
            do
            {
                Console.Write("X = ");
                isDouble = double.TryParse(Console.ReadLine(), out num);
                if (!isDouble) Console.WriteLine("Incorrect input, please try again:");
            } while (!isDouble);

            return num;
        }
    }
}
