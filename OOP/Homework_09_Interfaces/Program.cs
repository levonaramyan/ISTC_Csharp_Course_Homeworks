using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine($"The dog:");
            dog.Eat();
            dog.Guarding("John's house");
            dog.Breathe();
            dog.MakeSound();

            Shark shark = new Shark();
            Console.WriteLine("\nThe Shark:");
            shark.Breathe();
            shark.Attacking(new Shark());
            shark.Attacking(dog);

            Man kikos = new Man("Kikos", "Tavaqyalyan");
            kikos.MakeSound();
            shark.MakeSound();
            kikos.Think();
            shark.Attacking(kikos);            

            Console.ReadKey();
        }
    }
}
