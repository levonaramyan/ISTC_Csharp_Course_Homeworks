using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PROBLEM: write a simple console calculator, which asks a user to input two numbers
//          as well as to choose the type of operation, which is necessary to do
//          and returns the absolute value of the operation

namespace SimpleConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading num1 and num2
            Console.WriteLine("This is a simple \"Only Positive\" calculator. Just Enjoy!");
            Console.Write("Please input two numbers:\nnum1 : ");
            long num1 = ReadLong();
            Console.Write("num2 : ");
            long num2 = ReadLong();

            // Reading the operation type (input 1 to 7)
            string operation = ReadOperation();

            // implementing and returning calculation result
            string operationResult = Calculator(num1,num2,operation);

            // Printing the whole expression with result
            Console.WriteLine($"|{num1} {operation} {num2}| = {operationResult}");
            Console.ReadKey();
        }


        // Reading and returning a number with appropriate number format
        static long ReadLong ()
        {
            bool isLong = false;
            long num;
            do
            {
                isLong = long.TryParse(Console.ReadLine(), out num);
                if (!isLong) Console.WriteLine("Inaccurate input\nPlease input again but in a number format: ");
            } while (!isLong);

            return num;
        }


        // Reading a numerical symbol of the operation and returning its representation as a string
        static string ReadOperation()
        {
            // initializing variables
            bool isOperation = false;
            string[] opSymbol = new string[] { "+", "-", "/", "*", "%", "power", "root" }; // operation Types
            int operTypeCount = opSymbol.Length; // the number of possible operations
            int opNumSymbol; // the numerical representation codes of operation Types

            // offering the possible operation types
            Console.WriteLine("Please select below the type of an operation, that you like do implement:");
            for (int i = 0; i < operTypeCount; i++) Console.Write($"({opSymbol[i]})|{i + 1}\t\t");
            Console.WriteLine();

            // reading the operation num. code
            do
            {
                isOperation = int.TryParse(Console.ReadLine(), out opNumSymbol);
                isOperation = isOperation && (opNumSymbol <= operTypeCount && opNumSymbol >= 1);
                if (!isOperation)
                    Console.WriteLine($"Wrong command!!!\n Please select a number from 1 to {operTypeCount}");
            } while (!isOperation);
            

            return opSymbol[opNumSymbol-1]; // returning the operation type as a string
        }

        // Reading num1, num2 and the operation type. Returning the result of the calculation
        static string Calculator (long num1, long num2, string op)
        {
            // defining variables;
            double opResult;
            string result = "";

            // checking the operation type and implementing he calculation
            switch (op)
            {
                case "+":
                    opResult = num1 + num2;
                    break;

                case "-":
                    opResult = num1 - num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        result = "ERROR!!! Impossible to divide by 0";
                        opResult = 0;
                    }
                    else opResult = (double)(num1 / num2);
                    break;

                case "*":
                    opResult = num1 * num2;
                    break;

                case "%":
                    if (num2 == 0 )
                    {
                        result = "ERROR!!! Impossible to divide by 0";
                        opResult = 0;
                    } else opResult = (double) (num1 % num2);
                    break;

                case "power":                    
                    opResult = Math.Pow(num1, num2);
                    break;

                case "root":
                    opResult = Math.Pow(num1,(1.0/num2));
                    break;

                default:
                    opResult = 0;
                    break;
            }
            
            opResult = Math.Abs(opResult); // taking the absolute value of the operation result
            if (result.Length == 0) result = Convert.ToString(opResult); // if there is no error, return opResult
            return result;
        }
    }
}
