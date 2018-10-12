using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_21: Արտածել տրված թվի բոլոր բաժանարարները։
// Խնդիր_22: Հաշվել տրված թվի բոլոր բաժանարարների գումարը։
// Խնդիր_23: Հաշվել տրված թվի բոլոր բաժանարարների գումարի և դրանց քանակի քանորդը։

namespace Homework_9_Task_21_22_23_Divisers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the title and tasks.
            Console.WriteLine("Homework 9: Using Methods\n");
            Console.WriteLine("Task 21: Given a number N, print all of its divisers\n");
            Console.WriteLine("Task 22: Given a number N, print the sum of all of its divisers\n");
            Console.WriteLine("Task 23: Given a number N, print the mean of all of its divisers\n");

            // Reading an integer from Console.
            Console.WriteLine("Please enter the input number:");
            int num = ReadInt();

            // Printing the results of Tasks 21, 22 and 23 in Console.
            Console.WriteLine($"\nTask 21: Result\nThe divisers are: {ShowDivisers(num)}");
            Console.WriteLine($"\nTask 22: Result\nThe sum of divisers is: {GetDivisersSum(num)}");
            Console.WriteLine($"\nTask 23: Result\nThe mean of divisers is: {GetMeanOfDivisers(num)}");

            // Delay, waiting for a key
            Console.ReadKey();
        }

        /// <summary>
        /// Checking if candidate (param.) is a diviser of num (param.). 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="candidate"></param>
        /// <returns></returns>
        static bool IsDiviser(int num, int candidate)
        {
            return (num % candidate == 0);
        }

        /// <summary>
        /// Returns a string which contains all of the divisers of num (param.) by ascending.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static string ShowDivisers (int num)
        {
            string divisers = "1";

            for (int i = 2; i <= num / 2; i++) divisers = IsDiviser(num, i) ? $"{divisers} {i}" : divisers;
            divisers = num > 1 ? $"{divisers} {num}" : divisers;

            return divisers;
        }

        /// <summary>
        /// Returns the total number of divisers of num (param.)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetDivisersCount(int num)
        {
            int count = 0;

            for (int i = 1; i <= (int)Math.Sqrt(num); i++)
                count = IsDiviser(num, i) ? ((num / i != i) ? (count + 2) : (count + 1)) : count;

            return count;
        }

        /// <summary>
        /// Returns the sum of all of the divisers of num (param.).
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetDivisersSum(int num)
        {
            int sum = 0;

            for (int i = 1; i <= (int)Math.Sqrt(num); i++)
                sum += IsDiviser(num, i) ? (num / i != i ? i + num/i : i) : 0;

            return sum;
        }

        /// <summary>
        /// Returns the mean of divisers of num (param.).
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static double GetMeanOfDivisers (int num)
        {
            return 1.0 * GetDivisersSum(num) / GetDivisersCount(num);
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
    }
}
