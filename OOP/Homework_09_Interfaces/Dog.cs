using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    class Dog : Omnivore
    {
        public Dog()
        {
            Name = "Dog";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Haf-Haf");
        }

        public void Guarding(string target)
        {
            Console.WriteLine($"Guards the {target}");
        }
    }
}
