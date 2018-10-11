using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_20: Գտնել տրված թվի ամենամեծ և ամենափոքր թվանշանների տարբերության քառակուսին։

namespace Homework_9_Task_20_Square_Of_Max_And_Min_Digit_Diff
{
    class Program
    {
        static void Main(string[] args)
        {
            Title(homework: 9, task: 20, subject: "Using Methods",
                problem: "Given a number n, print the square of a difference between its maximum and minimum digits.");

            int num = ReadInt();
            int res = GetMaxMinDiffSquare(num);

            Console.WriteLine($"The result is: {res}");
            Console.ReadKey();
        }

        /// <summary>
        /// Returning the square of difference between min and max digits of number n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int GetMaxMinDiffSquare(int n)
        {
            int minDigit = 10;
            int maxDigit = 0;
            while (n != 0)
            {
                int tempDigit = n % 10;
                if (minDigit > tempDigit) minDigit = tempDigit;
                if (maxDigit < tempDigit) maxDigit = tempDigit;
                n /= 10;
            }

            int diffMinMax = maxDigit - minDigit;

            return diffMinMax * diffMinMax;
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
    }
}
