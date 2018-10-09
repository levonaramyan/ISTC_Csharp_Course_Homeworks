using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PROBLEM: Given two positive integers A and B,
//          print a number of similar digits in a and b,
//          print a number of cases, when similar digits are located in the same positions in a and b

namespace Homework_8_spec2_FindSimilarDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two positive integers to compare:");
            Console.Write("A = ");
            string a = Console.ReadLine();
            Console.Write("B = ");
            string b =Console.ReadLine();
            int similarDigits = 0;

            // Making sure than a is not longer than b
            if (a.Length > b.Length)
            {
                string temp = b;
                b = a;
                a = temp;
            }

            int aLen = a.Length;
            int bLen = b.Length;
            int samePosCount = 0;

            // Calculating the number of digits with the same position
            string aDupl = a; // taking a duplicate of a, for some replacements
            string bDupl = b; // taking a duplicate of b, for some replacements
            for (int i = 0; i < aLen; i++)
            {
                if (a[i] == b[i]) // counting a cases, when similar digits are in the same position in a and b
                {
                    samePosCount++;
                    
                    if (aDupl[i] != ' ') // if the digit was not previously considered, count also similarDigits
                    {
                        similarDigits++;
                        // replacing all similar to a[i] digits in both a and b with " "
                        aDupl = aDupl.Replace($"{aDupl[i]}", " ");
                        bDupl = bDupl.Replace($"{bDupl[i]}", " ");
                    }
                }
            }

            // getting new values of a and b, without the digits (as well as their copies in other positions)
            // which are found to be similar and are in the same position 
            a = aDupl.Replace(" ", "");
            b = bDupl.Replace(" ", "");

            // Making sure than a is not longer than b
            if (a.Length > b.Length)
            {
                string temp = b;
                b = a;
                a = temp;
            }

            aLen = a.Length;
            bLen = b.Length;

            // Finding the remaining similar digits
            for (int i = 0; i < aLen; i++)
            {
                // if found similars, then count and remove all their copies from a and b
                if (b.Contains(a[i]))
                {
                    similarDigits++;
                    int temp = a[i];
                    a = a.Replace($"{temp}", "");
                    b = b.Replace($"{temp}", "");
                }
                aLen = a.Length; // getting a resulting length of a, after the changes
            }

            Console.WriteLine($"The number of similar digits in A and B is: {similarDigits}");
            Console.WriteLine($"The number of cases, when a same digit appears at the same position in A and B is: {samePosCount}");
            Console.ReadKey();
        }
    }
}
