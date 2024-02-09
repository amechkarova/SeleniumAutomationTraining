using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateThePlanetTraining.Zoopark
{
    internal class Kitten: Animal
    {
        public Kitten(string name, int age, bool isFemale)
            : base(name, age, isFemale)
        {
            isFemale = true;
        }

        public override string AnimalSound => "Meow";
    }
}
