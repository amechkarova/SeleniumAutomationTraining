using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateThePlanetTraining.Zoopark
{
    internal class Tomcat: Animal
    {
        public Tomcat(string name, int age, bool isFemale)
            : base(name, age, isFemale)
        {
            isFemale = false;
        }

        public override string AnimalSound => "Meow";
    }
}
