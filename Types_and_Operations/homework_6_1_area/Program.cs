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
            Console.Write("Select shape : \n1 - Rectangle \n2 - Circle \n3 - Square\nShape: ");
            string shape = Console.ReadLine();
            Console.Write(shape == "2" ? "Enter circle radius : R = " : shape == "3" ? "Enter square side : A = " : shape == "1" ? "Enter Rectangle sides : \nA = " : "wrong selection");
            if (shape == "1" || shape == "2" || shape == "3")
            {
                double side1 = Convert.ToDouble(Console.ReadLine());
                if (shape == "1") Console.Write("B = ");
                Console.WriteLine("The area of " + (shape == "2" ? $"circle is: {Math.PI * side1 * side1}" : (shape == "3" ? $"square is: {side1 * side1}" : (shape == "1" ? $"rectangle is: {side1 * Convert.ToDouble(Console.ReadLine())}" : ""))));
            }
                Console.ReadKey();         
        }
    }
}
