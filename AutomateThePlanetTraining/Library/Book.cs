using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutomateThePlanetTraining.Library
{
    public class Book
    {
        public Book(string title, string firstName, string lastName, double price)
        {
            if (Regex.IsMatch(lastName, @"^\d"))
            {
                throw new ArgumentException("Author not valid");
            }
            if (title.Length < 3)
            {
                throw new ArgumentException("Title not valid");
            }
            if (price <= 0)
            {
                throw new ArgumentException("Price not valid");
            }
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            Price = price;
        }

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual double Price { get; set; }

        public override string ToString()
        {
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append(string.Format("Title: {0} ", Title));
            //stringBuilder.AppendLine();
            //stringBuilder.Append(string.Format("Author: {0}: ", FirstName));
            //stringBuilder.Append(LastName);
            //stringBuilder.Append(string.Format("Price: {0:0.00}: ", Price));
            //stringBuilder.AppendLine();
            //return stringBuilder.ToString();
            return $"Title: {Title}{Environment.NewLine} Author: {FirstName} {LastName}{Environment.NewLine} Price: {string.Format("{0:0.00}", Price)}";
        }
    }
}
