using AutomateThePlanetTraining.Zoopark;
using AutomateThePlanetTraining.Model;
using AutomateThePlanetTraining.Library;

namespace AutomateThePlanetTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 3: Modify the app to print your name
            string myName = "Aneliya Mechkarova";
            PrintName(myName);

            //exercise 4: Print numbers 2, 202 and 2002
            Console.WriteLine(2);
            Console.WriteLine(202);
            Console.WriteLine(2002);

            //exercise 5: Print current date and time
            Console.WriteLine($"Current date: {DateTime.Now}");

            //exercise 6: Calculate and print the square of the number 32346
            Console.WriteLine($"Square: {Math.Sqrt(32346)}");

            //exercise 7: Declare five variables to represent: 51240, -113, 4735941, 87, -20000
            ushort ushortnumber = 51240;
            sbyte signednumber = -113;
            int intnumber = 4735941;
            short shortnumber = -20000;

            //exercise 8: Boolean variable
            bool isFemale = true;

            //exercise 9: Type casting
            string hello = "Hello";
            string world = "world";
            object concatenatedString = hello + " " + world;
            string castToString = (string)concatenatedString;

            //exercise 10: Employee characteristics
            string firstName = "Aneliya";
            string lastName = "Mechkarova";
            int age = 27;
            char gender = 'f';
            int idNumber = 5696;
            Guid employeeID = Guid.NewGuid();

            //exercise 11: Exchange the values of two variables
            int firstValue = 5;
            int secondValue = 10;
            int helperVariable = firstValue;
            firstValue = secondValue;
            secondValue = helperVariable;

            //exercise 12:Check if a given integer is odd or even
            int num = 4;
            bool isEven = num % 2 == 0;
            Console.WriteLine(isEven);

            //exercise 13: Rectangle's ares by given width and height
            int height = 5;
            int width = 7;
            int rectangleArea = height * width;

            //exercise 14: Is a given number prime?
            int numberToCheck;
            Console.WriteLine("Enter number: ");
            numberToCheck = Convert.ToInt32(Console.ReadLine());
            if (isPrime(numberToCheck))
            {
                Console.WriteLine("Ii is prime.");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }

            //exercise 15: Trapezoid's areaby given sides a and b and height h
            int a = 5;
            int b = 10;
            int h = 7;
            double trapezoidArea = (a + b) * h / 2.0;

            //exercise 16: Exchange the values of the variables if the first one is greater than the second one
            int c = 5;
            int d = 6;
            if (c > d)
            {
                int temp = c;
                c = d;
                d = temp;
            }

            //exercise 17: Show the sign of the product of three real numbers without calculating it
            double real1, real2, real3;
            Console.WriteLine("Enter three real numbers: ");
            real1 = Convert.ToDouble(Console.ReadLine());
            real2 = Convert.ToDouble(Console.ReadLine());
            real3 = Convert.ToDouble(Console.ReadLine());
            if (real1 == 0 || real2 == 0 || real3 == 0)
            {
                Console.WriteLine("The product is 0");
            }
            else if (real1 < 0 && real2 < 0 && real3 < 0)
            {
                Console.WriteLine("The sign of the product is -");
            }
            else if (real1 < 0 && real2 < 0 && real3 > 0)
            {
                Console.WriteLine("The sign of the product is +");
            }
            else if (real1 < 0 && real2 > 0 && real3 > 0)
            {
                Console.WriteLine("The sign of the product is -");
            }
            else if (real1 > 0 && real2 > 0 && real3 > 0)
            {
                Console.WriteLine("The sign of the product is +");
            }
            else if (real1 > 0 && real2 > 0 && real3 < 0)
            {
                Console.WriteLine("The sign of the product is -");
            }
            else if (real1 > 0 && real2 < 0 && real3 < 0)
            {
                Console.WriteLine("The sign of the product is +");
            }
            else if (real1 > 0 && real2 < 0 && real3 > 0)
            {
                Console.WriteLine("The sign of the product is -");
            }
            else if (real1 < 0 && real2 > 0 && real3 < 0)
            {
                Console.WriteLine("The sign of the product is +");
            }



            //exercise 18: Print all numbers from 1 to 30
            int i = 1;
            while (i <= 30)
            {
                Console.WriteLine(i);
                i++;
            }
            //exercise 19: Print all numbers from 1 to 30 that are not divisible by 3 and 7 at the same time
            i = 1;
            while (i <= 30)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            //exercise 20: allocates array of 20 integers and initializes
            //each element by its index multiplied by 5.
            int[] array = new int[20];
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = j * 5;
                Console.WriteLine(array[j]);
            }

            //Array.Sort(array);
            //int[] secondArray = new int[20];
            //Array.Copy(array, secondArray, array.Length); 

            //exercise 21: The same as the previous but instead of array use list
            List<int> list = new List<int>();
            for (int j = 0; j < array.Length; j++)
            {
                list.Add(j * 5);
                Console.WriteLine(list.ElementAt(j));
            }

            //list.Sort();
            //List<int> secondList = new List<int>(list);
            //list.CopyTo(secondArray);
            //secondList = secondArray.ToList();

            //var myList = secondList.Where(x => x % 2 == 0); // where is part of Linq
            //secondList.ForEach(x => Console.WriteLine(x));

            //exercise 22: Write a method that returns the bigger of two integers
            Console.WriteLine(GetMax(num1: 23, num2: 24));

            //exercise 23: Generate and print 10 random values in the range [100, 200] to the console
            var rand = new Random();
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(rand.Next(100, 200));
            }

            //exercise 24: Prints which day of the week is today
            Console.WriteLine(DateTime.Now.DayOfWeek);


            //exercise 25: Storing data about people. 
            Person person = new Person("Aneliya", 27);
            Console.WriteLine(person.ToString());
            Child firstChild = new Child("Kaloyan", 1);
            Console.WriteLine(firstChild.ToString());
            Child secondChild = new Child("Brayan", 2);
            Child thirdChild = new Child("Konstantin", 3);
            Child[] children = { thirdChild, firstChild, secondChild };

            Child fourthChild = firstChild;
            Console.WriteLine(firstChild == fourthChild);

            Array.Sort(children);
            foreach (Child child in children)
            {
                Console.WriteLine(child.ToString());
            }

            //exercise 26: Store data about books. Ordinary books and special ones.
            Book book1 = new Book("some book", "Terry", "Pratchet", 32.99);
            Console.WriteLine(book1.ToString());

            //exercise 27: Hierarchy of Animals
            Dog dog = new Dog("Sparkie", 5, false);
            dog.ProduceSound();
            Console.WriteLine(dog);
            Cat cat = new Cat("Mike", 4, false);
            cat.ProduceSound();
            Console.WriteLine(cat);
        }

        private static bool isPrime(int numberToCheck)
        {
            if (numberToCheck <= 1)
            {
                return false;
            }

            double limit = Math.Ceiling(Math.Sqrt(numberToCheck));

            for (int i = 2; i <= limit; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        private static int GetMax(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        private static void PrintName(string name)
        {
            Console.WriteLine($"My name is {name}");
        }
    }

}
