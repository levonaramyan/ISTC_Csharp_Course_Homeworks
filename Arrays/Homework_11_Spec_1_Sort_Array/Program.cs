using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Spec 1: Given an array of integers, and boolean. Return sorted array by ascending/descending, if boolean is treu/false.

namespace Homework_11_Spec_1_Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the Title and the task
            Console.WriteLine("Homework 11: Arrays\n");
            Console.WriteLine("Task Spec1: Given an array of integers, and boolean b. " +
                "Return sorted array by ascending/descending, if b is true/false.\n");
            
            // Initializing a test array, and a defalut array result[]
            int[] test = CreateRandomIntArray(10,0,100);
            bool byAscending = false;
            int[] result = new int[test.Length];

            // getting the result of sorting in array result[]
            result = SortArrayBy(test, byAscending);

            // Printing the arrays element by element
            foreach (int i in test) Console.Write(i + " ");
            Console.WriteLine("\nAfter sorting by "+ (byAscending? "ascending" : "descending"));
            foreach (int i in result) Console.Write(i + " ");

            // Delay, waiting for a key
            Console.ReadKey();
        }

        // The method returns the sorted array by asc./desc., corresponding to bool ascending
        static int[] SortArrayBy (int[] arr, bool ascending)
        {
            // returning an array sorted by ascending/descending, when ascending parameter is true/false
            return ascending ? SortByAscending(arr) : ReverseArray(SortByAscending(arr));
        }

        // The method sorts by ascending and returns the resulting array
        static int[] SortByAscending (int[] arr)
        {
            int len = arr.Length; // getting the length of arr[]
            int[] sorted = new int[len]; // initializing a new sorted[] array with len elements

            // Getting each new element of arr[] and putting in correct order in sorted[]
            for (int i = 0; i < len; i++)
            {
                sorted[i] = arr[i];
                int j = i;

                // Putting the current value of sorted[j], in the right position in array
                while(j > 0 && sorted[j] < sorted[j-1])
                {
                    int temp = sorted[j];
                    sorted[j] = sorted[j - 1];
                    sorted[j - 1] = temp;
                    j--;
                }
            }

            return sorted; // returning the sorted array
        }

        // The method returns the reversed array
        static int[] ReverseArray (int[] arr)
        {
            int len = arr.Length; // getting the length of arr[]
            int[] reversed = new int[len]; // initializing a new reversed[] array with len elements

            // filling the array reversed[] in reversed order of arr[]
            for (int i = 0; i < len; i++)
            {
                reversed[i] = arr[len - i - 1];
            }

            return reversed; // returning the reversed array
        }

        // Returns an array with len number of random elements in range [min,max]
        static int[] CreateRandomIntArray(int len, int min, int max)
        {
            int[] arr = new int[len]; // Initializing a new array with len number of elements
            Random rd = new Random(); // Creating an instance of Random class

            // Adding random elements in array arr[]
            for (int i = 0; i < len; i++)
            {
                arr[i] = rd.Next(min, max);
            }

            return arr; // returning the randomly generated array
        }

        // Prints the input array in Console
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} ");
            }
        }
    }
}
