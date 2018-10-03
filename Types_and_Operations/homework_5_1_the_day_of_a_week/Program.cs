using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_5_1_the_day_of_a_week
{
    class Program
    {
        static void Main(string[] args)
        {
            // The program gets a number of the day in a week, which you typed
            // and writes in a console its text representation in various colors
            Console.WriteLine("Please enter the day of a week (1 to 7): ");
            string dayNum = Console.ReadLine(); // reading from console
            bool error = false; // will be true if the dayNum > 7
            string dayText = ""; // will be the text representation of the day
            var textColor = ConsoleColor.White; // corresponding text color for console


            // Version 1: with operators if, else
            /*
            if (dayNum == "1")
            {
                textColor = ConsoleColor.Yellow;
                dayText = "Monday";
            }
            else if (dayNum == "2")
            {
                textColor = ConsoleColor.Magenta;
                dayText = "Tuesday";
            }
            else if (dayNum == "3")
            {
                textColor = ConsoleColor.Green;
                dayText = "Wednesday";
            }
            else if (dayNum == "4")
            {
                textColor = ConsoleColor.Red;
                dayText = "Thursday";
            }
            else if (dayNum == "5")
            {
                textColor = ConsoleColor.Cyan;
                dayText = "Friday";
            }
            else if (dayNum == "6")
            {
                textColor = ConsoleColor.Gray;
                dayText = "Saturday";
            }
            else if (dayNum == "7")
            {
                textColor = ConsoleColor.Blue;
                dayText = "Sunday";
            }
            else
            {
                textColor = ConsoleColor.DarkYellow;
                dayText = "You entered inaccurate value";
                error = true;
            }*/



            // Version 2: with operator switch-case
            switch (dayNum)
            {
                case "1": // if (dayNum == "1") then:
                    textColor = ConsoleColor.Yellow; // chnaging the color
                    dayText = "Monday"; // getting the text representation of a day
                    break; // exiting the switch
                case "2":
                    textColor = ConsoleColor.Magenta;
                    dayText = "Tuesday";
                    break;
                case "3":
                    textColor = ConsoleColor.Green;
                    dayText = "Wednesday";
                    break;
                case "4":
                    textColor = ConsoleColor.Red;
                    dayText = "Thursday";
                    break;
                case "5":
                    textColor = ConsoleColor.Cyan;
                    dayText = "Friday";
                    break;
                case "6":
                    textColor = ConsoleColor.Gray;
                    dayText = "Saturday";
                    break;
                case "7":
                    textColor = ConsoleColor.Blue;
                    dayText = "Sunday";
                    break;
                default:
                    textColor = ConsoleColor.DarkYellow;
                    dayText = "You entered inaccurate value";
                    error = true;
                    break;
            }


            Console.ForegroundColor = textColor; // applying the textcolor to the Console foreground
            Console.WriteLine((!error)? $"The {dayNum} day of the week is {dayText}": dayText); // Result

            // Delay
            Console.ReadKey();
        }
    }
}
