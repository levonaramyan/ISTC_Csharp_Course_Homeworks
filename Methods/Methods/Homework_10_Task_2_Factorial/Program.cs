using System;
using System.Numerics;

// Task 2: Given a number n, return the factorial of n, i.e. n!

namespace Homework_10_Task_2_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the title and the description of the task
            Console.WriteLine("Homework 10: Recursion\n");
            Console.WriteLine("Task 2:\t Given a number n, return the factorial of n, i.e. n!\n");

            // Reading n from the console
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            // Printing the factorial, using the recursive method GetFactorial
            Console.WriteLine(GetFactorial(n));
            Console.ReadKey();
        }

        // The method recursively calculate and return the factorial of an input number n
        static BigInteger GetFactorial(int n)
        {
            if (n <= 1) return 1; // Setting the basis
            else return n * GetFactorial(n - 1); // Recursively call the method, until it gets to the basis
        }
    }
}
