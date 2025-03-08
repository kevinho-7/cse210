using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");

        Random randomGenarator = new Random();
        int number = randomGenarator.Next(1, 100); 

        Console.WriteLine("Find the magic number!!");
        Console.Write("What's your guess? -  "); int guess = int.Parse(Console.ReadLine());

        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("The magic number is higher");
            }
            else
            {
                Console.WriteLine("The magic number is lower");
            }

            Console.Write("What's your guess? -  "); guess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Congratulations! You found the magic number!");

    }
}