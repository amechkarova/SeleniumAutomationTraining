using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateThePlanetTraining.Zoopark
{
    internal class Frog : Animal
    {
        public Frog(string name, int age, bool isFemale)
            : base(name, age, isFemale)
        {

        }
        public override string AnimalSound => "Frogggg";
    }
}
