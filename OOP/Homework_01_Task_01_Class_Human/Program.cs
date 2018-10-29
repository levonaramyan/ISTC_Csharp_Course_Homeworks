using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Homework 01 -- Task 01:  Սահմանել մարդ class -ը որի մեջ լինի հետևյալ field-ները Անուն Ազգանուն Տարիք Քաշ Սեռ
//                          Որտեղ բոլորը հասանաելի չեն դրսից (private են) և կարող է կատարել հետևյալ գործողությունները
//                          Առանձին մեթոդներով տպել բորլոր վերը թվարկածները: Առանձին մեթոդներով փոփոխել վերը թվարկածները:
//                          Class-ը պետք է ունենա կոնստրուկտոր, որը ինիցիալիզացնի բոլոր վերը նշված field-ները:

namespace Homework_01_Task_01_Class_Human
{
    class Human
    {
        // A new constructor for Class Human, which initializes all of the fields
        public Human(string firstName, string lastName, int yearsOld, bool isMale)
        {
            name = firstName;
            surname = lastName;
            age = yearsOld;
            male = isMale;
        }

        // The fields of the Class Human
        private string name;
        private string surname;
        private int age;
        private bool male;

        // Methods, which print in console the fields of an instance
        public void PrintName() {
            Console.WriteLine($"Name:\t\t{name}");
        }

        public void PrintSurname() {
            Console.WriteLine($"Surname:\t{surname}");
        }

        public void PrintAge() {
            Console.WriteLine($"Age:\t\t{age}");
        }

        public void PrintMale() {
            Console.WriteLine("Gender:\t\t" + (male? "male" : "female"));
        }


        // Methods, which change the values of an instance
        public void SetName(string firstName) {
            name = firstName;
        }

        public void SetSurname(string lastName) {
            surname = lastName;
        }

        public void SetAge(int yearsOld) {
            age = yearsOld;
        }

        public void SetMale(bool isMale) {
            male = isMale;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initializing a new instance of Human, the human1
            Human human1 = new Human("Valod", "Nazaryan", 56, true);

            // Printing the initializid fields of instance human1
            Console.WriteLine("The initialized fields of human1 are:\n");
            human1.PrintName();
            human1.PrintSurname();
            human1.PrintAge();
            human1.PrintMale();
            Console.WriteLine("\n");

            // Changing the values of fields of human1
            human1.SetName("Parandzem");
            human1.SetSurname("Rshtuni");
            human1.SetAge(18);
            human1.SetMale(false);

            // Printing the field values of human1, after the changes
            Console.WriteLine("After the changes:\n");
            human1.PrintName();
            human1.PrintSurname();
            human1.PrintAge();
            human1.PrintMale();

            Console.ReadKey();
        }
    }
}
