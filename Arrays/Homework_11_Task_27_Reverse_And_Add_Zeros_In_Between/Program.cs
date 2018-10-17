using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 27: Given a number n, return its reversed number with 0-s in between its digits.

namespace Homework_11_Task_27_Reverse_And_Add_Zeros_In_Between
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the title and the description of the task
            Console.WriteLine("Homework 11: Arrays\n");
            Console.WriteLine("Task 27:\tGiven a number n, return its reversed number with 0-s in between its digits\n");

            // Reading the input number from console
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            // Getting he transformed number
            int nNew = RevAddZeroInBetween(n);

            // Printing the result 
            Console.WriteLine("\n"+nNew);

            // Delay, waiting for a key
            Console.ReadKey();
        }

        // Returns a new number, which is a reversed num, where between the digits 0-s are added.
        static int RevAddZeroInBetween (int num)
        {
            int[] revArr = ReversedDigitsArray(num); // getting digits reversed array
            int[] newNumArr = AddZerosInBetween(revArr); // getting digits reversed array with 0-s in between

            int newNum = 0; // will be the returning number
            int len = newNumArr.Length; // getting the length of the final array

            // adding the digits in a number
            for (int i = 0; i < len; i++)
            {
                newNum += newNumArr[i] * (int)Math.Pow(10, len - i - 1);
            }

            return newNum; // returning the transformed number
        }

        // Returns a new array, where new {0} element, is added between elements of digArray[]
        static int[] AddZerosInBetween(int[] digArray)
        {            
            int len = digArray.Length; // the length of input array
            int[] newNumArr = new int[2 * len - 1]; // a new array with length: len + (len - 1)--> zeros in between

            // adding digits in even indexes of a new array
            for (int i = 0; i < len; i++)
            {
                newNumArr[2 * i] = digArray[i];
            }

            return newNumArr; // returning a new array with digits and zeros
        }

        // Returns an array of integers, which contains the digits of num in reversed order
        static int[] ReversedDigitsArray (int num)
        {
            int len = (int) Math.Log10(num) + 1; // the number of digits in num
            int[] revDigArr = new int[len]; // initializing an array, which will contain the digits
            int index = 0;

            // Adding digits of num in revDigArr[] in reversed order
            while (index <= len - 1)
            {
                revDigArr[index] = num % 10; // getting the last digit in num
                num /= 10; // deleting the last digit from num
                index++;
            }

            return revDigArr; // returning the array of digits
        }
    }
}
