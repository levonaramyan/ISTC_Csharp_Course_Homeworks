using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 30: Find all the four digit abcd numbers, where all digits are different and |ab - cd| == a + b + c + d.

namespace Homework_11_Task_30_Find_The_Four_Digit_Numbers_Where_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the Title and the task
            Console.WriteLine("Homework 11: Arrays\n");
            Console.WriteLine("Task 30: Find all the four digit abcd numbers," +
                "where all digits are different and |ab - cd| == a + b + c + d.\n");
            
            // Initializing the res[] with the four digit numbers, which correspond to the terms above
            int[] res = FourDigitNumsWithTerms();

            // Printing the list of all of the numbers in res[]
            foreach (int i in res) Console.Write(i + " ");
            Console.ReadKey();
        }

        // Returns an array of four digit numbers, where each is like abcd and |ab - cd| == a + b + c + d
        static int[] FourDigitNumsWithTerms()
        {
            int[] fourDigLong = new int[9000]; // Will store the corresponding 4digit numbers
            int index = 0; // will be the index of each next number, that will be stored in fourDigLong

            // Checking both terms for numbers from 1023 to 9876
            // (the biggest and smallest numbers which consist of different digits)
            for (int i = 1023; i <= 9876; i++)
            {
                int[] digits = NumToDigitArray(i);

                if (IsABCDForm(digits) && Term1(digits))
                {
                    fourDigLong[index] = i; // adding the corresponding number in fourDigLong[]
                    index++; // moving to the next index
                }
            }

            // Because the fourDigLong[], has many useless elements
            // initializing a new array, with corresponding elements (index, the first useless element in fourDigLong[])
            int[] result = new int[index];
            for (int i = 0; i < index; i++)
            {
                result[i] = fourDigLong[i];
            }

            return result;
        }

        
        // Returns an array of digits of input number num
        static int[] NumToDigitArray (int num)
        {
            int len = (int)Math.Log10(num)+1; // Getting the number of digits in num
            int[] digits = new int[len]; // Initializing a new array with len elements

            // Adding the digits of num in digits[], one by one
            for (int i = 0; i < len; i++)
            {
                digits[len - 1 - i] = num % 10;
                num /= 10;
            }

            return digits;
        }

        // Returns true, if all of the numbers in d[] are different
        static bool IsABCDForm (int[] d)
        {
            int len = d.Length;
            bool isABCD = true;

            // When finds equal digits, makes isABCD false and stops the loops
            for (int i = 0; isABCD && i < len - 1; i++)
            {
                for (int j = i + 1; isABCD && j < len; j++)
                {
                    if (d[i] == d[j]) isABCD = false;
                }
            }

            return isABCD;

        }

        // Returns true if the four elements in array correspond to |ab - cd| == a + b + c + d
        static bool Term1 (int[] d)
        {
            return (d[0] + d[1] + d[2] + d[3] == Math.Abs(10 * d[0] + d[1] - 10 * d[2] - d[3]));
        }
    }
}
