using AutomateThePlanetTraining.Zoopark;

namespace AutomateThePlanetTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string myName = "Aneliya Mechkarova";

            //Console.WriteLine($"Hello, {myName}!");

            //Console.WriteLine(2);
            //Console.WriteLine(202);
            //Console.WriteLine(2002);
            //Console.WriteLine($"Current date: {DateTime.Now}");
            //Console.WriteLine($"Square: {Math.Sqrt(32346)}");

            //ushort ushortNumber = 51240;
            //sbyte signedNumber = -113;
            //int intNumber = 4735941;
            //short shortNumber = -20000;
            //bool isFemale = true;
            //string hello = "Hello";
            //string world = "world";
            //object concatenatedString = hello + " " + world;
            //string castToString = (string)concatenatedString;

            //string firstName = "Aneliya";
            //string lastName = "Mechkarova";
            //int age = 27;
            //char gender = 'f';
            //int idNumber = 5696;
            //Guid employeeID = Guid.NewGuid();

            //int firstValue = 5;
            //int secondValue = 10;
            //int helperValue = firstValue;
            //firstValue = secondValue;
            //secondValue = helperValue;

            //int num = 4;
            //bool isEven = num % 2 == 0;
            //Console.WriteLine(isEven);

            //int height = 5;
            //int width = 7;
            //int rectangleArea = height * width;

            ////is a given number prime
            //int numberToCheck;
            //Console.WriteLine("Enter number: ");
            //numberToCheck = Convert.ToInt32(Console.ReadLine());
            //if(isPrime(numberToCheck)) 
            //{
            //    Console.WriteLine("Ii is prime.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not prime");
            //}


            //int a = 5;
            //int b = 10;
            //int h = 7;
            //double trapezoidArea = (a + b) * h / 2.0;

            ////exercise 1
            //int c = 5;
            //int d = 6;
            //if(c > d)
            //{
            //    int temp = c;
            //    c = d;
            //    d = temp;
            //}

            ////exercise 2 - missing

            ////exercise loops
            ////exercise 1
            //int i = 1;
            //while(i <= 30)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //i = 1;
            //while (i <= 30)
            //{
            //    if ((i % 3 != 0 && i % 7 != 0))
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //exercises arrays
            //exercise 1
            //int[] array = new int[20];
            //for(int j = 0; j < array.Length; j++)
            //{
            //    array[j] = j * 5;
            //    Console.WriteLine(array[j]);
            //}

            //Array.Sort(array);

            //int[] secondArray = new int[20];
            //Array.Copy(array, secondArray, array.Length); 

            //List<int> list = new List<int>();
            //for(int j = 0;j < array.Length; j++)
            //{
            //    list.Add(j * 5);
            //    Console.WriteLine(list.ElementAt(j));
            //}

            //list.Sort();
            //List<int> secondList = new List<int>(list);

            //list.CopyTo(secondArray);
            //secondList = secondArray.ToList();

            //var myList = secondList.Where(x => x % 2 == 0); // where is part of Linq
            //secondList.ForEach(x => Console.WriteLine(x));

            //exercise methods
            //Console.WriteLine(GetMax(num1: 23, num2: 24));

            // var rand = new Random();
            //for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(rand.Next(100, 200));
            // }

            //Console.WriteLine(DateTime.Now.DayOfWeek);

            //Person person = new Person("Aneliya", 27);
            //Console.WriteLine(person.ToString());
            //Child firstChild = new Child("Kaloyan", 1);
            //Console.WriteLine(firstChild.ToString());
            //Child secondChild = new Child("Brayan", 2);
            //Child thirdChild = new Child("Konstantin", 3);
            //Child[] children = {thirdChild, firstChild, secondChild};

            //Child fourthChild = firstChild;
            //Console.WriteLine(firstChild == fourthChild);

            //implementing IComparable interface give us the possibility
            //to compare objects and thus the objects can be sorted

            //Array.Sort(children);
            //foreach ( Child child in children )
            //{
            //    Console.WriteLine(child.ToString());   
            //}

            //Book book1 = new Book("some book", "Terry", "Pratchet",32.99);
            //Console.WriteLine(book1.ToString());
            Dog dog = new Dog("Sparkie", 5, false);
            dog.ProduceSound();
            Console.WriteLine(dog);
            Cat cat = new Cat("Mike", 4, false);
            cat.ProduceSound();
            Console.WriteLine(cat);


        }
    }

}
