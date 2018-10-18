using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 31: Given a number n, construct and return an array, where each next element of p is
//          p/2 if p is even, else 3*p+1.

namespace Homework_11_Task_31_Construct_Sequence_From_N
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the Tile and task
            Console.WriteLine("Homework 11: Arrays\n");
            Console.WriteLine("Task 31:\tGiven a number n, construct and return an array, where each next element of p\n"+
                "\t\tis p/2 if p is even, else 3*p+1.\n");

            // Reading a number n from Console
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            // Initializing an array and filling with appropriate sequence of numbers
            int[] arr = ConstructArray(n);

            // Printing the elements of array one by one
            Console.WriteLine();
            foreach (int i in arr) Console.Write(i + " ");
            Console.ReadKey();
        }

        static int[] ConstructArray (int n)
        {
            int n1 = n; // a duplicate of n
            int len = 1; // will be the length of an array

            // Getting the length of an array
            while (n1 > 1)
            {
                n1 = n1 % 2 == 0 ? n1 / 2 : 3 * n1 + 1;
                len++;
            }

            // Initializing an array with len elements and filling with corresponding elements
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = n;
                n = n % 2 == 0 ? n / 2 : 3 * n + 1;
            }

            return arr; // Returning the constructed array
        }
    }
}
