using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace determining_Weight_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program will read your basic info and give you back some extra details about you.

            //Defining variables

            //name surname
            string name;
            string surname;

            //year of birth
            short yearOfBirth;
            bool yearFormat = false;
            short thisYear = Convert.ToInt16(DateTime.Now.Year);

            //weight
            float weight;
            bool weightFormat = false;
            string thinOrFat = "thin";
            float weightBorder = 99.9f;

            //male
            bool male = false;
            string maleFemale;
            bool maleFormat = false;


            //reading Name and Surname
            Console.Write("Please enter Your First Name - ");
            name = Console.ReadLine();            
            Console.Write("Please enter Your Last Name - ");
            surname = Console.ReadLine();

            //Reading the weight in appropriate number format
            do
            {
                Console.Write("Please enter Your Weight - ");
                weightFormat = float.TryParse(Console.ReadLine(), out weight);
                if (weightFormat == false)
                {
                    Console.WriteLine("Please type again the Weight only in number format: ");
                }
            } while (weightFormat == false);

            //Reading the year of birth in appropriate number format.
            // 1990 < yearOfBrith <= 2018
            do
            {
                Console.Write("Please enter Your Birth Year - ");
                yearFormat = short.TryParse(Console.ReadLine(), out yearOfBirth);
                if (yearFormat == false)
                {
                    Console.Write("Please enter again in four digit Year format (e.g. 1990): ");
                }
                else if (yearOfBirth < 1900)
                {
                    Console.WriteLine("Are you really so old? Please enter again, but no less than 1900: ");
                    yearFormat = false;
                }
                else if (yearOfBirth > thisYear)
                {
                    Console.WriteLine($"Did you arrive from the future? Please enter again, but no more than {thisYear}");
                    yearFormat = false;
                }
            } while (yearFormat == false);

            //checking if you are thin or fat?
            if (weight < weightBorder)
            {
                thinOrFat = "thin";
            }
            else
            {
                thinOrFat = "fat";
            }


            //reading the male in appropriate format.
            do
            {
                Console.Write("Are you a male or female? m / f ? ");
                maleFemale = Console.ReadLine();
                if (maleFemale == "male" || maleFemale == "m")
                {
                    male = true;
                    maleFormat = true;
                    maleFemale = "man";
                }
                else if (maleFemale == "female" || maleFemale == "f")
                {
                    male = false;
                    maleFormat = true;
                    maleFemale = "woman";
                }
            } while (maleFormat == false);

            //Printing your details in Console
            Console.WriteLine($"Dear {name} {surname} You are {thisYear-yearOfBirth} year old {thinOrFat} {maleFemale}");

            //Delay
            Console.ReadKey();
        }        
    }
}
