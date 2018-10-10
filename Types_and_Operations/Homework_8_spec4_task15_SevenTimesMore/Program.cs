using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_15: Եռանիշ թվի առաջին թվանշանը ջնջել։ Եթե ստացված թիվը բազմապատկվի 7-ով,
//           կստացվի սկզբնական թիվը։ Գտնել այդպիսի թվերը։

namespace Homework_8_spec4_task15_SevenTimesMore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro
            Console.WriteLine("Printing all of 3 Digit numbers, which are 7 times more, than the one without the first digit.");
            Console.WriteLine(new String('-', 100));

            // Checking for all 3 digit i-s, and printing the number, if it is the case.
            int i = 100;
            while (i < 1000)
            {
                Console.Write(((i % 100) * 7 == i) ? $"{i}\t" : "");
                i++;
            }

            Console.ReadKey();
        }
    }
}
