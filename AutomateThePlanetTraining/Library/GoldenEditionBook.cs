using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateThePlanetTraining.Library
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string firstName, string lastName, double price)
            : base(title, firstName, lastName, price)
        {
            Price += 0.3 * price;
        }
    }
}
