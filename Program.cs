using System;
using System.Security.Cryptography.X509Certificates;

namespace StoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please tell me your name");
            string myName = Console.ReadLine();

            Console.WriteLine("Now let me know What is your favorite animal");
            string myAnimal = Console.ReadLine();

            Console.WriteLine("And last but not least How old are you?");
            int myAge = int.Parse(Console.ReadLine());

            Story(myName, myAnimal,myAge);

            Console.WriteLine("Now lets do something different, lets do Maths...tell me one number");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number");
            int numberTwo = int.Parse(Console.ReadLine());

            Sum(numberOne, numberTwo);

            Mult(numberOne, numberTwo);






        }

        public static void Story(string myName, string myAnimal, int myAge)
        {
            Console.WriteLine($" Remember this...When you are {myAge + 10} , you will be walking trough a park and will find a {myAnimal}, So {myName} since that moment it will be your best friend! ");

        }

        public static void Sum( int numberOne, int numberTwo)
        {
            int sumResult = numberOne + numberTwo;
            Console.WriteLine($"The result of the sum is {sumResult}");

        }

        public static void Mult(int numberOne, int numberTwo)
        {
            int sumResult = numberOne * numberTwo;
            Console.WriteLine($"The result of the multiplication is {sumResult}");
           // return sumResult;
        }

    }
}
