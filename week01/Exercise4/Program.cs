using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter Number - "); int  getNum = int.Parse(Console.ReadLine());

        while (getNum != 0)
        {
            numbers.Add(getNum);
            Console.Write("Enter Number - "); getNum = int.Parse(Console.ReadLine());
        }

        int sum = numbers.Sum();
        double avarage = numbers.Average();
        int max = numbers.Max();
        Console.WriteLine(" ");

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The avarage is: {avarage}");
        Console.WriteLine($"The largest number is: {max}");

    }
}