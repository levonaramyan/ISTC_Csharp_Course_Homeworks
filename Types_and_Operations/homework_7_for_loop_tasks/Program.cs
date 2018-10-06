using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7_for_loop_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Խնդիր_2: Տրված են K և N(N > 0) ամբողջ թվերը։ N անգամ արտածել K թիվը։
            int K = 10, N = 5;
            Console.WriteLine($"Task 2\nPrinting the {K} number {N} times:");
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.Write($"{K}\t");
            }
            Console.WriteLine("\n__________________________________________________________");

            // Խնդիր_3: Ներածել n միանիշ թիվը։ Արտածել n-ին չգերազանցող թվանշանները։
            Console.WriteLine("Task 3\nPrinting all of the digits, which are <= n < 10");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine("\n__________________________________________________________");

            // Խնդիր_4: Ներածել n բնական թիվը։ Արտածել n–ի 1–ից մինչև 9 աստիճանների արժեքները։
            Console.WriteLine("Task 4\nPrinting n^i, where i is from 1 to 9");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"n ^ {i} = {Math.Pow(n,i)}\n");
            }
            Console.WriteLine("__________________________________________________________");

            // Խնդիր_5: Հաշվել տրված բնական թվին չգերազանցող զույգ թվերի գումարը՝ առանց զույգությունը ստուգելու։
            int maxNum = 150;
            Console.WriteLine($"Task 5\nPrinting the sum of all even nums. < maxNum = {maxNum}");
            int sumOfEvens = 0;
            Console.WriteLine();

            for (int i = 2; i <= maxNum; i+=2)
            {
                sumOfEvens += i;
            }
            Console.WriteLine($"sumOfEvens = {sumOfEvens}");
            Console.WriteLine("__________________________________________________________");

            // Խնդիր_6: Տրված են A և B(A < B) ամբողջ թվերը։ Արտածել աճման կարգով[A, B] հատվածին պատկանող ամբողջ թվերը,
            //          ապա նաև նրանց քանակը։
            int A = 5;
            int B = 15;
            Console.WriteLine($"Task 6\nPrinting all the nums. in range [{A} , {B}]");
            int count = 0;
            Console.WriteLine();
            for (int i = A; i <= B; i++)
            {
                Console.Write($"{i}\t");
                count++;
            }
            Console.WriteLine($"\n\nThe total number of integers is: {count}");
            Console.WriteLine("__________________________________________________________");

            // Խնդիր_7: Տրված են A և B(A < B) ամբողջ թվերը։ Գտնել[A, B] հատվածին պատկանող բոլոր ամբողջ թվերի գումարը։
            // A և B թվերը վերցնում ենք Խնդիր_6-ից
            Console.WriteLine($"Task 7\nPrinting the sum of all the nums. in range [{A} , {B}]");
            int sumAllNumsInRange = 0;

            for (int i = A; i <= B; i++)
            {
                sumAllNumsInRange += i;
            }
            Console.WriteLine($"\nThe sum is: {sumAllNumsInRange}");
            Console.WriteLine("__________________________________________________________");

            // Խնդիր_8: Տրված են A և B(A < B) ամբողջ թվերը։ Գտնել[A, B] հատվածին պատկանող 3 - ին պատիկ առաջին թիվը։
            // A և B թվերը վերցնում ենք Խնդիր_6-ից
            Console.WriteLine($"Task 8\nPrinting the first num in range [{A} , {B}], which can be divided to 3");

            bool noRes = false;
            string dividable = "There is no number in the range, which can be divided to 3";

            for (int i = A; i <= B && !noRes; i++)
            {
                if (i % 3 == 0)
                {
                    dividable = $"The number is: {i}";
                    noRes = true;
                }                    
            }
            Console.WriteLine($"\nThe num is: {dividable}");
            Console.WriteLine("__________________________________________________________");

            Console.ReadKey();

        }
    }
}
