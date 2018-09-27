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

            //Defining variables and reading the values

            //name surname
            string name = yourName();
            string surname = yourSurname();

            //year of birth
            short yearOfBirth = yourYearOfBirth();
            short thisYear = Convert.ToInt16(DateTime.Now.Year);

            //weight
            float weight = yourWeight();            
            string thinOrFat = "thin";            

            //male
            string maleFemale = yourMale();

            //checking if you are thin or fat?
            thinOrFat = yourFateness(weight);


            //Printing your details in Console
            Console.WriteLine($"Dear {name} {surname} You are {thisYear-yearOfBirth} year old {thinOrFat} {maleFemale}");

            //Delay
            Console.ReadKey();
        }

        // Reading and returning the Name
        static string yourName()
        {
            string name;
            Console.Write("Please enter Your First Name - ");
            name = Console.ReadLine();
            return name;
        }

        // Reading and returning the Surname
        static string yourSurname()
        {
            string surname;
            Console.Write("Please enter Your Last Name - ");
            surname = Console.ReadLine();
            return surname;
        }

        //Reading and returning Your Year of Birth
        static short yourYearOfBirth()
        {
            //defining variables for the year
            short yearOfBirth;
            bool yearFormat = false;
            short thisYear = Convert.ToInt16(DateTime.Now.Year); // dynamically determines the current year

            //Reading the year of birth, until it is in appropriate format. 1900 < yearOfBirth < current year
            do
            {
                Console.Write("Please enter Your Birth Year - ");
                yearFormat = short.TryParse(Console.ReadLine(), out yearOfBirth);
                if (yearFormat == false)
                {
                    Console.Write("Please enter again in four digit Year format (e.g. 1990): ");
                }

                // Checking if the Year of Birth is more than 1900
                else if (yearOfBirth < 1900)
                {
                    Console.WriteLine("Are you really so old? Please enter again, but no less than 1900: ");
                    yearFormat = false;
                }

                //Checking if the Year of Birth is not later than current year
                else if (yearOfBirth > thisYear)
                {
                    Console.WriteLine($"Did you arrive from the future? Please enter again, but no more than {thisYear}");
                    yearFormat = false;
                }
            } while (yearFormat == false);

            // Returning the Year of Birth
            return yearOfBirth;
        }

        //Reading your weight from the console, checking the format and returning as a float.
        static float yourWeight()
        {
            //Defining variables for the weight
            float weight;
            bool weightFormat = false;

            //Reading the weight as many times, as you enter it in a wrong format, until it is ok.
            do
            {
                Console.Write("Please enter Your Weight - ");
                weightFormat = float.TryParse(Console.ReadLine(), out weight);
                if (weightFormat == false)
                {
                    Console.WriteLine("Please type again the Weight only in number format: ");
                }
            } while (weightFormat == false);

            // Returning the weight as a float
            return weight;
        }


        //Getting your weight, it determines wheter you are thin or fat. Returns "thin" or "fat".
        static string yourFateness(float weight)
        {
            //defining variables
            string thinOrFat;
            float weightBorder = 99.9f;

            //determining fat or thin.
            if (weight < weightBorder)
            {
                thinOrFat = "thin";
            }
            else
            {
                thinOrFat = "fat";
            }

            //returning "thin" or "fat".
            return thinOrFat;
        }

        //Reading your male and returning it in appropriate format
        static string yourMale()
        {
            //defining variables
            string maleFemale;
            bool maleFormat = false;

            //reading the male in appropriate format: "male", "m", "female" "f".
            do
            {
                Console.Write("Are you a male or female? m / f ? ");
                maleFemale = Console.ReadLine();
                if (maleFemale == "male" || maleFemale == "m")
                {
                    maleFormat = true;
                    maleFemale = "man";
                }
                else if (maleFemale == "female" || maleFemale == "f")
                {                    
                    maleFormat = true;
                    maleFemale = "woman";
                }
            } while (maleFormat == false);

            //returning the male: "male", or "female"
            return maleFemale;
        }
    }
}
