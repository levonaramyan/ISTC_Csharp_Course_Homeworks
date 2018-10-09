using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_2: Տրված են K և N(N > 0) ամբողջ թվերը։ N անգամ արտածել K թիվը։

// Խնդիր_3: Ներածել n միանիշ թիվը։ Արտածել n-ին չգերազանցող թվանշանները։

// Խնդիր_4: Ներածել n բնական թիվը։ Արտածել n–ի 1–ից մինչև 9 աստիճանների արժեքները։

// Խնդիր_5: Հաշվել տրված բնական թվին չգերազանցող զույգ թվերի գումարը՝ առանց զույգությունը ստուգելու։

// Խնդիր_6: Տրված են A և B(A < B) ամբողջ թվերը։ Արտածել աճման կարգով[A, B] հատվածին պատկանող ամբողջ թվերը,
//          ապա նաև նրանց քանակը։

// Խնդիր_7: Տրված են A և B(A < B) ամբողջ թվերը։ Գտնել[A, B] հատվածին պատկանող բոլոր ամբողջ թվերի գումարը։
//          A և B թվերը վերցնում ենք Խնդիր_6-ից

// Խնդիր_8: Տրված են A և B(A < B) ամբողջ թվերը։ Գտնել[A, B] հատվածին պատկանող 3 - ին պատիկ առաջին թիվը։
//          A և B թվերը վերցնում ենք Խնդիր_6-ից

// Խնդիր_9:
// Տրված է N բնական թիվը։ Հաշվել 1 + 1 / 2 + 1 / 3 + … +1 / N գումարը(այն իրական թիվ է)։

// Խնդիր_10:
// Տրված է N բնական թիվը։ Հաշվել N^2 +(N + 1)^2 + (N + 2)^2 + … +(2·N)^2 գումարը։

// Խնդիր_11:
// Տրված է N բնական թիվը։ Հաշվել 1.1 · 1.2 · 1.3 · … արտադրյալը(արտադրիչների քանակը N է)։

// Խնդիր_12:
// Տրված է N բնական թիվը։ Հաշվել 1.1 – 1.2 + 1.3 – … արտահայտության արժեքը։
// Նշանափոխ գումարելիների քանակը N է։ Պայմանական(if) օպերատոր չօգտագործել։

// Խնդիր_13:
// Տրված է N բնական թիվը։ Հաշվել այդ թվի քառակուսին՝ օգտագործելով հետևյալ բանաձևը.
// N2 = 1 + 3 + 5 + … +(2 * N – 1). Հերթական գումարելին ավելացնելիս արտածել
// գումարի ընթացիկ արժեքը(արդյունքում կարտածվեն 1 - ից մինչև N բոլոր թվերի քառակուսիները)։

namespace Homework_8_The_same_tasks_with_while_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing strong and light separation line styles 
            string border = "------------------------------------------------------------------------------------";
            string separ = "---------------------------------";
            Console.WriteLine($"Homework 8: While Loop\nThis program contains the solution of tasks from 2 to 13\n{border}");
            
            ///////////////////////////////////////////////////////////////////
            ////////////////////////// Tasks 2 - 4 ////////////////////////////
            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("Task 2:\t\tfor the given N, print the number K, N times\n");
            Console.WriteLine("Task 3:\t\tfor the given N, print all of the digits, which are <= N < 10\n");
            Console.WriteLine($"Task 4:\t\tfor the given N, print n^i, where i is from 1 to 9\n{border}");
            Console.Write($"For all of the Tasks 2 - 4\n{separ}\nInput:\n\nN = ");
            string task2 = "", task3 = "", task4 = "";           
            int N = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= N )
            {
                task2 += $"{K} ";
                if (i / 10 == 0) task3 += $"{i} ";                
                i++;
            }

            i = 1;
            while (i <= 9)
            {
                task4 += $"\n{N}^{i} = {Math.Pow(N,i)} ";
                i++;
            }

            Console.WriteLine($"{separ}\nOutput:\n\nTask 2: {task2}\n\nTask 3: {task3}\n\nTask 4: {task4}\n{border}");
            Console.WriteLine($"{border}\n{border}");
            
            ///////////////////////////////////////////////////////////////////
            ///////////////////////////// Task 5 //////////////////////////////
            ///////////////////////////////////////////////////////////////////
            Console.WriteLine($"Task 5:\tfor the given N, print the sum of all even nums. <= N \n{separ}");
            Console.Write($"Input:\n\nN = ");
            N = int.Parse(Console.ReadLine());
            int task5 = 0;

            i = 2;
            while (i <= N)
            {
                task5 += i;
                i += 2;
            }

            Console.WriteLine($"{separ}\nOutput:\n\nSum = {task5}\n{border}");
            Console.WriteLine($"{border}\n{border}");

            ///////////////////////////////////////////////////////////////////
            ////////////////////////// Tasks 6 - 8 ////////////////////////////
            ///////////////////////////////////////////////////////////////////
            string task6 = "";
            int task7 = 0, task8 = 0;

            Console.WriteLine("Task 6:\t\tfor the given A and B, print all the nums. in range [A,B]\n");
            Console.WriteLine("Task 7:\t\tfor the given A and B, print the sum of all the nums. in range [A,B]\n");
            Console.WriteLine($"Task 8:\t\tfor the given A and B, print the first num in range [A,B], which is divisable to 3\n{border}");
            Console.Write($"For all of the Tasks 6 - 8\n{separ}\nInput:\n\nA = ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int B = int.Parse(Console.ReadLine());
            bool isfirst = true;
            i = A;

            while (i <= B)
            {
                task6 += $"{i} ";
                task7 += i;
                if (isfirst && i % 3 == 0)
                {
                    isfirst = false;
                    task8 = i;
                }
                i++;
            }

            Console.WriteLine($"{separ}\nOutput:\n\nTask 6: {task6}\n\nTask 7: {task7}\n\nTask 8: {task8}\n{border}");
            Console.WriteLine($"{border}\n{border}");

            ///////////////////////////////////////////////////////////////////
            ////////////////////////// Tasks 9 - 13 ///////////////////////////
            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("Task 9:\t\tfor the given N, print 1 + 1 / 2 + 1 / 3 + … + 1 / N\n");
            Console.WriteLine("Task 10:\tfor the given N, print N^2 +(N + 1)^2 + (N + 2)^2 + … +(2·N)^2\n");
            Console.WriteLine("Task 11:\tfor the given N, print 1.1 · 1.2 · 1.3 · … (N operands)\n");
            Console.WriteLine("Task 12:\tfor the given N, print 1.1 – 1.2 + 1.3 – … (N operands)\n");
            Console.WriteLine($"Task 13:\tfor the given N, print N^2 = 1 + 3 + 5 + … +(2 * N – 1)\n{border}");
            Console.Write($"For all of the Tasks 9 - 13\n{separ}\nInput:\n\nN = ");

            N = int.Parse(Console.ReadLine());
            double task9 = 0, task10 = N*N, task11 = 1, task12 = 0, task13 = 0;
            i = 1;
            string task13Ongoing = "";

            while (i <= N)
            {
                task9 += 1.0 / i;
                task10 += Math.Pow(N + i, 2);
                task11 *= 1 + 0.1 * i;
                task12 += Math.Pow(-1, i - 1) * (1 + 0.1 * i);
                task13 += 2 * i - 1;
                task13Ongoing += $"\t({i})^2 = {task13}\n";
                i++;
            }

            Console.WriteLine($"{separ}\nOutput:\n\nTask 9: {task9}\n\nTask 10: {task10}\n\nTask 11: {task11}\n");
            Console.WriteLine($"Task 12: {task12}\n\nTask 13: {task13}\n\n{task13Ongoing}{border}");
            Console.WriteLine($"{border}\n{border}");
            Console.ReadKey();
        }
    }
}
