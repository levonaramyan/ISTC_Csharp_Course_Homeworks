using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using no more than 10 lines, read the type of a shape (rectangle, circle, square),
// read its parameters and print its area

namespace homework_6_1_area
{
    class Program
    {
        static void Main(string[] args)
        {
            string parName = "ABRa"; // contains the names of parameters of various shapes
            double area = 1;
            Console.WriteLine("Please select the shape:\n1. Rectangle\n2. Circle\n3. Square"); // reading the shape
            char shape = Console.ReadKey().KeyChar;
            if (shape == '1') for (int i = 0; i <= 1; i++) { Console.Write($"\n{parName[i]} = "); // if rectangle
                    area *= Convert.ToDouble(Console.ReadLine());}
            else if (shape == '2' || shape == '3') { Console.Write($"\n{parName[Convert.ToInt32($"{shape}")]} = "); // if circle/square
                area *= Math.Pow(Math.PI, (3 - Convert.ToInt32($"{shape}"))) * Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);}
            Console.WriteLine((shape != '1' && shape != '2' && shape != '3') ? "\nWrong selection" : $"\nThe area is {area}");
            Console.ReadKey();
        }
    }
}
