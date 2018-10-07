using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

namespace Homework_7_1_New_For_Loop_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 7.1: For Loop\nThis program contains the solution of tasks from 9 to 13");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Task 9:\tfor the given N, print 1 + 1 / 2 + 1 / 3 + … + 1 / N\n");
            Console.WriteLine("Task 10:\tfor the given N, print N^2 +(N + 1)^2 + (N + 2)^2 + … +(2·N)^2\n");
            Console.WriteLine("Task 11:\tfor the given N, print 1.1 · 1.2 · 1.3 · … (N operands)\n");
            Console.WriteLine("Task 12:\tfor the given N, print 1.1 – 1.2 + 1.3 – … (N operands)\n");
            Console.WriteLine("Task 13:\tfor the given N, print N^2 = 1 + 3 + 5 + … +(2 * N – 1)\n");
            Console.WriteLine("------------------------------------------------------------------------------------");


            Console.Write("For all of the tasks above:\nN = ");
            int N = int.Parse(Console.ReadLine());
            string separ = "\n-----------------------------";
            Console.WriteLine(separ);

            double task9 = 0, task10 = N*N, task11 = 1, task12 = 0;
            int task13 = 0;
            string task13Ongoing = "";
            
            for (int i = 1; i <= N; i++)
            {
                task9 += 1.0 / i;
                task10 += Math.Pow(N + i, 2);
                task11 *= 1 + 0.1 * i;
                task12 += Math.Pow(-1, i - 1) * (1 + 0.1 * i);
                task13 += 2 * i - 1;
                task13Ongoing += $"\t({i})^2 = {task13}\n";
            }

            Console.WriteLine($"Results:{separ}\nTask 9: {task9}{separ}");
            Console.WriteLine($"Task 10: {task10}{separ}");
            Console.WriteLine($"Task 11: {task11}{separ}");
            Console.WriteLine($"Task 12: {task12}{separ}");
            Console.WriteLine($"Task 13: {task13}\n");
            Console.WriteLine($"{task13Ongoing}{separ}");
            Console.ReadKey();
        }
    }
}
