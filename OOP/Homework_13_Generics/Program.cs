using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "50"; // initial value
            byte b = Converter.StringToType<byte,string>(a); // conveted value

            Console.WriteLine(b*2); // printing the result of an operation with b
            Console.ReadKey();
        }
    }
}
