using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_17: Գտնել տրված թվի կենտ թվանշաններից ամենափոքրը։

namespace Homework_9_Task_17_The_Least_Odd_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Title(homework: 9, task: 17, subject: "Using Methods",
                problem: "Given a number n, print the least odd digit of n."); // printing a title 

            int myNum = ReadInt(); // reading an integer from console
            int minOdd = GetMinOddDigit(myNum); // getting the min. odd digit

            // If it finds an odd digit printing minOdd, else printing error message. 
            Console.WriteLine((minOdd < 10)? $"The least odd digit is: {minOdd}":
                "The number contains only even digits");
            Console.ReadKey();
        }

        /// <summary>
        /// Returns true, if the given number n is Odd
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool IsOdd (int n)
        {
            return n % 2 != 0;
        }

        /// <summary>
        /// Returns the minimum odd digit of input integer num. If no odd digits found, returns 11.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetMinOddDigit (int num)
        {
            int minOddDigit = 11;             
            while (num != 0)
            {
                int tempDigit = num % 10;
                if (IsOdd(tempDigit) && tempDigit < minOddDigit)
                    minOddDigit = tempDigit;
                num /= 10;
            }

            return minOddDigit;
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
