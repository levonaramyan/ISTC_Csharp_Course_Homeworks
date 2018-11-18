using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    class Shark : Carnivore
    {
        public Shark()
        {
            Name = "Shark";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bul-bul-bul!");
        }

        public override void Breathe()
        {
            Console.WriteLine("Breathing with gills!");
        }

        public void Attacking(Animal target)
        {
            if (target.Name != this.Name)
                Console.WriteLine($"The {target.Name} was delicious!");
            else Console.WriteLine("I don't eat my friends!");
        }
    }
}
