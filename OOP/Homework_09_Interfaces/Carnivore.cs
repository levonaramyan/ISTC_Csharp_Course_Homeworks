using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    abstract class Carnivore : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating Meet!!!");
        }
    }
}
