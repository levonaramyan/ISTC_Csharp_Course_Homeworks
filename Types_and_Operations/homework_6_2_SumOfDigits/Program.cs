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
            Console.Write("Please enter a four digit number:\nNum = ");
            do
            {
                dig = Console.ReadKey().KeyChar;
                if (char.IsDigit(dig)) sumOfDigits += Convert.ToInt32($"{dig}");
            } while (char.IsDigit(dig));

            Console.Write($"\nThe sum of digits is: {sumOfDigits}");
            Console.ReadKey();
        }
    }
}
