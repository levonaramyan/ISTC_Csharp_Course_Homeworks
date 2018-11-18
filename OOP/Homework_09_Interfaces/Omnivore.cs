using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    abstract class Omnivore : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating both meat and vegetables!!!");
        }
    }
}
