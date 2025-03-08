using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");

        DisplayWelcome();
        string outputName = PromptUserName();
        int favNumber = PromptUserNumber();
        int outputSquare = SquareNumber(favNumber);
        DisplayResult(outputName, outputSquare);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;

        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string getNumber = Console.ReadLine();
            int favNumber = int.Parse(getNumber);
            return favNumber;

        }

        static int SquareNumber(int number)
        {
            int result = number * number;
            return result;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        }
    }
}