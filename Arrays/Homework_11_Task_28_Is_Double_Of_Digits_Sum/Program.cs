using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 28: Given a number n, return yes if it is a double of its digits sum. Otherwise return no.

namespace Homework_11_Task_28_Is_Double_Of_Digits_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the title and the description of the task
            Console.WriteLine("Homework 11: Arrays\n");
            Console.WriteLine("Task 28:\tGiven a number n, return yes if it is a double of its digits sum. Otherwise no.\n");

            // Reading the input number from console
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            // Getting if the num is a double of its digits sum
            bool theAnswer = IsDoubleOfDigitsSum(n);

            // Printing the result: "yes" or "no"?
            Console.Write("\nIs it a double of its digits sum?\nAnswer: ");
            Console.WriteLine(theAnswer? "yes" : "no");

            // Delay, waiting for a key
            Console.ReadKey();
        }

        // Returns true, if num is a double of the sum of its digits
        static bool IsDoubleOfDigitsSum(int num)
        {
            int[] digitsNum = DigitsOfNum(num); // Getting and array of digits
            return (num == 2 * digitsNum.Sum()); // checking the statement, and returning the result
        }

        // Returns an array of digits of num
        static int[] DigitsOfNum (int num)
        {
            int len = (int)Math.Log10(num) + 1; // Getting the number of digits in num
            int[] digits = new int[len]; // Initializing an array, which will be filled with digits of num
            int index = len - 1; // Initializing of a starting index

            // Adding digits to array one by one
            while (num > 0)
            {
                digits[index] = num % 10; // adding the last digit of num
                num /= 10; // deleting the last digit from num
                index--; // changing the index
            }

            return digits; // Returning the obtained array of digits
        }
    }
}
