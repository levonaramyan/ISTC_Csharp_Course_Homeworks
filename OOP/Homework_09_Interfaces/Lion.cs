using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    class Lion : Carnivore
    {
        public Lion()
        {
            Name = "Lion";
        }

        public string Nickname { get; } = "The King";
        public override void MakeSound()
        {
            Console.WriteLine("Uuuaaaaauuu!!!");
        }
    }
}
