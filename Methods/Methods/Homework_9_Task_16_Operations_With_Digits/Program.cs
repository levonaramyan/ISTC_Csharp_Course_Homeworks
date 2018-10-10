using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_16: Հաշվել տրված բնական թվի թվանշանների գումարը, քանակը, արտադրյալը։

namespace Homework_9_Task_16_Operations_With_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 9: Using Methods\nTask_16: Given an integer n, print\n");
            Console.WriteLine("\t1. The Sum of digits\n\t2. The number of digits\n\t3. The multiplication of digits\n");

            int n = ReadInt();
            int sum = GetDigitSum(n);
            int mult = GetDigitMult(n);
            int num = CountDigits(n);

            Console.WriteLine($"\n1. The Sum of digits in {n} is: {sum}");
            Console.WriteLine($"\n2. The number of digits in {n} is: {num}");
            Console.WriteLine($"\n2. The multiplication of digits in {n} is: {mult}");

            Console.ReadKey();
        }


        /// <summary>
        /// Returns the sum of digits of the given integer
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetDigitSum(int num)
        {
            int digitSum = 0;

            while (num > 0)
            {
                digitSum += num % 10;
                num /= 10;
            }

            return digitSum;
        }

        /// <summary>
        /// Returns the multiplication of digits of the given integer
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetDigitMult(int num)
        {
            int digitMult = 1;

            while (num > 0)
            {
                digitMult *= num % 10;
                num /= 10;
            }

            return digitMult;
        }

        /// <summary>
        /// Returns the number of digits of the given integer
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int CountDigits(int num)
        {
            int count = 0;

            while (num > 0)
            {                
                num /= 10;
                count++;
            }

            return count;
        }

        /// <summary>
        /// Returns an integer, which the user entered in a Console
        /// </summary>
        /// <returns></returns>
        static int ReadInt ()
        {
            int num = 0;
            bool isInt = false;
            do
            {
                Console.Write("num = ");
                isInt = int.TryParse(Console.ReadLine(), out num);
                if (!isInt) Console.WriteLine("Incorrect input, please try again:");
            } while (!isInt);

            return num;
        }
    }
}
