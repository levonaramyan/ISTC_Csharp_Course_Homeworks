using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_Interfaces
{
    class Man : Omnivore, IIntelligenceActions
    {
        public Man(string fN, string lN)
        {
            FirstName = fN;
            LastName = lN;
            Name = "Man";
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine($"Hi! I am {FirstName} {LastName}. How can I help you?");
        }

        public void Think()
        {
            Console.WriteLine("Thinking about my next actions!");
        }
    }
}
