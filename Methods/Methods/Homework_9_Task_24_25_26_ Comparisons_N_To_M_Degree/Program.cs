using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_24: Պարզել, հանդիսանում է, արդյոք, տրված թիվը 3-ի աստիճան։
// Խնդիր_25: Տրված n>0 ամբողջ թվի համար հաշվել 2-ի ամենամեծ աստիճանը, որը չի գերազանցում n-ը։
// Խնդիր_26: Գտնել տրված բնական թվից մեծ և 2-ի աստիճան հանդիսացող ամենափոքր թիվը։

namespace Homework_9_Task_24_25_26__Comparisons_N_To_M_Degree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the title and the description of tasks
            Console.WriteLine("Homework 9: Using Methods\n");
            Console.WriteLine("Task 24: Given a number N, print whether it is a power of 3.\n");
            Console.WriteLine("Task 25: Given a number N, print the closest power of 2, which is no more than N.\n");
            Console.WriteLine("Task 26: Given a number N, print the closest power of 2, which is more than N.\n");

            // Reading an integer from Console.
            Console.WriteLine("Please enter the input number:");
            int num = ReadInt();

            // Printing the results of Tasks 22, 23 and 24 in Console.
            Console.WriteLine($"\nTask 24: Result\nIs N = {num} a power of 3: {IsPowerOf3(num)}");
            Console.WriteLine($"\nTask 25: Result\nThe closest Num = 2^m <= {num} : {GetClosPow(num, 2, higherThanNum: false)}");
            Console.WriteLine($"\nTask 26: Result\nThe closest Num = 2^m > {num} : {GetClosPow(num, 2)}");

            // Delay, waiting for a key
            Console.ReadKey();
        }

        /// <summary>
        /// Returns true, if the parameter n is a power of 3
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool IsPowerOf3 (int n)
        {
            bool isPowerOf3 = true;

            while (isPowerOf3 && n > 1)
            {
                if (n % 3 > 0) isPowerOf3 = false;
                n /= 3;
            }

            return isPowerOf3;
        }

        /// <summary>
        /// Returns the closest power of par, more (*no more) than num.
        /// (*) If gets higherThanNum = false. If nothing is set, it gets a value true.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="par"></param>
        /// <param name="higherThanNum"></param>
        /// <returns></returns>
        static int GetClosPow (int num, int par, bool higherThanNum = true)
        {
            int resLess = (int)(Math.Pow(par, (int)Math.Log(num, par))); // calc. closest par^m <= num
            int resMore = (int)(Math.Pow(par, 1 + (int)Math.Log(num, par))); // calc. closest par^m > num

            // If higherThanNum == true, returns: closest par^m > num
            // If higherThanNum == false, returns: closest par^m <= num
            return higherThanNum ? resMore : resLess;
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
