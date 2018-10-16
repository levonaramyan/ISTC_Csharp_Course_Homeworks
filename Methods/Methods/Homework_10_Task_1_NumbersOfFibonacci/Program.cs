using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 1: Given a number n, return the n-th element of Fibonacci's sequence.

namespace Homework_10_Task_1_NumbersOfFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the title and the task
            Console.WriteLine("Homework 10: Recursion\n");
            Console.WriteLine("Task 1:\t Given a number n, return the n-th element of Fibonacci's sequence\n");

            // Reading the index n of the element
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            // Printing the n-th element by recursive method GetFibonacciN
            Console.WriteLine(GetFibonacciN(n));
            Console.ReadKey();
        }

        // Recursively calculate and return the n-th element in Fibonacci's sequence
        static int GetFibonacciN (int n)
        {
            if (n <= 1) return 1; // initializing the basis
            else return (GetFibonacciN(n - 1) + GetFibonacciN(n - 2)); // recursively call the method, until it gets to the basis
        }
    }
}
