using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Խնդիր_32: Տրված է N բնական թիվը։ Օգտագործելով մեկ ցիկլ հաշվել 1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!) գումարը
// (N!-ով նշանակված է 1-ից N թվերի արտադրյալը։ Ստացված թիվը հանդիսանում է e հաստատունի մոտավոր արժեքը)։



namespace Homework_12_Task_32_A_Sequence_Of_exp_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing and printing the result
            Console.WriteLine(ApproxExp(1_000_000));
            Console.ReadKey();
        }

        // Returns the sum of n elements of the sequence of the approximation of e.
        static double ApproxExp(int n)
        {
            double elem = 1;
            double sum = 1;
            
            for (int i = 1; i <= n; i++)
            {
                elem /= i;
                sum += elem;
            }

            return sum;
        }
    }
}
