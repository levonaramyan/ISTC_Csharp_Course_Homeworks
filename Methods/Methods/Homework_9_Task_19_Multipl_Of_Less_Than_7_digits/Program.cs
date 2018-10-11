using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_Task_19_Multipl_Of_Less_Than_7_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Title(homework: 9, task: 19, subject: "Using Methods",
                problem: "Given a number n, print the multiplication of its even digits, which are < 7."); // printing a title 

            int myNum = ReadInt(); // reading an integer from console
            int mult = GetLessThan7EvenDigitMult(myNum); // getting the result of multiplication

            // Printing the result 
            Console.WriteLine($"The result is: {mult}");
            Console.ReadKey();
        }

        /// <summary>
        /// Returns the multiplication of the even digits of n, which are less than 7.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetLessThan7EvenDigitMult(int num)
        {
            int mult = 1;
            while (num != 0)
            {
                int tempDigit = num % 10;
                if (tempDigit != 0 && !IsOdd(tempDigit) && tempDigit < 7)
                    mult *= tempDigit;
                num /= 10;
            }

            return mult;
        }

        /// <summary>
        /// Returns true, if the given number n is Odd
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool IsOdd(int n)
        {
            return n % 2 != 0;
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
                Console.Write("num = ");
                isInt = int.TryParse(Console.ReadLine(), out num);
                if (!isInt) Console.WriteLine("Incorrect input, please try again:");
            } while (!isInt);

            return num;
        }

        /// <summary>
        /// Printing formatted title in a console.
        /// </summary>
        /// <param name="homework"></param>
        /// <param name="subject"></param>
        /// <param name="task"></param>
        /// <param name="problem"></param>
        static void Title(int homework = 0, string subject = "undefined", int task = 0, string problem = "quick task")
        {
            string firstLine = $"Homework {homework}: {subject}";
            string separ = new string('-', firstLine.Length);
            string secondLine = $"Task {task}:\t{problem}";

            Console.WriteLine($"{firstLine}\n{separ}\n{secondLine}\n");
        }
    }
}
