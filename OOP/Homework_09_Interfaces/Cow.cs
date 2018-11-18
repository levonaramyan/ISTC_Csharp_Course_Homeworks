using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    class Cow : Herbivore
    {
        public Cow()
        {
            Name = "Cow";
        }


        public string Produces { get; } = "Milk";
        public override void MakeSound()
        {
            Console.WriteLine("Muuuuuu!!!");
        }
    }
}
