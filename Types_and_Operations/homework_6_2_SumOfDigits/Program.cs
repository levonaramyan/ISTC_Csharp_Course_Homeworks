using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The program calculates the sum of digits, readed from console

namespace homework_6_2_SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfDigits = 0;
            char dig ;
                      
            // Reading and adding digits, until you typed a non digit char
            // Console.Write("Please enter a four digit number:\nNum = ");

            //******* Reading a key, while it is digit and adding it in sum *****
            //do
            //{
            //    dig = Console.ReadKey().KeyChar;
            //    if (char.IsDigit(dig)) sumOfDigits += Convert.ToInt32($"{dig}");
            //} while (char.IsDigit(dig));


            // ****** Reading a number from console and calculates the sum of its digits
            //string myNum = Console.ReadLine();
            //foreach (char i in myNum)
            //{
            //    sumOfDigits += Convert.ToInt32($"{dig}");
            //}

            // The simplest way to calculate a sum of digits of 4 digit integer
            int my4DigitNum = 4563;
            sumOfDigits += Convert.ToInt32($"{my4DigitNum}"[0]) + Convert.ToInt32($"{my4DigitNum}"[1])
                + Convert.ToInt32($"{my4DigitNum}"[2]) + Convert.ToInt32($"{my4DigitNum}"[3]);

            Console.Write($"\nThe sum of digits of {my4DigitNum} is: {sumOfDigits}");
            Console.ReadKey();
        }
    }
}
