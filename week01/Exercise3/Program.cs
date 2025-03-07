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
        

        


    }
}