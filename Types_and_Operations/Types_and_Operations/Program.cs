using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_and_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing the operands and their Type
            string theType;
            dynamic num1;
            dynamic num2;

            //reading the Type from console
            theType = readType();

            //Reading from Console the numbers num1 and num2 of selected type
            Console.Write($"{theType} : a = ");
            num1 = readnumber(theType);
            Console.Write($"{theType} : b = ");
            num2 = readnumber(theType);

            //implementing + , - , * , / operations with num1 and num2
            operations(num1, num2);

            //waiting a key to exit
            Console.ReadKey();                       
        }


        //Asking user to select the type from the list.
        static string readType()
        {
            string t;
            bool okType = false;

            Console.WriteLine("Please select below the Type of variables that you want to use:");
            Console.WriteLine("sbyte, short, int, long, float, double");

            do
            {
                t = Console.ReadLine();
                if (t == "sbyte" || t == "short" || t == "int" || t == "long" || t == "float" || t == "double")
                {
                    okType = true;
                } else
                {
                    Console.WriteLine("Inaccurate Type. Please repeat again: ");
                }
            } while (okType == false);

            return t;
        }

        //Asking user to write a number of a given type. Returns the first corresponding number.
        static dynamic readnumber (string numType)
        {
            bool parsable = false;
            dynamic inNum;
            string inNumStr;

            sbyte s_temp;
            short sh_temp;
            int i_temp;
            long l_temp;
            float f_temp;
            double d_temp;

            switch (numType)
            {
                case "sbyte":
                    do
                    {
                        inNumStr = Console.ReadLine();
                        parsable = sbyte.TryParse(inNumStr, out s_temp);
                        inNum = s_temp;
                        if (parsable == false)
                            Console.WriteLine("it does not correspond to Type -> sbyte. Please try again");
                    } while (parsable == false);
                    break;

                case "short":
                    do
                    {
                        inNumStr = Console.ReadLine();
                        parsable = short.TryParse(inNumStr, out sh_temp);
                        inNum = sh_temp;
                        if (parsable == false)
                            Console.WriteLine("it does not correspond to Type -> short. Please try again");
                    } while (parsable == false);
                    break;

                case "int":
                    do
                    {
                        inNumStr = Console.ReadLine();
                        parsable = int.TryParse(inNumStr, out i_temp);
                        inNum = i_temp;
                        if (parsable == false)
                            Console.WriteLine("it does not correspond to Type -> int. Please try again");
                    } while (parsable == false);
                    break;

                case "long":
                    do
                    {
                        inNumStr = Console.ReadLine();
                        parsable = long.TryParse(inNumStr, out l_temp);
                        inNum = l_temp;
                        if (parsable == false)
                            Console.WriteLine("it does not correspond to Type -> long. Please try again");
                    } while (parsable == false);
                    break;

                case "float":
                    do
                    {
                        inNumStr = Console.ReadLine();
                        parsable = float.TryParse(inNumStr, out f_temp);
                        inNum = f_temp;
                        if (parsable == false)
                            Console.WriteLine("it does not correspond to Type -> float. Please try again");
                    } while (parsable == false);
                    break;

                case "double":
                    do
                    {
                        inNumStr = Console.ReadLine();
                        parsable = double.TryParse(inNumStr, out d_temp);
                        inNum = d_temp;
                        if (parsable == false)
                            Console.WriteLine("it does not correspond to Type -> double. Please try again");
                    } while (parsable == false);
                    break;
                default:
                    Console.WriteLine("This type is not supported for this program");
                    inNum = 0;
                    break;
            }

            return inNum;
        }


        //Implementing mathematical simple operations with numbers a and b
        static void operations(dynamic a, dynamic b)
        {
            Console.WriteLine($"a + b = {a} + {b} = {a + b}");
            Console.WriteLine($"a - b = {a} - {b} = {a - b}");
            Console.WriteLine($"a * b = {a} * {b} = {a * b}");
            if (b != 0)
            {
                Console.WriteLine($"a / b = {a} / {b} = {a *0.1/ b}");
            } else
            {
                Console.WriteLine($"a / b = {a} / {b} = ERROR!!! impossibe to divide by zero");
            }

        }       
    }
}
